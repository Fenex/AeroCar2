using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Security.Permissions;

namespace AeroCar2
{
    public partial class Form1 : Form
    {
        private string folder = "";
        private CarTuning ct;
        private FileSystemWatcher watcher = null;
        private string tmpFile = "~aeroCar_temp";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void writeLog(System.Exception e)
        {
            string info = DateTime.Now.ToString("yyyy:MM:dd HH:mm:ss") + "\r\n";
            info += e.Message + "\r\n";
            info += e.StackTrace + "\r\n";
            MessageBox.Show(e.Message);
            try
            {
                File.WriteAllText("AeroCar2.log", info);
            }
            catch
            {
                MessageBox.Show("Не удалось создать лог-файл. Проверьте доступ.");
            }
        }

        private void readFiles()
        {
            if (this.folder == "")
                this.folder = "cars";

            DirectoryInfo d = new DirectoryInfo(this.folder);

            if (!d.Exists)
            {
                string err = "Не найдена папка \"cars\", в которой должны находиться изображения автомобилей.\r\nПриложение будет закрыто.\r\n";
                MessageBox.Show(err, "Ошибка");
                this.Close();
            }

            this.folder = d.FullName;

            if (this.folder.Length > 30)
            {
                lbl_FolderPath.Text = "Cars: " + d.Root.ToString() + "..." + this.folder.Substring(this.folder.Length - 30);
            }
            else
            {
                lbl_FolderPath.Text = "Cars: " + this.folder;
            }
            FileInfo[] fi = d.GetFiles();
            while (cmb_filelist.Items.Count > 0)
            {
                cmb_filelist.Items.Remove(cmb_filelist.Items[0]);
            }
            cmb_filelist.Items.AddRange(fi);
            cmb_filelist.Enabled = true;

            return;
        }

