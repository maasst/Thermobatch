namespace Thermobatch
{
    partial class Hauptfenster
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
            this.components = new System.ComponentModel.Container();
            this.btn_DBMesswerteLesen = new System.Windows.Forms.Button();
            this.tbx_DBConnectionStr = new System.Windows.Forms.TextBox();
            this.tbx_SqlCmd_Messwerte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DBMessstellenLesen = new System.Windows.Forms.Button();
            this.chklb_Messtellen = new System.Windows.Forms.CheckedListBox();
            this.dGrVw_Messwerte = new System.Windows.Forms.DataGridView();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVw_Messwerte)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DBMesswerteLesen
            // 
            this.btn_DBMesswerteLesen.Location = new System.Drawing.Point(138, 45);
            this.btn_DBMesswerteLesen.Name = "btn_DBMesswerteLesen";
            this.btn_DBMesswerteLesen.Size = new System.Drawing.Size(113, 23);
            this.btn_DBMesswerteLesen.TabIndex = 0;
            this.btn_DBMesswerteLesen.Text = "Lese Messwerte";
            this.btn_DBMesswerteLesen.UseVisualStyleBackColor = true;
            this.btn_DBMesswerteLesen.Click += new System.EventHandler(this.btn_DBMesswerteLesen_Click);
            // 
            // tbx_DBConnectionStr
            // 
            this.tbx_DBConnectionStr.Enabled = false;
            this.tbx_DBConnectionStr.Location = new System.Drawing.Point(257, 14);
            this.tbx_DBConnectionStr.Name = "tbx_DBConnectionStr";
            this.tbx_DBConnectionStr.Size = new System.Drawing.Size(488, 20);
            this.tbx_DBConnectionStr.TabIndex = 1;
            // 
            // tbx_SqlCmd_Messwerte
            // 
            this.tbx_SqlCmd_Messwerte.Enabled = false;
            this.tbx_SqlCmd_Messwerte.Location = new System.Drawing.Point(257, 45);
            this.tbx_SqlCmd_Messwerte.Name = "tbx_SqlCmd_Messwerte";
            this.tbx_SqlCmd_Messwerte.Size = new System.Drawing.Size(488, 20);
            this.tbx_SqlCmd_Messwerte.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datenbankverbindung";
            // 
            // btn_DBMessstellenLesen
            // 
            this.btn_DBMessstellenLesen.Location = new System.Drawing.Point(12, 45);
            this.btn_DBMessstellenLesen.Name = "btn_DBMessstellenLesen";
            this.btn_DBMessstellenLesen.Size = new System.Drawing.Size(113, 23);
            this.btn_DBMessstellenLesen.TabIndex = 4;
            this.btn_DBMessstellenLesen.Text = "Lese Messstellen";
            this.btn_DBMessstellenLesen.UseVisualStyleBackColor = true;
            this.btn_DBMessstellenLesen.Click += new System.EventHandler(this.btn_DBMessstellenLesen_Click);
            // 
            // chklb_Messtellen
            // 
            this.chklb_Messtellen.FormattingEnabled = true;
            this.chklb_Messtellen.Location = new System.Drawing.Point(12, 74);
            this.chklb_Messtellen.Name = "chklb_Messtellen";
            this.chklb_Messtellen.Size = new System.Drawing.Size(113, 139);
            this.chklb_Messtellen.TabIndex = 5;
            // 
            // dGrVw_Messwerte
            // 
            this.dGrVw_Messwerte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrVw_Messwerte.Location = new System.Drawing.Point(131, 75);
            this.dGrVw_Messwerte.Name = "dGrVw_Messwerte";
            this.dGrVw_Messwerte.Size = new System.Drawing.Size(614, 138);
            this.dGrVw_Messwerte.TabIndex = 6;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 219);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(733, 219);
            this.zedGraphControl1.TabIndex = 7;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.dGrVw_Messwerte);
            this.Controls.Add(this.chklb_Messtellen);
            this.Controls.Add(this.btn_DBMessstellenLesen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_SqlCmd_Messwerte);
            this.Controls.Add(this.tbx_DBConnectionStr);
            this.Controls.Add(this.btn_DBMesswerteLesen);
            this.Name = "Hauptfenster";
            this.Text = "ThermoBatch Hauptfenster";
            ((System.ComponentModel.ISupportInitialize)(this.dGrVw_Messwerte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DBMesswerteLesen;
        private System.Windows.Forms.TextBox tbx_DBConnectionStr;
        private System.Windows.Forms.TextBox tbx_SqlCmd_Messwerte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DBMessstellenLesen;
        private System.Windows.Forms.CheckedListBox chklb_Messtellen;
        private System.Windows.Forms.DataGridView dGrVw_Messwerte;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}