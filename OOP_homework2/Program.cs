using System;
using System.Collections.Generic;
using System.Linq;
namespace OOP_homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(" ");
            Garden garden = new Garden();

            while (inputArr[0] != "end")
            {
                switch (inputArr[0])
                {
                    case "Peach":
                        for (int i = 0; i < int.Parse(inputArr[1]); i++)
                        { garden.myGarden.Add(new Peach(5, 5)); }

                        inputArr = null;
                        inputArr = Console.ReadLine().Split(" ");
                        break;
                    case "Apricot":
                        for (int i = 0; i < int.Parse(inputArr[1]); i++)
                        { garden.myGarden.Add(new Apricot(7, 7)); }

                        inputArr = null;
                        inputArr = Console.ReadLine().Split(" ");
                        break;
                    case "Acacia":
                        for (int i = 0; i < int.Parse(inputArr[1]); i++)
                        { garden.myGarden.Add(new Acacia(10, 3)); }

                        inputArr = null;
                        inputArr = Console.ReadLine().Split(" ");
                        break;
                    case "Oak":
                        for (int i = 0; i < int.Parse(inputArr[1]); i++)
                        { garden.myGarden.Add(new Oak(5, 11)); }

                        inputArr = null;
                        inputArr = Console.ReadLine().Split(" ");
                        break;
                    case "Lily":
                        for (int i = 0; i < int.Parse(inputArr[1]); i++)
                        { garden.myGarden.Add(new Lily(7, 2)); }

                        inputArr = null;
                        inputArr = Console.ReadLine().Split(" ");
                        break;
                    case "Rose":
                        for (int i = 0; i < int.Parse(inputArr[1]); i++)
                        { garden.myGarden.Add(new Rose(15, 5)); }

                        inputArr = null;
                        inputArr = Console.ReadLine().Split(" ");
                        break;
                    case "Carrot":
                        for (int i = 0; i < int.Parse(inputArr[1]); i++)
                        { garden.myGarden.Add(new Carrot(10, 1)); }

                        inputArr = null;
                        inputArr = Console.ReadLine().Split(" ");
                        break;
                    case "Strawberry":
                        for (int i = 0; i < int.Parse(inputArr[1]); i++)
                        { garden.myGarden.Add(new Strawberry(12, 3)); }

                        inputArr = null;
                        inputArr = Console.ReadLine().Split(" ");
                        break;

                    default: return 0;     
                }
                

            }
            SumBeautyScore(garden.Beauties);
            SumEnergy(garden.Foods);
            SumWaterRequired(garden.myGarden);

        }

        //sum all the beautyScore
        public static void SumBeautyScore(List<IBeauty> myGarden)
        {
            double sum = 0;
            foreach (var item in myGarden)
            {
                sum += item.BeautyScore;
            }
            Console.WriteLine($"BeautyScore: {sum}");
        }
        //sum all the waterRequired
        public static void SumWaterRequired(List<IGardenItems> myGarden)
        {
            double sum = 0;
            foreach (var item in myGarden)
            {
                sum += item.WaterRequired;
            }
            Console.WriteLine($"Water Required: {sum}");

        }
        //sum all the energy
        public static void SumEnergy(List<IFood> myGarden)
        {
            double sum = 0;
            foreach (var item in myGarden)
            {
                sum += item.Energy;
            }
            Console.WriteLine($"Energy: {sum}");

        }

    }
}
