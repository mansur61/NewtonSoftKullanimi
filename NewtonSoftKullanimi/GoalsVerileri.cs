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
    class GoalsVerileri
    {


        private TextBox txtResponse;
        private string jsonVeri;
        public GoalsVerileri(string jsonVeri,TextBox txtResponse)
        {
            this.jsonVeri = jsonVeri;
            this.txtResponse = txtResponse;
        }

        public void durationVerileri()
        {
            try
            {
                var jsonParse = JsonConvert.DeserializeObject<Goals>(jsonVeri);

                txtResponse.Text = "total_pages -->" + jsonParse.total_pages;
                //+" duration :" + jsonArray.duration.ToString();


                // Attribute Json erişimleri..
                foreach (var u in jsonParse.data)//dizideki değerler
                    txtResponse.Text = txtResponse.Text + "--> is_enabled :" + u.is_enabled.ToString();

               
                //Array Object Json erişimleri
                foreach(var m in jsonParse.data)
                    foreach (var n in m.subscribers)
                        txtResponse.Text = txtResponse.Text + "--> email :" + n.email.ToString();


                foreach (var u in jsonParse.data)//dizideki değerler
                    txtResponse.Text = txtResponse.Text + "--> title :" + u.title.ToString();


                // Nesne Json erişimleri
                foreach (var m in jsonParse.data)                 
                        txtResponse.Text = txtResponse.Text + "--> actual_seconds :" + m.chart_data.actual_seconds;

                foreach (var m in jsonParse.data)
                    txtResponse.Text = txtResponse.Text + "--> range.date :" + m.chart_data.range.date.ToString();
                   
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Hata :" + ex.Message.ToString();
            }



        }


       
    }
}
