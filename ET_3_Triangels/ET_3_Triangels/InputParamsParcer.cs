using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_3_Triangels
{
    class InputParamsParcer
    {
        public static List<InputParams> Parse(string[] args)
        {
            var result = new List<InputParams>();

            string list = String.Join(" ", args);
            string[] argsByComma = list.Split(',', ';');

            if (argsByComma.Length % InputParams.CountAgrs != 0)
            {
                throw new ArgumentException("Input agrs is not valid");
            }

            int j = 0;
            double temp;
            for (int i = 1; i <= argsByComma.Length; i++)
            {
                if (i % InputParams.CountAgrs == 1)
                {
                    result.Add(new InputParams());
                    result[j].Name = argsByComma[i - 1];
                }
                if (i % InputParams.CountAgrs == 2)
                {        
                    if(!Double.TryParse(argsByComma[i - 1], out temp))
                    {
                        throw new ArgumentException(String.Format("Value SideA: {0} for {1} triangle is not valid", argsByComma[i], j));
                    }
                    result[j].SideA = temp;

                }
                if (i % InputParams.CountAgrs == 3)
                {
                    if (!Double.TryParse(argsByComma[i - 1], out temp))
                    {
                        throw new ArgumentException(String.Format("Value SideB: {0} for {1} triangle is not valid", argsByComma[i], j));
                    }
                    result[j].SideB = Double.Parse(argsByComma[i - 1]);
                }
                if (i % InputParams.CountAgrs == 0)
                {
                    if (!Double.TryParse(argsByComma[i - 1], out temp))
                    {
                        throw new ArgumentException(String.Format("Value SideC: {0} for {1} triangle is not valid", argsByComma[i], j));
                    }
                    result[j].SideC = Double.Parse(argsByComma[i - 1]);
                    j++;
                }
            }

            return result;
        }
    }
}
