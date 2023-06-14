using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
	

        public List<Product> LoadData()
		{
			Console.WriteLine($"I am reading data from the list database");

            return new List<Product>
            {
            new Product() { Name = "Cupcakes", Price = 2.99m },
            new Product() { Name = "Cheesecake", Price = 9.99m },
            new Product() { Name = "CrumCake", Price = 1.99m },

            };
        }


        public void SaveData()
		{
			Console.WriteLine("I am saving data from the list database");

		}


    }
}

