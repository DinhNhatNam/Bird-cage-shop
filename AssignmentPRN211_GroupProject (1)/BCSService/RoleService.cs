using BCSRepository;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSService
{
    public class RoleService : IRoleService
    {
        private IRoleRepository repo;
        public RoleService()
        {
            repo = new RoleRepository();
        }
        public List<Role> GetAll() => repo.GetAll();

    }
}
