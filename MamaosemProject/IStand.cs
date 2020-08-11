using System;
using System.Collections.Generic;
using System.Text;

namespace MamaosemProject
{

    public interface IStand<T>
    {
        T PerformProdLineStep();
        T PerformProdLineStep(T cake);
        void AddCake(T cake);
    }
}
