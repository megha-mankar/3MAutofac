using AutfacDemo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutfacDemo.BL
{
    public interface IEmployee
    {
        Employee GetEmployee(int id);
    }
}
