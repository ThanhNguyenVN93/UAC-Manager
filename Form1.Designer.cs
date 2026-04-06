namespace frmmoduac
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbtitile = new System.Windows.Forms.GroupBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.grbfunc = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnoff = new System.Windows.Forms.Button();
            this.btnon = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.grbos = new System.Windows.Forms.GroupBox();
            this.lblos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbtitile.SuspendLayout();
            this.grbfunc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbtitile
            // 
            this.grbtitile.Controls.Add(this.lbltitle);
            this.grbtitile.Location = new System.Drawing.Point(1, 1);
            this.grbtitile.Name = "grbtitile";
            this.grbtitile.Size = new System.Drawing.Size(377, 66);
            this.grbtitile.TabIndex = 0;
            this.grbtitile.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Red;
            this.lbltitle.Location = new System.Drawing.Point(88, 26);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(179, 25);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "UAC MANAGER";
            // 
            // grbfunc
            // 
            this.grbfunc.Controls.Add(this.groupBox1);
            this.grbfunc.Controls.Add(this.lblstatus);
            this.grbfunc.Location = new System.Drawing.Point(1, 73);
            this.grbfunc.Name = "grbfunc";
            this.grbfunc.Size = new System.Drawing.Size(377, 92);
            this.grbfunc.TabIndex = 1;
            this.grbfunc.TabStop = false;
            this.grbfunc.Text = "Function";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnoff);
            this.groupBox1.Controls.Add(this.btnon);
            this.groupBox1.Location = new System.Drawing.Point(193, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnoff
            // 
            this.btnoff.Enabled = false;
            this.btnoff.Location = new System.Drawing.Point(104, 25);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(68, 31);
            this.btnoff.TabIndex = 2;
            this.btnoff.Text = "Turn Off";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // btnon
            // 
            this.btnon.Enabled = false;
            this.btnon.Location = new System.Drawing.Point(6, 25);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(68, 31);
            this.btnon.TabIndex = 1;
            this.btnon.Text = "Turn On";
            this.btnon.UseVisualStyleBackColor = true;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(11, 49);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(41, 13);
            this.lblstatus.TabIndex = 0;
            this.lblstatus.Text = "label1";
            // 
            // grbos
            // 
            this.grbos.Controls.Add(this.lblos);
            this.grbos.Location = new System.Drawing.Point(1, 171);
            this.grbos.Name = "grbos";
            this.grbos.Size = new System.Drawing.Size(377, 40);
            this.grbos.TabIndex = 2;
            this.grbos.TabStop = false;
            this.grbos.Text = "OS";
            // 
            // lblos
            // 
            this.lblos.AutoSize = true;
            this.lblos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblos.Location = new System.Drawing.Point(11, 16);
            this.lblos.Name = "lblos";
            this.lblos.Size = new System.Drawing.Size(47, 15);
            this.lblos.TabIndex = 1;
            this.lblos.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 219);
            this.Controls.Add(this.grbos);
            this.Controls.Add(this.grbfunc);
            this.Controls.Add(this.grbtitile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(397, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(397, 258);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbtitile.ResumeLayout(false);
            this.grbtitile.PerformLayout();
            this.grbfunc.ResumeLayout(false);
            this.grbfunc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbos.ResumeLayout(false);
            this.grbos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbtitile;
        private System.Windows.Forms.GroupBox grbfunc;
        private System.Windows.Forms.GroupBox grbos;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Button btnon;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblos;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Timer timer1;
    }
}

