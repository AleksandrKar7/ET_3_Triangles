using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_3_Triangels
{
    class Program
    {
        static void Main(string[] args)
        {

            List<InputParams> inputParams = InputParamsParcer.Parse(args);
            List<IFigure> figures = new List<IFigure>();
            foreach(InputParams p in inputParams)
            {
                figures.Add(new Triangel(p.Name, p.SideA, p.SideB, p.SideC));
            }


            //Triangel tr = new Triangel("first", 2, 2, 2);
            //string list = String.Join(" ", args);
            //Console.WriteLine(list);
            //Console.WriteLine(list);
            
            //Console.WriteLine(String.Format("{0}: {1}, {2}, {3}", param[0].Name, param[0].SideA, param[0].SideB, param[0].SideC));
            Console.Read();
        }
    }
}
