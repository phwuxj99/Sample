using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using Northwind.Entities.Models;
using Microsoft.Data.OData;
using Northwind.Service;
using Repository.Pattern.UnitOfWork;

namespace Northwind.Web.Api
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using Northwind.Entities.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<tblWebsiteUser>("tblWebsiteUsers");
    config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());
    */
    public class tblWebsiteUsersController : ODataController
    {


        private readonly IWebsiteUserService _WebsiteUserService;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        
        public tblWebsiteUsersController(
            IUnitOfWorkAsync unitOfWorkAsync,
            IWebsiteUserService WebsiteUserService)
        {
            _unitOfWorkAsync = unitOfWorkAsync;
            _WebsiteUserService = WebsiteUserService;
        }


        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        //[HttpGet]
        //[Queryable]
        //public IQueryable<tblWebsiteUser> GettblWebsiteUsers()
        //{
        //    return _WebsiteUserService.Queryable();
        //}

        // GET: odata/tblWebsiteUsers

        [HttpGet]
        [Queryable]
        public async Task<IHttpActionResult> GettblWebsiteUsers(ODataQueryOptions<tblWebsiteUser> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok<IEnumerable<tblWebsiteUser>>(_WebsiteUserService.Queryable());
            // return StatusCode(HttpStatusCode.NotImplemented);

            // return _WebsiteUserService.Queryable();
        }

        // GET: odata/tblWebsiteUsers(5)
        public async Task<IHttpActionResult> GettblWebsiteUser([FromODataUri] string key, ODataQueryOptions<tblWebsiteUser> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<tblWebsiteUser>(tblWebsiteUser);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/tblWebsiteUsers(5)
        public async Task<IHttpActionResult> Put([FromODataUri] string key, Delta<tblWebsiteUser> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(tblWebsiteUser);

            // TODO: Save the patched entity.

            // return Updated(tblWebsiteUser);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/tblWebsiteUsers
        public async Task<IHttpActionResult> Post(tblWebsiteUser tblWebsiteUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(tblWebsiteUser);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/tblWebsiteUsers(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] string key, Delta<tblWebsiteUser> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(tblWebsiteUser);

            // TODO: Save the patched entity.

            // return Updated(tblWebsiteUser);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/tblWebsiteUsers(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] string key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWorkAsync.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
