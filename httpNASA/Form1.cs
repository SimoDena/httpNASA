using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.Http;
using System.Net;

namespace httpNASA
{
    public partial class Form1 : Form
    {
        const string EndpointURL = "https://api.nasa.gov/planetary/apod";
        DateTime dataLancio = new DateTime(1995, 6, 16);
        int immaginiScaricateOggi;

        const string immagineAvvio = "immagine avvio";
        const string limiteAnno = "limite anno";
        const string dataOggi = "data oggi";
        const string richiesteOggi = "richieste oggi";
        const char delimitatore = ':';


        public Form1()
        {
            InitializeComponent();
            monthCalendar1.MinDate = dataLancio;
            monthCalendar1.MaxDate = DateTime.Today;

            ReadInitFile();
        }

        private void btnDataLancio_Click(object sender, EventArgs e)
        {
            cbLimitaAnno.Enabled = false;
            monthCalendar1.SelectionEnd = dataLancio;
        }

        private void cbLimitaAnno_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLimitaAnno.Checked == true)
            {
                DateTime anno = new DateTime(DateTime.Today.Year, 1, 1);
                monthCalendar1.MinDate = anno;
            }
            else
            {
                monthCalendar1.MinDate = dataLancio;
            }
        }

        private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            await RecuperaFoto();
        }

        private bool FormatoSupportato(string photoURL)
        {
            string ext = Path.GetExtension(photoURL).ToLower();

            return (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif" || ext == ".bmp" ||
                    ext == ".tif");
        }

        private async Task RecuperaFoto()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12; // Versione protocolli ssl/tls
            var client = new HttpClient();
            JObject jresult = new JObject();
            string responseContent;
            string descrizione;
            string copyright;
            string fotoURL;


            DateTime dataScelta = monthCalendar1.SelectionEnd;
            string dateSelected = $"{dataScelta.Year.ToString()}-{dataScelta.Month.ToString("00")}-{dataScelta.Day.ToString("00")}";
            string parametriURL = $"?date={dateSelected}&api_key=D4pjizeEkQwGcfPqJdPh7aOXa1NgJVED4QDvL3VT";

            client.BaseAddress = new Uri(EndpointURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage risposta = client.GetAsync(parametriURL).Result;  //invia GET e ottiene la risposta.

            if (risposta.IsSuccessStatusCode)
            {
                try
                {
                    responseContent = await risposta.Content.ReadAsStringAsync();

                    jresult = JObject.Parse(responseContent);

                    fotoURL = (string)jresult["url"];
                    pictureBox1.ImageLocation = fotoURL;

                    if (FormatoSupportato(fotoURL))
                    {
                        copyright = (string)jresult["copyright"];
                        if (copyright != null && copyright.Length>0)
                        {
                            txtCrediti.Text = copyright;
                        }
                        else
                        {
                            txtCrediti.Text = "NASA";
                        }

                        descrizione = (string)jresult["explanation"];
                        if (descrizione != null && descrizione.Length > 0)
                        {
                            txtDescrizione.Text = descrizione;
                        }
                        else
                        {
                            txtDescrizione.Text = "";
                        }
                    }
                    else
                    {
                        txtDescrizione.Text = "Formato foto non supportato\nl'URL è:" + fotoURL;
                    }
                }
                catch(Exception ex)
                {
                    txtDescrizione.Text = $"Image data in non supported. {ex.Message}";
                }

                ++immaginiScaricateOggi;
                txtImmaginiscaricate.Text = immaginiScaricateOggi.ToString();
            }
            else
            {
                txtDescrizione.Text = "Impossibilie ottentere immagine Nasa oggi!" + $"  {risposta.StatusCode.ToString()} {risposta.ReasonPhrase}";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!File.Exists("init.txt"))
            {
                File.Create("init.txt");
            }

            using (StreamWriter sw = new StreamWriter("init.txt"))
            {
                sw.WriteLine($"{immagineAvvio}{delimitatore} {cbAvvio.Checked.ToString()}");
                sw.WriteLine($"{limiteAnno}{delimitatore} {cbLimitaAnno.Checked.ToString()}");
                sw.WriteLine($"{dataOggi}{delimitatore} {DateTime.Today.ToShortDateString()}");
                sw.WriteLine($"{richiesteOggi}{delimitatore} {txtImmaginiscaricate.Text.ToString()}");
            }

        }

        private void ReadInitFile()
        {
            if (File.Exists("init.txt"))
            {
                string line;
                string[] lineaSplittata;
                bool isToday = false;

                using (StreamReader sr = new StreamReader("init.txt"))
                {
                    while ((line = sr.ReadLine())!=null)
                    {
                        lineaSplittata = line.Split(delimitatore);

                        switch (lineaSplittata[0])
                        {
                            case immagineAvvio:
                                cbAvvio.Checked = bool.Parse(lineaSplittata[1]);
                                break;
                            case limiteAnno:
                                cbLimitaAnno.Checked = bool.Parse(lineaSplittata[1]);
                                break;
                            case dataOggi:
                                DateTime dt = DateTime.Parse(lineaSplittata[1]);
                                if (dt.Equals(DateTime.Today))
                                {
                                    isToday = true;
                                }
                                break;
                            case richiesteOggi:
                                if (isToday)
                                {
                                    try
                                    {
                                        immaginiScaricateOggi = int.Parse(lineaSplittata[1]);
                                    }
                                    catch
                                    {
                                        immaginiScaricateOggi = 0;
                                    }
                                    
                                }
                                else
                                {
                                    immaginiScaricateOggi = 0;
                                }
                                break;

                        }
                    }
                }
            }
            else
            {
                immaginiScaricateOggi = 0;
                cbAvvio.Checked = true;
                cbLimitaAnno.Checked = true;
            }

            txtImmaginiscaricate.Text = immaginiScaricateOggi.ToString();
            if (cbAvvio.Checked)
            {
                monthCalendar1_DateSelected(null, null);
            }
        }
    }
}
