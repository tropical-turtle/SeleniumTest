namespace SeleniumTest
{
    partial class mainForm
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
            this.btnTestWithChrome = new System.Windows.Forms.Button();
            this.btnTestWithFireFox = new System.Windows.Forms.Button();
            this.rtBoxPossibleExceptionMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTestWithChrome
            // 
            this.btnTestWithChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestWithChrome.Location = new System.Drawing.Point(17, 486);
            this.btnTestWithChrome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTestWithChrome.Name = "btnTestWithChrome";
            this.btnTestWithChrome.Size = new System.Drawing.Size(185, 66);
            this.btnTestWithChrome.TabIndex = 0;
            this.btnTestWithChrome.Text = "Test with Chrome";
            this.btnTestWithChrome.UseVisualStyleBackColor = true;
            this.btnTestWithChrome.Click += new System.EventHandler(this.btnTestWithChrome_Click);
            // 
            // btnTestWithFireFox
            // 
            this.btnTestWithFireFox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestWithFireFox.Location = new System.Drawing.Point(587, 486);
            this.btnTestWithFireFox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTestWithFireFox.Name = "btnTestWithFireFox";
            this.btnTestWithFireFox.Size = new System.Drawing.Size(189, 66);
            this.btnTestWithFireFox.TabIndex = 1;
            this.btnTestWithFireFox.Text = "Test with Firefox";
            this.btnTestWithFireFox.UseVisualStyleBackColor = true;
            this.btnTestWithFireFox.Click += new System.EventHandler(this.btnTestWithFireFox_Click);
            // 
            // rtBoxPossibleExceptionMessage
            // 
            this.rtBoxPossibleExceptionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtBoxPossibleExceptionMessage.Location = new System.Drawing.Point(17, 78);
            this.rtBoxPossibleExceptionMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtBoxPossibleExceptionMessage.Name = "rtBoxPossibleExceptionMessage";
            this.rtBoxPossibleExceptionMessage.Size = new System.Drawing.Size(759, 370);
            this.rtBoxPossibleExceptionMessage.TabIndex = 2;
            this.rtBoxPossibleExceptionMessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test Result";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtBoxPossibleExceptionMessage);
            this.Controls.Add(this.btnTestWithFireFox);
            this.Controls.Add(this.btnTestWithChrome);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.Text = "Searfarer Test with Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestWithChrome;
        private System.Windows.Forms.Button btnTestWithFireFox;
        private System.Windows.Forms.RichTextBox rtBoxPossibleExceptionMessage;
        private System.Windows.Forms.Label label1;
    }
}

