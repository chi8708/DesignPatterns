using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> pList = new List<Person>();
            for (int i = 0; i < 1000; i++)
            {
                Person p = new Person() { PId = i, Name = "hahah" + i, Age = i };
                pList.Add(p);
            }

            List<Porder> oList = new List<Porder>();
            for (int i = 0; i < 1000; i++)
            {
                Porder o = new Porder() { PId = i, Content = "aaaaa" + i };
                oList.Add(o);
            }
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            List<PersonCustom> poList1 = new List<PersonCustom>();
            //遍历形式加入自定义类中
            foreach (var item in pList)
            {
                PersonCustom po = new PersonCustom();
                foreach (var item2 in oList)
                {

                    po.Age = item.Age;
                    po.Name = item.Name;
                    if (item.PId==item2.PId)
                    {
                        po.oContent = item2.Content;
                    }
                    poList1.Add(po);
                }
            }
            sw1.Stop();


            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            List<PersonCustom> poList2 = new List<PersonCustom>();
            //linq形式加入自定义类中
            poList2 = (pList.Select(p => new PersonCustom()
              {
                  Age = p.Age,
                  Name = p.Name,
                  oContent=oList.Where(o=>o.PId==p.PId).Select(o=>o.Content).FirstOrDefault()
              })).ToList();
            sw2.Stop();

            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            List<PersonCustom> poList3 = new List<PersonCustom>();
            //join形式加入自定义类中
            poList3 = (from p in pList
                       join o in oList
                       on p.PId equals o.PId
                       select new PersonCustom() { Name = p.Name, Age = p.Age, oContent = o.Content }).ToList();

            //poList3 = (from p in pList
            //           from o in oList
            //           where p.PId==o.PId
            //     
            //select new PersonCustom() { Name = p.Name, Age = p.Age, oContent = o.Content }).ToList();

            sw3.Stop();



            Console.WriteLine(sw1.Elapsed +"--------" +sw2.Elapsed+"--------"+sw3.Elapsed);
            Console.ReadKey();

            //1000和1000条数据耗时,linq join<linq<foreach

        }
    }
}
