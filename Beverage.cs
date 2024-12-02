using Assignment_3._4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._4
{

    //Create an abstract base class to represent "Beverage" and inherit "Coffee"
    //class from it. Create a list of coffees.

    //parents class beverage
    //child class coffee
    //List with sprinkles!


    //abstract base class
    public abstract class Beverage
    {
        public double size { get; set; }
        public string BeverageName { get; set; }
        public double price { get; set; }
        public string orderName { get; set; }
   
        //{
        //    StudentID = studentID;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Address = address;
        //    MonthOfAdmission = monthOfAdmission;
        //    Grade = grade;
        //}

        //public Beverage(string BeverageName, double price, string orderName, double size);
        //{
        ////Name = name;
        ////Price = price;
        //}
    }
    //making enums?
    //public enum roast { light, medium, dark }
    //public enum temp { hot, iced}

    //derived class
    class Coffee : Beverage
    {
        public string type { get; set; }    
        public double price { get; set; }
        public string condiment { get; set; }

        public Coffee(string beverageName, double price, string orderName, double size, string type, string condiment)
        : base(beverageName, price, orderName, size)
        {
            //Type = type;
            //Condiment = condiment;
        }

    }
    class alchohol : Beverage
    { 
    }

    class juice : Beverage
    { 
    }

    class makeorders
    {
        public static List<Coffee> Coffees;
        public static void CreateData()
        {
            Coffees = new List<Coffee>()

            {
            new Coffee("Black", 0.99, "Cream and Sugar"),
            new Coffee("Caramel Latte", 9.99, "Sprinkles!"),
            new Coffee("Macchiato", 7.99, "Double Shot")
            };
        }
        //public string sprinkles { get; set; }
        //public string caramel { get; set; }
        //public string cream { get; set; }
        //public string sugar { get; set; }
        //public string nameonorder { get; set; }
        //public string icedcoffee   { get; set; }

    }

    //not even sure what happened, need to clean up code.

}

    

