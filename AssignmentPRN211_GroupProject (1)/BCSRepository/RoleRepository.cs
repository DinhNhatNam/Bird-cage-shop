using BCSDAO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSRepository
{
    public class RoleRepository : IRoleRepository
    {
        public List<Role> GetAll() =>
            RoleDAO.Instance.GetAll();
    }
}
