using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandomRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; int ran;
            Random random = new Random();
            ran = random.Next(200);

            for(int i = 0; i < 10; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                num = int.Parse(Console.ReadLine());
                if (ran == num)
                {
                    Console.WriteLine("정답입니다!"); break;
                }
                else if (ran > num)
                {
                    Console.WriteLine(num + "보다는 큰 숫자입니다.\n");
                }
                else
                {
                    Console.WriteLine(num + "보다는 작은 숫자입니다.\n");
                }

            }
            

        }
    }
}
