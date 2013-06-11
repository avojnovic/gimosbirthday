using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using BusinessObjects;
using System.Net.Mail;
using System.IO;

namespace Gimos
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            loadData();
        }

        private void loadData()
        {
            GridViewContactos.DataSource = ContactDAO.get(Application.StartupPath);

            Cumpleanos c = CumpleanosDAO.get(Application.StartupPath).First();

            TxtBody.Text = c.Body;
            TxtCantDiasAntes.Text = c.Dias.ToString();
            TxtContrasena.Text = c.Contrasena;
            TxtEmailOrigen.Text = c.Email;
            TxtSubject.Text = c.Subject;

        }

        private void BtnGuardarContacto_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            Boolean guardar = true;
            Boolean modificar = false;

            if (TxtId.Text != "")
            {
                c.Id = int.Parse(TxtId.Text);
                modificar = true;
            }


            if (TxtNombre.Text.Trim() == "")
            {
                lblNombre.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblNombre.ForeColor = Color.Black;
                c.Nombre = TxtNombre.Text;
            }

            if (TxtApellido.Text.Trim() == "")
            {
                lblApellido.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblApellido.ForeColor = Color.Black;
                c.Apellido = TxtApellido.Text;
            }

            if (TxtEmail.Text.Trim() == "")
            {
                lblEmail.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblEmail.ForeColor = Color.Black;
                c.Email = TxtEmail.Text;
            }

            if (TxtFechaNacimiento.Text.Trim() == "")
            {
                lblNacimiento.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblNacimiento.ForeColor = Color.Black;
                c.FechaNacimiento = TxtFechaNacimiento.Value;
            }


            if (guardar)
            {
                if (modificar)
                {
                    c.FechaModificacion = DateTime.Today;
                    ContactDAO.update(Application.StartupPath, c);
                }
                else
                {
                    c.FechaAlta = DateTime.Today;
                    ContactDAO.insert(Application.StartupPath, c);
                }

                GridViewContactos.DataSource = ContactDAO.get(Application.StartupPath);
                Limpiar();
            }


        }

        private void GridViewContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = GridViewContactos.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtNombre.Text = GridViewContactos.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtApellido.Text = GridViewContactos.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtFechaNacimiento.Value = DateTime.Parse(GridViewContactos.Rows[e.RowIndex].Cells[3].Value.ToString());
            TxtEmail.Text = GridViewContactos.Rows[e.RowIndex].Cells[4].Value.ToString();




        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            lblNombre.ForeColor = Color.Black;
            lblApellido.ForeColor = Color.Black;
            lblEmail.ForeColor = Color.Black;
            lblNacimiento.ForeColor = Color.Black;


            TxtId.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtFechaNacimiento.Value = DateTime.Today;
            TxtEmail.Text = "";
        }

        private void email(Contact c)
        {

            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.Credentials = new System.Net.NetworkCredential(TxtEmailOrigen.Text, TxtContrasena.Text);
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();


                //Setting From , To and CC
                mail.From = new MailAddress(TxtEmailOrigen.Text, "Gimos Ituzaingo");


                mail.To.Add(new MailAddress(c.Email));


                mail.IsBodyHtml = true;
                mail.Body = PopulateBody();
                mail.Subject = TxtSubject.Text;

                smtpClient.Send(mail);

                lblComentarios.Text = "Email enviado correctamente";

                Envio e = new Envio();
                e.FechaEnvio = DateTime.Today;
                e.Texto = mail.Body;

                EnviosDAO.Insertar(Application.StartupPath, c,e);


            }
            catch (Exception ex)
            {

                lblComentarios.Text = "Error al enviar el Email: " + ex.Message;
            }
        }

        private string PopulateBody()
        {
            string body = TxtBody.Text;
            //using (StreamReader reader = new StreamReader(Server.MapPath("~/Pagos/EmailTemplate.htm")))
            //{
            //    body = reader.ReadToEnd();
            //}
            //body = body.Replace("{TxtApellido}", TxtApellido.Text);
            //body = body.Replace("{TxtNombre}", TxtNombre.Text);
            //body = body.Replace("{TxtMatricula}", TxtMatricula.Text);
            //body = body.Replace("{TxtFechaEmision}", TxtFechaEmision.Text);
            //body = body.Replace("{TxtVencimiento1}", TxtVencimiento1.Text);
            //body = body.Replace("{TxtVencimiento2}", TxtVencimiento2.Text);
            //body = body.Replace("{BarCode}", ImgBarCode.ImageUrl);
            //body = body.Replace("{TxtSubTotal}", TxtSubTotal.Text);
            //body = body.Replace("{TxtDescuento}", TxtDescuento.Text);
            //body = body.Replace("{TxtTotal}", TxtTotal.Text);
            //body = body.Replace("{TxtTotal1Ven}", TxtTotal1Ven.Text);
            //body = body.Replace("{TxtTotal2Ven}", TxtTotal2Ven.Text);

            return body;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            lblComentarios.Text = "";
            if (GuardarCumpleanos())
            {

                var contactos = ContactDAO.get(Application.StartupPath);

                var filtrados = from c in contactos
                                where c.DiasParaCumpleanos <= int.Parse(TxtCantDiasAntes.Text)
                                select c;

                foreach (Contact c in filtrados)
                {
                    Application.DoEvents();
                    c.ListaEnvios=EnviosDAO.get(Application.StartupPath, c);

                    if(c.ListaEnvios.Count>0)
                    {
                        var maxEnvio = c.ListaEnvios.Max(o => o.FechaEnvio);

                        if ((DateTime.Today-maxEnvio).Days>(int.Parse(TxtCantDiasAntes.Text)+c.DiasParaCumpleanos))
                        {
                            email(c);
                        }


                    }
                    else
                    {
                        email(c);
                    }
                }
            }

        }

        private void BtnGuardarCumpleanos_Click(object sender, EventArgs e)
        {
            GuardarCumpleanos();
        }

        private bool GuardarCumpleanos()
        {
            lblComentarios.Text = "";

            Cumpleanos c = new Cumpleanos();
            Boolean guardar = true;

            if (TxtBody.Text.Trim() == "")
            {
               lblBody.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblBody.ForeColor = Color.Black;
                c.Body = TxtBody.Text;
            }

            if (TxtCantDiasAntes.Text.Trim() == "")
            {
               lblDias.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblDias.ForeColor = Color.Black;
                c.Dias = int.Parse(TxtCantDiasAntes.Text);
            }

            if (TxtContrasena.Text.Trim() == "")
            {
               lblContrasena.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblContrasena.ForeColor = Color.Black;
                c.Contrasena = TxtContrasena.Text;
            }

            if (TxtEmailOrigen.Text.Trim() == "")
            {
              lblEmailOrigen.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblEmailOrigen.ForeColor = Color.Black;
                c.Email = TxtEmailOrigen.Text;
            }

            if (TxtSubject.Text.Trim() == "")
            {
              lblAsunto.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblAsunto.ForeColor = Color.Black;
                c.Subject = TxtSubject.Text;
            }


            if (guardar)
            {
                CumpleanosDAO.update(Application.StartupPath, c);
                           
            }


            return guardar;

        }

        private void TxtCantDiasAntes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }


    }
}
