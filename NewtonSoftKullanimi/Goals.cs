using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonSoftKullanimi
{
    class Goals
    {
        //json formattaki verileri uygun şekilde (eğer bir deserilaze sonucu almak istiyorsak) düzgün
        //bir şekilde( Goals classı gibi) hale getirmek gerek..
        //Goals class herhangi bir örnektir..
        public List<Datalar> data { get; set; }

        public class Datalar
        {
           

            public ChartData chart_data { get; set; }
            public string cumulative_status { get; set; }
            public string delta { get; set; }
            public string id { get; set; }
            public string ignore_days { get; set; }
            public float improve_by_percent { get; set; }
            public bool is_enabled { get; set; }
            public string languages { get; set; }
            public string projects { get; set; }
            public string range_text { get; set; }
            public int seconds { get; set; }
         
            public List<Subscribers> subscribers { get; set; }
            public string title { get; set; }
            public string status { get; set; }
            public string type { get; set; }
            

        }
        public class Subscribers
        {
            public string email { get; set; }
            public string email_frequency { get; set; }
            public string full_name { get; set; }
            public string user_id { get; set; }
            public string username { get; set; }

        }
        public class ChartData
        {
            public int actual_seconds { get; set; }
            public string actual_seconds_text { get; set; }
            public int goal_seconds { get; set; }
            public string goal_seconds_text { get; set; }

            public Range range { get; set; }
            public string range_status { get; set; }
            public string range_status_reason { get; set; }
            public string average_status { get; set; }

        }
        public class Range
        {
            public string date { get; set; }
            public int end { get; set; }
            public int start { get; set; }
            public string text { get; set; }
            public string timezone { get; set; }
        }

       public int total { get; set; }
       public int total_pages { get; set; }
    }
}
