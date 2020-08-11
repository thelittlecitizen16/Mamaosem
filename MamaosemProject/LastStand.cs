using Mamaosem.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MamaosemProject
{
    public class LastStand : IStand<HouseCake>
    {
        private int _stepNum;
        private Queue<HouseCake> _cakeWaitInLine;

        public LastStand(int stepNum)
        {
            _stepNum = stepNum;
            _cakeWaitInLine = new Queue<HouseCake>();
        }

        public HouseCake PerformProdLineStep()
        {
            HouseCake cake = _cakeWaitInLine.Dequeue();

            cake.ProductionTime = DateTime.Now;
            cake.ExpiryDate = DateTime.Now.AddMonths(4);

            File.WriteAllText(@"C:\Users\thelittlecitizen16\Desktop\MamaosemProject\MamaosemProject\storage.txt", cake.ToString());

            Console.WriteLine($"Cake: {cake.SerialNumber} - Station {_stepNum} Done!");

            return cake;
        }

        public HouseCake PerformProdLineStep(HouseCake cake)
        {
            cake.ProductionTime = DateTime.Now;
            cake.ExpiryDate = DateTime.Now.AddMonths(4);

            File.AppendAllText(@"C:\Users\thelittlecitizen16\Desktop\MamaosemProject\MamaosemProject\storage.txt" , Environment.NewLine + cake.ToString());

            Console.WriteLine($"#Cake: {cake.SerialNumber} - Station {_stepNum} Done!");

            return cake;
        }

        public void AddCake(HouseCake cake)
        {
            _cakeWaitInLine.Enqueue(cake);
        }

    }
}
