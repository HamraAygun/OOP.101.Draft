using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    internal class clsHome
    {
        //Evlerle ilgili örnek bir class..

        public clsHome(int param)
        {

            DoorNumber = param; //parametreden gelen değeri property alanıma yüklüyorum.
            Console.WriteLine("Ev {0} adresinde, {1} kapı numarasında bulunuyor...", StreetName, DoorNumber);

        }
        public int DoorNumber { get; set; }
        public string StreetName { get; set; } = "Doming Street..";
    }
}
