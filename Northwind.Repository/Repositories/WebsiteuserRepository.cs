using Northwind.Entities.Models;
using Repository.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repository.Repositories
{
  public static class WebsiteuserRepository
    {
        public static IEnumerable<tblWebsiteUser> WebsiteUserbyName(this IRepositoryAsync<tblWebsiteUser> repository, string userName)
        {
            return repository
                .Queryable()
                .Where(x => x.UserName.Contains(userName))
                .AsEnumerable();
        }

    }
}
