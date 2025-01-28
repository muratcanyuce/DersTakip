namespace Acme.DersTakip.WinUI
{
    partial class StudentForm
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
            this.tbxParentSurname = new System.Windows.Forms.TextBox();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxParentName = new System.Windows.Forms.TextBox();
            this.tbxStudentPhone = new System.Windows.Forms.TextBox();
            this.tbxParentPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxStudentSurname = new System.Windows.Forms.TextBox();
            this.lblInstrument = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgwStudent = new System.Windows.Forms.DataGridView();
            this.gbxInstrument.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInstrument
            // 
            this.gbxInstrument.Controls.Add(this.tbxParentSurname);
            this.gbxInstrument.Controls.Add(this.tbxStudentName);
            this.gbxInstrument.Controls.Add(this.btnAdd);
            this.gbxInstrument.Controls.Add(this.label3);
            this.gbxInstrument.Controls.Add(this.label2);
            this.gbxInstrument.Controls.Add(this.label5);
            this.gbxInstrument.Controls.Add(this.label1);
            this.gbxInstrument.Controls.Add(this.btnDelete);
            this.gbxInstrument.Controls.Add(this.btnUpdate);
            this.gbxInstrument.Controls.Add(this.tbxParentName);
            this.gbxInstrument.Controls.Add(this.tbxStudentPhone);
            this.gbxInstrument.Controls.Add(this.tbxParentPhone);
            this.gbxInstrument.Controls.Add(this.label4);
            this.gbxInstrument.Controls.Add(this.tbxStudentSurname);
            this.gbxInstrument.Controls.Add(this.lblInstrument);
            this.gbxInstrument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxInstrument.Location = new System.Drawing.Point(419, 3);
            this.gbxInstrument.Name = "gbxInstrument";
            this.gbxInstrument.Size = new System.Drawing.Size(286, 444);
            this.gbxInstrument.TabIndex = 6;
            this.gbxInstrument.TabStop = false;
            this.gbxInstrument.Text = "Öğrenci";
            // 
            // tbxParentSurname
            // 
            this.tbxParentSurname.Location = new System.Drawing.Point(120, 151);
            this.tbxParentSurname.Name = "tbxParentSurname";
            this.tbxParentSurname.Size = new System.Drawing.Size(137, 22);
            this.tbxParentSurname.TabIndex = 6;
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Location = new System.Drawing.Point(120, 37);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(137, 22);
            this.tbxStudentName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 218);
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
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Veli Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Veli Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Soyadı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(184, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxParentName
            // 
            this.tbxParentName.Location = new System.Drawing.Point(120, 121);
            this.tbxParentName.Name = "tbxParentName";
            this.tbxParentName.Size = new System.Drawing.Size(137, 22);
            this.tbxParentName.TabIndex = 0;
            // 
            // tbxStudentPhone
            // 
            this.tbxStudentPhone.Location = new System.Drawing.Point(120, 93);
            this.tbxStudentPhone.Name = "tbxStudentPhone";
            this.tbxStudentPhone.Size = new System.Drawing.Size(137, 22);
            this.tbxStudentPhone.TabIndex = 0;
            // 
            // tbxParentPhone
            // 
            this.tbxParentPhone.Location = new System.Drawing.Point(120, 179);
            this.tbxParentPhone.Name = "tbxParentPhone";
            this.tbxParentPhone.Size = new System.Drawing.Size(137, 22);
            this.tbxParentPhone.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Veli Soyadı";
            // 
            // tbxStudentSurname
            // 
            this.tbxStudentSurname.Location = new System.Drawing.Point(120, 65);
            this.tbxStudentSurname.Name = "tbxStudentSurname";
            this.tbxStudentSurname.Size = new System.Drawing.Size(137, 22);
            this.tbxStudentSurname.TabIndex = 0;
            // 
            // lblInstrument
            // 
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Location = new System.Drawing.Point(12, 40);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(27, 16);
            this.lblInstrument.TabIndex = 2;
            this.lblInstrument.Text = "Adı";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gbxInstrument, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgwStudent, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 450);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dgwStudent
            // 
            this.dgwStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudent.Location = new System.Drawing.Point(3, 3);
            this.dgwStudent.Name = "dgwStudent";
            this.dgwStudent.RowHeadersWidth = 51;
            this.dgwStudent.RowTemplate.Height = 24;
            this.dgwStudent.Size = new System.Drawing.Size(410, 444);
            this.dgwStudent.TabIndex = 1;
            this.dgwStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudent_CellClick);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentForm";
            this.Text = "Öğrenci Form";
            this.gbxInstrument.ResumeLayout(false);
            this.gbxInstrument.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInstrument;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxParentName;
        private System.Windows.Forms.TextBox tbxStudentPhone;
        private System.Windows.Forms.TextBox tbxStudentSurname;
        private System.Windows.Forms.Label lblInstrument;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgwStudent;
        private System.Windows.Forms.TextBox tbxParentSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxParentPhone;
        private System.Windows.Forms.Label label4;
    }
}