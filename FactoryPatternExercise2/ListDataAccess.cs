using System;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Names = "Gum", Price = 2},
            new Product(){ Names = "Shoes", Price = 190},
            new Product(){ Names = "Bookbag", Price = 65},
            new Product(){ Names = "Ipad", Price = 690},

        };
        
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access.");
            return Products;
        }


        public void SaveData()
        {
            Console.WriteLine("I am saving data from List Data Access.");
        }
    }
}

