using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_and_Search_Application
{
    class Sort
    {
        static void sort(string[] args)
        {
            int temp = 0;
            for (int i = 0; i <= TrafficData.Length - 1; i++)
            {
                for (int j = i + 1; j <= TrafficData.Length; j++)
                {
                    if (TrafficData[i] > TrafficData[j])
                    {
                        temp = TrafficData[i];
                        TrafficData[i] = TrafficData[j];
                        TrafficData[j] = temp;
                    }
                }
            }
        }
    }
}
}
//why did the chicken cross the road