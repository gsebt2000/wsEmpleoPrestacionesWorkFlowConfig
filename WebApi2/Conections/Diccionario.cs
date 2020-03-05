using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2.Conections
{
    public class Diccionario
    {
        Dictionary<string, object> param = new Dictionary<string, object>();
        public object this[string key]
        {
            get
            {
                return param[key.ToUpper()];
            }
            set
            {
                param[key.ToUpper()] = value;
            }
        }

        public bool ContainsKey(string p)
        {
            return param.ContainsKey(p.ToUpper());
        }

        public void Add(string p, object obj)
        {
            param.Add(p.ToUpper(), obj);
        }

        public void Remove(string p)
        {
            param.Remove(p.ToUpper());
        }
    }

}
