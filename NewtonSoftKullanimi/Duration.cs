using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonSoftKullanimi
{
    class Duration
    {
        //json formattaki verileri uygun şekilde (eğer bir deserilaze sonucu almak istiyorsak) düzgün
        //bir şekilde( Duration classı gibi) hale getirmek gerek..
        //Duration class herhangi bir örnektir..
        public List<Datalar> data { get; set; }

        public class Datalar
        {
            public string project { get; set; }
            public string time { get; set; }
            public string duration { get; set; }

        }

        public string branches { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string timezone { get; set; }
 
        
    }
}
