﻿
namespace VehicleServiceStations
{
    partial class Service
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
            this.cmbname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvid = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Vehicle";
            // 
            // cmbname
            // 
            this.cmbname.FormattingEnabled = true;
            this.cmbname.Items.AddRange(new object[] {
            "Two Wheeler",
            "Four Wheeler",
            "Three Wheeler"});
            this.cmbname.Location = new System.Drawing.Point(347, 99);
            this.cmbname.Name = "cmbname";
            this.cmbname.Size = new System.Drawing.Size(166, 24);
            this.cmbname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Service ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(347, 150);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(166, 22);
            this.txtid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vehicle No";
            // 
            // txtvno
            // 
            this.txtvno.Location = new System.Drawing.Point(347, 197);
            this.txtvno.Name = "txtvno";
            this.txtvno.Size = new System.Drawing.Size(166, 22);
            this.txtvno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Service Details";
            // 
            // txtsd
            // 
            this.txtsd.Location = new System.Drawing.Point(347, 257);
            this.txtsd.Name = "txtsd";
            this.txtsd.Size = new System.Drawing.Size(166, 22);
            this.txtsd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vehicle Type id";
            // 
            // txtvid
            // 
            this.txtvid.Location = new System.Drawing.Point(347, 320);
            this.txtvid.Name = "txtvid";
            this.txtvid.Size = new System.Drawing.Size(166, 22);
            this.txtvid.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(207, 378);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtvid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbname);
            this.Controls.Add(this.label1);
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button1;
    }
}