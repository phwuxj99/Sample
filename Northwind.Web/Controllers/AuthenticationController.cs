using Northwind.Entities.StoredProcedures.Models;
using Northwind.Service;
using Northwind.Web.Models.Authentication;
using Repository.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Northwind.Web.Controllers
{
    public class AuthenticationController : ApiController
    {
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        private readonly IStoredProcedureService _storedProcedureService;


        public AuthenticationController(IUnitOfWorkAsync unitOfWorkAsync,  IStoredProcedureService storedProcedureService)
        {
            _unitOfWorkAsync = unitOfWorkAsync;
            _storedProcedureService = storedProcedureService;
        }

        [Route("authenticate")]
        public IHttpActionResult Authenticate(AuthenticateViewModel viewModel)
        {
            /* REPLACE THIS WITH REAL AUTHENTICATION
            ----------------------------------------------*/
            //if (!(viewModel.Username == "test" && viewModel.Password == "test"))
            //{
            //    return Ok(new { success = false, message = "User code or password is incorrect" });
            //}

            // IEnumerable<WebsiteUserIDP> aaa = _storedProcedureService.GetWebsiteUserIDP(viewModel.Username.ToString()).FirstOrDefault();
            var aaa = _storedProcedureService.GetWebsiteUserIDP(viewModel.Username.ToString()).FirstOrDefault();
            if (viewModel.Password!=aaa.UserPassword)
            { return Ok(new { success = false, message = "User code or password is incorrect" }); }

            return Ok(new { success = true });
        }
    }
}
