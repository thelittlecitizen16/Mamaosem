using System;

namespace MamaosemProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageProductionLine manageProductionLine = new ManageProductionLine();

            Console.WriteLine("Hi, here is the menu:");
            Console.WriteLine("enter a cake to first stand- enter  1");
            Console.WriteLine("enter a cake to all stand- enter  2");
            Console.WriteLine("work one round in production line- enter  3");
            Console.WriteLine("if you want to exit- enter 0");

            string userChoice = Console.ReadLine();

            while (userChoice != "0")
            {
                switch (userChoice)
                {
                    case "1":
                        manageProductionLine.CreateNewCakeToFirstStand();
                        break;
                    case "2":
                        manageProductionLine.CreateNewCakeInAllStands();
                        break;
                    case "3":
                        manageProductionLine.RoundOfWork();
                        break;
                    default:
                        Console.WriteLine("you can choose one of the menu: 0, 1, 2, 3");
                        break;
                }

                Console.WriteLine("you can choose one choice of the menu:  0, 1, 2, 3");
                userChoice = Console.ReadLine();
            }
        }
    }
}
