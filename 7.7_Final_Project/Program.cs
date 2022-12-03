using System;

namespace _7._7_Final_Project
{
    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery: Delivery
    {

    }

    class PickPointDelivery: Delivery
    {

    }

    class ShopDelivery: Delivery
    {

    }

    class Order <TDelivery, TStruct> where TDelivery: Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

    }