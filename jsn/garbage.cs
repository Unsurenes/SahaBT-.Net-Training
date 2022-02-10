using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsn
{
    class garbage
    {   List<Person> jsnl = new List<Person>();
        List<Person> Garbage = new List<Person>();
        public garbage()
        {
            jsnl = data.jsn;
            
            for (int i = 0; i<jsnl.Count(); i++)
            {
                for (int j = 0; j<jsnl.Count; j++)
                {
                    if (jsnl[i].Email==jsnl[j].Email && i!=j)
                    {
                        Garbage.Add(jsnl[j]);
                        jsnl.RemoveAt(j);
                    }
}
            }

        }
        public List<Person> getGarbage()
        {
            return Garbage;
        }
        public List<Person> getList()
        {
            return jsnl;
        }
       
    }
}
