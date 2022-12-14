
namespace Floyd_algorythm__term_work_
{
    partial class FormPage1
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonEnd = new System.Windows.Forms.Button();
            this.PanelPage1 = new System.Windows.Forms.Panel();
            this.PanelPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(75, 25);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(100, 25);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start program";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonEnd
            // 
            this.ButtonEnd.Location = new System.Drawing.Point(75, 60);
            this.ButtonEnd.Name = "ButtonEnd";
            this.ButtonEnd.Size = new System.Drawing.Size(100, 25);
            this.ButtonEnd.TabIndex = 1;
            this.ButtonEnd.Text = "End program";
            this.ButtonEnd.UseVisualStyleBackColor = true;
            this.ButtonEnd.Click += new System.EventHandler(this.ButtonEnd_Click);
            // 
            // PanelPage1
            // 
            this.PanelPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPage1.Controls.Add(this.ButtonEnd);
            this.PanelPage1.Controls.Add(this.ButtonStart);
            this.PanelPage1.Location = new System.Drawing.Point(10, 10);
            this.PanelPage1.Name = "PanelPage1";
            this.PanelPage1.Size = new System.Drawing.Size(255, 110);
            this.PanelPage1.TabIndex = 5;
            // 
            // FormPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 131);
            this.Controls.Add(this.PanelPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPage1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floyd algorythm";
            this.PanelPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonEnd;
        private System.Windows.Forms.Panel PanelPage1;
    }
}

