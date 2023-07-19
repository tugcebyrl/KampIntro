using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class IhtiyacKrediManager : IKrediManager //ilk baslangicta verdigi hatayi duzeltmek icin verdigi öneride "implement interface" yazisina tiklariz
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //throw new NotImplementedException();
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
