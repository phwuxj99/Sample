using Northwind.Entities.Models;
using Repository.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repository.Repositories
{
    //class UserControlRepository
    //{
    //}


    public static class UserControlRepository
    {
        public static IEnumerable<UserControl> UserControlbyID(this IRepositoryAsync<UserControl> repository, int ID)
        {
            return repository
                .Queryable()
                .Where(x => x.IDX_ROW_ID==ID)
                .AsEnumerable();
        }

    }
}
