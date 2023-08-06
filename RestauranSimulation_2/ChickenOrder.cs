using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_2
{
    public class ChickenOrder : Order
    {
        public ChickenOrder(int _quantity) : base(_quantity)
        {
        }
        public void CutUp() { }
        public override void Cook() { }
    }
}
