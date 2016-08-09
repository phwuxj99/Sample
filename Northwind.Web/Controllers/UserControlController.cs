using Northwind.Entities.Models;
using Northwind.Entities.StoredProcedures.Models;
using Northwind.Service;
using Repository.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Northwind.Web.Controllers
{
    public class UserControlController : ApiController
    {

        private readonly IUserControlService _UserControlService;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        private readonly IStoredProcedureService _storedProcedureService;

        public UserControlController(IUnitOfWorkAsync unitOfWorkAsync, IUserControlService userControlService, IStoredProcedureService storedProcedureService)
        {
            _unitOfWorkAsync = unitOfWorkAsync;
            _UserControlService = userControlService;
            _storedProcedureService = storedProcedureService;
        }


        //[HttpGet]
        //[Queryable]
        public async Task<IHttpActionResult> Get()
        {
            return Ok<IEnumerable<UserControl>>(_UserControlService.Queryable().Take(100));
            // return StatusCode(HttpStatusCode.NotImplemented);
        }

        //[Route("api/UserControl/{userid}")]
       // [Route("api/GetWebsiteUserIDP")]
        //[HttpGet]
        //[Queryable]
        public async Task<IHttpActionResult> Get(string userid)
        {
            return Ok<IEnumerable<WebsiteUserIDP>>(_storedProcedureService.GetWebsiteUserIDP(userid));
            // return StatusCode(HttpStatusCode.NotImplemented);
        }
        //localhost:50000/api/UserControl?userid=KaitlinMansky

        //public async Task<BackOfficeResponse<List<Country>>> ReturnAllCountriesAsync()
        //{
        //    return await _service.ProcessAsync<List<Country>>(BackOfficeEndpoint.CountryEndpoint, "returnCountries");
        //}

        //public async Task<IEnumerable<Product>> Get()
        //{
        //    using (var ctx = new NorthwindSlimContext())
        //    {
        //        List<Product> products = await
        //            (from p in ctx.Products.Include("Category")
        //             orderby p.ProductName
        //             select p).ToListAsync();
        //        return products;
        //    }
        //}

        //public async Task<string> WebServiceAsync(int id)
        //{
        //    var client = new HttpClient
        //    {
        //        BaseAddress =
        //        new Uri(WebServiceAddress)
        //    };
        //    string json = await client.GetStringAsync(id.ToString());
        //    var result = JsonConvert.DeserializeObject<string>(json);
        //    return result;
        //}


        //[HttpGet]
        //public async Task<IEnumerable<Car>> AllCarsInParallelNonBlockingAsync()
        //{
        //    IEnumerable<Task<IEnumerable<Car>>> allTasks = PayloadSources.Select(uri => GetCarsAsync(uri));
        //    IEnumerable<Car>[] allResults = await Task.WhenAll(allTasks);
        //    return allResults.SelectMany(cars => cars);
        //}

    }
}
