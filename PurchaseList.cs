using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    public class PurchaseList
    {
        public string Run(string input)
        {           
            string[] inputArray = input.Split(' ');
            
            Dictionary<int, int> itemCount = new Dictionary<int, int>();

            int soldOnlyOnce = -1;
            int soldMoreThanOnce = -1;

            foreach (string item in inputArray)
            {
                int price = int.Parse(item);

                
                if (itemCount.ContainsKey(price))
                {
                    itemCount[price]++;
                }
                else
                {
                    itemCount[price] = 1;
                }
            }
           
            foreach (var kvp in itemCount)
            {
                if (kvp.Value == 1 && soldOnlyOnce == -1)
                {
                    soldOnlyOnce = kvp.Key;
                }
                else if (kvp.Value > 1 && soldMoreThanOnce == -1)
                {
                    soldMoreThanOnce = kvp.Key;
                }
            }
            
            return (soldOnlyOnce != -1 ? soldOnlyOnce.ToString() : "none") + "\n" + 
                (soldMoreThanOnce != -1 ? soldMoreThanOnce.ToString() : "none");

        }

    }

}
