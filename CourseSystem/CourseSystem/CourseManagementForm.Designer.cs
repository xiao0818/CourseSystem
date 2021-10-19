
namespace CourseSystem
{
    partial class CourseManagementForm
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
            this._comingSoonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _comingSoonLabel
            // 
            this._comingSoonLabel.AllowDrop = true;
            this._comingSoonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comingSoonLabel.Font = new System.Drawing.Font("DFKai-SB", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._comingSoonLabel.Location = new System.Drawing.Point(0, 0);
            this._comingSoonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._comingSoonLabel.Name = "_comingSoonLabel";
            this._comingSoonLabel.Size = new System.Drawing.Size(1200, 675);
            this._comingSoonLabel.TabIndex = 0;
            this._comingSoonLabel.Text = "Coming Soon";
            this._comingSoonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this._comingSoonLabel);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseManagementForm";
            this.Text = "QQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingFormCourseManagementForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _comingSoonLabel;
    }
}