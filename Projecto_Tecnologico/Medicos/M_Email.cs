﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Projecto_Tecnologico.Medicos
{
    public partial class M_Email : Form
    {
        int move;
        int moveX;
        int moveY;

        public M_Email()
        {
            InitializeComponent();
        }

  

        private void pb_send_Click_1(object sender, EventArgs e)
        {
            Config fromix = (Config)System.Windows.Forms.Application.OpenForms["Config"];
            try
            {

                SmtpClient SmtpServer = new SmtpClient(fromix.tb_smtp.Text);
                SmtpServer.Credentials = new System.Net.NetworkCredential(fromix.tb_emailadm.Text, fromix.tb_passemail.Text);
                SmtpServer.Port = 22;
                //SmtpServer.EnableSsl = fromix.sslbool;


                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(fromix.tb_emailadm.Text);
                mail.To.Add(tb_destinatario.Text);
                mail.Subject = tb_assunto.Text;
                mail.Body = tb_mensagem.Text;
                mail.IsBodyHtml = true;


                mail.Attachments.Add(new Attachment(lb_filename.Text));


                SmtpServer.Send(mail);
                MessageBox.Show("Email Enviado Com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Médicos)this.MdiParent).pn_mail.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Médicos)this.MdiParent).M_email.Enabled = true;
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY - 170);
            }
        }
    }
}
    

