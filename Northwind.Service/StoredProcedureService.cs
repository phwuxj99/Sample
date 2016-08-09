using System.Collections.Generic;
using Northwind.Entities.Models;
using Northwind.Entities.StoredProcedures.Models;

namespace Northwind.Service
{
    public class StoredProcedureService : IStoredProcedureService
    {
        private readonly INorthwindStoredProcedures _storedProcedures;

        public StoredProcedureService(INorthwindStoredProcedures storedProcedures)
        {
            _storedProcedures = storedProcedures;
        }

        public IEnumerable<CustomerOrderHistory> CustomerOrderHistory(string customerID)
        {
            return _storedProcedures.CustomerOrderHistory(customerID);
        }

        public int CustOrdersDetail(int? orderID)
        {
            return _storedProcedures.CustOrdersDetail(orderID);
        }

        public IEnumerable<CustomerOrderDetail> CustomerOrderDetail(string customerID)
        {
            return _storedProcedures.CustomerOrderDetail(customerID);
        }

        public IEnumerable<WebsiteUserIDP> GetWebsiteUserIDP(string userID)
        {
            return _storedProcedures.GetWebsiteUserIDP(userID);
        }
    }
}