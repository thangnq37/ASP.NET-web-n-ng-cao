using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFController;
using Model;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //IObserver cus1 = new Customer("Ti", 11);
            //IObserver cus2 = new Customer("Teo", 12);
            //Student st1 = new Student("131", "Duc");
            //Student st2 = new Student("132", "Tai");
            //Product product1 = new Product("Laptop");
            //product1.attachObserver(cus1);// cus1 dang ky phan ung khi có thông báo
            //                              // từ product
            //product1.attachObserver(cus2);
            //product1.attachObserver(st1);
            //product1.attachObserver(st2);
            //product1.notifyObserver();// thông báo đến tất cả các Observer.
            //LoaiBaiHoc LBH = new LoaiBaiHoc() { Ten ="thu1", MoTa="Khoai lang bam",AnHien=true,KeyWords="thu 2",ThuTu=2};
            ModelController<Model.LoaiBaiHoc> tehm = new LoaiBaiHocController();
            //tehm.Insert(LBH);

            List<Model.LoaiBaiHoc> ls = tehm.SelectAll();
            foreach (var item in ls)
            {
                Console.WriteLine(item.KeyWords);
            }

            Console.ReadKey();
        }
    }
}
