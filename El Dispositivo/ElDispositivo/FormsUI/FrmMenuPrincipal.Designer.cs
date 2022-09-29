namespace FormsUI
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_SO = new System.Windows.Forms.ComboBox();
            this.lbl_SO = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contrasenia = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrania = new System.Windows.Forms.TextBox();
            this.grp_datosUsuario = new System.Windows.Forms.GroupBox();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.grp_datosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_SO
            // 
            this.cmb_SO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SO.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_SO.FormattingEnabled = true;
            this.cmb_SO.Location = new System.Drawing.Point(26, 75);
            this.cmb_SO.Name = "cmb_SO";
            this.cmb_SO.Size = new System.Drawing.Size(193, 29);
            this.cmb_SO.TabIndex = 0;
            // 
            // lbl_SO
            // 
            this.lbl_SO.AutoSize = true;
            this.lbl_SO.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SO.Location = new System.Drawing.Point(26, 19);
            this.lbl_SO.Name = "lbl_SO";
            this.lbl_SO.Size = new System.Drawing.Size(193, 42);
            this.lbl_SO.TabIndex = 1;
            this.lbl_SO.Text = "Elija el Sistema Operativo\r\nde su dispositivo";
            this.lbl_SO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.Location = new System.Drawing.Point(40, 19);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(117, 21);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Ingrese usuario";
            // 
            // lbl_contrasenia
            // 
            this.lbl_contrasenia.AutoSize = true;
            this.lbl_contrasenia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_contrasenia.Location = new System.Drawing.Point(29, 101);
            this.lbl_contrasenia.Name = "lbl_contrasenia";
            this.lbl_contrasenia.Size = new System.Drawing.Size(141, 21);
            this.lbl_contrasenia.TabIndex = 3;
            this.lbl_contrasenia.Text = "Ingrese contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(29, 43);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(141, 29);
            this.txt_usuario.TabIndex = 4;
            // 
            // txt_contrania
            // 
            this.txt_contrania.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_contrania.Location = new System.Drawing.Point(29, 125);
            this.txt_contrania.Name = "txt_contrania";
            this.txt_contrania.Size = new System.Drawing.Size(141, 29);
            this.txt_contrania.TabIndex = 5;
            // 
            // grp_datosUsuario
            // 
            this.grp_datosUsuario.Controls.Add(this.lbl_contrasenia);
            this.grp_datosUsuario.Controls.Add(this.txt_usuario);
            this.grp_datosUsuario.Controls.Add(this.txt_contrania);
            this.grp_datosUsuario.Controls.Add(this.lbl_usuario);
            this.grp_datosUsuario.Location = new System.Drawing.Point(26, 138);
            this.grp_datosUsuario.Name = "grp_datosUsuario";
            this.grp_datosUsuario.Size = new System.Drawing.Size(193, 160);
            this.grp_datosUsuario.TabIndex = 6;
            this.grp_datosUsuario.TabStop = false;
            this.grp_datosUsuario.Text = "Datos Usuario";
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ingreso.Location = new System.Drawing.Point(55, 322);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(141, 47);
            this.btn_ingreso.TabIndex = 7;
            this.btn_ingreso.Text = "Ingresar";
            this.btn_ingreso.UseVisualStyleBackColor = true;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 397);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.grp_datosUsuario);
            this.Controls.Add(this.lbl_SO);
            this.Controls.Add(this.cmb_SO);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.grp_datosUsuario.ResumeLayout(false);
            this.grp_datosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_SO;
        private System.Windows.Forms.Label lbl_SO;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contrasenia;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contrania;
        private System.Windows.Forms.GroupBox grp_datosUsuario;
        private System.Windows.Forms.Button btn_ingreso;
    }
}
