using System;

namespace Referance_Type;
class Program
{
    static void Main(string[] args)
    {
        /*
         //Referance Type 
         1-> referans tipine örnek olarak class (sınıf) ve interface (arayüz) türleri verilebilir.
         Bu türler, bellekte ayrı bir yerde, heap bölgesinde saklanır ve değişkenler,
         bu verilerin adresini veya referansını içerir.

         2-> Bir referans tipi değişkeni kopyalandığında, yalnızca referansın kopyası alınır ve gerçek veri kopyalanmaz.

         3-> Referance tipleri, genellikle belleğin yığın (heap) bölgesinde saklanır. 
         */

        Person person1 = new Person();
        person1.Name = "Eyyüp";
        person1.Age = 24;
        person1.Job = "Computer Enginner";


        Person person2 = person1;//person2 person1 in referansını alıyor.

        person2.Name = "Zehra";

        Console.WriteLine("Person1 = " + person1.Name + " " + person1.Age + " " + person1.Job);
        Console.WriteLine("Person2 = " + person2.Name + " " + person2.Age + " " + person2.Job);


        Console.Read();//Aynı referansa sahip oldukları için aynı çıktılar elde edilir.
    }
}

