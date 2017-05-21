using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace EFController
{
    public abstract class Base
    {
        public EF thu;
        private static volatile EF _instance;
        private static object syncRoot = new Object();
        public Base(){
            thu = new EF();
        }
        public static EF Instance
        {
            get{
                if(_instance == null)
                {
                    lock (syncRoot)
                    {
                        if(_instance == null)
                        {
                            _instance = new EF();
                        }
                    }
                }
                return _instance;

            }
        }
    }
}
