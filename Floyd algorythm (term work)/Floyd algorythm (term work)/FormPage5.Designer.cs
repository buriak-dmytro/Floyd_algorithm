
namespace Floyd_algorythm__term_work_
{
    partial class FormPage5
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
            this.components = new System.ComponentModel.Container();
            this.PanelPage4 = new System.Windows.Forms.Panel();
            this.ButtonExecuteAlgorythm = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonAcceptResults = new System.Windows.Forms.Button();
            this.PanelInitialMatrixData = new System.Windows.Forms.Panel();
            this.PanelResultsOfWork = new System.Windows.Forms.Panel();
            this.toolTipShowShortestPath = new System.Windows.Forms.ToolTip(this.components);
            this.PanelPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPage4
            // 
            this.PanelPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPage4.Controls.Add(this.ButtonExecuteAlgorythm);
            this.PanelPage4.Controls.Add(this.Label2);
            this.PanelPage4.Controls.Add(this.Label1);
            this.PanelPage4.Controls.Add(this.ButtonAcceptResults);
            this.PanelPage4.Controls.Add(this.PanelInitialMatrixData);
            this.PanelPage4.Controls.Add(this.PanelResultsOfWork);
            this.PanelPage4.Location = new System.Drawing.Point(10, 10);
            this.PanelPage4.Name = "PanelPage4";
            this.PanelPage4.Size = new System.Drawing.Size(330, 565);
            this.PanelPage4.TabIndex = 15;
            // 
            // ButtonExecuteAlgorythm
            // 
            this.ButtonExecuteAlgorythm.Location = new System.Drawing.Point(185, 250);
            this.ButtonExecuteAlgorythm.Name = "ButtonExecuteAlgorythm";
            this.ButtonExecuteAlgorythm.Size = new System.Drawing.Size(135, 25);
            this.ButtonExecuteAlgorythm.TabIndex = 10;
            this.ButtonExecuteAlgorythm.Text = "Execute algorythm";
            this.ButtonExecuteAlgorythm.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 290);
            this.Label2.MinimumSize = new System.Drawing.Size(0, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(180, 20);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Results of Floyd algorythm work:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 10);
            this.Label1.MinimumSize = new System.Drawing.Size(0, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(132, 20);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Initial adjacency matrix:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAcceptResults
            // 
            this.ButtonAcceptResults.Location = new System.Drawing.Point(185, 530);
            this.ButtonAcceptResults.Name = "ButtonAcceptResults";
            this.ButtonAcceptResults.Size = new System.Drawing.Size(135, 25);
            this.ButtonAcceptResults.TabIndex = 9;
            this.ButtonAcceptResults.Text = "Accept results";
            this.ButtonAcceptResults.UseVisualStyleBackColor = true;
            // 
            // PanelInitialMatrixData
            // 
            this.PanelInitialMatrixData.AutoScroll = true;
            this.PanelInitialMatrixData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelInitialMatrixData.Location = new System.Drawing.Point(10, 40);
            this.PanelInitialMatrixData.Name = "PanelInitialMatrixData";
            this.PanelInitialMatrixData.Size = new System.Drawing.Size(310, 200);
            this.PanelInitialMatrixData.TabIndex = 5;
            // 
            // PanelResultsOfWork
            // 
            this.PanelResultsOfWork.AutoScroll = true;
            this.PanelResultsOfWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelResultsOfWork.Location = new System.Drawing.Point(10, 320);
            this.PanelResultsOfWork.Name = "PanelResultsOfWork";
            this.PanelResultsOfWork.Size = new System.Drawing.Size(310, 200);
            this.PanelResultsOfWork.TabIndex = 6;
            // 
            // FormPage5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 586);
            this.Controls.Add(this.PanelPage4);
            this.Name = "FormPage5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floyd algorythm";
            this.Load += new System.EventHandler(this.FormPage5_Load);
            this.PanelPage4.ResumeLayout(false);
            this.PanelPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPage4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ButtonAcceptResults;
        private System.Windows.Forms.Panel PanelInitialMatrixData;
        private System.Windows.Forms.Panel PanelResultsOfWork;
        private System.Windows.Forms.ToolTip toolTipShowShortestPath;
        private System.Windows.Forms.Button ButtonExecuteAlgorythm;
    }
}