internal class Program
{
    private static void Main(string[] args)
    {
        //Bir araba galerisi olduğunu varsayalım. Galerideki arabalarla bir sınıf yapalım..
        //Syntax : <erişim belirleyici> class <sınıfın adı>
        //Sıra geldi tanımlanmış sınıftan bir örnek-instance-nesne yaratmaya
        //<sınıf adı> <nesne adı> = new <sınıf adı>

        CarGallery carGallery = new CarGallery(); // Nesnem tanımlanmış olan sınıftan kendini örnekledi (instance aldı)

        //Nesnemizin özelliklerini ulaşalım.
        carGallery.Colour = "Füme";

        carGallery.Brand = "Mercedes"; // Bellekte boş olarak duran yerleri veri ile doldurdum.
        carGallery.Model = "C200";

        Console.WriteLine("Arabanın Markası: " + carGallery.Brand + " - " + "Arabanın Modeli: " + carGallery.Model + " - " + "Arabanın Rengi: " + carGallery.Colour);

        Console.WriteLine(carGallery.Price.ToString()); // Fiyatını da içinde default olarak tanımlanmış özellikten alacak. 
        
        Console.ReadKey();
    }
    public class CarGallery // CarGallery isminde bir class tanımlanıyor.

    {

        public string Brand { get; set; } // Marka      
        public  string Model { get; set; } // Model
        public string Class { get; set; } // Sınıf (B,C, SUV)
        public int MPower { get; set; } // Motoe gücü 90, 140 Beygir..
        public int MVolume { get; set; } // 1400,2000 cc
        public string MSerial { get; set; } // Motor seri no XSDRTT%%&Y/YWGGDS
        public char GasType { get; set; } // Yakıt Türü
        public char GearType { get; set; } // Vites Türü
        public string  CaseType { get; set; } // Kasa Tipi
        public int ProducedYear { get; set; } // Üretildiği Yıl
        public  string Colour { get; set; } // Renk Bilgisi

        public int Price = 100000; // Default bir değer atadım.


    }

}