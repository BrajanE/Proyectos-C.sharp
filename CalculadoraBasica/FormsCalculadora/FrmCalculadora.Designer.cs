namespace FormsCalculadora
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.cmb_operador = new System.Windows.Forms.ComboBox();
            this.btn_operar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_convertirABinario = new System.Windows.Forms.Button();
            this.btn_convertirADecimal = new System.Windows.Forms.Button();
            this.lstbx_operaciones = new System.Windows.Forms.ListBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_num1.Location = new System.Drawing.Point(12, 39);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(179, 29);
            this.txt_num1.TabIndex = 0;
            // 
            // txt_num2
            // 
            this.txt_num2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_num2.Location = new System.Drawing.Point(274, 39);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(179, 29);
            this.txt_num2.TabIndex = 2;
            // 
            // cmb_operador
            // 
            this.cmb_operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_operador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_operador.FormattingEnabled = true;
            this.cmb_operador.Location = new System.Drawing.Point(206, 39);
            this.cmb_operador.Name = "cmb_operador";
            this.cmb_operador.Size = new System.Drawing.Size(53, 29);
            this.cmb_operador.TabIndex = 1;
            // 
            // btn_operar
            // 
            this.btn_operar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_operar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_operar.Location = new System.Drawing.Point(12, 100);
            this.btn_operar.Name = "btn_operar";
            this.btn_operar.Size = new System.Drawing.Size(143, 54);
            this.btn_operar.TabIndex = 3;
            this.btn_operar.Text = "Operar";
            this.btn_operar.UseVisualStyleBackColor = false;
            this.btn_operar.Click += new System.EventHandler(this.btn_operar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_limpiar.Location = new System.Drawing.Point(161, 100);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(143, 54);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cerrar.Location = new System.Drawing.Point(310, 100);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(143, 54);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_convertirABinario
            // 
            this.btn_convertirABinario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_convertirABinario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convertirABinario.Location = new System.Drawing.Point(32, 160);
            this.btn_convertirABinario.Name = "btn_convertirABinario";
            this.btn_convertirABinario.Size = new System.Drawing.Size(202, 54);
            this.btn_convertirABinario.TabIndex = 6;
            this.btn_convertirABinario.Text = "Convertir a Binario";
            this.btn_convertirABinario.UseVisualStyleBackColor = false;
            this.btn_convertirABinario.Click += new System.EventHandler(this.btn_convertirABinario_Click);
            // 
            // btn_convertirADecimal
            // 
            this.btn_convertirADecimal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_convertirADecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convertirADecimal.Location = new System.Drawing.Point(240, 160);
            this.btn_convertirADecimal.Name = "btn_convertirADecimal";
            this.btn_convertirADecimal.Size = new System.Drawing.Size(202, 54);
            this.btn_convertirADecimal.TabIndex = 7;
            this.btn_convertirADecimal.Text = "Convertir a Decimal";
            this.btn_convertirADecimal.UseVisualStyleBackColor = false;
            this.btn_convertirADecimal.Click += new System.EventHandler(this.btn_convertirADecimal_Click);
            // 
            // lstbx_operaciones
            // 
            this.lstbx_operaciones.FormattingEnabled = true;
            this.lstbx_operaciones.ItemHeight = 15;
            this.lstbx_operaciones.Location = new System.Drawing.Point(459, 39);
            this.lstbx_operaciones.Name = "lstbx_operaciones";
            this.lstbx_operaciones.Size = new System.Drawing.Size(234, 214);
            this.lstbx_operaciones.TabIndex = 8;
            this.lstbx_operaciones.TabStop = false;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_resultado.Location = new System.Drawing.Point(459, 9);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(133, 21);
            this.lbl_resultado.TabIndex = 9;
            this.lbl_resultado.Text = "Resultado Actual";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(709, 268);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lstbx_operaciones);
            this.Controls.Add(this.btn_convertirADecimal);
            this.Controls.Add(this.btn_convertirABinario);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_operar);
            this.Controls.Add(this.cmb_operador);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tu Calculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.ComboBox cmb_operador;
        private System.Windows.Forms.Button btn_operar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_convertirABinario;
        private System.Windows.Forms.Button btn_convertirADecimal;
        private System.Windows.Forms.ListBox lstbx_operaciones;
        private System.Windows.Forms.Label lbl_resultado;
    }
}
