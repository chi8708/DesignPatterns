using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28访问者模式
{
    //对象结构
    class ObjectStruct
    {
        List<Person> pList = new List<Person>();

        public void Add(Person p)
        {
            pList.Add(p);
        }

        public void Delete(Person p) 
        {
            pList.Remove(p);
        }

        public void Display(Action vistor) 
        {
            foreach (Person item in pList)
            {
                item.Action(vistor);
            }
        }
    }
}
