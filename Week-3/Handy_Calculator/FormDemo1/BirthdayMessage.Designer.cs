namespace FormDemo1
{
    partial class BirthdayMessage
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
            this.textboxName = new System.Windows.Forms.TextBox();
            this.lableName = new System.Windows.Forms.Label();
            this.lableDOB = new System.Windows.Forms.Label();
            this.lableBirthdayMS = new System.Windows.Forms.Label();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(239, 34);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(200, 20);
            this.textboxName.TabIndex = 0;
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Location = new System.Drawing.Point(47, 34);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(118, 13);
            this.lableName.TabIndex = 1;
            this.lableName.Text = "Please enter your name";
            // 
            // lableDOB
            // 
            this.lableDOB.AutoSize = true;
            this.lableDOB.Location = new System.Drawing.Point(47, 91);
            this.lableDOB.Name = "lableDOB";
            this.lableDOB.Size = new System.Drawing.Size(148, 13);
            this.lableDOB.TabIndex = 2;
            this.lableDOB.Text = "Please enter your date of birth";
            // 
            // lableBirthdayMS
            // 
            this.lableBirthdayMS.AutoSize = true;
            this.lableBirthdayMS.Location = new System.Drawing.Point(60, 259);
            this.lableBirthdayMS.Name = "lableBirthdayMS";
            this.lableBirthdayMS.Size = new System.Drawing.Size(35, 13);
            this.lableBirthdayMS.TabIndex = 3;
            this.lableBirthdayMS.Text = "label3";
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Location = new System.Drawing.Point(239, 91);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDOB.TabIndex = 4;
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(118, 176);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(248, 23);
            this.btnShowMessage.TabIndex = 5;
            this.btnShowMessage.Text = "Click to get your birthday message";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BirthdayMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowMessage);
            this.Controls.Add(this.dateTimeDOB);
            this.Controls.Add(this.lableBirthdayMS);
            this.Controls.Add(this.lableDOB);
            this.Controls.Add(this.lableName);
            this.Controls.Add(this.textboxName);
            this.Name = "BirthdayMessage";
            this.Text = "BirthdayMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.Label lableDOB;
        private System.Windows.Forms.Label lableBirthdayMS;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
        private System.Windows.Forms.Button btnShowMessage;
        private System.Windows.Forms.Button button2;
    }
}

