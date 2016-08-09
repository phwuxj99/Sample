using Northwind.Entities.Models;
using Northwind.Repository.Repositories;
using Repository.Pattern.Repositories;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Service
{
    

    /// <summary>
    ///     Add any custom business logic (methods) here
    /// </summary>
    public interface IWebsiteUserService : IService<tblWebsiteUser>
    {
        //decimal CustomerOrderTotalByYear(string customerId, int year);
        IEnumerable<tblWebsiteUser> WebsiteuserByUsername(string userName);
        //IEnumerable<CustomerOrder> GetCustomerOrder(string country);
    }

    /// <summary>
    ///     All methods that are exposed from Repository in Service are overridable to add business logic,
    ///     business logic should be in the Service layer and not in repository for separation of concerns.
    /// </summary>
    public class WebsiteUserService : Service<tblWebsiteUser>, IWebsiteUserService
    {
        private readonly IRepositoryAsync<tblWebsiteUser> _repository;

        public WebsiteUserService(IRepositoryAsync<tblWebsiteUser> repository) : base(repository)
        {
            _repository = repository;
        }


        public IEnumerable<tblWebsiteUser> WebsiteuserByUsername(string userName)
        {
            // add business logic here
            
            return _repository.WebsiteUserbyName(userName);
        }
    }
}
