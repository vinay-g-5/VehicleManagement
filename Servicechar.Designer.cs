
namespace VehicleServiceStations
{
    partial class Servicechar
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttsc = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Vehicle";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Two Wheeler",
            "Four Wheeler",
            "Three Wheeler"});
            this.comboBox1.Location = new System.Drawing.Point(329, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total  Service Charge";
            // 
            // txttsc
            // 
            this.txttsc.Location = new System.Drawing.Point(349, 175);
            this.txttsc.Name = "txttsc";
            this.txttsc.Size = new System.Drawing.Size(146, 22);
            this.txttsc.TabIndex = 3;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(201, 261);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(111, 33);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(364, 261);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(111, 33);
            this.btnhome.TabIndex = 5;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            // 
            // Servicechar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txttsc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Servicechar";
            this.Text = "Servicechar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttsc;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnhome;
    }
}