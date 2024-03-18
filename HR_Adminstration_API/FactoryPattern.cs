using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HR_Adminstration_API
{
    public class FactoryPattern<K, T> where T : class, K, new()
    {
        public static K GetInstance()
        {
            K obj;
            obj =  new T();
            return obj;
        }

    }

}
