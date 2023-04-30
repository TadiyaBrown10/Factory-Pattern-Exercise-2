using System;
using System.Diagnostics;

namespace FactoryPatternExercise2
{
	public class SQLDatatAccess : IDataAccess
	{
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Names = "Chair", Price = 200},
            new Product(){ Names = "Perfume", Price = 90},
            new Product(){ Names = "GymBag", Price = 30},
            new Product(){ Names = "TV", Price = 600},

        };
       

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Access.");
            return Products;
        }


        public void SaveData()
        {
            Console.WriteLine("I am saving data from SQL Data Access.");
        }
    }

       
    
}

