
namespace Floyd_algorythm__term_work_
{
    partial class FormPage4
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
            this.PanelPage4 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonConfirmMatrixData = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.RichTextBoxMatrixData = new System.Windows.Forms.RichTextBox();
            this.PanelPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPage4
            // 
            this.PanelPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPage4.Controls.Add(this.Label1);
            this.PanelPage4.Controls.Add(this.ButtonConfirmMatrixData);
            this.PanelPage4.Controls.Add(this.Label2);
            this.PanelPage4.Controls.Add(this.RichTextBoxMatrixData);
            this.PanelPage4.Location = new System.Drawing.Point(10, 10);
            this.PanelPage4.Name = "PanelPage4";
            this.PanelPage4.Size = new System.Drawing.Size(330, 325);
            this.PanelPage4.TabIndex = 14;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 10);
            this.Label1.MaximumSize = new System.Drawing.Size(200, 0);
            this.Label1.MinimumSize = new System.Drawing.Size(0, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(102, 20);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Adjacency matrix:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonConfirmMatrixData
            // 
            this.ButtonConfirmMatrixData.Location = new System.Drawing.Point(250, 290);
            this.ButtonConfirmMatrixData.Name = "ButtonConfirmMatrixData";
            this.ButtonConfirmMatrixData.Size = new System.Drawing.Size(70, 25);
            this.ButtonConfirmMatrixData.TabIndex = 11;
            this.ButtonConfirmMatrixData.Text = "Confirm";
            this.ButtonConfirmMatrixData.UseVisualStyleBackColor = true;
            this.ButtonConfirmMatrixData.Click += new System.EventHandler(this.ButtonConfirmMatrixData_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label2.Location = new System.Drawing.Point(10, 35);
            this.Label2.MinimumSize = new System.Drawing.Size(0, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(308, 30);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "(use \' \' (space) and \'\\n\' (line feed) only for matrix markup;\r\nuse \"inf\" to indic" +
    "ate absence of arc)";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RichTextBoxMatrixData
            // 
            this.RichTextBoxMatrixData.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBoxMatrixData.Location = new System.Drawing.Point(10, 80);
            this.RichTextBoxMatrixData.Name = "RichTextBoxMatrixData";
            this.RichTextBoxMatrixData.Size = new System.Drawing.Size(310, 200);
            this.RichTextBoxMatrixData.TabIndex = 10;
            this.RichTextBoxMatrixData.Text = "";
            this.RichTextBoxMatrixData.WordWrap = false;
            // 
            // FormPage4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 346);
            this.Controls.Add(this.PanelPage4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPage4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floyd algorithm";
            this.PanelPage4.ResumeLayout(false);
            this.PanelPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPage4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ButtonConfirmMatrixData;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.RichTextBox RichTextBoxMatrixData;
    }
}