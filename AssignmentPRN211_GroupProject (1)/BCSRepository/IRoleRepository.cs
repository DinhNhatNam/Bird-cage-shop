using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSRepository
{
    public interface IRoleRepository
    {
        List<Role> GetAll();
    }
}
