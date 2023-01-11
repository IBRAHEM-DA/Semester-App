
namespace SemesterManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGradeCalc = new System.Windows.Forms.Button();
            this.btnAdmiInfo = new System.Windows.Forms.Button();
            this.btnLecturerInfo = new System.Windows.Forms.Button();
            this.btnCoursesSyllabus = new System.Windows.Forms.Button();
            this.btnWeeklySch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 140);
            this.label1.TabIndex = 6;
            this.label1.Text = "Semester Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGradeCalc
            // 
            this.btnGradeCalc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGradeCalc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGradeCalc.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeCalc.Location = new System.Drawing.Point(185, 495);
            this.btnGradeCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGradeCalc.Name = "btnGradeCalc";
            this.btnGradeCalc.Size = new System.Drawing.Size(255, 49);
            this.btnGradeCalc.TabIndex = 11;
            this.btnGradeCalc.Text = "Grade Calculator";
            this.btnGradeCalc.UseVisualStyleBackColor = false;
            this.btnGradeCalc.Click += new System.EventHandler(this.btnGradeCalc_Click);
            // 
            // btnAdmiInfo
            // 
            this.btnAdmiInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdmiInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdmiInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdmiInfo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmiInfo.Location = new System.Drawing.Point(185, 414);
            this.btnAdmiInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmiInfo.Name = "btnAdmiInfo";
            this.btnAdmiInfo.Size = new System.Drawing.Size(255, 49);
            this.btnAdmiInfo.TabIndex = 10;
            this.btnAdmiInfo.Text = "Administration Info";
            this.btnAdmiInfo.UseVisualStyleBackColor = false;
            this.btnAdmiInfo.Click += new System.EventHandler(this.btnAdmiInfo_Click);
            // 
            // btnLecturerInfo
            // 
            this.btnLecturerInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLecturerInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLecturerInfo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturerInfo.Location = new System.Drawing.Point(185, 333);
            this.btnLecturerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLecturerInfo.Name = "btnLecturerInfo";
            this.btnLecturerInfo.Size = new System.Drawing.Size(255, 49);
            this.btnLecturerInfo.TabIndex = 9;
            this.btnLecturerInfo.Text = "Lecturer Info";
            this.btnLecturerInfo.UseVisualStyleBackColor = false;
            this.btnLecturerInfo.Click += new System.EventHandler(this.btnLecturerInfo_Click);
            // 
            // btnCoursesSyllabus
            // 
            this.btnCoursesSyllabus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCoursesSyllabus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCoursesSyllabus.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoursesSyllabus.Location = new System.Drawing.Point(185, 252);
            this.btnCoursesSyllabus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCoursesSyllabus.Name = "btnCoursesSyllabus";
            this.btnCoursesSyllabus.Size = new System.Drawing.Size(255, 49);
            this.btnCoursesSyllabus.TabIndex = 8;
            this.btnCoursesSyllabus.Text = "Course\'s Syllabus";
            this.btnCoursesSyllabus.UseVisualStyleBackColor = false;
            this.btnCoursesSyllabus.Click += new System.EventHandler(this.btnCoursesSyllabus_Click);
            // 
            // btnWeeklySch
            // 
            this.btnWeeklySch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWeeklySch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWeeklySch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWeeklySch.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklySch.Location = new System.Drawing.Point(185, 171);
            this.btnWeeklySch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeeklySch.Name = "btnWeeklySch";
            this.btnWeeklySch.Size = new System.Drawing.Size(255, 49);
            this.btnWeeklySch.TabIndex = 7;
            this.btnWeeklySch.Text = "Weekly Schedule";
            this.btnWeeklySch.UseVisualStyleBackColor = false;
            this.btnWeeklySch.Click += new System.EventHandler(this.btnWeeklySch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 566);
            this.Controls.Add(this.btnGradeCalc);
            this.Controls.Add(this.btnAdmiInfo);
            this.Controls.Add(this.btnLecturerInfo);
            this.Controls.Add(this.btnCoursesSyllabus);
            this.Controls.Add(this.btnWeeklySch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semester Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGradeCalc;
        private System.Windows.Forms.Button btnAdmiInfo;
        private System.Windows.Forms.Button btnLecturerInfo;
        private System.Windows.Forms.Button btnCoursesSyllabus;
        private System.Windows.Forms.Button btnWeeklySch;
    }
}