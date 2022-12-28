using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    internal class clsCarGallery
    {
        // yapıcı metot
        public clsCarGallery()
        {
            GalleryName = "project 100 ky gallery";

            Console.WriteLine("Galerimizin adı : {0}", GalleryName);

        }
        //Classın propertyleri
        public string Brand { get; set; } // Marka      
        public string Model { get; set; } // Model
        public string Class { get; set; } // Sınıf (B,C, SUV)
        public int MPower { get; set; } // Motoe gücü 90, 140 Beygir..
        public int MVolume { get; set; } // 1400,2000 cc
        public string MSerial { get; set; } // Motor seri no XSDRTT%%&Y/YWGGDS
        public char GasType { get; set; } // Yakıt Türü
        public char GearType { get; set; } // Vites Türü
        public string CaseType { get; set; } // Kasa Tipi
        public int ProducedYear { get; set; } // Üretildiği Yıl
        public string Colour { get; set; } // Renk Bilgisi

        public int Price = 100000; // Default bir değer atadım.
        public string? GalleryName { get; set; }

    }
}
