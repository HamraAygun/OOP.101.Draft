using System.Reflection;
using OOP._101.Draft;


    internal class Program
{
    private static void Main(string[] args)
    {
        //Bir araba galerisi olduğunu varsayalım. Galerideki arabalarla bir sınıf yapalım..
        //Syntax : <erişim belirleyici> class <sınıfın adı>
        //Sıra geldi tanımlanmış sınıftan bir örnek-instance-nesne yaratmaya
        //<sınıf adı> <nesne adı> = new <sınıf adı>

        clsCarGallery clscarGallery = new clsCarGallery(); // Nesnem tanımlanmış olan sınıftan kendini örnekledi (instance aldı)

        //Nesnemizin özelliklerini ulaşalım.
        clscarGallery.Colour = "Füme";

        clscarGallery.Brand = "Mercedes"; // Bellekte boş olarak duran yerleri veri ile doldurdum.
        clscarGallery.Model = "C200";

        Console.WriteLine("Arabanın Markası: " + clscarGallery.Brand + " - " + "Arabanın Modeli: " + clscarGallery.Model + " - " + "Arabanın Rengi: " + clscarGallery.Colour);

        Console.WriteLine(clscarGallery.Price.ToString()); // Fiyatını da içinde default olarak tanımlanmış özellikten alacak. 

        // parametrik constructor örneği:

        new clsHome(234); //234 değeri class a geçilecek olan parametre değeridir

        Console.ReadKey();
    }
  


}

