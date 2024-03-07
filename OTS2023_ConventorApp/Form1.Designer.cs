namespace OTS2023_ConventorApp
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
            this.lblLabela1 = new System.Windows.Forms.Label();
            this.lblLabela2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Mass = new System.Windows.Forms.RadioButton();
            this.LEngth = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLabela1
            // 
            this.lblLabela1.AutoSize = true;
            this.lblLabela1.Location = new System.Drawing.Point(285, 207);
            this.lblLabela1.Name = "lblLabela1";
            this.lblLabela1.Size = new System.Drawing.Size(23, 13);
            this.lblLabela1.TabIndex = 0;
            this.lblLabela1.Text = "lbl1";
            // 
            // lblLabela2
            // 
            this.lblLabela2.AutoSize = true;
            this.lblLabela2.Location = new System.Drawing.Point(285, 245);
            this.lblLabela2.Name = "lblLabela2";
            this.lblLabela2.Size = new System.Drawing.Size(23, 13);
            this.lblLabela2.TabIndex = 1;
            this.lblLabela2.Text = "lbl2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Mass
            // 
            this.Mass.AutoSize = true;
            this.Mass.Location = new System.Drawing.Point(351, 79);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(50, 17);
            this.Mass.TabIndex = 4;
            this.Mass.TabStop = true;
            this.Mass.Text = "Mass";
            this.Mass.UseVisualStyleBackColor = true;
            this.Mass.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LEngth
            // 
            this.LEngth.AutoSize = true;
            this.LEngth.Location = new System.Drawing.Point(351, 119);
            this.LEngth.Name = "LEngth";
            this.LEngth.Size = new System.Drawing.Size(58, 17);
            this.LEngth.TabIndex = 5;
            this.LEngth.TabStop = true;
            this.LEngth.Text = "Length";
            this.LEngth.UseVisualStyleBackColor = true;
            this.LEngth.CheckedChanged += new System.EventHandler(this.LEngth_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LEngth);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLabela2);
            this.Controls.Add(this.lblLabela1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabela1;
        private System.Windows.Forms.Label lblLabela2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton Mass;
        private System.Windows.Forms.RadioButton LEngth;
        private System.Windows.Forms.Button button1;
    }
}

