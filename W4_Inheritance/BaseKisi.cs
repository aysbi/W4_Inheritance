using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_Inheritance
{
    public class BaseKisi //ilk once base class tanimlanir
    {
        public string Ad { get; set; } //Ad ve soyad alinir 
        public string Soyad { get; set; }
        
        public virtual void Yazdir() //base metodumuz, ogretmen icin override ornegi yapmak istedigimden virtual olarak belirledim
        {
            Console.WriteLine(Ad + " " + Soyad);
        }
    }

    public class Ogretmen : BaseKisi //Ogretmen BaseKisi sinifindan metot ve nesneleri kullanabilir
    {
        public int MaasBilgisi { get; set; } //ek olarak maas bilgisi girilir
        public override void Yazdir()  //Burada override kullanmak istedim bir ornegi olmasi icin. Yazdir metodunun icini degistirdim 
        {
            Console.WriteLine(Ad + " " + Soyad + " Maas: " + MaasBilgisi + "TL"); 
        }
    }

    public class Ogrenci : BaseKisi //yine basekisiden dogan ogrenci sinifi
    {
        public int OgrenciNumarasi { get; set; }
        public void OgrenciBilgileriniYazdir () //burada yeni bir metot tanimlayarak Basekisideki metodu da icinde cagirdim ve ekleme yaptim
        {
            Yazdir();
            Console.WriteLine("No: " + OgrenciNumarasi);
        }
    }
}
