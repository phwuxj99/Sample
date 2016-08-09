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
    //class UserControlService
    //{
    //}


    /// <summary>
    ///     Add any custom business logic (methods) here
    /// </summary>
    public interface IUserControlService : IService<UserControl>
    {
        //decimal CustomerOrderTotalByYear(string customerId, int year);
        IEnumerable<UserControl> UserControlByUsername(int id);
        //IEnumerable<CustomerOrder> GetCustomerOrder(string country);
    }

    /// <summary>
    ///     All methods that are exposed from Repository in Service are overridable to add business logic,
    ///     business logic should be in the Service layer and not in repository for separation of concerns.
    /// </summary>
    public class UserControlService : Service<UserControl>, IUserControlService
    {
        private readonly IRepositoryAsync<UserControl> _repository;

        public UserControlService(IRepositoryAsync<UserControl> repository) : base(repository)
        {
            _repository = repository;
        }

        //public IEnumerable<UserControl> WebsiteuserByUsername(string userName)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<UserControl> UserControlByUsername(int id)
        {
            // add business logic here
            return _repository.UserControlbyID(id);
        }
    }
}
