using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessLogicLayer;
namespace Projecto_Tecnologico
{
    public partial class Config : Form
    {
        Image img;

        //pastas
        string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager");
        string Databaselogs = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\DataBase Logs");
        string info = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Info");
        string loginlogs = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Logins Logs");

        string Entrada = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Logins Logs\entrada.txt");
        string Saida = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Logins Logs\saida.txt");

        string Apagados = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\DataBase Logs\Apagados.txt");
        string Editados = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\DataBase Logs\Editados.txt");
        string Registados = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\DataBase Logs\Registados.txt");
        string hmsname = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Info\hmsconfig.txt");


        string configs = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Alteracoes\");
        string configsfile = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Alteracoes\configs.txt");


        bool sslbool = true;
        const int PASS_MIN = 0;
        const int PASS_MAX = 10;
        const string PASS_STRENGTH_FORMAT = "{0:F0}/{1}";
        public Config()
        {
            InitializeComponent();

            if (Directory.Exists(mainfolder))
            {

                Login login = new Login();
               // login.Show();
                Application.Run(new Login());
                this.Close();
            }
            else
            {

            }      
        }

        private static int RatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return 0;
            int result = Math.Min(password.Length, 7);

            if (System.Text.RegularExpressions.Regex.Match(password, "[a-zA-Z]").Success)
                result += 1;

            if (System.Text.RegularExpressions.Regex.Match(password, "[0-9]").Success)
                result += 1;

            if (System.Text.RegularExpressions.Regex.Match(password, "[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)\\{\\}\\[\\]\\:\\'\\;\\\"\\/\\?\\.\\>\\,\\<\\~\\`\\-\\\\_\\=\\+\\|]").Success)
                result += 1;
            return result;
        }
        private void UpdateProgressBar()
        {
            int strength = RatePassword(tb_pass.Text);
            lb_forca.Text = string.Format(PASS_STRENGTH_FORMAT, strength, PASS_MAX);
            pb_forca.Value = strength;
            if (pb_forca.Value < 5)
                pb_forca.ForeColor = Color.Maroon;
            else
                pb_forca.ForeColor = Color.DarkGreen;
        }
        private void PreConfig_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_fechar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(mainfolder))
            {
                Directory.CreateDirectory(mainfolder);
                Directory.CreateDirectory(Databaselogs);
                Directory.CreateDirectory(info);
                Directory.CreateDirectory(loginlogs);
                Directory.CreateDirectory(configs);
                        File.Create(configsfile).Dispose();
                File.Create(Entrada).Dispose();
                File.Create(Saida).Dispose();
                File.Create(Apagados).Dispose();
                File.Create(Editados).Dispose();
                File.Create(Registados).Dispose();
                File.Create(hmsname).Dispose();

            }
            int admin = BLL.prefil.insertprefil("adminstrador", tb_admin.Text, tb_pass.Text);

            if (cb_nao.Checked)
            {
                sslbool = false;
            }

            if (File.Exists(hmsname))
            {
                TextWriter tw = new StreamWriter(hmsname, true);
                tw.WriteLine(tb_nomehpl.Text);
                tw.Close();
            }

            MessageBox.Show("Programa Configurado com Sucesso!");
        }

        private void b_min_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cb_sim_CheckedChanged(object sender, EventArgs e)
        {
            cb_nao.Checked = !cb_sim.Checked;
        }

        private void cb_nao_CheckedChanged(object sender, EventArgs e)
        {
            cb_sim.Checked = !cb_nao.Checked;
        }

        private void pb_abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb_foto.Image = new Bitmap(dlg.OpenFile());
            }

            dlg.Dispose();

            pb_foto.SizeMode = PictureBoxSizeMode.Zoom;
            img = pb_foto.Image;
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            pb_foto.Image = null;
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
