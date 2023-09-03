using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System;
using System.IO;
using System.Diagnostics;
using RestSharp;
using System.Text;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieListerX
{
    public partial class Form1 : Form
    {
        private bool key;
        private string sub;
        private string id;
        private bool foundMatch = false;
        private bool foundMatchx = false;

        public string item;
        public string originalTitle;
        public string primetitle;
        public string IMDB;
        public string search_imdb;
        public string date;

        public Form1()
        {
            InitializeComponent();
        }

        public void search()
        {
            string maskedtxt = name.Text.Trim();
            string filePath = "data.tsv";

            if (key == true)
            {
                sub = "movie";
            }
            else
            {
                sub = "tvSeries";
            }

            double.TryParse(combo_date.Text.Trim(), out double dt);

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split('\t');

                        //Data
                        string tconst = fields[0];
                        string titleType = fields[1];
                        originalTitle = fields[3];
                        date = fields[5];

                        //Convert
                        double.TryParse(date.Trim(), out double date_s);

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

                            //Space Sign Problem
                            if (originalTitle.Contains(maskedtxt, StringComparison.OrdinalIgnoreCase) && titleType.Equals(sub, StringComparison.OrdinalIgnoreCase) && date_s >= dt)
                            {
                                foundMatch = true;
                                id = tconst;
                                break;
                            }

                            //Punctuation Problem
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void searchx()
        {
            string maskedtxt = name.Text.Trim();
            string filePath = "data.tsv";

            if (key == true)
            {
                sub = "movie";
            }
            else
            {
                sub = "series";
            }

            double.TryParse(combo_date.Text.Trim(), out double dt);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void raiting()
        {
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

                            if (tconst.Contains(id, StringComparison.OrdinalIgnoreCase))
                            {
                                foundMatchx = true;
                                search_imdb = this.IMDB;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("IMDB Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (combo_date.Text == null)
            {
                combo_date.Text = "2000";
            }
            if (r_movie.Checked == true || r_series.Checked == true)
            {
                search();

                if (foundMatchx == true)
                {

                    if (originalTitle != "")
                    {
                        ListX.Items.Add("||" + sub + " " + "Name: " + originalTitle + "||" + sub + " " + "IMDB: " + search_imdb + "||" + sub + " " + "Date: " + date);
                    }
                    else
                    {
                        ListX.Items.Add("||" + sub + " " + "Name: " + primetitle + "||" + sub + " " + "IMDB: " + search_imdb + "||" + sub + " " + "Date: " + date);
                    }

                    writer();

                }
                else
                {
                    MessageBox.Show("Not Found");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Movie or Series");
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (r_movie.Checked)
            {
                r_series.Checked = false;
                key = true;
            }
            else
            {
                r_movie.Checked = false;
                key = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reader();
        }

        private void List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Delete 
                for (int i = ListX.Items.Count - 1; i >= 0; i--)
                {
                    if (ListX.GetItemChecked(i))
                    {
                        string item = ListX.Items[i].ToString();
                        ListX.Items.RemoveAt(i);
                        writer2(item);
                    }
                }
            }

            writer();
        }

        private void writer()
        {
            string folderName = "Skymoon";
            string fileName = "unlist.dat";

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = Path.Combine(documentsPath, folderName);


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, fileName);

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                foreach (string item in ListX.Items)
                {
                    byte[] dirNameBytes = System.Text.Encoding.UTF8.GetBytes(item);
                    writer.Write(dirNameBytes.Length);
                    writer.Write(dirNameBytes);
                }
            }
        }
        private void writer2(string item)
        {
            string folderName = "Skymoon";
            string fileName = "list.dat";

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = Path.Combine(documentsPath, folderName);


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, fileName);

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {

                byte[] dirNameBytes = System.Text.Encoding.UTF8.GetBytes(item);
                writer.Write(dirNameBytes.Length);
                writer.Write(dirNameBytes);
            }
        }
        private void reader()
        {
            string folderName = "Skymoon";
            string fileName = "unlist.dat";

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = Path.Combine(documentsPath, folderName);

            string filePath = Path.Combine(folderPath, fileName);

            if (File.Exists(filePath))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int length = reader.ReadInt32();
                        byte[] dirNameBytes = reader.ReadBytes(length);
                        string dirName = System.Text.Encoding.UTF8.GetString(dirNameBytes);
                        ListX.Items.Add(dirName);
                    }
                }
            }
            else
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }

        }
        private void reader2()
        {
            string folderName = "Skymoon";
            string fileName = "list.dat";

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = Path.Combine(documentsPath, folderName);

            string filePath = Path.Combine(folderPath, fileName);

            if (File.Exists(filePath))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int length = reader.ReadInt32();
                        byte[] dirNameBytes = reader.ReadBytes(length);
                        string dirName = System.Text.Encoding.UTF8.GetString(dirNameBytes);
                        ListX.Items.Add(dirName);
                    }
                }
            }
            else
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }

        }

        private void btn_unwt_Click(object sender, EventArgs e)
        {
            ListX.Items.Clear();
            reader();
        }

        private void btn_wt_Click(object sender, EventArgs e)
        {
            ListX.Items.Clear();
            reader2();
        }

        private void btn_watch_Click(object sender, EventArgs e)
        {
            item = name.Text.Replace(" ", "-");

            string url = "https://filmmax.org/" + item + "/";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

    }
}