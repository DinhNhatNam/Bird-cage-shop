using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSDAO
{
    public class RoleDAO
    {
        private BirdCageShopContext _dbContext;
        public static RoleDAO instance = null;

        public RoleDAO()
        {
        }

        public static RoleDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoleDAO();
                }
                return instance;
            }

        }
        public List<Role> GetAll()
        {
            return new BirdCageShopContext().Roles.ToList();
        }
    }
}
