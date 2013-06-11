namespace Gimos
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelContactoGral = new System.Windows.Forms.TableLayoutPanel();
            this.GridViewContactos = new System.Windows.Forms.DataGridView();
            this.tableLayoutContactoABM = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.BtnGuardarContacto = new System.Windows.Forms.Button();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtBody = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.lblEmailOrigen = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.TxtEmailOrigen = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.TxtCantDiasAntes = new System.Windows.Forms.TextBox();
            this.BtnGuardarCumpleanos = new System.Windows.Forms.Button();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanelContactoGral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewContactos)).BeginInit();
            this.tableLayoutContactoABM.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            this.tableLayoutPanelPrincipal.ColumnCount = 3;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.129456F));
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.87054F));
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 3;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.925408F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.07459F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(894, 466);
            this.tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(63, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 399);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanelContactoGral);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contactos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelContactoGral
            // 
            this.tableLayoutPanelContactoGral.ColumnCount = 3;
            this.tableLayoutPanelContactoGral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelContactoGral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContactoGral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanelContactoGral.Controls.Add(this.GridViewContactos, 1, 1);
            this.tableLayoutPanelContactoGral.Controls.Add(this.tableLayoutContactoABM, 1, 0);
            this.tableLayoutPanelContactoGral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContactoGral.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelContactoGral.Name = "tableLayoutPanelContactoGral";
            this.tableLayoutPanelContactoGral.RowCount = 3;
            this.tableLayoutPanelContactoGral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelContactoGral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContactoGral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContactoGral.Size = new System.Drawing.Size(774, 367);
            this.tableLayoutPanelContactoGral.TabIndex = 1;
            // 
            // GridViewContactos
            // 
            this.GridViewContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewContactos.Location = new System.Drawing.Point(47, 63);
            this.GridViewContactos.Name = "GridViewContactos";
            this.GridViewContactos.Size = new System.Drawing.Size(703, 281);
            this.GridViewContactos.TabIndex = 6;
            this.GridViewContactos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewContactos_CellDoubleClick);
            // 
            // tableLayoutContactoABM
            // 
            this.tableLayoutContactoABM.ColumnCount = 6;
            this.tableLayoutContactoABM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.87879F));
            this.tableLayoutContactoABM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.12122F));
            this.tableLayoutContactoABM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutContactoABM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutContactoABM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutContactoABM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutContactoABM.Controls.Add(this.lblEmail, 3, 0);
            this.tableLayoutContactoABM.Controls.Add(this.lblApellido, 2, 0);
            this.tableLayoutContactoABM.Controls.Add(this.lblNombre, 1, 0);
            this.tableLayoutContactoABM.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutContactoABM.Controls.Add(this.TxtId, 0, 1);
            this.tableLayoutContactoABM.Controls.Add(this.TxtNombre, 1, 1);
            this.tableLayoutContactoABM.Controls.Add(this.TxtApellido, 2, 1);
            this.tableLayoutContactoABM.Controls.Add(this.BtnGuardarContacto, 5, 1);
            this.tableLayoutContactoABM.Controls.Add(this.lblNacimiento, 4, 0);
            this.tableLayoutContactoABM.Controls.Add(this.TxtEmail, 3, 1);
            this.tableLayoutContactoABM.Controls.Add(this.TxtFechaNacimiento, 4, 1);
            this.tableLayoutContactoABM.Controls.Add(this.BtnLimpiar, 5, 0);
            this.tableLayoutContactoABM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutContactoABM.Location = new System.Drawing.Point(47, 3);
            this.tableLayoutContactoABM.Name = "tableLayoutContactoABM";
            this.tableLayoutContactoABM.RowCount = 2;
            this.tableLayoutContactoABM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContactoABM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContactoABM.Size = new System.Drawing.Size(703, 54);
            this.tableLayoutContactoABM.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(408, 14);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(229, 14);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(87, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // TxtId
            // 
            this.TxtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtId.Location = new System.Drawing.Point(3, 30);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(27, 20);
            this.TxtId.TabIndex = 99;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Location = new System.Drawing.Point(36, 30);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(147, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApellido.Location = new System.Drawing.Point(189, 30);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(124, 20);
            this.TxtApellido.TabIndex = 2;
            // 
            // BtnGuardarContacto
            // 
            this.BtnGuardarContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGuardarContacto.Location = new System.Drawing.Point(639, 30);
            this.BtnGuardarContacto.Name = "BtnGuardarContacto";
            this.BtnGuardarContacto.Size = new System.Drawing.Size(61, 21);
            this.BtnGuardarContacto.TabIndex = 5;
            this.BtnGuardarContacto.Text = "Guardar";
            this.BtnGuardarContacto.UseVisualStyleBackColor = true;
            this.BtnGuardarContacto.Click += new System.EventHandler(this.BtnGuardarContacto_Click);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(548, 14);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(72, 13);
            this.lblNacimiento.TabIndex = 8;
            this.lblNacimiento.Text = "F. Nacimiento";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.Location = new System.Drawing.Point(319, 30);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(211, 20);
            this.TxtEmail.TabIndex = 3;
            // 
            // TxtFechaNacimiento
            // 
            this.TxtFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaNacimiento.Location = new System.Drawing.Point(536, 30);
            this.TxtFechaNacimiento.Name = "TxtFechaNacimiento";
            this.TxtFechaNacimiento.Size = new System.Drawing.Size(97, 20);
            this.TxtFechaNacimiento.TabIndex = 4;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(639, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(57, 21);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Emails Cumpleaños";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.32143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.67857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.Controls.Add(this.lblAsunto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBody, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtSubject, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBody, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnEnviar, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblEmailOrigen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblContrasena, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtContrasena, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtEmailOrigen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDias, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtCantDiasAntes, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnGuardarCumpleanos, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblComentarios, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.19889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.80111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 367);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAsunto
            // 
            this.lblAsunto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(3, 99);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(40, 13);
            this.lblAsunto.TabIndex = 0;
            this.lblAsunto.Text = "Asunto";
            // 
            // lblBody
            // 
            this.lblBody.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(3, 173);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(34, 13);
            this.lblBody.TabIndex = 1;
            this.lblBody.Text = "Texto";
            // 
            // TxtSubject
            // 
            this.TxtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSubject.Location = new System.Drawing.Point(98, 95);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(327, 20);
            this.TxtSubject.TabIndex = 2;
            // 
            // TxtBody
            // 
            this.TxtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBody.Location = new System.Drawing.Point(98, 141);
            this.TxtBody.Multiline = true;
            this.TxtBody.Name = "TxtBody";
            this.TxtBody.Size = new System.Drawing.Size(327, 77);
            this.TxtBody.TabIndex = 3;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(506, 337);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 4;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // lblEmailOrigen
            // 
            this.lblEmailOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmailOrigen.AutoSize = true;
            this.lblEmailOrigen.Location = new System.Drawing.Point(3, 10);
            this.lblEmailOrigen.Name = "lblEmailOrigen";
            this.lblEmailOrigen.Size = new System.Drawing.Size(32, 13);
            this.lblEmailOrigen.TabIndex = 5;
            this.lblEmailOrigen.Text = "Email";
            // 
            // lblContrasena
            // 
            this.lblContrasena.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(3, 47);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 6;
            this.lblContrasena.Text = "Contraseña";
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtContrasena.Location = new System.Drawing.Point(98, 43);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(327, 20);
            this.TxtContrasena.TabIndex = 7;
            // 
            // TxtEmailOrigen
            // 
            this.TxtEmailOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmailOrigen.Location = new System.Drawing.Point(98, 7);
            this.TxtEmailOrigen.Name = "TxtEmailOrigen";
            this.TxtEmailOrigen.Size = new System.Drawing.Size(327, 20);
            this.TxtEmailOrigen.TabIndex = 8;
            // 
            // lblDias
            // 
            this.lblDias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(3, 226);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(89, 26);
            this.lblDias.TabIndex = 9;
            this.lblDias.Text = "Cantidad de dias Antes:";
            // 
            // TxtCantDiasAntes
            // 
            this.TxtCantDiasAntes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCantDiasAntes.Location = new System.Drawing.Point(98, 229);
            this.TxtCantDiasAntes.MaxLength = 3;
            this.TxtCantDiasAntes.Name = "TxtCantDiasAntes";
            this.TxtCantDiasAntes.Size = new System.Drawing.Size(327, 20);
            this.TxtCantDiasAntes.TabIndex = 10;
            this.TxtCantDiasAntes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantDiasAntes_KeyPress);
            // 
            // BtnGuardarCumpleanos
            // 
            this.BtnGuardarCumpleanos.Location = new System.Drawing.Point(431, 224);
            this.BtnGuardarCumpleanos.Name = "BtnGuardarCumpleanos";
            this.BtnGuardarCumpleanos.Size = new System.Drawing.Size(69, 23);
            this.BtnGuardarCumpleanos.TabIndex = 11;
            this.BtnGuardarCumpleanos.Text = "Guardar Cambios";
            this.BtnGuardarCumpleanos.UseVisualStyleBackColor = true;
            this.BtnGuardarCumpleanos.Click += new System.EventHandler(this.BtnGuardarCumpleanos_Click);
            // 
            // lblComentarios
            // 
            this.lblComentarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.ForeColor = System.Drawing.Color.Red;
            this.lblComentarios.Location = new System.Drawing.Point(98, 308);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(0, 13);
            this.lblComentarios.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 466);
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.Name = "Main";
            this.Text = "Gimos";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanelContactoGral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewContactos)).EndInit();
            this.tableLayoutContactoABM.ResumeLayout(false);
            this.tableLayoutContactoABM.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.DataGridView GridViewContactos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContactoGral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutContactoABM;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Button BtnGuardarContacto;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.DateTimePicker TxtFechaNacimiento;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.TextBox TxtBody;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label lblEmailOrigen;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtEmailOrigen;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox TxtCantDiasAntes;
        private System.Windows.Forms.Button BtnGuardarCumpleanos;
        private System.Windows.Forms.Label lblComentarios;
    }
}

