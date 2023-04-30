using System;

namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Names = "Paper", Price = 1},
            new Product(){ Names = "BoardGame", Price = 10},
            new Product(){ Names = "Pancake", Price = 5},
            new Product(){ Names = "Lamp", Price = 15},

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Data Access.");
            return Products;
        }


        public void SaveData()
        {
            Console.WriteLine("I am saving data from Mongo Data Access.");
        }
    }
}

