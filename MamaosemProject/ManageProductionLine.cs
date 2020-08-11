using Mamaosem.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MamaosemProject
{
    public class ManageProductionLine
    {
        private ProductionLine _productionLine;
        public ManageProductionLine()
        {
            _productionLine = new ProductionLine(CreateAllStands());
        }

        public void RoundOfWork()
        {
            _productionLine.RoundOfWork();
        }

        public void CreateNewCakeInAllStands()
        {
            HouseCake cake = UserCreateCake();

            if (cake!=null)
            {
                _productionLine.CreateCakeInAllStands(cake);
            }
        }

        public void CreateNewCakeToFirstStand()
        {
            HouseCake cake = UserCreateCake();

            if (cake != null)
            {
                _productionLine.CreateCakeInFirstStand(cake);
            }

        }

        private HouseCake UserCreateCake()
        {
            Console.WriteLine("what the number of the cakeType?");

            string cakeType = Console.ReadLine();
            int numberCakeType;

            if (int.TryParse(cakeType, out numberCakeType))
            {
                while (numberCakeType < 0 || numberCakeType > 5)
                {
                    Console.WriteLine("you need number between 0 to 5");
                }

                HouseCake cake = new HouseCake();
                cake.Type = (CakeType)numberCakeType;

                return cake;
            }
            else
            {
                Console.WriteLine("you enter a string not a number");

                return null;
            }
        }

        private LinkedList<IStand<HouseCake>> CreateAllStands()
        {
            LinkedList<IStand<HouseCake>> stands = new LinkedList<IStand<HouseCake>>();

            stands.AddLast(new Stand(1));
            stands.AddLast(new Stand(2));
            stands.AddLast(new Stand(3));
            stands.AddLast(new LastStand(4));

            return stands;
        }
    }
}
