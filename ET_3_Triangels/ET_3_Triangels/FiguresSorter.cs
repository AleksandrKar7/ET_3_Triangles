using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_3_Triangels
{
    class FiguresSorter
    {
        void SortByArea(ref List<IFigure> figures)
        {
            if(figures == null)
            {
                throw new NullReferenceException("List of figures is null");
            }

            int i = 0;
            int j = 0;
            IFigure temp;
            while(i < figures.Count)
            {
                if (figures[j].GetArea() < figures[j + 1].GetArea())
                {
                    temp = figures[j + 1];
                    figures[j + 1] = figures[j];
                    figures[j] = temp;
                }
                if (j == figures.Count-1)
                {
                    j = 0;
                    i++;
                }
                j++;
            }
        }
    }
}
