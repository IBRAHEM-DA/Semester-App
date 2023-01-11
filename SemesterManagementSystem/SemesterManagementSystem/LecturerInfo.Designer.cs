
namespace SemesterManagementSystem
{
    partial class LecturerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerInfo));
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCourses
            // 
            this.cmbCourses.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(283, 93);
            this.cmbCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(300, 28);
            this.cmbCourses.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(204, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Course :";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShow.Location = new System.Drawing.Point(604, 81);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 50);
            this.btnShow.TabIndex = 20;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 143);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 116);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 19.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(318, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lecturer Info";
            // 
            // LecturerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SemesterManagementSystem.Properties.Resources.windows;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 270);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LecturerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
    }
}