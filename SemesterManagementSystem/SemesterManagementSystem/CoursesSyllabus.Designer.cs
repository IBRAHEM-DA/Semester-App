
namespace SemesterManagementSystem
{
    partial class CoursesSyllabus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesSyllabus));
            this.btnShow = new System.Windows.Forms.Button();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.tblCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataDataSet = new SemesterManagementSystem.MyDataDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblCoursesTableAdapter = new SemesterManagementSystem.MyDataDataSetTableAdapters.TblCoursesTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCoursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCoursesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new SemesterManagementSystem.MyDataDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShow.Location = new System.Drawing.Point(649, 72);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 50);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // cmbCourses
            // 
            this.cmbCourses.DataSource = this.tblCoursesBindingSource;
            this.cmbCourses.DisplayMember = "CName";
            this.cmbCourses.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(316, 84);
            this.cmbCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(300, 28);
            this.cmbCourses.TabIndex = 14;
            this.cmbCourses.ValueMember = "Id";
            // 
            // tblCoursesBindingSource
            // 
            this.tblCoursesBindingSource.DataMember = "TblCourses";
            this.tblCoursesBindingSource.DataSource = this.myDataDataSet;
            // 
            // myDataDataSet
            // 
            this.myDataDataSet.DataSetName = "MyDataDataSet";
            this.myDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 19.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(333, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Course\'s Syllabus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(237, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Course :";
            // 
            // tblCoursesTableAdapter
            // 
            this.tblCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // myDataDataSetBindingSource
            // 
            this.myDataDataSetBindingSource.DataSource = this.myDataDataSet;
            this.myDataDataSetBindingSource.Position = 0;
            // 
            // myDataDataSetBindingSource1
            // 
            this.myDataDataSetBindingSource1.DataSource = this.myDataDataSet;
            this.myDataDataSetBindingSource1.Position = 0;
            // 
            // tblCoursesBindingSource1
            // 
            this.tblCoursesBindingSource1.DataMember = "TblCourses";
            this.tblCoursesBindingSource1.DataSource = this.myDataDataSet;
            // 
            // tblCoursesBindingSource2
            // 
            this.tblCoursesBindingSource2.DataMember = "TblCourses";
            this.tblCoursesBindingSource2.DataSource = this.myDataDataSet;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TblCoursesTableAdapter = this.tblCoursesTableAdapter;
            this.tableAdapterManager1.TblStuffTableAdapter = null;
            this.tableAdapterManager1.TblWeeklyLuzeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SemesterManagementSystem.MyDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CoursesSyllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SemesterManagementSystem.Properties.Resources.windows;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 505);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoursesSyllabus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course\'s Syllabus";
            this.Load += new System.EventHandler(this.CoursesSyllabus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MyDataDataSet myDataDataSet;
        private System.Windows.Forms.BindingSource tblCoursesBindingSource;
        private MyDataDataSetTableAdapters.TblCoursesTableAdapter tblCoursesTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource myDataDataSetBindingSource;
        private System.Windows.Forms.BindingSource myDataDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tblCoursesBindingSource1;
        private System.Windows.Forms.BindingSource tblCoursesBindingSource2;
        private MyDataDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}