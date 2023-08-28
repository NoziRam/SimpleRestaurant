using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_3.MenuItems
{
    public interface IMenuItem
    {
        public void Obtain() { }
        public string Serve() { return ""; }
    }
}
