using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.IO;
using System;

namespace XML_Document
{
    public partial class Form1 : Form
    {
        readonly SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["kutuphaneConnectionString"].ConnectionString);
        XmlDocument xml = new XmlDocument();
        XmlElement filmler;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!File.Exists("..\\..\\Filmler.xml"))
            {
                filmler = xml.CreateElement("filmler");
                xml.AppendChild(filmler);
            }
            else
            {
                xml.Load("..\\..\\Filmler.xml");
                filmler = (XmlElement)xml.SelectSingleNode("filmler");
                XmlNodeList film = filmler.SelectNodes("film");
                foreach (XmlNode node in film)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = node.Attributes["adi"].Value;
                    lvi.SubItems.Add(node.Attributes["tur"].Value);
                    lvi.SubItems.Add(node.Attributes["yil"].Value);
                    lvi.SubItems.Add(node.Attributes["yonetmen"].Value);
                    lvi.SubItems.Add(node.Attributes["imdb"].Value);
                    listView1.Items.Add(lvi);
                }
            }

        }

        private void filmEkle_button_Click(object sender, EventArgs e)
        {
            XmlElement film = xml.CreateElement("film");

            XmlAttribute adi = xml.CreateAttribute("adi");
            adi.Value = filmAdi_textBox.Text;
            film.Attributes.Append(adi);

            XmlAttribute tur = xml.CreateAttribute("tur");
            tur.Value = filmTuru_comboBox.Text;
            film.Attributes.Append(tur);

            XmlAttribute yil = xml.CreateAttribute("yil");
            yil.Value = yapimYili_dateTimePicker.Value.Year.ToString();
            film.Attributes.Append(yil);

            XmlAttribute yonetmen = xml.CreateAttribute("yonetmen");
            yonetmen.Value = yonetmen_textBox.Text;
            film.Attributes.Append(yonetmen);

            XmlAttribute imdb = xml.CreateAttribute("imdb");
            imdb.Value = numericUpDown1.Value.ToString();
            film.Attributes.Append(imdb);

            XmlElement oyuncular = xml.CreateElement("oyuncular");

            foreach (string oyuncu in listBox1.Items)
            {
                XmlElement xmloyuncu = xml.CreateElement("oyuncu");
                xmloyuncu.InnerText = oyuncu;
                oyuncular.AppendChild(xmloyuncu);
            }
            film.AppendChild(oyuncular);
            filmler.AppendChild(film);
            xml.Save("..\\..\\Filmler.xml");
        }

        private void oyuncuEkle_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(oyuncu_textBox.Text);
        }

        private void dbToXML_button_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("XML dosyasi kutuphane veritabanindan veriler cekmektedir!\n XML Adi: Kitap.xml", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlDataAdapter adp = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SelectKitap", sql);
                DataTable dt = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand = cmd;
                dt.TableName = "Kitap";
                adp.Fill(dt);
                dt.WriteXml("Kitap.xml");
                try
                {
                    System.Diagnostics.Process.Start("..\\Debug");
                }
                catch (Exception)
                { }
            }
            catch (Exception)
            {
                MessageBox.Show("XML Dosyasi Olusturulamadi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
