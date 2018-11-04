using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.IO;

namespace Projecto_Tecnologico.Admistradores
{
    public partial class NovoPrefil : Form
    {
        public NovoPrefil()
        {
            InitializeComponent();
        }

        private void NovoPrefil_Load(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            A_Funcionarios formix = (A_Funcionarios)System.Windows.Forms.Application.OpenForms["A_Funcionarios"];
           int prefil = BLL.prefil.insertprefil(formix.tb_medico.Text,formix.cb_cargo.Text, finalString);


            tb_cargo.Text = formix.cb_cargo.Text;
            tb_login.Text = formix.tb_medico.Text;
            tb_Pass.Text = finalString;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string lol = DateTime.Now.ToString("HH:mm:ss tt");
            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Registos\prefis.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(tb_login.Text, tb_cargo, DateTime.Now, lol);
                    tw.Close();
                }
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
