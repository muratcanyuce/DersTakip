namespace Acme.DersTakip.WinUI
{
    partial class TeacherForm
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
            this.gbxInstrument = new System.Windows.Forms.GroupBox();
            this.tbxTeacherName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxTeacherEmail = new System.Windows.Forms.TextBox();
            this.tbxTeacherPhone = new System.Windows.Forms.TextBox();
            this.tbxTeacherSurname = new System.Windows.Forms.TextBox();
            this.lblInstrument = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.cbxTeachersInstrument = new System.Windows.Forms.ComboBox();
            this.dgwTeachersInstrument = new System.Windows.Forms.DataGridView();
            this.btnAddTeachersInstrument = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgwTeachers = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.gbxInstrument.SuspendLayout();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachersInstrument)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInstrument
            // 
            this.gbxInstrument.Controls.Add(this.tbxTeacherName);
            this.gbxInstrument.Controls.Add(this.btnAdd);
            this.gbxInstrument.Controls.Add(this.label3);
            this.gbxInstrument.Controls.Add(this.label2);
            this.gbxInstrument.Controls.Add(this.label1);
            this.gbxInstrument.Controls.Add(this.btnDelete);
            this.gbxInstrument.Controls.Add(this.btnUpdate);
            this.gbxInstrument.Controls.Add(this.tbxTeacherEmail);
            this.gbxInstrument.Controls.Add(this.tbxTeacherPhone);
            this.gbxInstrument.Controls.Add(this.tbxTeacherSurname);
            this.gbxInstrument.Controls.Add(this.lblInstrument);
            this.gbxInstrument.Controls.Add(this.groupbox1);
            this.gbxInstrument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxInstrument.Location = new System.Drawing.Point(317, 3);
            this.gbxInstrument.Name = "gbxInstrument";
            this.gbxInstrument.Size = new System.Drawing.Size(265, 444);
            this.gbxInstrument.TabIndex = 6;
            this.gbxInstrument.TabStop = false;
            this.gbxInstrument.Text = "Eğitmen";
            // 
            // tbxTeacherName
            // 
            this.tbxTeacherName.Location = new System.Drawing.Point(114, 27);
            this.tbxTeacherName.Name = "tbxTeacherName";
            this.tbxTeacherName.Size = new System.Drawing.Size(137, 22);
            this.tbxTeacherName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Soyadı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(91, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxTeacherEmail
            // 
            this.tbxTeacherEmail.Location = new System.Drawing.Point(114, 111);
            this.tbxTeacherEmail.Name = "tbxTeacherEmail";
            this.tbxTeacherEmail.Size = new System.Drawing.Size(137, 22);
            this.tbxTeacherEmail.TabIndex = 0;
            // 
            // tbxTeacherPhone
            // 
            this.tbxTeacherPhone.Location = new System.Drawing.Point(114, 83);
            this.tbxTeacherPhone.Name = "tbxTeacherPhone";
            this.tbxTeacherPhone.Size = new System.Drawing.Size(137, 22);
            this.tbxTeacherPhone.TabIndex = 0;
            // 
            // tbxTeacherSurname
            // 
            this.tbxTeacherSurname.Location = new System.Drawing.Point(114, 55);
            this.tbxTeacherSurname.Name = "tbxTeacherSurname";
            this.tbxTeacherSurname.Size = new System.Drawing.Size(137, 22);
            this.tbxTeacherSurname.TabIndex = 0;
            // 
            // lblInstrument
            // 
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Location = new System.Drawing.Point(6, 30);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(27, 16);
            this.lblInstrument.TabIndex = 2;
            this.lblInstrument.Text = "Adı";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.cbxTeachersInstrument);
            this.groupbox1.Controls.Add(this.dgwTeachersInstrument);
            this.groupbox1.Controls.Add(this.btnAddTeachersInstrument);
            this.groupbox1.Location = new System.Drawing.Point(0, 179);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(254, 265);
            this.groupbox1.TabIndex = 14;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Enstrüman";
            // 
            // cbxTeachersInstrument
            // 
            this.cbxTeachersInstrument.FormattingEnabled = true;
            this.cbxTeachersInstrument.Location = new System.Drawing.Point(1, 194);
            this.cbxTeachersInstrument.Name = "cbxTeachersInstrument";
            this.cbxTeachersInstrument.Size = new System.Drawing.Size(105, 24);
            this.cbxTeachersInstrument.TabIndex = 13;
            // 
            // dgwTeachersInstrument
            // 
            this.dgwTeachersInstrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeachersInstrument.Location = new System.Drawing.Point(0, 21);
            this.dgwTeachersInstrument.Name = "dgwTeachersInstrument";
            this.dgwTeachersInstrument.RowHeadersWidth = 51;
            this.dgwTeachersInstrument.RowTemplate.Height = 24;
            this.dgwTeachersInstrument.Size = new System.Drawing.Size(242, 167);
            this.dgwTeachersInstrument.TabIndex = 11;
            // 
            // btnAddTeachersInstrument
            // 
            this.btnAddTeachersInstrument.Location = new System.Drawing.Point(125, 195);
            this.btnAddTeachersInstrument.Name = "btnAddTeachersInstrument";
            this.btnAddTeachersInstrument.Size = new System.Drawing.Size(85, 23);
            this.btnAddTeachersInstrument.TabIndex = 8;
            this.btnAddTeachersInstrument.Text = "Ekle";
            this.btnAddTeachersInstrument.UseVisualStyleBackColor = true;
            this.btnAddTeachersInstrument.Click += new System.EventHandler(this.btnAddTeachersInstrument_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gbxInstrument, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgwTeachers, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(571, 450);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dgwTeachers
            // 
            this.dgwTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeachers.Location = new System.Drawing.Point(3, 3);
            this.dgwTeachers.Name = "dgwTeachers";
            this.dgwTeachers.RowHeadersWidth = 51;
            this.dgwTeachers.RowTemplate.Height = 24;
            this.dgwTeachers.Size = new System.Drawing.Size(308, 444);
            this.dgwTeachers.TabIndex = 1;
            this.dgwTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTeachers_CellClick);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TeacherForm";
            this.Text = "Eğitmen Form";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.gbxInstrument.ResumeLayout(false);
            this.gbxInstrument.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachersInstrument)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInstrument;
        private System.Windows.Forms.TextBox tbxTeacherSurname;
        private System.Windows.Forms.Label lblInstrument;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgwTeachers;
        private System.Windows.Forms.TextBox tbxTeacherName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTeacherEmail;
        private System.Windows.Forms.TextBox tbxTeacherPhone;
        private System.Windows.Forms.DataGridView dgwTeachersInstrument;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.ComboBox cbxTeachersInstrument;
        private System.Windows.Forms.Button btnAddTeachersInstrument;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}