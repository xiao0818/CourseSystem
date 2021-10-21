
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
            this.managementTabControl = new System.Windows.Forms.TabControl();
            this.courseManagementTabPage = new System.Windows.Forms.TabPage();
            this.classManagementTabPage = new System.Windows.Forms.TabPage();
            this.comingSoonLabel = new System.Windows.Forms.Label();
            this.managementTabControl.SuspendLayout();
            this.classManagementTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // managementTabControl
            // 
            this.managementTabControl.Controls.Add(this.courseManagementTabPage);
            this.managementTabControl.Controls.Add(this.classManagementTabPage);
            this.managementTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managementTabControl.Location = new System.Drawing.Point(0, 0);
            this.managementTabControl.Name = "managementTabControl";
            this.managementTabControl.SelectedIndex = 0;
            this.managementTabControl.Size = new System.Drawing.Size(800, 450);
            this.managementTabControl.TabIndex = 0;
            // 
            // courseManagementTabPage
            // 
            this.courseManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this.courseManagementTabPage.Name = "courseManagementTabPage";
            this.courseManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.courseManagementTabPage.Size = new System.Drawing.Size(792, 424);
            this.courseManagementTabPage.TabIndex = 0;
            this.courseManagementTabPage.Text = "課程管理";
            this.courseManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // classManagementTabPage
            // 
            this.classManagementTabPage.Controls.Add(this.comingSoonLabel);
            this.classManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this.classManagementTabPage.Name = "classManagementTabPage";
            this.classManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classManagementTabPage.Size = new System.Drawing.Size(792, 424);
            this.classManagementTabPage.TabIndex = 1;
            this.classManagementTabPage.Text = "班級管理";
            this.classManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // comingSoonLabel
            // 
            this.comingSoonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comingSoonLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comingSoonLabel.Location = new System.Drawing.Point(3, 3);
            this.comingSoonLabel.Name = "comingSoonLabel";
            this.comingSoonLabel.Size = new System.Drawing.Size(786, 418);
            this.comingSoonLabel.TabIndex = 0;
            this.comingSoonLabel.Text = "coming soon";
            this.comingSoonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comingSoonLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managementTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseManagementForm";
            this.Text = "課程管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingFormCourseManagementForm);
            this.managementTabControl.ResumeLayout(false);
            this.classManagementTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl managementTabControl;
        private System.Windows.Forms.TabPage courseManagementTabPage;
        private System.Windows.Forms.TabPage classManagementTabPage;
        private System.Windows.Forms.Label comingSoonLabel;
    }
}