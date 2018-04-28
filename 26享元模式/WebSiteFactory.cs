using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _26享元模式
{
    class WebSiteFactory
    {
        Hashtable flyWeights = new Hashtable();

        public Website GetWebSiteCategory(string key) 
        {
            if (!flyWeights.ContainsKey(key))
            {
                flyWeights.Add(key,new ConcreteWebsite(key));
            }
            return flyWeights[key] as Website;
        }

        public int GetWebSiteCount() 
        {
            return flyWeights.Count;
        }
    }
}
