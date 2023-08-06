using System;

namespace RestaurantSimulation_1
{
    public class Employee
    {
        
        int generate;
        object order;
        bool weHaveOrder = false;
        bool newRequestCalled = false;

        public Employee()
        {

        }
        public object NewRequest(int quantity, string menuItem)
        {
            generate++;
            weHaveOrder = true;
            newRequestCalled = true;
            if (generate % 3 == 0)
            {
                if (menuItem == "Egg")
                {
                    menuItem = "Chicken";
                }
                else menuItem = "Egg";
            }

            if (menuItem == "Egg")
            {
                order = new EggOrder(quantity);
            }
            else
            {
                order = new ChickenOrder(quantity);
            }
            return order;
        }
        public object CopyRequest()
        {

            if (!newRequestCalled)
                throw new Exception("You have no requests");

            if (order is ChickenOrder)
            {
                weHaveOrder = true;
                return new ChickenOrder(((ChickenOrder)order).GetQuantity());
            }
            else
            {
                weHaveOrder = true;
                return new EggOrder(((EggOrder)order).GetQuantity());
            }

        }
        public string Inspect()
        {
            if (!weHaveOrder)
                throw new Exception("First order please");

            if (order is EggOrder)
            {
                return ((EggOrder)order).GetQuality().ToString();
            }
            return "no inspection is required";
        }
        public string PrepareFood(object order)
        {

            if (!weHaveOrder)
                throw new Exception("First order please");

            if (order is ChickenOrder)
            {
                ChickenOrder ordered = (ChickenOrder)order;
                int quantity = ordered.GetQuantity();
                for (int i = 0; i < quantity; i++)
                {
                    ((ChickenOrder)order).CutUp();
                }
                ordered.Cook();
                weHaveOrder = false;
                return $"Order: Chicken Quantity: {quantity} completed";
            }
            else
            {
                EggOrder ordered = (EggOrder)order;
                int quantity = ordered.GetQuantity();

                for (int i = 0; i < quantity; i++)
                {
                    ordered.Crack();
                    ordered.DiscardShell();
                }
                ordered.Cook();
                weHaveOrder = false;
                return $"Order: Egg Quantity: {quantity} completed";
            }
        }
    }
}
