using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonSoftKullanimi
{
   
    class SerilazeKullanimi
    {
     
     // Bu şekilde kendi attribute özellikleri ve değerelerini tanımlayarak verilerimizi
     //JSON formata çevirebiliriz..

 
        public string cinsiyet { get; set; }
        public int yas { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string il { get; set; }
        public string addres { get; set; }
        public DateTime LogDate { get; set; }

        public string[] string_dizi = new string[] { "Ali", "Veli", "49","50" };
        public int[] int_dizi = new int[] { 10, 25, 38, 61 };       
           
        public SerilazeKullanimi()
        {
            this.ad= "mansur";
            this.yas = 45;
            this.addres = "Köprübaşı/Sürmene/Trabzon";
            this.cinsiyet = "erkek";
            this.soyad = "kaya";
            this.il = "Trabzon";
            this.int_dizi[0] =10;
            this.int_dizi[1] = 25;
            this.int_dizi[2] = 61;
            this.string_dizi[0] = "Ali";
            this.string_dizi[1] = "Mehmet";
            LogDate = new DateTime(2009, 2, 15, 0, 0, 0, DateTimeKind.Utc);
        }

    }
}
