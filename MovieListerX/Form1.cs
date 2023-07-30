using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MovieListerX
{
    public partial class Form1 : Form
    {
        private bool key;
        private string sub;
        private string id;
        private bool foundMatch = false;
        private bool foundMatchx = false;

        public string originalTitle;
        public string primetitle;
        public int IMDB_movie;
        public double IMDB_s;
        public string IMDB;
        public string movie_imdb;
        public string date;

        public Form1()
        {
            InitializeComponent();
        }



        public void search()
        {
            string maskedtxt = textBox1.Text.Trim();
            string filePath = "data.tsv";

            if (key == true)
            {
                sub = "movie";
            }
            else
            {
                sub = "series";
            }

            double.TryParse(comboBox2.Text.Trim(), out double dt);

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split('\t');

                        string tconst = fields[0];
                        string titleType = fields[1];
                        date = fields[5];

                        double.TryParse(date.Trim(), out double date_s);

                        originalTitle = fields[3];

                        if (originalTitle.Contains(maskedtxt, StringComparison.OrdinalIgnoreCase) && titleType.Equals(sub, StringComparison.OrdinalIgnoreCase) && date_s >= dt)
                        {
                            foundMatch = true;
                            id = tconst;
                            break;
                        }
                        else
                        {
                            string temp = originalTitle;
                            originalTitle = originalTitle.Trim();

                            //Bosluk Isaret Sorunu
                            if (originalTitle.Contains(maskedtxt, StringComparison.OrdinalIgnoreCase) && titleType.Equals(sub, StringComparison.OrdinalIgnoreCase) && date_s >= dt)
                            {
                                foundMatch = true;
                                id = tconst;
                                break;
                            }

                            //Noktalama Isaret Sorunu
                            else
                            {
                                originalTitle = temp;
                                originalTitle = originalTitle.Replace("-", "").Replace(":", "").Replace(".", "");

                                if (originalTitle.Contains(maskedtxt, StringComparison.OrdinalIgnoreCase) && titleType.Equals(sub, StringComparison.OrdinalIgnoreCase) && date_s >= dt)
                                {
                                    foundMatch = true;
                                    id = tconst;
                                    break;
                                }
                            }
                        }

                    }
                }

                if (foundMatch)
                {
                    raiting();
                }
                else
                {
                    searchx();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchx()
        {
            string maskedtxt = textBox1.Text.Trim();
            string filePath = "data.tsv";

            if (key == true)
            {
                sub = "movie";
            }
            else
            {
                sub = "series";
            }

            double.TryParse(comboBox2.Text.Trim(), out double dt);


            try
            {

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split('\t');

                        string tconst = fields[0];
                        string titleType = fields[1];
                        date = fields[5];
                        primetitle = fields[2];

                        double.TryParse(date.Trim(), out double date_s);

                        if (primetitle.Contains(maskedtxt, StringComparison.OrdinalIgnoreCase) && titleType.Equals(sub, StringComparison.OrdinalIgnoreCase) && date_s >= dt)
                        {
                            foundMatch = true;
                            id = tconst;
                            break;
                        }
                        else
                        {
                            primetitle = primetitle.Replace("-", "").Replace(":", "").Replace(".", "");

                            if (primetitle.Contains(maskedtxt, StringComparison.OrdinalIgnoreCase) && titleType.Equals(sub, StringComparison.OrdinalIgnoreCase) && date_s >= dt)
                            {
                                foundMatch = true;
                                id = tconst;
                                break;
                            }
                        }

                    }
                }

                if (foundMatch)
                {
                    raiting();
                }
                else
                {
                    MessageBox.Show("Eslesme bulunamadi.");
                    foundMatchx = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void raiting()
        {

            string maskedtxt = textBox1.Text.Trim();
            string filePath = "raiting.tsv";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] fields = line.Split('\t');

                            string tconst = fields[0];
                            IMDB = fields[1];

                            double.TryParse(IMDB, out IMDB_s);
                            double.TryParse(comboBox1.Text.Trim(), out double IMDB_c);

                            if (tconst.Contains(id, StringComparison.OrdinalIgnoreCase))
                            {
                                foundMatchx = true;
                                movie_imdb = this.IMDB;
                                //MessageBox.Show("IMDB: " + IMDB, "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }

                    }
                }

                if (!foundMatchx)
                {
                    MessageBox.Show("IMDB Eslesme bulunamadi.", "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("IMDB Hata olustu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == null)
            {
                comboBox2.Text = "1990";
            }
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                search();

                if (foundMatchx == true)
                {

                    if (originalTitle != "")
                    {
                        List.Items.Add("Film Adi=" + originalTitle + "  " + "Film IMDB=" + movie_imdb + "  " + "Film Tarih:" + date);
                    }
                    else
                    {
                        List.Items.Add("Film Adi=" + primetitle + "  " + "Film IMDB=" + movie_imdb + "  " + "Film Tarih:" + date);
                    }
                }
                else
                {
                    MessageBox.Show("Film Bulunamadi");
                }

            }
            else
            {
                MessageBox.Show("Lutfen Dizi veya Film Seciniz");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                key = true;
            }
            else
            {
                radioButton1.Checked = false;
                key = false;
            }
        }
    }
}