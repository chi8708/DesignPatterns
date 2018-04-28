using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("输入数字1");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入运算符");
                string opr = Console.ReadLine();
                Console.WriteLine("输入数字2");
                double num2 = Convert.ToDouble(Console.ReadLine());
                //简单工程模式
               // Calculate cal = CalculateFactory.CreateOperate(opr);

                //工厂模式
                IoperateFactory opration = new IAddFactory();
                Calculate cal = opration.CreateOperate();

                cal.Num1 = num1;
                cal.Num2 = num2;
                double result = cal.GetResult();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
