
namespace Floyd_algorythm__term_work_
{
    partial class FormPage2
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
            this.PanelPage2 = new System.Windows.Forms.Panel();
            this.ButtonFile = new System.Windows.Forms.Button();
            this.ButtonManualInput = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.PanelPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPage2
            // 
            this.PanelPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPage2.Controls.Add(this.ButtonFile);
            this.PanelPage2.Controls.Add(this.ButtonManualInput);
            this.PanelPage2.Controls.Add(this.Label1);
            this.PanelPage2.Location = new System.Drawing.Point(10, 10);
            this.PanelPage2.Name = "PanelPage2";
            this.PanelPage2.Size = new System.Drawing.Size(255, 110);
            this.PanelPage2.TabIndex = 4;
            // 
            // ButtonFile
            // 
            this.ButtonFile.Location = new System.Drawing.Point(55, 40);
            this.ButtonFile.Name = "ButtonFile";
            this.ButtonFile.Size = new System.Drawing.Size(150, 25);
            this.ButtonFile.TabIndex = 1;
            this.ButtonFile.Text = "File";
            this.ButtonFile.UseVisualStyleBackColor = true;
            this.ButtonFile.Click += new System.EventHandler(this.ButtonFile_Click);
            // 
            // ButtonManualInput
            // 
            this.ButtonManualInput.Location = new System.Drawing.Point(55, 75);
            this.ButtonManualInput.Name = "ButtonManualInput";
            this.ButtonManualInput.Size = new System.Drawing.Size(150, 25);
            this.ButtonManualInput.TabIndex = 2;
            this.ButtonManualInput.Text = "Manual input";
            this.ButtonManualInput.UseVisualStyleBackColor = true;
            this.ButtonManualInput.Click += new System.EventHandler(this.ButtonManualInput_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 10);
            this.Label1.MinimumSize = new System.Drawing.Size(240, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(240, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Get adjacency matrix from:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 131);
            this.Controls.Add(this.PanelPage2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPage2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floyd algorythm";
            this.PanelPage2.ResumeLayout(false);
            this.PanelPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPage2;
        private System.Windows.Forms.Button ButtonFile;
        private System.Windows.Forms.Button ButtonManualInput;
        private System.Windows.Forms.Label Label1;
    }
}