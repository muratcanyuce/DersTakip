namespace Acme.DersTakip.WinUI
{
    partial class ScheduleNewForm
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
            this.dgwScheduleNew = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxFee = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.chkStatusSchedule = new System.Windows.Forms.CheckBox();
            this.cbxStudentSchedule = new System.Windows.Forms.ComboBox();
            this.cbxInstrumentSchedule = new System.Windows.Forms.ComboBox();
            this.cbxTeacherSchedule = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwScheduleNew)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwScheduleNew
            // 
            this.dgwScheduleNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwScheduleNew.Location = new System.Drawing.Point(12, 12);
            this.dgwScheduleNew.Name = "dgwScheduleNew";
            this.dgwScheduleNew.RowHeadersWidth = 51;
            this.dgwScheduleNew.RowTemplate.Height = 24;
            this.dgwScheduleNew.Size = new System.Drawing.Size(394, 433);
            this.dgwScheduleNew.TabIndex = 0;
            this.dgwScheduleNew.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwScheduleNew_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxFee);
            this.groupBox1.Controls.Add(this.tbxDescription);
            this.groupBox1.Controls.Add(this.dtpDateTime);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTeacher);
            this.groupBox1.Controls.Add(this.chkStatusSchedule);
            this.groupBox1.Controls.Add(this.cbxStudentSchedule);
            this.groupBox1.Controls.Add(this.cbxInstrumentSchedule);
            this.groupBox1.Controls.Add(this.cbxTeacherSchedule);
            this.groupBox1.Location = new System.Drawing.Point(412, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 433);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takvim Oluşturma";
            // 
            // tbxFee
            // 
            this.tbxFee.Location = new System.Drawing.Point(157, 136);
            this.tbxFee.Name = "tbxFee";
            this.tbxFee.Size = new System.Drawing.Size(213, 22);
            this.tbxFee.TabIndex = 6;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(157, 166);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(213, 22);
            this.tbxDescription.TabIndex = 6;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "";
            this.dtpDateTime.Location = new System.Drawing.Point(157, 108);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(213, 22);
            this.dtpDateTime.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(162, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih Seçimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Saatlik Ders Ücreti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Devam Durumu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enstrüman";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(24, 24);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(66, 16);
            this.lblTeacher.TabIndex = 3;
            this.lblTeacher.Text = "Öğretmen";
            // 
            // chkStatusSchedule
            // 
            this.chkStatusSchedule.AutoSize = true;
            this.chkStatusSchedule.Location = new System.Drawing.Point(263, 194);
            this.chkStatusSchedule.Name = "chkStatusSchedule";
            this.chkStatusSchedule.Size = new System.Drawing.Size(18, 17);
            this.chkStatusSchedule.TabIndex = 2;
            this.chkStatusSchedule.UseVisualStyleBackColor = true;
            // 
            // cbxStudentSchedule
            // 
            this.cbxStudentSchedule.FormattingEnabled = true;
            this.cbxStudentSchedule.Location = new System.Drawing.Point(157, 48);
            this.cbxStudentSchedule.Name = "cbxStudentSchedule";
            this.cbxStudentSchedule.Size = new System.Drawing.Size(213, 24);
            this.cbxStudentSchedule.TabIndex = 1;
            // 
            // cbxInstrumentSchedule
            // 
            this.cbxInstrumentSchedule.FormattingEnabled = true;
            this.cbxInstrumentSchedule.Location = new System.Drawing.Point(157, 78);
            this.cbxInstrumentSchedule.Name = "cbxInstrumentSchedule";
            this.cbxInstrumentSchedule.Size = new System.Drawing.Size(213, 24);
            this.cbxInstrumentSchedule.TabIndex = 0;
            // 
            // cbxTeacherSchedule
            // 
            this.cbxTeacherSchedule.FormattingEnabled = true;
            this.cbxTeacherSchedule.Location = new System.Drawing.Point(157, 21);
            this.cbxTeacherSchedule.Name = "cbxTeacherSchedule";
            this.cbxTeacherSchedule.Size = new System.Drawing.Size(213, 24);
            this.cbxTeacherSchedule.TabIndex = 0;
            this.cbxTeacherSchedule.SelectedIndexChanged += new System.EventHandler(this.cbxTeacherSchedule_SelectedIndexChanged);
            // 
            // ScheduleNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwScheduleNew);
            this.Name = "ScheduleNewForm";
            this.Text = "Takvim Yeni Form";
            this.Load += new System.EventHandler(this.ScheduleNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwScheduleNew)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwScheduleNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxStudentSchedule;
        private System.Windows.Forms.ComboBox cbxTeacherSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.CheckBox chkStatusSchedule;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxInstrumentSchedule;
        private System.Windows.Forms.TextBox tbxFee;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}