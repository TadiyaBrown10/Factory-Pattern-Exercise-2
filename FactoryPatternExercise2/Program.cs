namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userinput;
            bool correctInput;
            do
            {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("Hello, what database would you like to use: List, SQL, or Mongo?");

                userinput = Console.ReadLine();
                if (userinput != "sql" && userinput != "mongo" && userinput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Ooops, thats not a database option!");
                    Thread.Sleep(1000);
                }
            } while (correctInput == false);

            Console.Clear();

            var db = DataAccessFactory.GetDataAccessType(userinput);

            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Names} Prices: {product.Price} ");
            }
        }
    }
}
