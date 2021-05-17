
namespace miapp_r2
{
    partial class AltaPersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtApellidoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskFNacimientoA = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdMasculinoA = new System.Windows.Forms.RadioButton();
            this.rdOtroA = new System.Windows.Forms.RadioButton();
            this.rdFemeninoA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTDocumentoA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskNroDocumentoA = new System.Windows.Forms.MaskedTextBox();
            this.txtNroCasaA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalleA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ckSolteroA = new System.Windows.Forms.CheckBox();
            this.ckCasadoA = new System.Windows.Forms.CheckBox();
            this.ckHijosA = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskCantidadHijosA = new System.Windows.Forms.MaskedTextBox();
            this.cbCarreraA = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardarPersonaA = new System.Windows.Forms.Button();
            this.btnLimpiarDatosA = new System.Windows.Forms.Button();
            this.dgPersonas = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarDatosA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreA
            // 
            this.txtNombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreA.Location = new System.Drawing.Point(177, 37);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(126, 24);
            this.txtNombreA.TabIndex = 1;
            // 
            // txtApellidoA
            // 
            this.txtApellidoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoA.Location = new System.Drawing.Point(177, 75);
            this.txtApellidoA.Name = "txtApellidoA";
            this.txtApellidoA.Size = new System.Drawing.Size(126, 24);
            this.txtApellidoA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // mskFNacimientoA
            // 
            this.mskFNacimientoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFNacimientoA.Location = new System.Drawing.Point(177, 116);
            this.mskFNacimientoA.Mask = "00/00/0000";
            this.mskFNacimientoA.Name = "mskFNacimientoA";
            this.mskFNacimientoA.Size = new System.Drawing.Size(126, 24);
            this.mskFNacimientoA.TabIndex = 4;
            this.mskFNacimientoA.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexo:";
            // 
            // rdMasculinoA
            // 
            this.rdMasculinoA.AutoSize = true;
            this.rdMasculinoA.Location = new System.Drawing.Point(188, 167);
            this.rdMasculinoA.Name = "rdMasculinoA";
            this.rdMasculinoA.Size = new System.Drawing.Size(73, 17);
            this.rdMasculinoA.TabIndex = 7;
            this.rdMasculinoA.TabStop = true;
            this.rdMasculinoA.Text = "Masculino";
            this.rdMasculinoA.UseVisualStyleBackColor = true;
            // 
            // rdOtroA
            // 
            this.rdOtroA.AutoSize = true;
            this.rdOtroA.Location = new System.Drawing.Point(188, 213);
            this.rdOtroA.Name = "rdOtroA";
            this.rdOtroA.Size = new System.Drawing.Size(45, 17);
            this.rdOtroA.TabIndex = 8;
            this.rdOtroA.TabStop = true;
            this.rdOtroA.Text = "Otro";
            this.rdOtroA.UseVisualStyleBackColor = true;
            // 
            // rdFemeninoA
            // 
            this.rdFemeninoA.AutoSize = true;
            this.rdFemeninoA.Location = new System.Drawing.Point(188, 190);
            this.rdFemeninoA.Name = "rdFemeninoA";
            this.rdFemeninoA.Size = new System.Drawing.Size(71, 17);
            this.rdFemeninoA.TabIndex = 9;
            this.rdFemeninoA.TabStop = true;
            this.rdFemeninoA.Text = "Femenino";
            this.rdFemeninoA.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo Documento:";
            // 
            // cbTDocumentoA
            // 
            this.cbTDocumentoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTDocumentoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTDocumentoA.FormattingEnabled = true;
            this.cbTDocumentoA.Location = new System.Drawing.Point(480, 35);
            this.cbTDocumentoA.Name = "cbTDocumentoA";
            this.cbTDocumentoA.Size = new System.Drawing.Size(126, 26);
            this.cbTDocumentoA.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nro Documento:";
            // 
            // mskNroDocumentoA
            // 
            this.mskNroDocumentoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNroDocumentoA.Location = new System.Drawing.Point(480, 79);
            this.mskNroDocumentoA.Mask = "99999999";
            this.mskNroDocumentoA.Name = "mskNroDocumentoA";
            this.mskNroDocumentoA.Size = new System.Drawing.Size(126, 24);
            this.mskNroDocumentoA.TabIndex = 13;
            this.mskNroDocumentoA.ValidatingType = typeof(int);
            // 
            // txtNroCasaA
            // 
            this.txtNroCasaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCasaA.Location = new System.Drawing.Point(480, 169);
            this.txtNroCasaA.Name = "txtNroCasaA";
            this.txtNroCasaA.Size = new System.Drawing.Size(126, 24);
            this.txtNroCasaA.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nro Casa:";
            // 
            // txtCalleA
            // 
            this.txtCalleA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleA.Location = new System.Drawing.Point(480, 128);
            this.txtCalleA.Name = "txtCalleA";
            this.txtCalleA.Size = new System.Drawing.Size(126, 24);
            this.txtCalleA.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Calle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(642, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Estado Civil:";
            // 
            // ckSolteroA
            // 
            this.ckSolteroA.AutoSize = true;
            this.ckSolteroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSolteroA.Location = new System.Drawing.Point(752, 43);
            this.ckSolteroA.Name = "ckSolteroA";
            this.ckSolteroA.Size = new System.Drawing.Size(82, 22);
            this.ckSolteroA.TabIndex = 19;
            this.ckSolteroA.Text = "Soltero";
            this.ckSolteroA.UseVisualStyleBackColor = true;
            // 
            // ckCasadoA
            // 
            this.ckCasadoA.AutoSize = true;
            this.ckCasadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCasadoA.Location = new System.Drawing.Point(751, 71);
            this.ckCasadoA.Name = "ckCasadoA";
            this.ckCasadoA.Size = new System.Drawing.Size(85, 22);
            this.ckCasadoA.TabIndex = 20;
            this.ckCasadoA.Text = "Casado";
            this.ckCasadoA.UseVisualStyleBackColor = true;
            // 
            // ckHijosA
            // 
            this.ckHijosA.AutoSize = true;
            this.ckHijosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckHijosA.Location = new System.Drawing.Point(751, 99);
            this.ckHijosA.Name = "ckHijosA";
            this.ckHijosA.Size = new System.Drawing.Size(71, 22);
            this.ckHijosA.TabIndex = 21;
            this.ckHijosA.Text = "Hijo/s";
            this.ckHijosA.UseVisualStyleBackColor = true;
            this.ckHijosA.CheckedChanged += new System.EventHandler(this.ckHijosA_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(766, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cantidad:";
            // 
            // mskCantidadHijosA
            // 
            this.mskCantidadHijosA.Enabled = false;
            this.mskCantidadHijosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCantidadHijosA.Location = new System.Drawing.Point(840, 128);
            this.mskCantidadHijosA.Mask = "99";
            this.mskCantidadHijosA.Name = "mskCantidadHijosA";
            this.mskCantidadHijosA.Size = new System.Drawing.Size(31, 21);
            this.mskCantidadHijosA.TabIndex = 23;
            this.mskCantidadHijosA.ValidatingType = typeof(int);
            // 
            // cbCarreraA
            // 
            this.cbCarreraA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarreraA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarreraA.FormattingEnabled = true;
            this.cbCarreraA.Location = new System.Drawing.Point(177, 251);
            this.cbCarreraA.Name = "cbCarreraA";
            this.cbCarreraA.Size = new System.Drawing.Size(126, 26);
            this.cbCarreraA.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(101, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Carrera:";
            // 
            // btnGuardarPersonaA
            // 
            this.btnGuardarPersonaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPersonaA.Location = new System.Drawing.Point(672, 251);
            this.btnGuardarPersonaA.Name = "btnGuardarPersonaA";
            this.btnGuardarPersonaA.Size = new System.Drawing.Size(199, 39);
            this.btnGuardarPersonaA.TabIndex = 26;
            this.btnGuardarPersonaA.Text = "Guardar Persona";
            this.btnGuardarPersonaA.UseVisualStyleBackColor = true;
            this.btnGuardarPersonaA.Click += new System.EventHandler(this.btnGuardarPersonaA_Click);
            // 
            // btnLimpiarDatosA
            // 
            this.btnLimpiarDatosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatosA.Location = new System.Drawing.Point(456, 251);
            this.btnLimpiarDatosA.Name = "btnLimpiarDatosA";
            this.btnLimpiarDatosA.Size = new System.Drawing.Size(199, 39);
            this.btnLimpiarDatosA.TabIndex = 27;
            this.btnLimpiarDatosA.Text = "Limpiar Datos";
            this.btnLimpiarDatosA.UseVisualStyleBackColor = true;
            this.btnLimpiarDatosA.Click += new System.EventHandler(this.btnLimpiarDatosA_Click);
            // 
            // dgPersonas
            // 
            this.dgPersonas.AllowUserToAddRows = false;
            this.dgPersonas.AllowUserToDeleteRows = false;
            this.dgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.Documento,
            this.Nombre,
            this.Apellido});
            this.dgPersonas.Location = new System.Drawing.Point(25, 317);
            this.dgPersonas.Name = "dgPersonas";
            this.dgPersonas.ReadOnly = true;
            this.dgPersonas.Size = new System.Drawing.Size(846, 150);
            this.dgPersonas.TabIndex = 28;
            this.dgPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonas_CellClick);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "IdTipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo doc";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 204;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "NroDocumento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 204;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 204;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 204;
            // 
            // btnActualizarDatosA
            // 
            this.btnActualizarDatosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatosA.Location = new System.Drawing.Point(672, 478);
            this.btnActualizarDatosA.Name = "btnActualizarDatosA";
            this.btnActualizarDatosA.Size = new System.Drawing.Size(199, 39);
            this.btnActualizarDatosA.TabIndex = 29;
            this.btnActualizarDatosA.Text = "Actualizar Datos";
            this.btnActualizarDatosA.UseVisualStyleBackColor = true;
            this.btnActualizarDatosA.Click += new System.EventHandler(this.btnActualizarDatosA_Click);
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 541);
            this.Controls.Add(this.btnActualizarDatosA);
            this.Controls.Add(this.dgPersonas);
            this.Controls.Add(this.btnLimpiarDatosA);
            this.Controls.Add(this.btnGuardarPersonaA);
            this.Controls.Add(this.cbCarreraA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskCantidadHijosA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ckHijosA);
            this.Controls.Add(this.ckCasadoA);
            this.Controls.Add(this.ckSolteroA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNroCasaA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCalleA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskNroDocumentoA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTDocumentoA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdFemeninoA);
            this.Controls.Add(this.rdOtroA);
            this.Controls.Add(this.rdMasculinoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskFNacimientoA);
            this.Controls.Add(this.txtApellidoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreA);
            this.Controls.Add(this.label1);
            this.Name = "AltaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaPersona";
            this.Load += new System.EventHandler(this.AltaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtApellidoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskFNacimientoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdMasculinoA;
        private System.Windows.Forms.RadioButton rdOtroA;
        private System.Windows.Forms.RadioButton rdFemeninoA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTDocumentoA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskNroDocumentoA;
        private System.Windows.Forms.TextBox txtNroCasaA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCalleA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckSolteroA;
        private System.Windows.Forms.CheckBox ckCasadoA;
        private System.Windows.Forms.CheckBox ckHijosA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskCantidadHijosA;
        private System.Windows.Forms.ComboBox cbCarreraA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardarPersonaA;
        private System.Windows.Forms.Button btnLimpiarDatosA;
        private System.Windows.Forms.DataGridView dgPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button btnActualizarDatosA;
    }
}