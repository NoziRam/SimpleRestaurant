using RestaurantSimulation_3.MenuItems.Foods;
using RestaurantSimulation_3.MenuItems.Drinks;
using System.Text;

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
            cook.Process(tableRequests);
        }
        public StringBuilder Serve()
        {
            StringBuilder result = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < tableRequests.Length; i++)
            {
                var request = tableRequests[i];
                if (request!=null)
                {
                    int eggCount = 0;
                    int chickenCount = 0;
                    string drinkName = "";
                    foreach (var item in request)
                    {
                        if (item is Egg) eggCount++;
                        else if (item is Chicken) chickenCount++;
                        else drinkName = item.ToString();
                    }
                    result.Append($"Customer{counter} is served{eggCount} Egg, {chickenCount}Checken and a {drinkName}");
                    counter++;
                }
            }
            result.Append("Enjoy your meal!!!");
            return result;
        }
    }
}
