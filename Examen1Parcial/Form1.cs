using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1Parcial
{
    public partial class Form1 : Form
    {


        string APIKey = "d45c2ffc2fd7a4cf1b27dace41566589";
        public Form1()
        {
            InitializeComponent();
        }

        void Buscar()
        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCiudad.Text, APIKey);

                var json = web.DownloadString(url);
                Clim.root info = JsonConvert.DeserializeObject<Clima.root>(json);

                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
             
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
