using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_2
{
    public class Cook
    {
        Order order;
        public void SubmitRequestforFood(MenuItem item, int count)
        {
            if (item is MenuItem.ChickenOrder)
            {
                order = new ChickenOrder(count);
            }
            else
            {
                order = new EggOder(count);
            }
        }
        public int? PrepareFood()
        {
            if (order is EggOder)
            {
                int[] qualities = new int[order.GetQuantity()];
                EggOder eggOder = (EggOder)order;
                for (int i = 0; i < eggOder.GetQuantity(); i++)
                {
                    eggOder.Crack();
                    eggOder.Discard();
                    qualities[i] = eggOder.GetQuality();
                }
                eggOder.Cook();
                return GetMidQuality(qualities);
            }
            else 
            {
                ChickenOrder chickenOrder = order as ChickenOrder;
                for (int i = 0; i < chickenOrder.GetQuantity(); i++)
                {
                    chickenOrder.CutUp();
                }
                chickenOrder.Cook();
            }
            return null;
        }

      int? GetMidQuality(int[] qualities)
        {
            int sum = 0;
            foreach (var quality in qualities)
            {
                sum += quality;
            }
            return sum / qualities.Length;
        }
    }
}
