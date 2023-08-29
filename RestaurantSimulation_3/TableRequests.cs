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
        public void Add(int customer, IMenuItem item)
        {
            Array.Resize(ref singleRequest, singleRequest.Length + 1);
            singleRequest[singleRequest.Length - 1] = item;
            if (item is Drink)
            {
                Array.Resize(ref requests, requests.Length + 1);
                requests[requests.Length - 1] = singleRequest;
                singleRequest = new IMenuItem[0];
            }
        }
    }
}
