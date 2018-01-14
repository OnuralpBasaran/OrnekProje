namespace OrnekProje
{
    partial class FrmStokEkstre
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
            this.grdCtrEkstre = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtBaslangicTarih = new System.Windows.Forms.TextBox();
            this.txtBitisTarih = new System.Windows.Forms.TextBox();
            this.txtMalKodu = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTextExport = new System.Windows.Forms.Button();
            this.btnPdfExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrEkstre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrEkstre
            // 
            this.grdCtrEkstre.Location = new System.Drawing.Point(12, 59);
            this.grdCtrEkstre.MainView = this.gridView1;
            this.grdCtrEkstre.Name = "grdCtrEkstre";
            this.grdCtrEkstre.Size = new System.Drawing.Size(843, 496);
            this.grdCtrEkstre.TabIndex = 0;
            this.grdCtrEkstre.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrEkstre;
            this.gridView1.Name = "gridView1";
            // 
            // txtBaslangicTarih
            // 
            this.txtBaslangicTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaslangicTarih.Location = new System.Drawing.Point(12, 30);
            this.txtBaslangicTarih.Name = "txtBaslangicTarih";
            this.txtBaslangicTarih.Size = new System.Drawing.Size(148, 23);
            this.txtBaslangicTarih.TabIndex = 1;
            this.txtBaslangicTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBitisTarih
            // 
            this.txtBitisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitisTarih.Location = new System.Drawing.Point(166, 30);
            this.txtBitisTarih.Name = "txtBitisTarih";
            this.txtBitisTarih.Size = new System.Drawing.Size(118, 23);
            this.txtBitisTarih.TabIndex = 2;
            this.txtBitisTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMalKodu
            // 
            this.txtMalKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMalKodu.Location = new System.Drawing.Point(312, 30);
            this.txtMalKodu.Name = "txtMalKodu";
            this.txtMalKodu.Size = new System.Drawing.Size(237, 23);
            this.txtMalKodu.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(555, 30);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Başlangıç Tarihi (2018.01.01):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bitiş Tarihi (2018.01.02):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mal Kodu:";
            // 
            // btnTextExport
            // 
            this.btnTextExport.Location = new System.Drawing.Point(699, 30);
            this.btnTextExport.Name = "btnTextExport";
            this.btnTextExport.Size = new System.Drawing.Size(75, 23);
            this.btnTextExport.TabIndex = 8;
            this.btnTextExport.Text = ".txt Export";
            this.btnTextExport.UseVisualStyleBackColor = true;
            this.btnTextExport.Click += new System.EventHandler(this.btnTextExport_Click);
            // 
            // btnPdfExport
            // 
            this.btnPdfExport.Location = new System.Drawing.Point(780, 30);
            this.btnPdfExport.Name = "btnPdfExport";
            this.btnPdfExport.Size = new System.Drawing.Size(75, 23);
            this.btnPdfExport.TabIndex = 9;
            this.btnPdfExport.Text = ".pdf Export";
            this.btnPdfExport.UseVisualStyleBackColor = true;
            this.btnPdfExport.Click += new System.EventHandler(this.btnPdfExport_Click);
            // 
            // FrmStokEkstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 567);
            this.Controls.Add(this.btnPdfExport);
            this.Controls.Add(this.btnTextExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtMalKodu);
            this.Controls.Add(this.txtBitisTarih);
            this.Controls.Add(this.txtBaslangicTarih);
            this.Controls.Add(this.grdCtrEkstre);
            this.Name = "FrmStokEkstre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ekstre";
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrEkstre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrEkstre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtBaslangicTarih;
        private System.Windows.Forms.TextBox txtBitisTarih;
        private System.Windows.Forms.TextBox txtMalKodu;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTextExport;
        private System.Windows.Forms.Button btnPdfExport;
    }
}

