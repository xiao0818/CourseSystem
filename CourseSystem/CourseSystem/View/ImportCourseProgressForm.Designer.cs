
namespace CourseSystem
{
    partial class ImportCourseProgressForm
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
            this._progressLabel = new System.Windows.Forms.Label();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // _progressLabel
            // 
            this._progressLabel.AutoSize = true;
            this._progressLabel.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._progressLabel.Location = new System.Drawing.Point(12, 92);
            this._progressLabel.Name = "_progressLabel";
            this._progressLabel.Size = new System.Drawing.Size(226, 24);
            this._progressLabel.TabIndex = 0;
            this._progressLabel.Text = "正在匯入課程....0%";
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(16, 119);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(572, 58);
            this._progressBar.TabIndex = 1;
            // 
            // ImportCourseProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._progressLabel);
            this.Name = "ImportCourseProgressForm";
            this.Text = "ImportCourseProgressForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingImportCourseProgressForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _progressLabel;
        private System.Windows.Forms.ProgressBar _progressBar;
    }
}