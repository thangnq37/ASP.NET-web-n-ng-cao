using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Student : IObserver
    {
        private string _mssv;
        private string _name;
        public void update(string message)
        {
            Console.WriteLine("MSSV: {0} - Name: {1}, Message:{2}",_mssv,_name,message);
        }

        public Student(string mssv, string name)
        {
            _mssv = mssv;
            _name = name;
        }
    }
}
