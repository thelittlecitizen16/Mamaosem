using Mamaosem.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MamaosemProject
{
    public class Stand : IStand<HouseCake>
    {
        private int _stepNum;
        private Queue<HouseCake> _cakeWaitInLine;

        public Stand(int stepNum)
        {
            _stepNum = stepNum;
            _cakeWaitInLine = new Queue<HouseCake>();
        }

        public HouseCake PerformProdLineStep()
        {
            HouseCake cake = _cakeWaitInLine.Dequeue();
            ProductionLineService.PerformProdLineStep(_stepNum, cake);

            return cake;
        }

        public HouseCake PerformProdLineStep(HouseCake cake)
        {
            ProductionLineService.PerformProdLineStep(_stepNum, cake);

            return cake;
        }


        public void AddCake(HouseCake cake)
        {
            _cakeWaitInLine.Enqueue(cake);
        }

    }
}
