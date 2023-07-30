using System;

namespace RestaurantSimulation_1
{
    public class Employee
    {
        int generate;
        object order;
        private int quantity;

        public Employee()
        {

        }
        public object NewRequest(int quantity, string menuItem)
        {
            generate++;
            if (menuItem == "Chicken")
            {
                if (generate % 3 == 0)
                {
                    return order = new EggOrder(quantity);
                }
                return order = new ChickenOrder(quantity);
            }
            else if (menuItem == "Egg")
            {
                if (generate % 3 == 0)
                {
                    return order = new ChickenOrder(quantity);
                }
                return order = new EggOrder(quantity);
            }
            else throw new Exception("Zakaz nest");
        }
        public object CopyRequest()
        {

            if (order is ChickenOrder)
                return new ChickenOrder(((ChickenOrder)order).GetQuantity());
            else if (order is EggOrder)
                return new EggOrder(((EggOrder)order).GetQuantity());
            else throw new Exception("Baroi takror zakaz nest");

        }
        public string Inspect()
        {
            if (order is EggOrder)
            {
                return ((EggOrder)order).GetQuality().ToString();
            }
            else return "no inspection is required";
        }
        public string PrepareFood(object order)
        {

            if (order is ChickenOrder)
            {
                for (int i = 0; i < quantity; i++)
                {
                    ((ChickenOrder)order).CutUp();
                }
                   ((ChickenOrder)order).Cook();
                return $"Order is Chicken, quantity:{quantity}";
            }
            else if (order is EggOrder)
            {
                for (int i = 0; i < quantity; i++)
                {
                    ((EggOrder)order).Crack();
                    ((EggOrder)order).DiscardShell();
                }
                ((EggOrder)order).Cook();

                return $"Order is Egg, quantity:{quantity}";
            }
            else throw new Exception("Marhamad zakaz kuned");
        }
    }
}
