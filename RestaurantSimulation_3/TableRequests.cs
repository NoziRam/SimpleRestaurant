using System;
using RestaurantSimulation_3.MenuItems;
using RestaurantSimulation_3.MenuItems.Foods;

namespace RestaurantSimulation_3
{
    public class TableRequests
    {
        IMenuItem [][] requests = new IMenuItem[0][];
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
        public IMenuItem[] this[IMenuItem food]
        {
            get 
            {
                IMenuItem[] returnOrders = new IMenuItem[0];
                foreach (var request in requests)
                {
                    foreach (var item in request)
                    {
                        if (item is Chicken && food is Chicken)
                        {
                            Array.Resize(ref returnOrders, returnOrders.Length + 1);
                            returnOrders[returnOrders.Length - 1] = item;
                        }
                        else if (item is Egg && food is Egg)
                        {
                            Array.Resize(ref returnOrders, returnOrders.Length + 1);
                            returnOrders[returnOrders.Length - 1] = item;
                        }
                    }
                }
                return returnOrders;
            }
           
        }
        public IMenuItem[] this[int index]
        {
            get { return requests[index]; }
            
        }

    }
}
