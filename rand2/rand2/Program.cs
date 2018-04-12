using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand2
{
    class Program
    {
        static void Main(string[] args)
        {
            //把所有的号码放入List
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 42; i++)
            {
                numbers.Add(i);
            }
            
            //随机挑选一个印出
             Random rand = new Random();
            for(int i = 0; i < 6; i ++)
            {

            int r = rand.Next(1, numbers.Count );
            Console.WriteLine(numbers[r]);

            //并从List中删除
            numbers.Remove(r);

            //重复2.3六次
          }

            Console.ReadKey();
           
            
            
        }
    }
}