        private void btn_aero_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_aero.Text == "Aero...")
                {
                    string nameFile = "";

                    DirectoryInfo dd = new DirectoryInfo(".");
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.InitialDirectory = dd.FullName;
                    openFileDialog.Filter = "Img files (*.png, *.gif, *.jpg)|*.jpg;*.jpeg;*.gif;*.png";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        nameFile = openFileDialog.FileName;
                    }
                    if (nameFile.Length != 0)
                    {

                        btn_aero.Text = "Снять";
                        cmb_aero.Enabled = false;
                        try
                        {
                            File.Copy(nameFile, tmpFile, true);
                        }
                        catch (System.Exception ee)
                        {
                            writeLog(ee);
                            MessageBox.Show(ee.Message + "\r\nПриложение будет закрыто.");
                            this.Close();
                        }
                        pictureBox3.BackgroundImage = System.Drawing.Image.FromFile(tmpFile);

                        dd = new DirectoryInfo(nameFile);

                        watcher = new FileSystemWatcher(dd.Parent.FullName);
                        watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess;
                        watcher.Changed += new FileSystemEventHandler(OnChanged);
                        watcher.Filter = dd.Name;
                        watcher.EnableRaisingEvents = true;
                        lbl_FileName.Text = "Listening: " + dd.Name;
                    }
                }
                else
                {
                    watcher.EnableRaisingEvents = false;
                    watcher = null;
                    lbl_FileName.Text = "";
                    on_off_enabled(false);
                    System.Threading.Thread.Sleep(1000);
                    pictureBox3.BackgroundImage.Dispose();
                    System.Threading.Thread.Sleep(1000);
                    on_off_enabled(true);
                    pictureBox3.BackgroundImage = getPictureByCode("Aero");
                    btn_aero.Text = "Aero...";
                    cmb_aero.Enabled = true;
                    cmb_aero.SelectedIndex = 0;
                }
            }
            catch(System.Exception ee)
            {
                this.writeLog(ee);
                MessageBox.Show(ee.Message + "\r\nПриложение будет закрыто.");
                this.Close();
            }
        }

        private void changeGroupBox(int n)
        {
            int GB_height = 24;
            int step = 24;
            this.groupBox1.Height = GB_height + step * n;
            this.groupBox1.Enabled = true;

            if (n < 1)
            {
                this.groupBox1.Enabled = false;
                n = 1;
            }
            
            this.groupBox1.Controls.Clear();

            for (int i = 0; i < n; i++)
            {
                
                NumericUpDown nud = new NumericUpDown();
                nud.Name = "nud" + i.ToString();
                nud.Width = 90;
                nud.Height = 20;
                nud.Top = (19+4)*(i+1);
                nud.Left = 6;
                nud.ValueChanged += nud_ValueChanged;
                if(i==0)
                    nud.Maximum = ct.getCountTuning(i)-1;
                else
                    nud.Maximum = ct.getCountTuning(i);
                this.groupBox1.Controls.Add(nud);

            }
            
        }

        private int getSelectedIndex(int i)
        {
            Control c = this.groupBox1.Controls.Find("nud" + i.ToString(), false)[0];
            NumericUpDown nud = (NumericUpDown)c;
            return (int)nud.Value;
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            Image img = ct.getImg(0, this.getSelectedIndex(0));

            for (int i = 1; i < ct.TypesTuning; i++)
            {
                img = ct.createTuning(img, ct.getImg(i, this.getSelectedIndex(i)));
            }

            pictureBox1.Image = img;
        }

        private void cmb_filelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cmb_filelist.SelectedIndex;
            string filename = this.cmb_filelist.Items[index].ToString();
            try
            {
                Image img = Image.FromFile(this.folder + "/" + filename);
                ct = new CarTuning(img);
                this.changeGroupBox(ct.TypesTuning);
                pictureBox1.Image = ct.getImg(0, 0);
            }
            catch
            {
                //MessageBox.Show("Ошибка №1. Приложение будет закрыто."); this.Close(); }
                this.cmb_filelist.Items.RemoveAt(index);
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            string[] tmp_files = { "~tmp1_", "~tmp2_" };
            System.Threading.Thread.Sleep(200);
            pictureBox3.BackgroundImage.Dispose();
            System.Threading.Thread.Sleep(200);

            try
            {
                File.Copy(e.FullPath, tmp_files[0], true);
                pictureBox3.BackgroundImage = System.Drawing.Image.FromFile(tmp_files[0]);
            }
            catch
            {
                try
                {
                    File.Copy(e.FullPath, tmp_files[1], true);
                    pictureBox3.BackgroundImage = System.Drawing.Image.FromFile(tmp_files[1]);
                }
                catch
                {
                    MessageBox.Show("Ошибка №2. Приложение будет закрыто.");
                    this.Close();
                }
            }
        }

        private void cmb_aero_SelectedValueChanged(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = getPictureByCode(cmb_aero.Text);
        }

        private Bitmap getPictureByCode(string name)
        {
            switch (name)
            {
                case "Aero 1": return AeroCar2.Properties.Resources.aero1;
                case "Aero 2": return AeroCar2.Properties.Resources.aero2;
                case "Aero 3": return AeroCar2.Properties.Resources.aero3;
                case "Aero 4": return AeroCar2.Properties.Resources.aero4;
                case "Aero 5": return AeroCar2.Properties.Resources.aero5;
                case "Aero 6": return AeroCar2.Properties.Resources.aero6;
                case "Aero 7": return AeroCar2.Properties.Resources.aero7;
                case "Aero 8": return AeroCar2.Properties.Resources.aero8;
                default:
                    int w = 100;
                    int h = 50;
                    Bitmap b = new Bitmap(w, h);
                    Color c = Color.FromArgb(255, 255, 255, 255);
                    for (int x = 0; x < w; x++)
                    {
                        for (int y = 0; y < h; y++)
                        {
                            b.SetPixel(x, y, c);
                        }
                    }
                    return b;
            }
        }

        private void on_off_enabled(bool q)
        {
            groupBox1.Enabled = q;
            btn_aero.Enabled = q;
            cmb_aero.Enabled = q;
            cmb_filelist.Enabled = q;
            btn_exit.Enabled = q;
            return;
        }

        private void pictureBox3_BackgroundImageChanged(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = pictureBox3.BackgroundImage;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;

        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            openFolder("Выберите папку, в которой хранятся изображения автомобилей.");
        }

        private bool openFolder(string str) {
            FolderBrowserDialog bd = new FolderBrowserDialog();
            bd.Description = str;
            bd.ShowDialog();
            this.folder = bd.SelectedPath;
            if (this.folder == "")
                return false;
            return true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readFiles();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ShowInTaskbar = false;
            }
            else
            {
                ShowInTaskbar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }
    }
}
