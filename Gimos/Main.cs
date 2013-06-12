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
using System.Text.RegularExpressions;

namespace Gimos
{
    public partial class Main : Form
    {

        Dictionary<int, Contact> _contactos = new Dictionary<int, Contact>();
        int emailsCorrectos = 0;
        int emailsIncorrectos = 0;


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {


            setStyle();
            
            _contactos = ContactDAO.get(Application.StartupPath);
            loadData();



        }

        private void setStyle()
        {

            var botones = GetAll(this, typeof(Button));
            foreach (var b in botones)
            {
                b.BackColor = Color.Black;
                b.ForeColor = Color.White;
                b.Font = new Font("Arial", 9, FontStyle.Bold);
            }


            var labels = GetAll(this, typeof(Label));
            foreach (var b in labels)
            {
                b.ForeColor = Color.Black;
                b.Font = new Font("Arial", 9, FontStyle.Bold);
            }

            var checkboxs = GetAll(this, typeof(CheckBox));
            foreach (var b in checkboxs)
            {
                b.ForeColor = Color.Black;
                b.Font = new Font("Arial", 9, FontStyle.Bold);
            }

            var tabs = GetAll(this, typeof(TabControl));
            foreach (var b in tabs)
            {
                b.Font = new Font("Arial", 9);
            }

        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }


        private void loadData()
        {
            GridViewContactos.DataSource = _contactos.Values.ToList();

            Cumpleanos c = CumpleanosDAO.get(Application.StartupPath).First();

            TxtBody.Text = c.Body;
            TxtCantDiasAntes.Text = c.Dias.ToString();
            TxtContrasena.Text = c.Contrasena;
            TxtEmailOrigen.Text = c.Email;
            TxtSubject.Text = c.Subject;

            TxtImagen.Text=c.Adjunto;
            CheckImagenCumplanos.Checked=c.Imagen;
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
                c.Nombre = TxtNombre.Text.Trim();
            }

            if (TxtApellido.Text.Trim() == "")
            {
                lblApellido.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblApellido.ForeColor = Color.Black;
                c.Apellido = TxtApellido.Text.Trim();
            }

            if (TxtEmail.Text.Trim() == "")
            {
                lblEmail.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                Match rex = Regex.Match(TxtEmail.Text.Trim(' '), "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase);
                if (rex.Success == false)
                {
                    lblEmail.ForeColor = Color.Red;
                    guardar = false;
                }
                else
                {
                    lblEmail.ForeColor = Color.Black;
                    c.Email = TxtEmail.Text.Trim();
                }

            }

            if (TxtFechaNacimiento.Text.Trim() == "")
            {
                lblNacimiento.ForeColor = Color.Red;
                guardar = false;
            }
            else
            {
                lblNacimiento.ForeColor = Color.Black;
                c.FechaNacimiento = DateTime.Parse(TxtFechaNacimiento.Value.ToShortDateString());
            }


            if (guardar)
            {
                if (modificar)
                {
                    c.FechaModificacion = DateTime.Today;
                    ContactDAO.update(Application.StartupPath, c);
                    c.FechaAlta = _contactos[c.Id].FechaAlta;
                    _contactos[c.Id] = c;

                }
                else
                {
                    c.FechaAlta = DateTime.Today;
                    c.Id = ContactDAO.insert(Application.StartupPath, c);
                    _contactos.Add(c.Id, c);
                }

                GridViewContactos.DataSource = _contactos.Values.ToList();
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

            GridViewContactos.DataSource = _contactos.Values.ToList();
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

                //lblComentarios.Text = "Email enviado correctamente";

                Envio e = new Envio();
                e.FechaEnvio = DateTime.Today;
                e.Texto = mail.Body;

                EnviosDAO.Insertar(Application.StartupPath, c, e);
                emailsCorrectos++;

            }
            catch (Exception ex)
            {
               
                emailsIncorrectos++;
                lblComentarios.Text = lblComentarios.Text +  " {Error: " + ex.Message + ", "+c.Email +"} ";
            }
        }

        private string PopulateBody()
        {
            string body ="<a>" + TxtBody.Text + "</a>";

            if (CheckImagenCumplanos.Checked)
            {
                body = body + "<br>";
                body = body + string.Format("<img src=@'{0}'/>", TxtImagen.Text);

            }

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
            emailsCorrectos = 0;
            emailsIncorrectos = 0;
            
            lblCantidadEmails.Text = "";
            lblComentarios.Text = "";
            if (GuardarCumpleanos())
            {

                var contactos = _contactos.Values.ToList();

                var filtrados = from c in contactos
                                where c.DiasParaCumpleanos <= int.Parse(TxtCantDiasAntes.Text)
                                select c;

                foreach (Contact c in filtrados)
                {
                    Application.DoEvents();
                    c.ListaEnvios = EnviosDAO.get(Application.StartupPath, c);

                    if (c.ListaEnvios.Count > 0)
                    {
                        var maxEnvio = c.ListaEnvios.Max(o => o.FechaEnvio);

                        if ((DateTime.Today - maxEnvio).Days > (int.Parse(TxtCantDiasAntes.Text) + c.DiasParaCumpleanos))
                        {
                            email(c);
                        }


                    }
                    else
                    {
                        email(c);
                    }
                }
               
                lblCantidadEmails.Text = string.Format("Emails enviados={0}, Emails Erroneos={1}",emailsCorrectos,emailsIncorrectos);

            }

        }

        private void BtnGuardarCumpleanos_Click(object sender, EventArgs e)
        {
            GuardarCumpleanos();
        }

        private bool GuardarCumpleanos()
        {
            lblComentarios.Text = "";
            lblCantidadEmails.Text = "";

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


            c.Adjunto = TxtImagen.Text;
            c.Imagen = CheckImagenCumplanos.Checked;

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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            string texto = TxtBuscar.Text.ToUpper().Trim();

            if (texto != "")
            {

                var contactos = _contactos.Values.ToList();

                var filtrados = from c in contactos
                                where c.Nombre.ToUpper().Contains(texto) || c.Apellido.ToUpper().Contains(texto) || c.Email.ToUpper().Contains(texto) || c.FechaNacimiento.ToShortDateString().ToUpper().Contains(texto)
                                select c;

                GridViewContactos.DataSource = filtrados.ToList();

            }
            else
            {
                Limpiar();
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (TxtEmail.Text.Trim() != "")
            {
               Match rex = Regex.Match(TxtEmail.Text.Trim(' '), "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase);
                if (rex.Success == false)
                {
                    lblEmail.ForeColor = Color.Red;
                }
                else
                {
                    lblEmail.ForeColor = Color.Black;
                }
            }
        }

        private void BtnImagenCumplanos_Click(object sender, EventArgs e)
        {
      
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "*.jpg|*.jpeg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              TxtImagen.Text = openFileDialog1.FileName;
            }
        }



    }
}
