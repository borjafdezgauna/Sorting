using System;
using System.Collections.Generic;
using System.Text;

namespace EDA
{
    public interface ISortingAlgorithm
    {
        bool CheckIsCorrect();
        void Sort(int[] A);
    }
}
