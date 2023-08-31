using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_3.MenuItems.Foods
{
    public class Egg : CookedFood, IMenuItem, IDisposable
    {
        public Egg(int quantity):base(quantity)
        {

        }
        public override void Cook()
        {
            
        }
        public void Obtain() { }
        public void Crack() { }
        public void DiscardShells()
        {
            Dispose();
        }
        public void Dispose()
        {
           
        }
    }
}
