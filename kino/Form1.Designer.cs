namespace kino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.Location = new System.Drawing.Point(8, 12);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(208, 52);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "Poniedziałek";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.Click += new System.EventHandler(this.dniTygodnia);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Wtroek";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Środa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(653, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Czwartek";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(867, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 52);
            this.button5.TabIndex = 7;
            this.button5.Text = "Piątek";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1081, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 52);
            this.button6.TabIndex = 6;
            this.button6.Text = "Sobota";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1295, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 52);
            this.button7.TabIndex = 5;
            this.button7.Text = "niedziela";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.Location = new System.Drawing.Point(1025, 548);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 61);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 925);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button checkBox;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private CheckBox checkBox1;
    }
}