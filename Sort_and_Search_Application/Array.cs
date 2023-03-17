using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_and_Search_Application
{
    class Array
    {
        public int[] TrafficData()
        { 
            var list = new List<int>();
            var Road = File.ReadAllLines(Directory + Path);
        foreach (var line in Road)
            {
                list.Add(Convert.ToInt32(line));
            }
            return list.ToArray();
        }
    }
}
