
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace comb_alg_4a
{
    class GreedAlgorithm
    {
        static int[] answer;

        public static string Result(int[] set, int sum, out long time, out int realDiff)
        {
            time = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Array.Sort(set);
            Array.Reverse(set);

            realDiff = greedy(set, set.Length, sum);

            stopWatch.Stop();
            time = stopWatch.Elapsed.Ticks;

            return ExactAlgorithm.ToString(answer);
        }



        
        private static int greedy(int[] set, int n, int sum) 
        {
            int summary = 0;
            List<int> subSet = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int tmp = sum;
                subSet.Clear();
                for (int j = i; j < n; j++)
                {
                    if (set[j] <= tmp)
                    {
                        tmp -= set[j];
                        subSet.Add(set[j]);
                    }
                }
                if (sum - tmp > summary)
                {
                    summary = sum - tmp;
                    answer = new int[subSet.Count];
                    subSet.CopyTo(answer);
                    if (summary == sum) return 0;
                }
            }
            return sum - summary;
        }
       

    }
}
