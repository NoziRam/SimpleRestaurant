using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulation_2
{
    public class Server
    {
        Cook cook;
        public Server()
        {
            cook = new Cook();
        }
        int counter = 0;
        bool weHaveRequest = false;
        bool requestsAreSent = false;
        MenuItem[][] requests = new MenuItem[8][];

        public void ReceiveRequests(int chickenQuantity, int eggQuantity, string drinkName)
        {
            MenuItem[] request = new MenuItem[chickenQuantity + eggQuantity + 1];
            if (counter > 7)
            {
                throw new Exception("Requests ara mo than 8");
            }

            for (int i = 0; i < chickenQuantity; i++)
            {
                request[i] = MenuItem.ChickenOrder;
            }
            for (int i = chickenQuantity; i < (chickenQuantity + eggQuantity); i++)
            {
                request[i] = MenuItem.EggOrder;
            }

            Enum.TryParse<MenuItem>(drinkName, out MenuItem drink);
            request[request.Length - 1] = drink;
            
            requests[counter] = request;
            counter++;
            weHaveRequest = true;
        }
        public int? SendAll()
        {
            if (weHaveRequest)
            {
                int chicken_count = 0;
                int egg_count = 0;
                foreach (var request in requests)
                {
                    if (request != null)
                    {
                        foreach (var item in request)
                        {
                            if (item is MenuItem.ChickenOrder)
                            {
                                chicken_count++;
                            }
                            else if (item is MenuItem.EggOrder) egg_count++;
                        }
                    }
                }
                cook.SubmitRequestforFood(MenuItem.EggOrder, egg_count);
                int? eggQuality = cook.PrepareFood();
                cook.SubmitRequestforFood(MenuItem.ChickenOrder, chicken_count);
                cook.PrepareFood();
                requestsAreSent = true;
                return eggQuality;
            }
            else throw new Exception("First order please");
        }
        public StringBuilder Serve()
        {
            if (requestsAreSent)
            {
                StringBuilder result = new StringBuilder();
                int counter = 0;
                foreach (var request in requests)
                {
                    if (request != null)
                    {
                        int eggCount = 0;
                        int chickenCount = 0;
                        string drinkName = "";
                        foreach (var item in request)
                        {
                            if (item is MenuItem.EggOrder) eggCount++;
                            else if (item is MenuItem.ChickenOrder) chickenCount++;
                            else drinkName = item.ToString();
                        }
                        result.AppendLine($"Costomer{counter} is served  {chickenCount} Chicken, {eggCount} Egg and a {drinkName}");
                        counter++;
                    }
                }
                requests = new MenuItem[8][];
                weHaveRequest = false;
                requestsAreSent = false;
                result.AppendLine("Enjoy your meal!!!");
                return result;

            }
            else throw new Exception("First send requests to the cook");
        }
    }
}