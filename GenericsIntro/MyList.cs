using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T> // Class olusturduktan sonra <T> ekliyoruz
    {
        T[] items;
        //Constructor ctor--> tab tab
        public MyList() 
        {
            items = new T[0];
        }
        public void Add(T item) //verilen eleman turune gore listeye ekleme cikarma yapabiliyoruz
        {
            T[] tempArray = items; //Gecici dizi ile listedeki verilerin referans adresini sakliyoruz
            items = new T[items.Length + 1];
        }
    }
}
