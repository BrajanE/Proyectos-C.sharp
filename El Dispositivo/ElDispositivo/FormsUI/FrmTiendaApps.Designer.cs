namespace FormsUI
{
    partial class FrmTiendaApps
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
            this.dgv_aplicaciones = new System.Windows.Forms.DataGridView();
            this.btn_instalarApps = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aplicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_aplicaciones
            // 
            this.dgv_aplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aplicaciones.Location = new System.Drawing.Point(12, 12);
            this.dgv_aplicaciones.MultiSelect = false;
            this.dgv_aplicaciones.Name = "dgv_aplicaciones";
            this.dgv_aplicaciones.ReadOnly = true;
            this.dgv_aplicaciones.RowTemplate.Height = 25;
            this.dgv_aplicaciones.Size = new System.Drawing.Size(300, 297);
            this.dgv_aplicaciones.TabIndex = 1;
            // 
            // btn_instalarApps
            // 
            this.btn_instalarApps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_instalarApps.Location = new System.Drawing.Point(318, 63);
            this.btn_instalarApps.Name = "btn_instalarApps";
            this.btn_instalarApps.Size = new System.Drawing.Size(99, 46);
            this.btn_instalarApps.TabIndex = 2;
            this.btn_instalarApps.Text = "Instalar";
            this.btn_instalarApps.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(318, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(318, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmTiendaApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 321);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_instalarApps);
            this.Controls.Add(this.dgv_aplicaciones);
            this.Name = "FrmTiendaApps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTiendaApps";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTiendaApps_FormClosing);
            this.Load += new System.EventHandler(this.FrmTiendaApps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aplicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_aplicaciones;
        private System.Windows.Forms.Button btn_instalarApps;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}