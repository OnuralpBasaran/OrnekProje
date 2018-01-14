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
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrEkstre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrEkstre
            // 
            this.grdCtrEkstre.Location = new System.Drawing.Point(12, 39);
            this.grdCtrEkstre.MainView = this.gridView1;
            this.grdCtrEkstre.Name = "grdCtrEkstre";
            this.grdCtrEkstre.Size = new System.Drawing.Size(843, 466);
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
            this.txtBaslangicTarih.Location = new System.Drawing.Point(12, 10);
            this.txtBaslangicTarih.Name = "txtBaslangicTarih";
            this.txtBaslangicTarih.Size = new System.Drawing.Size(100, 23);
            this.txtBaslangicTarih.TabIndex = 1;
            this.txtBaslangicTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBitisTarih
            // 
            this.txtBitisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitisTarih.Location = new System.Drawing.Point(118, 10);
            this.txtBitisTarih.Name = "txtBitisTarih";
            this.txtBitisTarih.Size = new System.Drawing.Size(100, 23);
            this.txtBitisTarih.TabIndex = 2;
            this.txtBitisTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMalKodu
            // 
            this.txtMalKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMalKodu.Location = new System.Drawing.Point(243, 10);
            this.txtMalKodu.Name = "txtMalKodu";
            this.txtMalKodu.Size = new System.Drawing.Size(237, 23);
            this.txtMalKodu.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(486, 10);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // FrmStokEkstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 515);
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
    }
}

