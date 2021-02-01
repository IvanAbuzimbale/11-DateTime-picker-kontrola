
namespace DateTime_picker
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
            this.DateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerVrijeme = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonRezervacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimePickerDatum
            // 
            this.DateTimePickerDatum.Location = new System.Drawing.Point(137, 12);
            this.DateTimePickerDatum.Name = "DateTimePickerDatum";
            this.DateTimePickerDatum.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerDatum.TabIndex = 0;
            // 
            // DateTimePickerVrijeme
            // 
            this.DateTimePickerVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerVrijeme.Location = new System.Drawing.Point(137, 37);
            this.DateTimePickerVrijeme.Name = "DateTimePickerVrijeme";
            this.DateTimePickerVrijeme.ShowUpDown = true;
            this.DateTimePickerVrijeme.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerVrijeme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upišite datum leta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Upišite vrijeme polaska:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 184);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // buttonRezervacija
            // 
            this.buttonRezervacija.Location = new System.Drawing.Point(137, 251);
            this.buttonRezervacija.Name = "buttonRezervacija";
            this.buttonRezervacija.Size = new System.Drawing.Size(75, 23);
            this.buttonRezervacija.TabIndex = 5;
            this.buttonRezervacija.Text = "Rezervacija";
            this.buttonRezervacija.UseVisualStyleBackColor = true;
            this.buttonRezervacija.Click += new System.EventHandler(this.buttonRezervacija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRezervacija);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePickerVrijeme);
            this.Controls.Add(this.DateTimePickerDatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerDatum;
        private System.Windows.Forms.DateTimePicker DateTimePickerVrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonRezervacija;
    }
}

