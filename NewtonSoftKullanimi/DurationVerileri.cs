using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NewtonSoftKullanimi
{
    /*

   {
   "data": [
   {
     "project": "string: project name",     
     "time": "float: start of this duration as ISO 8601 UTC datetime; numbers after decimal point are fractions of a second",
      "duration": "integer: length of time of this duration in seconds"
    }, 
  ],
  "branches": "list of strings: branches included in this response",
  "start": "integer: start of time range as ISO 8601 UTC datetime",
  "end": "integer: end of time range as ISO 8601 UTC datetime",
  "timezone": "string: timezone used for this request in Olson Country/Region format"
}

    */
    class DurationVerileri
    {
        private string jsonVeri;
        private TextBox txtResponse;
        public DurationVerileri(string jsonVeri,TextBox txtResponse)
        {
            this.jsonVeri = jsonVeri;
            this.txtResponse = txtResponse;
        }


        public void  durationVerileri()
        {
            try
            {
                var jsonParse = JsonConvert.DeserializeObject<Duration>(jsonVeri);
               
                txtResponse.Text = "branches :" + jsonParse.branches.ToString();
                //+" duration :" + jsonArray.duration.ToString();
               

                
                   foreach(var u in jsonParse.data)//dizideki değerler
                    txtResponse.Text = txtResponse.Text +"--> duration :" + u.duration.ToString();
               

            }
            catch(Exception ex)
            {
                txtResponse.Text = "Hata :" + ex.Message.ToString();
            }
            


        }
    }
}
