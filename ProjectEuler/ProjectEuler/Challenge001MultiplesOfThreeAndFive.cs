using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Challenge001MultiplesOfThreeAndFive
    {

        public static List<long> GetMultiplesLessThanN(List<int> inputValues)
        {
            int T = inputValues[0];
            List<long> returnValue = new List<long>();

            for (int test = 1; test <= T; test++)
            {
                int N = inputValues[test];
                long sum = 0;

                int counter = 3;

                while (counter < N)//counter++
                {
                    if (counter % 3 == 0 || counter % 5 == 0)
                    { sum += counter; }
                }

                returnValue.Add(sum);
            }

            return returnValue;
        }
    }
}
