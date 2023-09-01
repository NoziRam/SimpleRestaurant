using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_3.MenuItems.Foods
{
    public class Chicken: CookedFood, IMenuItem
    {
        public Chicken(int quantity): base(quantity)
        {

        }
        public void Obtain() { }
        public void CutUp() { }    
        public override void Cook()
        {
            
        }
    }
}
