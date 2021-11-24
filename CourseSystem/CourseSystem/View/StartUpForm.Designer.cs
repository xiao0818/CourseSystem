
namespace CourseSystem
{
    partial class StartUpForm
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
            this._courseSelectingFormButton = new System.Windows.Forms.Button();
            this._courseManagementFormButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _courseSelectingFormButton
            // 
            this._courseSelectingFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._courseSelectingFormButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._courseSelectingFormButton.Location = new System.Drawing.Point(0, 0);
            this._courseSelectingFormButton.Margin = new System.Windows.Forms.Padding(4);
            this._courseSelectingFormButton.Name = "_courseSelectingFormButton";
            this._courseSelectingFormButton.Size = new System.Drawing.Size(1200, 264);
            this._courseSelectingFormButton.TabIndex = 0;
            this._courseSelectingFormButton.Text = "Course Selecting System";
            this._courseSelectingFormButton.UseVisualStyleBackColor = true;
            this._courseSelectingFormButton.Click += new System.EventHandler(this.ClickCourseSelectingButton);
            // 
            // _courseManagementFormButton
            // 
            this._courseManagementFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._courseManagementFormButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._courseManagementFormButton.Location = new System.Drawing.Point(0, 264);
            this._courseManagementFormButton.Margin = new System.Windows.Forms.Padding(4);
            this._courseManagementFormButton.Name = "_courseManagementFormButton";
            this._courseManagementFormButton.Size = new System.Drawing.Size(1200, 264);
            this._courseManagementFormButton.TabIndex = 1;
            this._courseManagementFormButton.Text = "Course Management System";
            this._courseManagementFormButton.UseVisualStyleBackColor = true;
            this._courseManagementFormButton.Click += new System.EventHandler(this.ClickCourseManagementFormButton);
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitButton.Location = new System.Drawing.Point(882, 537);
            this._exitButton.Margin = new System.Windows.Forms.Padding(4);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(300, 120);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._courseManagementFormButton);
            this.Controls.Add(this._courseSelectingFormButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingFormStartUpForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _courseSelectingFormButton;
        private System.Windows.Forms.Button _courseManagementFormButton;
        private System.Windows.Forms.Button _exitButton;
    }
}