using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_2
{
     public  class Order
    {
        private readonly int quantity;

        public Order(int _quantity)
        {
            quantity = _quantity;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public virtual void Cook() { }
        public virtual void SubtractQuantity() { }
    }
}
