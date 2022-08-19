using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //제네릭
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(1111);
            Wanted<double> wantedDouble = new Wanted<double>(22.2222);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);


            //인덱서
            Products p = new Products();
            Console.WriteLine("오늘의 점심 메뉴는 " + p[0] + "입니다.");
            p[0] = "우동";
            Console.WriteLine("오늘의 점심 메뉴는 " + p[0] + "입니다.");
        }
    }
}
