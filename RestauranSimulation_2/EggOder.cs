using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_2
{
    public class EggOder : Order
    {
        public EggOder(int _quantity) : base(_quantity)
        {

        }
        Random rnd = new Random();
        public int GetQuality()
        {
            return rnd.Next(101);
        }
        public void Crack() { }
        public void Discard() { }
        public override void Cook() { }
    }
}
