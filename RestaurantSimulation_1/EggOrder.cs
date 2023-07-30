using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_1
{
    public class EggOrder
    {
        int quantity;
        int generate;

        public EggOrder(int _quantity)
        {
            quantity = _quantity;
            generate++;
        }

        public int GetQuantity() => quantity;
        public int? GetQuality()
        {
            int quality;
            Random random = new Random();
            if (generate%2==0)
            {
                return null;
            }
           return quality = random.Next(101); 
        }
        public void Crack() {
            if (GetQuality()<25)
            {
                throw new Exception("a rotten egg");  
            }
        }
        public void DiscardShell() { }
        public void Cook() { }

    }
}
