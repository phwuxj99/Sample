using Northwind.Entities.StoredProcedures.Models;
using System;
using System.Collections.Generic;

namespace Northwind.Entities.Models
{
    public interface INorthwindStoredProcedures
    {
        IEnumerable<WebsiteUserIDP> GetWebsiteUserIDP(string UserID);
        IEnumerable<CustomerOrderHistory> CustomerOrderHistory(string customerID);
        int CustOrdersDetail(int? orderID);
        IEnumerable<CustomerOrderDetail> CustomerOrderDetail(string customerID);
        int EmployeeSalesByCountry(DateTime? beginningDate, DateTime? endingDate);
        int SalesByCategory(string categoryName, string ordYear);
        int SalesByYear(DateTime? beginningDate, DateTime? endingDate);

        int AddWebsiteUser(WebsiteUser newUser);
    }
}