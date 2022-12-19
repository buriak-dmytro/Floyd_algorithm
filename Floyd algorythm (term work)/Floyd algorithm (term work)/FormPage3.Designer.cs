
namespace Floyd_algorythm__term_work_
{
    partial class FormPage3
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
            this.PanelPage3 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonConfirmFilePath = new System.Windows.Forms.Button();
            this.TextBoxFilePath = new System.Windows.Forms.TextBox();
            this.PanelPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPage3
            // 
            this.PanelPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPage3.Controls.Add(this.Label1);
            this.PanelPage3.Controls.Add(this.ButtonConfirmFilePath);
            this.PanelPage3.Controls.Add(this.TextBoxFilePath);
            this.PanelPage3.Location = new System.Drawing.Point(10, 10);
            this.PanelPage3.Name = "PanelPage3";
            this.PanelPage3.Size = new System.Drawing.Size(255, 110);
            this.PanelPage3.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 10);
            this.Label1.MinimumSize = new System.Drawing.Size(0, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 20);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "File path:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonConfirmFilePath
            // 
            this.ButtonConfirmFilePath.Location = new System.Drawing.Point(175, 75);
            this.ButtonConfirmFilePath.Name = "ButtonConfirmFilePath";
            this.ButtonConfirmFilePath.Size = new System.Drawing.Size(70, 25);
            this.ButtonConfirmFilePath.TabIndex = 6;
            this.ButtonConfirmFilePath.Text = "Confirm";
            this.ButtonConfirmFilePath.UseVisualStyleBackColor = true;
            this.ButtonConfirmFilePath.Click += new System.EventHandler(this.ButtonConfirmFilePath_Click);
            // 
            // TextBoxFilePath
            // 
            this.TextBoxFilePath.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFilePath.Location = new System.Drawing.Point(10, 40);
            this.TextBoxFilePath.MinimumSize = new System.Drawing.Size(4, 25);
            this.TextBoxFilePath.Name = "TextBoxFilePath";
            this.TextBoxFilePath.Size = new System.Drawing.Size(235, 21);
            this.TextBoxFilePath.TabIndex = 5;
            // 
            // FormPage3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 131);
            this.Controls.Add(this.PanelPage3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPage3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floyd algorithm";
            this.PanelPage3.ResumeLayout(false);
            this.PanelPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPage3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ButtonConfirmFilePath;
        private System.Windows.Forms.TextBox TextBoxFilePath;
    }
}