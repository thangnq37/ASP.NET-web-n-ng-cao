using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Product : ISubject
    {
        private List<IObserver> obs = new List<IObserver>();
        private String nameProduct;


        public Product(String nameProduct)
        {
            this.nameProduct = nameProduct;
        }
        public void attachObserver(IObserver observer)
        {
            obs.Add(observer);
        }

        public void detachObserver(IObserver observer)
        {
            obs.Remove(observer);
        }

        public void notifyObserver()
        {
            foreach (IObserver ob in obs)
            {
                ob.update(nameProduct);
            }
        }
    }
}
