using System;
using RestaurantSimulation_3.MenuItems;

namespace RestaurantSimulation_3
{
    public class TableRequests
    {
        IMenuItem [][] requests = new IMenuItem[8][];
        public int Length
        { 
            get
            {
                return requests.Length;
            }
        }
        IMenuItem[] singleRequest = new IMenuItem[0];
        public void Add()
        { 
        
        }
    }
}
