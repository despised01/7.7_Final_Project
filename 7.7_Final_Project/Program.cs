using System;

namespace _7._7_Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Итоговое задание по ООП");

            Console.WriteLine(DisplayAddress());
        }
    }
    abstract class Delivery
    {
        public string Address;
        
        protected virtual void DisplayStatus()
        {
            Console.WriteLine("Доставка");
        }
    }

    class HomeDelivery : Delivery
    {
        protected override void DisplayStatus()
        {
          Console.WriteLine("Доставка на дом");
        }
    }

    class PickPointDelivery : Delivery
    {
        protected override void DisplayStatus()
        {
           Console.WriteLine("Доставка в пункт выдачи");
        }
    }

    class ShopDelivery : Delivery
    {
        protected override void DisplayStatus()
        {
            Console.WriteLine("Доставка в магазин");
        }
    }

    class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }

    class Person
    {
        public string Name;
        public string Surname;
    }

    class Customer: Person
    {
        private string PhoneNumber;
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для совершения заказа возраст должен быть не меньше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }

        static bool CheckPhone(string phone, out int corrphone)
        {
            if (int.TryParse(phone, out int intphone))
            {
                if (intphone > 0)
                {
                    corrphone = intphone;
                    return false;
                }
            }
            {
                corrphone = 0;
                return true;
            }
        }

        public Customer(string name, string surname, string phonenumber, int age)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phonenumber;
            Age = age;
        }
    }

    class Courier : Person
    {
        private HomeDelivery homeDelivery;

        private PickPointDelivery pickPointDelivery;

        private ShopDelivery shopDelivery;

        public Courier()
        {
            homeDelivery = new HomeDelivery();

            pickPointDelivery = new PickPointDelivery();

            shopDelivery = new ShopDelivery();
        }
    }
}