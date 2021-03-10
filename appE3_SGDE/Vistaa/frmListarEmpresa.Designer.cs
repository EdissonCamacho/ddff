namespace appE3_SGDE.Vistaa
{
    partial class frmListarEmpresa
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvListarEmpresa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA EMPRESAS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvListarEmpresa
            // 
            this.dgvListarEmpresa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListarEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEmpresa.Location = new System.Drawing.Point(177, 111);
            this.dgvListarEmpresa.Name = "dgvListarEmpresa";
            this.dgvListarEmpresa.Size = new System.Drawing.Size(457, 199);
            this.dgvListarEmpresa.TabIndex = 2;
            // 
            // frmListarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appE3_SGDE.Properties.Resources.WhatsApp_Image_2021_03_09_at_8_22_41_AM;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListarEmpresa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmListarEmpresa";
            this.Text = "frmListarEmpresa";
            this.Load += new System.EventHandler(this.frmListarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvListarEmpresa;
    }
}