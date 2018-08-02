using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NewtonSoftKullanimi
{
    public partial class Form1 : Form
    {
        private DurationVerileri _durationVeriler;
        private GoalsVerileri _goalsVeriler;
       
        public Form1()
        {
            InitializeComponent();
            txtJsonVeriGir.Text = "SERİLAZE BUTONUNA TIKLAYARAK SONUCU GÖREBİLİRSİNİZ..";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _durationVeriler = new DurationVerileri(txtJsonVeriGir.Text.ToString(),txtResponse);
            _goalsVeriler=new GoalsVerileri(txtJsonVeriGir.Text.ToString(), txtResponse);

            //_durationVeriler.durationVerileri();
            _goalsVeriler.durationVerileri();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtResponse.Text = string.Empty;
        }

        private void btnSerilaze_Click(object sender, EventArgs e)
        {
           
            try
            {
                SerilazeKullanimi _serilaze = new SerilazeKullanimi();
                //Goals goal = new Goals();//attribute lara değer atanmadığı içiin  varsayılan değer olarak
                //kimini null,kimini 0 göstreir..

                var serilazeKullanimi = JsonConvert.SerializeObject(_serilaze);

                JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
                string microsoftJson = JsonConvert.SerializeObject(_serilaze, microsoftDateFormatSettings);
                // {"Details":"Application started.","LogDate":"\/Date(1234656000000)\/"}

                string javascriptJson = JsonConvert.SerializeObject(_serilaze, new JavaScriptDateTimeConverter());


                txtResponse.Text = serilazeKullanimi.ToString();
                 //txtResponse.Text = microsoftJson.ToString();
              // txtResponse.Text = javascriptJson.ToString();
            }
            catch (Exception ex)
            {
                txtResponse.Text = "HATA :" + ex.Message.ToString();
            }
          
        }
    }
}
