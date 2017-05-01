namespace Winform_demo3
{
    partial class Demo3FormRichTextBox
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
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonChangeBG = new System.Windows.Forms.Button();
            this.buttonNextpage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDisplay.Location = new System.Drawing.Point(323, 51);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.Size = new System.Drawing.Size(330, 160);
            this.richTextBoxDisplay.TabIndex = 0;
            this.richTextBoxDisplay.Text = "";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFile.Location = new System.Drawing.Point(69, 51);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(171, 69);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open a text file";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonChangeBG
            // 
            this.buttonChangeBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeBG.Location = new System.Drawing.Point(69, 167);
            this.buttonChangeBG.Name = "buttonChangeBG";
            this.buttonChangeBG.Size = new System.Drawing.Size(171, 69);
            this.buttonChangeBG.TabIndex = 2;
            this.buttonChangeBG.Text = "Change background color";
            this.buttonChangeBG.UseVisualStyleBackColor = true;
            this.buttonChangeBG.Click += new System.EventHandler(this.buttonChangeBG_Click);
            this.buttonChangeBG.MouseLeave += new System.EventHandler(this.buttonChangeBG_MouseLeave);
            this.buttonChangeBG.MouseHover += new System.EventHandler(this.buttonChangeBG_MouseHover);
            // 
            // buttonNextpage
            // 
            this.buttonNextpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextpage.Location = new System.Drawing.Point(69, 283);
            this.buttonNextpage.Name = "buttonNextpage";
            this.buttonNextpage.Size = new System.Drawing.Size(171, 69);
            this.buttonNextpage.TabIndex = 3;
            this.buttonNextpage.Text = "Go to next page";
            this.buttonNextpage.UseVisualStyleBackColor = true;
            this.buttonNextpage.Click += new System.EventHandler(this.buttonNextpage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 398);
            this.Controls.Add(this.buttonNextpage);
            this.Controls.Add(this.buttonChangeBG);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.richTextBoxDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonChangeBG;
        private System.Windows.Forms.Button buttonNextpage;
    }
}

