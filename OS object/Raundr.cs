using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_object
{
    class Raundr
    {
         void findWaitingTime( int n, int[] bt, int[] wt, int quantum)
        {
            int[] rem_bt = new int[n];

            for (int i = 0; i < n; i++)
                rem_bt[i] = bt[i];

            int t = 0;

            string str = "0";
            while (true)
            {
                bool done = true;

                for (int i = 0; i < n; i++)
                {

                    if (rem_bt[i] > 0)
                    {
                        done = false;

                        if (rem_bt[i] > quantum)
                        {

                            t += quantum;
                            rem_bt[i] -= quantum;
                        }
                        else
                        {

                            t = t + rem_bt[i];
                            wt[i] = t - bt[i];

                            // As the process gets fully  
                            // executed make its remaining 
                            // burst time = 0 
                            rem_bt[i] = 0;
                        }
                    }

                    str = str + "  " + t;


                }

                // If all processes are done 
                if (done == true)
                    break;
            }
          //  Console.WriteLine(str);
        }
        // Method to calculate average time 
       public float findavgTime( int n, int[] bt, int quantum)
        {
            int[] wt = new int[n];
            int[] tat = new int[n];
            int total_wt = 0, total_tat = 0;
            findWaitingTime( n, bt, wt, quantum);
            Console.WriteLine("Processes " + " Burst time ");
            for (int i = 0; i < n; i++)
            {
                total_wt = total_wt + wt[i];
                total_tat = total_tat + tat[i];
               // Console.WriteLine(" " + (i + 1) + "\t\t" + bt[i] + "\t\t" + wt[i]);
            }


            return (float)total_wt / (float)n;
        }













    }
}
