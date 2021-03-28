namespace appE3_SGDE.Vistaa
{
    partial class frmInformeTarifa
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
            this.reportDatos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportDatos
            // 
            this.reportDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDatos.Location = new System.Drawing.Point(0, 0);
            this.reportDatos.Name = "reportDatos";
            this.reportDatos.ServerReport.BearerToken = null;
            this.reportDatos.Size = new System.Drawing.Size(800, 450);
            this.reportDatos.TabIndex = 0;
            // 
            // frmInformeTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportDatos);
            this.Name = "frmInformeTarifa";
            this.Text = "frmInformeTarifa";
            this.Load += new System.EventHandler(this.frmInformeTarifa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportDatos;
    }
}