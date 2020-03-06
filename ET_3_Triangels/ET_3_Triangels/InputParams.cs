using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_3_Triangels
{
    class InputParams
    {
        public string Name { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public const int CountAgrs = 4;

        //public InputParams()
        //{

        //}
        //public InputParams(string name, double sideA, double sideB, double sideC)
        //{
        //    Name = name;
        //    SideA = sideA;
        //    SideB = sideB;
        //    SideC = sideC;
        //}

        //public static bool isValid(string[] args)
        //{
        //    var result = new List<InputParams>();

        //    string list = String.Join(" ", args);
        //    string[] argsByComma = list.Split(',');

        //    if (argsByComma.Length % CountAgrs != 0)
        //    {
        //        return false
        //    }

        //    int j = 0;
        //    for (int i = 0; i < argsByComma.Length; i++)
        //    {
        //        if (i % CountAgrs == 1)
        //        {
        //            result.Add(new InputParams());
        //            result[j].Name = argsByComma[i];
        //        }
        //        if (i % CountAgrs == 2)
        //        {
        //            result[j].SideA = Double.Parse(argsByComma[i]);
        //        }
        //        if (i % CountAgrs == 3)
        //        {
        //            result[j].SideB = Double.Parse(argsByComma[i]);

        //        }
        //        if (i % CountAgrs == 0)
        //        {
        //            result[j].SideC = Double.Parse(argsByComma[i]);
        //            j++;
        //        }
        //    }

        //    return result;
        //}

        
    }
}
