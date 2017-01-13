namespace ManagementObjectSearcher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.arrayFormat_CB = new System.Windows.Forms.CheckBox();
            this.namesOnly_CB = new System.Windows.Forms.CheckBox();
            this.newLine_CB = new System.Windows.Forms.CheckBox();
            this.notNull_CB = new System.Windows.Forms.CheckBox();
            this.output_BTN = new System.Windows.Forms.Button();
            this.class_ET = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.output_ET = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.arrayFormat_CB);
            this.panel1.Controls.Add(this.namesOnly_CB);
            this.panel1.Controls.Add(this.newLine_CB);
            this.panel1.Controls.Add(this.notNull_CB);
            this.panel1.Controls.Add(this.output_BTN);
            this.panel1.Controls.Add(this.class_ET);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 26);
            this.panel1.TabIndex = 8;
            // 
            // arrayFormat_CB
            // 
            this.arrayFormat_CB.AutoSize = true;
            this.arrayFormat_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.arrayFormat_CB.Location = new System.Drawing.Point(452, -1);
            this.arrayFormat_CB.Name = "arrayFormat_CB";
            this.arrayFormat_CB.Size = new System.Drawing.Size(105, 21);
            this.arrayFormat_CB.TabIndex = 13;
            this.arrayFormat_CB.Text = "Array format";
            this.arrayFormat_CB.UseVisualStyleBackColor = true;
            // 
            // namesOnly_CB
            // 
            this.namesOnly_CB.AutoSize = true;
            this.namesOnly_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.namesOnly_CB.Location = new System.Drawing.Point(345, -1);
            this.namesOnly_CB.Name = "namesOnly_CB";
            this.namesOnly_CB.Size = new System.Drawing.Size(101, 21);
            this.namesOnly_CB.TabIndex = 12;
            this.namesOnly_CB.Text = "Names only";
            this.namesOnly_CB.UseVisualStyleBackColor = true;
            // 
            // newLine_CB
            // 
            this.newLine_CB.AutoSize = true;
            this.newLine_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.newLine_CB.Location = new System.Drawing.Point(259, -1);
            this.newLine_CB.Name = "newLine_CB";
            this.newLine_CB.Size = new System.Drawing.Size(80, 21);
            this.newLine_CB.TabIndex = 11;
            this.newLine_CB.Text = "New line";
            this.newLine_CB.UseVisualStyleBackColor = true;
            // 
            // notNull_CB
            // 
            this.notNull_CB.AutoSize = true;
            this.notNull_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.notNull_CB.Location = new System.Drawing.Point(178, -1);
            this.notNull_CB.Name = "notNull_CB";
            this.notNull_CB.Size = new System.Drawing.Size(75, 21);
            this.notNull_CB.TabIndex = 10;
            this.notNull_CB.Text = "Not null";
            this.notNull_CB.UseVisualStyleBackColor = true;
            // 
            // output_BTN
            // 
            this.output_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.output_BTN.Location = new System.Drawing.Point(563, -1);
            this.output_BTN.Name = "output_BTN";
            this.output_BTN.Size = new System.Drawing.Size(143, 24);
            this.output_BTN.TabIndex = 9;
            this.output_BTN.Text = "Output";
            this.output_BTN.UseVisualStyleBackColor = true;
            this.output_BTN.Click += new System.EventHandler(this.output_BTN_Click);
            // 
            // class_ET
            // 
            this.class_ET.Location = new System.Drawing.Point(49, 0);
            this.class_ET.Name = "class_ET";
            this.class_ET.Size = new System.Drawing.Size(123, 20);
            this.class_ET.TabIndex = 8;
            this.class_ET.Text = "Win32_Processor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Class:";
            // 
            // output_ET
            // 
            this.output_ET.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_ET.Location = new System.Drawing.Point(10, 36);
            this.output_ET.Multiline = true;
            this.output_ET.Name = "output_ET";
            this.output_ET.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_ET.Size = new System.Drawing.Size(706, 561);
            this.output_ET.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 607);
            this.Controls.Add(this.output_ET);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox arrayFormat_CB;
        private System.Windows.Forms.CheckBox namesOnly_CB;
        private System.Windows.Forms.CheckBox newLine_CB;
        private System.Windows.Forms.CheckBox notNull_CB;
        private System.Windows.Forms.Button output_BTN;
        private System.Windows.Forms.TextBox class_ET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output_ET;
    }
}

