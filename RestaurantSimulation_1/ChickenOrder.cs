using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_1
{
    public class ChickenOrder
    {
        int quantity;
        public ChickenOrder(int _quantity)
        {
            quantity = _quantity;
        }

        public int GetQuantity() => quantity;
        public void CutUp() { }
        public void Cook() { }
    }
}
