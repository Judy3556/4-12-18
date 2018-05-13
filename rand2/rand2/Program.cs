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
            Console.WriteLine();
            Console.WriteLine(" 不重複大樂透中獎號碼");
            Console.WriteLine(" ————————————");

            // 把所有的号码放入List
            List<int> numbers = new List<int>();

            for (int i = 0; i <= 42; i++)
            {
                numbers.Add(i);
            }
             
            // 随机挑选一个印出
            Random rand = new Random();

            // 重复六次
            for (int i = 0; i < 6; i++)
            {
                int r = rand.Next(1, numbers.Count);
                Console.WriteLine(" "+numbers[r]+" ");

                // 把選出的數從List中刪除
                numbers.Remove(r);

            }

            Console.WriteLine(" ————————————");
            Console.WriteLine(" 感謝您的參與");
            Console.ReadKey();
           
            
            
        }
    }
}
