using Mamaosem.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MamaosemProject
{
    public class ProductionLine
    {
        private LinkedList<IStand<HouseCake>> _standsInProductionLine;

        public ProductionLine(LinkedList<IStand<HouseCake>> standsInProductionLine)
        {
            _standsInProductionLine = standsInProductionLine;
        }

        public void RoundOfWork()
        {
            PassAllStands();
        }

        public void CreateCakeInAllStands(HouseCake cake)
        {
            PassAllStands(cake);
        }

        public void CreateCakeInFirstStand(HouseCake cake)
        {
            _standsInProductionLine.First.Value.AddCake(cake);
        }

        private void PassAllStands(HouseCake cake = null)
        {
            LinkedListNode<IStand<HouseCake>> stand = _standsInProductionLine.First;

            int count = 0;

            foreach (var stande in _standsInProductionLine)
            {
                if (cake == null)
                {
                    cake = stande.PerformProdLineStep();
                }
                cake = stande.PerformProdLineStep(cake);

                count++;
                if (count < _standsInProductionLine.Count)
                {
                    stand.Next.Value.AddCake(cake);
                    stand = stand.Next;
                }
            }
        }
    }
}
