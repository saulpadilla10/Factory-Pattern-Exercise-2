using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select database(list, SQL, mongo):");

            string answer = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(answer);

            List<Product> products = data.LoadData();

            foreach (var product in products)

            {
                Console.WriteLine($"{product.Name} {product.Price}");

            }

            data.SaveData();


        }
    }
}
