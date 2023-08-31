using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_3.MenuItems
{
   public abstract class CookedFood:IMenuItem
    {
        protected int _quantity;

        public CookedFood(int quantity)
        {
            _quantity = quantity;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public abstract void Cook();
        public void Serve() { }
    }
}
