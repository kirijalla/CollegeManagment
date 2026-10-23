namespace CollegeManagment
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewApplicantList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxApplicantInformation = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxApplicatnId = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelApplicantId = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxWbinarInformation = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelWebinarCode = new System.Windows.Forms.Label();
            this.labelWebinarName = new System.Windows.Forms.Label();
            this.labelTotalHour = new System.Windows.Forms.Label();
            this.textBoxWebinarCode = new System.Windows.Forms.TextBox();
            this.textBoxWebinarName = new System.Windows.Forms.TextBox();
            this.textBoxTotalHour = new System.Windows.Forms.TextBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicantList)).BeginInit();
            this.groupBoxApplicantInformation.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxWbinarInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 447);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewApplicantList);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonEdit);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.groupBoxApplicantInformation);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Applicants";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridViewApplicantList
            // 
            this.dataGridViewApplicantList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplicantList.Location = new System.Drawing.Point(31, 257);
            this.dataGridViewApplicantList.Name = "dataGridViewApplicantList";
            this.dataGridViewApplicantList.RowHeadersWidth = 51;
            this.dataGridViewApplicantList.RowTemplate.Height = 24;
            this.dataGridViewApplicantList.Size = new System.Drawing.Size(729, 150);
            this.dataGridViewApplicantList.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Applicant List";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Gray;
            this.buttonDelete.Location = new System.Drawing.Point(356, 148);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 50);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Gray;
            this.buttonEdit.Location = new System.Drawing.Point(202, 148);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(115, 50);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Gray;
            this.buttonAdd.Location = new System.Drawing.Point(28, 148);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 50);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // groupBoxApplicantInformation
            // 
            this.groupBoxApplicantInformation.Controls.Add(this.textBoxEmail);
            this.groupBoxApplicantInformation.Controls.Add(this.textBoxLastName);
            this.groupBoxApplicantInformation.Controls.Add(this.textBoxFirstName);
            this.groupBoxApplicantInformation.Controls.Add(this.textBoxApplicatnId);
            this.groupBoxApplicantInformation.Controls.Add(this.labelEmail);
            this.groupBoxApplicantInformation.Controls.Add(this.labelLastName);
            this.groupBoxApplicantInformation.Controls.Add(this.labelFirstName);
            this.groupBoxApplicantInformation.Controls.Add(this.labelApplicantId);
            this.groupBoxApplicantInformation.Location = new System.Drawing.Point(28, 11);
            this.groupBoxApplicantInformation.Name = "groupBoxApplicantInformation";
            this.groupBoxApplicantInformation.Size = new System.Drawing.Size(656, 100);
            this.groupBoxApplicantInformation.TabIndex = 12;
            this.groupBoxApplicantInformation.TabStop = false;
            this.groupBoxApplicantInformation.Text = "Applicant Information";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(503, 62);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(342, 62);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(174, 62);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // textBoxApplicatnId
            // 
            this.textBoxApplicatnId.Location = new System.Drawing.Point(9, 62);
            this.textBoxApplicatnId.Name = "textBoxApplicatnId";
            this.textBoxApplicatnId.Size = new System.Drawing.Size(100, 22);
            this.textBoxApplicatnId.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(500, 34);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(339, 34);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(72, 16);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(171, 34);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(72, 16);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // labelApplicantId
            // 
            this.labelApplicantId.AutoSize = true;
            this.labelApplicantId.Location = new System.Drawing.Point(6, 34);
            this.labelApplicantId.Name = "labelApplicantId";
            this.labelApplicantId.Size = new System.Drawing.Size(79, 16);
            this.labelApplicantId.TabIndex = 0;
            this.labelApplicantId.Text = "Applicant ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxWbinarInformation);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Webinars";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxWbinarInformation
            // 
            this.groupBoxWbinarInformation.Controls.Add(this.labelEndDate);
            this.groupBoxWbinarInformation.Controls.Add(this.labelStartDate);
            this.groupBoxWbinarInformation.Controls.Add(this.textBoxTotalHour);
            this.groupBoxWbinarInformation.Controls.Add(this.textBoxWebinarName);
            this.groupBoxWbinarInformation.Controls.Add(this.textBoxWebinarCode);
            this.groupBoxWbinarInformation.Controls.Add(this.labelTotalHour);
            this.groupBoxWbinarInformation.Controls.Add(this.labelWebinarName);
            this.groupBoxWbinarInformation.Controls.Add(this.labelWebinarCode);
            this.groupBoxWbinarInformation.Location = new System.Drawing.Point(54, 34);
            this.groupBoxWbinarInformation.Name = "groupBoxWbinarInformation";
            this.groupBoxWbinarInformation.Size = new System.Drawing.Size(696, 226);
            this.groupBoxWbinarInformation.TabIndex = 0;
            this.groupBoxWbinarInformation.TabStop = false;
            this.groupBoxWbinarInformation.Text = "Wbinar Information";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registration";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // labelWebinarCode
            // 
            this.labelWebinarCode.AutoSize = true;
            this.labelWebinarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebinarCode.Location = new System.Drawing.Point(6, 58);
            this.labelWebinarCode.Name = "labelWebinarCode";
            this.labelWebinarCode.Size = new System.Drawing.Size(137, 22);
            this.labelWebinarCode.TabIndex = 0;
            this.labelWebinarCode.Text = "Webinar Code";
            // 
            // labelWebinarName
            // 
            this.labelWebinarName.AutoSize = true;
            this.labelWebinarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebinarName.Location = new System.Drawing.Point(153, 58);
            this.labelWebinarName.Name = "labelWebinarName";
            this.labelWebinarName.Size = new System.Drawing.Size(141, 22);
            this.labelWebinarName.TabIndex = 1;
            this.labelWebinarName.Text = "Webinar Name";
            this.labelWebinarName.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelTotalHour
            // 
            this.labelTotalHour.AutoSize = true;
            this.labelTotalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHour.Location = new System.Drawing.Point(317, 58);
            this.labelTotalHour.Name = "labelTotalHour";
            this.labelTotalHour.Size = new System.Drawing.Size(105, 22);
            this.labelTotalHour.TabIndex = 2;
            this.labelTotalHour.Text = "Total Hour";
            // 
            // textBoxWebinarCode
            // 
            this.textBoxWebinarCode.Location = new System.Drawing.Point(21, 97);
            this.textBoxWebinarCode.Name = "textBoxWebinarCode";
            this.textBoxWebinarCode.Size = new System.Drawing.Size(100, 22);
            this.textBoxWebinarCode.TabIndex = 3;
            // 
            // textBoxWebinarName
            // 
            this.textBoxWebinarName.Location = new System.Drawing.Point(169, 97);
            this.textBoxWebinarName.Name = "textBoxWebinarName";
            this.textBoxWebinarName.Size = new System.Drawing.Size(100, 22);
            this.textBoxWebinarName.TabIndex = 4;
            // 
            // textBoxTotalHour
            // 
            this.textBoxTotalHour.Location = new System.Drawing.Point(322, 97);
            this.textBoxTotalHour.Name = "textBoxTotalHour";
            this.textBoxTotalHour.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotalHour.TabIndex = 5;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(539, 18);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(66, 16);
            this.labelStartDate.TabIndex = 6;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(539, 112);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(63, 16);
            this.labelEndDate.TabIndex = 7;
            this.labelEndDate.Text = "End Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicantList)).EndInit();
            this.groupBoxApplicantInformation.ResumeLayout(false);
            this.groupBoxApplicantInformation.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxWbinarInformation.ResumeLayout(false);
            this.groupBoxWbinarInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewApplicantList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxApplicantInformation;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxApplicatnId;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelApplicantId;
        private System.Windows.Forms.GroupBox groupBoxWbinarInformation;
        private System.Windows.Forms.Label labelTotalHour;
        private System.Windows.Forms.Label labelWebinarName;
        private System.Windows.Forms.Label labelWebinarCode;
        private System.Windows.Forms.TextBox textBoxTotalHour;
        private System.Windows.Forms.TextBox textBoxWebinarName;
        private System.Windows.Forms.TextBox textBoxWebinarCode;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
    }
}

