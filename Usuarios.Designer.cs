
namespace miapp_r2
{
    partial class Usuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCamposFU = new System.Windows.Forms.Button();
            this.btnAltaUsuarioFU = new System.Windows.Forms.Button();
            this.txtRContraseñaFU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseñaFU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreFU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgUsuariosFU = new System.Windows.Forms.DataGridView();
            this.IdDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDeUsuarioDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContraseñaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuariosFU)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarCamposFU);
            this.groupBox1.Controls.Add(this.btnAltaUsuarioFU);
            this.groupBox1.Controls.Add(this.txtRContraseñaFU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContraseñaFU);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreFU);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // btnLimpiarCamposFU
            // 
            this.btnLimpiarCamposFU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCamposFU.Location = new System.Drawing.Point(224, 202);
            this.btnLimpiarCamposFU.Name = "btnLimpiarCamposFU";
            this.btnLimpiarCamposFU.Size = new System.Drawing.Size(147, 35);
            this.btnLimpiarCamposFU.TabIndex = 7;
            this.btnLimpiarCamposFU.Text = "Limpiar campos";
            this.btnLimpiarCamposFU.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposFU.Click += new System.EventHandler(this.btnLimpiarCamposFU_Click);
            // 
            // btnAltaUsuarioFU
            // 
            this.btnAltaUsuarioFU.Location = new System.Drawing.Point(377, 202);
            this.btnAltaUsuarioFU.Name = "btnAltaUsuarioFU";
            this.btnAltaUsuarioFU.Size = new System.Drawing.Size(115, 35);
            this.btnAltaUsuarioFU.TabIndex = 6;
            this.btnAltaUsuarioFU.Text = "Alta usuario";
            this.btnAltaUsuarioFU.UseVisualStyleBackColor = true;
            this.btnAltaUsuarioFU.Click += new System.EventHandler(this.btnAltaUsuarioFU_Click);
            // 
            // txtRContraseñaFU
            // 
            this.txtRContraseñaFU.Location = new System.Drawing.Point(224, 125);
            this.txtRContraseñaFU.Name = "txtRContraseñaFU";
            this.txtRContraseñaFU.PasswordChar = '*';
            this.txtRContraseñaFU.Size = new System.Drawing.Size(191, 24);
            this.txtRContraseñaFU.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repetir contraseña:";
            // 
            // txtContraseñaFU
            // 
            this.txtContraseñaFU.Location = new System.Drawing.Point(224, 84);
            this.txtContraseñaFU.Name = "txtContraseñaFU";
            this.txtContraseñaFU.PasswordChar = '*';
            this.txtContraseñaFU.Size = new System.Drawing.Size(191, 24);
            this.txtContraseñaFU.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // txtNombreFU
            // 
            this.txtNombreFU.Location = new System.Drawing.Point(224, 41);
            this.txtNombreFU.Name = "txtNombreFU";
            this.txtNombreFU.Size = new System.Drawing.Size(191, 24);
            this.txtNombreFU.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgUsuariosFU);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 261);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de usuarios";
            // 
            // dgUsuariosFU
            // 
            this.dgUsuariosFU.AllowUserToAddRows = false;
            this.dgUsuariosFU.AllowUserToDeleteRows = false;
            this.dgUsuariosFU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuariosFU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDG,
            this.NombreDeUsuarioDG,
            this.ContraseñaDG});
            this.dgUsuariosFU.Location = new System.Drawing.Point(7, 23);
            this.dgUsuariosFU.Name = "dgUsuariosFU";
            this.dgUsuariosFU.ReadOnly = true;
            this.dgUsuariosFU.Size = new System.Drawing.Size(502, 232);
            this.dgUsuariosFU.TabIndex = 0;
            // 
            // IdDG
            // 
            this.IdDG.DataPropertyName = "IdUsuarioBD";
            this.IdDG.HeaderText = "Id usuario";
            this.IdDG.Name = "IdDG";
            this.IdDG.ReadOnly = true;
            this.IdDG.Width = 160;
            // 
            // NombreDeUsuarioDG
            // 
            this.NombreDeUsuarioDG.DataPropertyName = "NombreDeUsuarioBD";
            this.NombreDeUsuarioDG.HeaderText = "Usuario";
            this.NombreDeUsuarioDG.Name = "NombreDeUsuarioDG";
            this.NombreDeUsuarioDG.ReadOnly = true;
            this.NombreDeUsuarioDG.Width = 160;
            // 
            // ContraseñaDG
            // 
            this.ContraseñaDG.DataPropertyName = "PasswordBD";
            this.ContraseñaDG.HeaderText = "Contraseña";
            this.ContraseñaDG.Name = "ContraseñaDG";
            this.ContraseñaDG.ReadOnly = true;
            this.ContraseñaDG.Width = 160;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuariosFU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreFU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRContraseñaFU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseñaFU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAltaUsuarioFU;
        private System.Windows.Forms.Button btnLimpiarCamposFU;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgUsuariosFU;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDeUsuarioDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContraseñaDG;
    }
}