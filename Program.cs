using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShopPõlluste
{ /*
    five pizza types, each pizza has four types
    2 types of pizza dough
    add some additional items
    custom pizza: choose a custom pizza with four orders
    order more than one pizza
    confirm order
    display total
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Pizza
    {
        public static string pizzaName { get; set; }
        // public string ingridient { get; set; }
        public string dough { get; set; }
        public double price { get; set; }
        public string size { get; set; }
        public List<IngridientsPerPizza> ingridients { get; set; }
        public List<string> doughs { get; set; }

        //  public Pizza(string _name, string _ingriedient,string _dough)
        public Pizza(string _name, string _dough, IngridientsPerPizza _ings)
        {
            pizzaName = _name;
            dough = _dough;
            ingridients.Add(_ings);
        }

    }
    public class IngridientsPerPizza
    {
        public List<string> IngriedientsPerPizza;
        public string ingridientID1 { get; set; }
        public string ingridientID2 { get; set; }
        public string ingridientID3 { get; set; }
        public string ingridientID4 { get; set; }

        public IngridientsPerPizza(string _ing1, string _ing2, string _ing3, string _ing4)
        {
            List<string> IngriedientsPerPizza = new List<string>();
            ingridientID1 = _ing1;
            ingridientID2 = _ing2;
            ingridientID2 = _ing3;
            ingridientID2 = _ing4;
            IngriedientsPerPizza.Add(ingridientID1);
            IngriedientsPerPizza.Add(ingridientID2);
            IngriedientsPerPizza.Add(ingridientID3);
            IngriedientsPerPizza.Add(ingridientID4);
        }
    }

    public class Menu
    {
        public List<Pizza>menuItems;

        public Menu (Pizza pizza)
        {
            menuItems = new List<Pizza>();
            menuItems.Add(pizza);
        }

    }
   

   

    



}

        public class Additionals
    {
        public List<string> additionals;
    }

    
    public class Orders
    {

    }
   public  class SumOrder 
    {
        
    }

