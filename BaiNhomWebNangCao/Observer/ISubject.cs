using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface ISubject
    {
        void attachObserver(IObserver observer);// thêm đối tượng đăng ký lắng nghe thông báo.


        void detachObserver(IObserver observer);// hủy đối tượng đăng ký lắng nghe thông báo


        void notifyObserver();// thong bao đến tất cả các đối tượng đã đăng ký thông báo.
    }
}
