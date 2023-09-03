using RestaurantSimulation_3.MenuItems;
using RestaurantSimulation_3.MenuItems.Foods;

namespace RestaurantSimulation_3.Employees
{
    public class Cook
    {
        public void Process(TableRequests tableRequests)
        {
            IMenuItem[] chickens = tableRequests[new Chicken(1)];
            IMenuItem[] eggs = tableRequests[new Egg(1)];
            foreach (var chicken in chickens)
            {
                Chicken ch = (Chicken)chicken;
                ch.CutUp();
                ch.Cook();
            }
            foreach (var egg in eggs)
            {
                Egg egg1 = (Egg)egg;
                egg1.Crack();
                egg1.Cook();
            }
        
        }
    }
}
