using RestaurantSimulation_3.MenuItems.Foods;
using RestaurantSimulation_3.MenuItems.Drinks;

namespace RestaurantSimulation_3.Employees
{
    public class Server
    {
        TableRequests tableRequests;
        Cook cook;
        public Server()
        {
            tableRequests = new TableRequests();
            cook = new Cook();
        }
        int customerIndex = 0;
        public void AddNewRequest(int chickenCount, int eggCount, string drink)
        {
            for (int i = 0; i < chickenCount; i++)
            {
                tableRequests.Add(customerIndex, new Chicken(chickenCount));
            }
            for (int i = 0; i < eggCount; i++)
            {
                tableRequests.Add(customerIndex, new Egg(eggCount));
            }
            if (drink == "CocaCola")
                tableRequests.Add(customerIndex, new CocaCola());
            else if (drink == "Pepsi")
                tableRequests.Add(customerIndex, new Pepsi());
            else tableRequests.Add(customerIndex, new Tea());
            customerIndex++;
        
        }
        public void SendAll()
        { 
        
        }
    }
}
