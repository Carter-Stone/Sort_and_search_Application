using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sort_and_Search_Application
{
    class Array
    {
        public int[] TrafficData()
        {
            var list = new List<int>();
            try
            {
                var Road = File.ReadAllLines(Directory + Path);

                foreach (var line in Road)
                {
                    list.Add(Convert.ToInt16(line));
                }
                return list.ToArray();
            }
            catch (Exception exception) {
                Console.WriteLine($"Exception caught - {exception.Message}");
            }
            return list.ToArray();
        }
    }
}
