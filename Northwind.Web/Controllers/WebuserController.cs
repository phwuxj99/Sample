using Northwind.Entities.Models;
using Northwind.Service;
using Repository.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Northwind.Web.Controllers
{
    public class WebuserController : ApiController
    {
        private readonly IWebsiteUserService _WebsiteUserService;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public WebuserController(
            IUnitOfWorkAsync unitOfWorkAsync,
            IWebsiteUserService WebsiteUserService)
        {
            _unitOfWorkAsync = unitOfWorkAsync;
            _WebsiteUserService = WebsiteUserService;
        }

        // GET: api/Customers
        [HttpGet]
        [Queryable]
        public IQueryable<tblWebsiteUser> Get()
        {
            return _WebsiteUserService.Queryable();
        }

        // GET: odata/Customers/test
        [HttpGet]
        [Queryable]
        public IEnumerable<tblWebsiteUser> GetCustomer(string userName)
        {
            return _WebsiteUserService.WebsiteuserByUsername(userName);
        }

        [Queryable]
        public IQueryable<tblWebsiteUser> GetCustomer2(string userName)
        {
            return _WebsiteUserService.Queryable().Where(t => t.UserName == userName);
        }

        //// GET: api/WebsiteUser
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/WebsiteUser/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/WebsiteUser
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WebsiteUser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WebsiteUser/5
        public void Delete(int id)
        {
        }
    }
}
