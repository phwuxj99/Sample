#region

using Northwind.Entities.StoredProcedures.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

#endregion

namespace Northwind.Entities.Models
{
    public partial class NorthwindContext : INorthwindStoredProcedures
    {
        public IEnumerable<WebsiteUserIDP> GetWebsiteUserIDP(string UserID)
        {
            var customerIDParameter = UserID != null ?
                new SqlParameter("@UserID", UserID) :
                new SqlParameter("@UserID", typeof(string));

            return Database.SqlQuery<WebsiteUserIDP>("GetWebsiteUserIDP @UserID", customerIDParameter);
        }
        public IEnumerable<CustomerOrderHistory> CustomerOrderHistory(string customerID)
        {
            var customerIDParameter = customerID != null ?
                new SqlParameter("@CustomerID", customerID) :
                new SqlParameter("@CustomerID", typeof(string));

            return Database.SqlQuery<CustomerOrderHistory>("CustOrderHist @CustomerID", customerIDParameter);
        }

        public int CustOrdersDetail(int? orderID)
        {
            var orderIDParameter = orderID.HasValue ?
                new SqlParameter("@OrderID", orderID) :
                new SqlParameter("@OrderID", typeof(int));

            return Database.ExecuteSqlCommand("CustOrdersDetail @OrderId", orderIDParameter);
        }

        public IEnumerable<CustomerOrderDetail> CustomerOrderDetail(string customerID)
        {
            var customerIDParameter = customerID != null ?
                new SqlParameter("@CustomerID", customerID) :
                new SqlParameter("@CustomerID", typeof(string));

            return Database.SqlQuery<CustomerOrderDetail>("CustOrdersOrders @CustomerID", customerIDParameter);
        }

        public int EmployeeSalesByCountry(DateTime? beginningDate, DateTime? endingDate)
        {
            var beginningDateParameter = beginningDate.HasValue ?
                new SqlParameter("@Beginning_Date", beginningDate) :
                new SqlParameter("@Beginning_Date", typeof(DateTime));

            var endingDateParameter = endingDate.HasValue ?
                new SqlParameter("@Ending_Date", endingDate) :
                new SqlParameter("@Ending_Date", typeof(DateTime));

            return Database.ExecuteSqlCommand("EmployeeSalesByCountry @Beginning_Date, @Ending_Date", beginningDateParameter, endingDateParameter);
        }

        public int SalesByCategory(string categoryName, string ordYear)
        {
            var categoryNameParameter = categoryName != null ?
                new SqlParameter("@CategoryName", categoryName) :
                new SqlParameter("@CategoryName", typeof(string));

            var ordYearParameter = ordYear != null ?
                new SqlParameter("@OrdYear", ordYear) :
                new SqlParameter("@OrdYear", typeof(string));

            return Database.ExecuteSqlCommand("SalesByCategory @CategoryName, @OrdYear", categoryNameParameter, ordYearParameter);
        }

        public int SalesByYear(DateTime? beginningDate, DateTime? endingDate)
        {
            var beginningDateParameter = beginningDate.HasValue ?
                new SqlParameter("@Beginning_Date", beginningDate) :
                new SqlParameter("@Beginning_Date", typeof(DateTime));

            var endingDateParameter = endingDate.HasValue ?
                new SqlParameter("@Ending_Date", endingDate) :
                new SqlParameter("@Ending_Date", typeof(DateTime));

            return Database.ExecuteSqlCommand("SalesByYear @Beginning_Date, @Ending_Date", beginningDateParameter, endingDateParameter);
        }

        public int AddWebsiteUser(WebsiteUser newUser)
        {
            var sqlBigIDParameter =newUser.SqlBigID !=null  ?
                new SqlParameter("@SQLBigID", newUser.SqlBigID) :
                new SqlParameter("@SQLBigID", typeof(int));

            var orgNameParameter =newUser.OrgName!=null ?
                new SqlParameter("@OrgName", newUser.OrgName) :
                new SqlParameter("@OrgName", typeof(string));

            var userNameParameter =newUser.UserName!=null ?
                new SqlParameter("@UserName", newUser.UserName) :
                new SqlParameter("@UserName", typeof(string));

            var userIDParameter = newUser.UserID!=null ?
                new SqlParameter("@UserID", newUser.UserID) :
                new SqlParameter("@UserID", typeof(string));

            var userPasswordParameter = newUser.UserID != null ?
                new SqlParameter("@UserPassword", newUser.UserID) :
                new SqlParameter("@UserPassword", typeof(string));

            var emailParameter = newUser.UserID != null ?
                new SqlParameter("@Email", newUser.UserID) :
                new SqlParameter("@Email", typeof(string));

            return Database.ExecuteSqlCommand("LV_NutritionCourseUserAdd @SQLBigID ,@OrgName ,@UserName ,@UserID ,@UserPassword ,@Email ", sqlBigIDParameter, orgNameParameter, userNameParameter, userIDParameter, userPasswordParameter, emailParameter);

            //http://www.c-sharpcorner.com/article/crud-using-mvc-web-api-and-angularjs/
            //http://cybarlab.com/crud-operations-in-angularjs-and-web-api
            //http://www.codeproject.com/Tips/1074608/CRUD-in-ASP-NET-MVC-using-WebAPI-with-AngularJS
        }

        //// POST api/employee  
        //public HttpResponseMessage Post(Employee model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Employees.Add(model);
        //        db.SaveChanges();
        //        HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, model);
        //        return response;
        //    }
        //    else
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }
        //}

    }
}