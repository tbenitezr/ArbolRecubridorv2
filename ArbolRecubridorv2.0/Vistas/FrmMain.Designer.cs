namespace ArbolRecubridorv2._0
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.rbnRuta = new System.Windows.Forms.RadioButton();
            this.rbnOther = new System.Windows.Forms.RadioButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.llbFormat = new System.Windows.Forms.LinkLabel();
            this.llbHelp = new System.Windows.Forms.LinkLabel();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.llbSearch = new System.Windows.Forms.LinkLabel();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnAcept = new System.Windows.Forms.Button();
            this.fbdFolderS = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // rbnRuta
            // 
            this.rbnRuta.AutoSize = true;
            this.rbnRuta.Location = new System.Drawing.Point(46, 61);
            this.rbnRuta.Name = "rbnRuta";
            this.rbnRuta.Size = new System.Drawing.Size(158, 17);
            this.rbnRuta.TabIndex = 0;
            this.rbnRuta.TabStop = true;
            this.rbnRuta.Text = "Desde archivo de texto (.txt)";
            this.rbnRuta.UseVisualStyleBackColor = true;
            this.rbnRuta.CheckedChanged += new System.EventHandler(this.rbnRuta_CheckedChanged);
            // 
            // rbnOther
            // 
            this.rbnOther.AutoSize = true;
            this.rbnOther.Location = new System.Drawing.Point(46, 124);
            this.rbnOther.Name = "rbnOther";
            this.rbnOther.Size = new System.Drawing.Size(146, 17);
            this.rbnOther.TabIndex = 1;
            this.rbnOther.TabStop = true;
            this.rbnOther.Text = "Capturando manualmente";
            this.rbnOther.UseVisualStyleBackColor = true;
            this.rbnOther.CheckedChanged += new System.EventHandler(this.rbnOther_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(55, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Paso uno:";
            // 
            // llbFormat
            // 
            this.llbFormat.AutoSize = true;
            this.llbFormat.Location = new System.Drawing.Point(223, 61);
            this.llbFormat.Name = "llbFormat";
            this.llbFormat.Size = new System.Drawing.Size(49, 13);
            this.llbFormat.TabIndex = 4;
            this.llbFormat.TabStop = true;
            this.llbFormat.Text = "*Formato";
            // 
            // llbHelp
            // 
            this.llbHelp.AutoSize = true;
            this.llbHelp.Location = new System.Drawing.Point(646, 13);
            this.llbHelp.Name = "llbHelp";
            this.llbHelp.Size = new System.Drawing.Size(37, 13);
            this.llbHelp.TabIndex = 5;
            this.llbHelp.TabStop = true;
            this.llbHelp.Text = "Ayuda";
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(114, 84);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(483, 20);
            this.tbxPath.TabIndex = 6;
            this.tbxPath.Visible = false;
            this.tbxPath.TextChanged += new System.EventHandler(this.tbxPath_TextChanged);
            // 
            // llbSearch
            // 
            this.llbSearch.AutoSize = true;
            this.llbSearch.Location = new System.Drawing.Point(603, 87);
            this.llbSearch.Name = "llbSearch";
            this.llbSearch.Size = new System.Drawing.Size(49, 13);
            this.llbSearch.TabIndex = 7;
            this.llbSearch.TabStop = true;
            this.llbSearch.Text = "Buscar...";
            this.llbSearch.Visible = false;
            this.llbSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSearch_LinkClicked);
            this.llbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.llbSearch_MouseDoubleClick);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(75, 87);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(33, 13);
            this.lblPath.TabIndex = 8;
            this.lblPath.Text = "Ruta:";
            this.lblPath.Visible = false;
            // 
            // btnAcept
            // 
            this.btnAcept.Enabled = false;
            this.btnAcept.Location = new System.Drawing.Point(572, 171);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 10;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // fbdFolderS
            // 
            this.fbdFolderS.ShowNewFolderButton = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 212);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.llbSearch);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.llbHelp);
            this.Controls.Add(this.llbFormat);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.rbnOther);
            this.Controls.Add(this.rbnRuta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Árbol Recubridor Mínimo";
            this.Load += new System.EventHandler(this.FrmUno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnRuta;
        private System.Windows.Forms.RadioButton rbnOther;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.LinkLabel llbFormat;
        private System.Windows.Forms.LinkLabel llbHelp;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.LinkLabel llbSearch;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderS;
    }
}

