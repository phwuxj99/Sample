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
    builder.EntitySet<UserControl>("UserControls");
    config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());
    */
    public class UserControlsController : ODataController
    {


        private readonly IUserControlService _UserControlService;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public UserControlsController(
            IUnitOfWorkAsync unitOfWorkAsync,
            IUserControlService userControlService)
        {
            _unitOfWorkAsync = unitOfWorkAsync;
            _UserControlService = userControlService;
        }

        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/UserControls

        [HttpGet]
        [Queryable]
        public async Task<IHttpActionResult> GetUserControls(ODataQueryOptions<UserControl> queryOptions)
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

             return Ok<IEnumerable<UserControl>>(_UserControlService.Queryable());
           // return StatusCode(HttpStatusCode.NotImplemented);
        }


        // GET: odata/Customers(5)
        [Queryable]
        public SingleResult<UserControl> GetUserControls(int key)
        {
            return SingleResult.Create(_UserControlService.Queryable().Where(t=>t.IDX_ROW_ID == key));
        }

        //// GET: odata/UserControls(5)
        //public async Task<IHttpActionResult> GetUserControl([FromODataUri] int key, ODataQueryOptions<UserControl> queryOptions)
        //{
        //    // validate the query.
        //    try
        //    {
        //        queryOptions.Validate(_validationSettings);
        //    }
        //    catch (ODataException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //     //return Ok<UserControl>(_UserControlService.UserControlByUsername());
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        // PUT: odata/UserControls(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<UserControl> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(userControl);

            // TODO: Save the patched entity.

            // return Updated(userControl);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/UserControls
        public async Task<IHttpActionResult> Post(UserControl userControl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(userControl);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/UserControls(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<UserControl> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(userControl);

            // TODO: Save the patched entity.

            // return Updated(userControl);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/UserControls(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
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
