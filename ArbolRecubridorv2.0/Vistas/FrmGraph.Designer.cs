namespace ArbolRecubridorv2._0
{
    partial class FrmGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGraph));
            this.gbxPrim = new System.Windows.Forms.GroupBox();
            this.gbxDraw = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.gbxStart = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlPrim = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimePrim = new System.Windows.Forms.Label();
            this.gbxKruscal = new System.Windows.Forms.GroupBox();
            this.lblTimeKruscal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlKruscal = new System.Windows.Forms.Panel();
            this.lblTotTime = new System.Windows.Forms.Label();
            this.gbxPrim.SuspendLayout();
            this.gbxDraw.SuspendLayout();
            this.gbxStart.SuspendLayout();
            this.gbxKruscal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPrim
            // 
            this.gbxPrim.Controls.Add(this.lblTimePrim);
            this.gbxPrim.Controls.Add(this.label1);
            this.gbxPrim.Controls.Add(this.pnlPrim);
            this.gbxPrim.Location = new System.Drawing.Point(12, 121);
            this.gbxPrim.Name = "gbxPrim";
            this.gbxPrim.Size = new System.Drawing.Size(316, 362);
            this.gbxPrim.TabIndex = 0;
            this.gbxPrim.TabStop = false;
            this.gbxPrim.Text = "Prim";
            // 
            // gbxDraw
            // 
            this.gbxDraw.Controls.Add(this.btnDraw);
            this.gbxDraw.Location = new System.Drawing.Point(12, 37);
            this.gbxDraw.Name = "gbxDraw";
            this.gbxDraw.Size = new System.Drawing.Size(316, 55);
            this.gbxDraw.TabIndex = 1;
            this.gbxDraw.TabStop = false;
            this.gbxDraw.Text = "Paso dos";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(114, 20);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // gbxStart
            // 
            this.gbxStart.Controls.Add(this.btnStart);
            this.gbxStart.Location = new System.Drawing.Point(389, 37);
            this.gbxStart.Name = "gbxStart";
            this.gbxStart.Size = new System.Drawing.Size(316, 55);
            this.gbxStart.TabIndex = 2;
            this.gbxStart.TabStop = false;
            this.gbxStart.Text = "paso tres";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(116, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Comenzar";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(650, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // pnlPrim
            // 
            this.pnlPrim.BackColor = System.Drawing.SystemColors.Window;
            this.pnlPrim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPrim.Location = new System.Drawing.Point(7, 37);
            this.pnlPrim.Name = "pnlPrim";
            this.pnlPrim.Size = new System.Drawing.Size(303, 266);
            this.pnlPrim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grafo";
            // 
            // lblTimePrim
            // 
            this.lblTimePrim.AutoSize = true;
            this.lblTimePrim.Location = new System.Drawing.Point(7, 340);
            this.lblTimePrim.Name = "lblTimePrim";
            this.lblTimePrim.Size = new System.Drawing.Size(35, 13);
            this.lblTimePrim.TabIndex = 2;
            this.lblTimePrim.Text = "label2";
            // 
            // gbxKruscal
            // 
            this.gbxKruscal.Controls.Add(this.lblTimeKruscal);
            this.gbxKruscal.Controls.Add(this.label3);
            this.gbxKruscal.Controls.Add(this.pnlKruscal);
            this.gbxKruscal.Location = new System.Drawing.Point(389, 118);
            this.gbxKruscal.Name = "gbxKruscal";
            this.gbxKruscal.Size = new System.Drawing.Size(316, 362);
            this.gbxKruscal.TabIndex = 3;
            this.gbxKruscal.TabStop = false;
            this.gbxKruscal.Text = "Prim";
            // 
            // lblTimeKruscal
            // 
            this.lblTimeKruscal.AutoSize = true;
            this.lblTimeKruscal.Location = new System.Drawing.Point(7, 340);
            this.lblTimeKruscal.Name = "lblTimeKruscal";
            this.lblTimeKruscal.Size = new System.Drawing.Size(35, 13);
            this.lblTimeKruscal.TabIndex = 2;
            this.lblTimeKruscal.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grafo";
            // 
            // pnlKruscal
            // 
            this.pnlKruscal.BackColor = System.Drawing.SystemColors.Window;
            this.pnlKruscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKruscal.Location = new System.Drawing.Point(7, 37);
            this.pnlKruscal.Name = "pnlKruscal";
            this.pnlKruscal.Size = new System.Drawing.Size(303, 266);
            this.pnlKruscal.TabIndex = 0;
            // 
            // lblTotTime
            // 
            this.lblTotTime.AutoSize = true;
            this.lblTotTime.Location = new System.Drawing.Point(198, 496);
            this.lblTotTime.Name = "lblTotTime";
            this.lblTotTime.Size = new System.Drawing.Size(42, 13);
            this.lblTotTime.TabIndex = 4;
            this.lblTotTime.Text = "Tiempo";
            // 
            // FrmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 518);
            this.Controls.Add(this.lblTotTime);
            this.Controls.Add(this.gbxKruscal);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gbxStart);
            this.Controls.Add(this.gbxDraw);
            this.Controls.Add(this.gbxPrim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGraph";
            this.Text = "Árbol Recubridor Mínimo";
            this.Load += new System.EventHandler(this.Dos_Load);
            this.gbxPrim.ResumeLayout(false);
            this.gbxPrim.PerformLayout();
            this.gbxDraw.ResumeLayout(false);
            this.gbxStart.ResumeLayout(false);
            this.gbxKruscal.ResumeLayout(false);
            this.gbxKruscal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPrim;
        private System.Windows.Forms.Label lblTimePrim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPrim;
        private System.Windows.Forms.GroupBox gbxDraw;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox gbxStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gbxKruscal;
        private System.Windows.Forms.Label lblTimeKruscal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlKruscal;
        private System.Windows.Forms.Label lblTotTime;
    }
}