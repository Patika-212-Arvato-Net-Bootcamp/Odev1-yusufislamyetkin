# Odev1-yusufislamyetkin


Araştırma Ödevi: Sealed Clas ne zaman hangi kurala göre kullanılmalı ?

Sealed class türetilmesini istemediğimiz sınıflarlarla işlem yapmak istediğimiz zaman kullanılmalı. .Net Framework içerisinde erişilemeyen bir çok sealed class bulunmaktadır. Örnek olarak string verilebilir. 

 Buluğum açıklayacı bir sealed kullanımı. 

    sealed class Kordinat
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main()
        {
            Kordinat kord = new Kordinat();
            kord.x = 100;
            kord.y = 180;
            Console.WriteLine("x = {0}, y = {1}", kord.x, kord.y);
            Console.ReadLine();
        }

Araştırma Ödevi: Stack Owerflow,Out of memory neden handle edemiyoruz ?

İşletim sistemi onu yakalayacağından (Windows durumunda) EXCEPTION_STACK_OVERFLOW yapılandırılmış istisnasını kendimiz yakalayamayız.
Yığın taşmasını işlemek doğru çözüm değildir, bunun yerine programınızın yığından taşmamasını sağlamalısınız.

