namespace Lab2
{
    partial class Form4
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
            this.vacationList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.AirToBox = new System.Windows.Forms.TextBox();
            this.AirFromBox = new System.Windows.Forms.TextBox();
            this.CToBox = new System.Windows.Forms.TextBox();
            this.CFromBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vacationList
            // 
            this.vacationList.FormattingEnabled = true;
            this.vacationList.Location = new System.Drawing.Point(12, 12);
            this.vacationList.Name = "vacationList";
            this.vacationList.Size = new System.Drawing.Size(262, 147);
            this.vacationList.TabIndex = 0;
            this.vacationList.SelectedValueChanged += new System.EventHandler(this.vacationList_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Offer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(455, 169);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 24;
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(330, 169);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.ReadOnly = true;
            this.DurationBox.Size = new System.Drawing.Size(100, 20);
            this.DurationBox.TabIndex = 23;
            // 
            // AirToBox
            // 
            this.AirToBox.Location = new System.Drawing.Point(455, 116);
            this.AirToBox.Name = "AirToBox";
            this.AirToBox.ReadOnly = true;
            this.AirToBox.Size = new System.Drawing.Size(100, 20);
            this.AirToBox.TabIndex = 22;
            // 
            // AirFromBox
            // 
            this.AirFromBox.Location = new System.Drawing.Point(330, 116);
            this.AirFromBox.Name = "AirFromBox";
            this.AirFromBox.ReadOnly = true;
            this.AirFromBox.Size = new System.Drawing.Size(100, 20);
            this.AirFromBox.TabIndex = 21;
            // 
            // CToBox
            // 
            this.CToBox.Location = new System.Drawing.Point(455, 62);
            this.CToBox.Name = "CToBox";
            this.CToBox.ReadOnly = true;
            this.CToBox.Size = new System.Drawing.Size(100, 20);
            this.CToBox.TabIndex = 20;
            // 
            // CFromBox
            // 
            this.CFromBox.Location = new System.Drawing.Point(330, 62);
            this.CFromBox.Name = "CFromBox";
            this.CFromBox.ReadOnly = true;
            this.CFromBox.Size = new System.Drawing.Size(100, 20);
            this.CFromBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(460, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(330, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(460, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Airport to(city):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(330, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Airport from(city):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(460, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Country to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(330, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Country from:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(340, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 25);
            this.labelName.TabIndex = 25;
            this.labelName.Text = "Name";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 205);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.AirToBox);
            this.Controls.Add(this.AirFromBox);
            this.Controls.Add(this.CToBox);
            this.Controls.Add(this.CFromBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vacationList);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox vacationList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox DurationBox;
        private System.Windows.Forms.TextBox AirToBox;
        private System.Windows.Forms.TextBox AirFromBox;
        private System.Windows.Forms.TextBox CToBox;
        private System.Windows.Forms.TextBox CFromBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
    }
}