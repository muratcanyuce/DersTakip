namespace Acme.DersTakip.WinUI
{
    partial class InstrumentForm
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
            this.tbxInstrumentName = new System.Windows.Forms.TextBox();
            this.lblInstrument = new System.Windows.Forms.Label();
            this.btnInstrumentUpdate = new System.Windows.Forms.Button();
            this.btnInstrumentAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxInstrument = new System.Windows.Forms.GroupBox();
            this.btnInstrumentDelete = new System.Windows.Forms.Button();
            this.dgwInstrument = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxInstrument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInstrument)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxInstrumentName
            // 
            this.tbxInstrumentName.Location = new System.Drawing.Point(20, 44);
            this.tbxInstrumentName.Name = "tbxInstrumentName";
            this.tbxInstrumentName.Size = new System.Drawing.Size(231, 22);
            this.tbxInstrumentName.TabIndex = 0;
            // 
            // lblInstrument
            // 
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Location = new System.Drawing.Point(17, 16);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(93, 16);
            this.lblInstrument.TabIndex = 2;
            this.lblInstrument.Text = "Enstrüman Adı";
            // 
            // btnInstrumentUpdate
            // 
            this.btnInstrumentUpdate.Location = new System.Drawing.Point(99, 81);
            this.btnInstrumentUpdate.Name = "btnInstrumentUpdate";
            this.btnInstrumentUpdate.Size = new System.Drawing.Size(78, 23);
            this.btnInstrumentUpdate.TabIndex = 4;
            this.btnInstrumentUpdate.Text = "Güncelle";
            this.btnInstrumentUpdate.UseVisualStyleBackColor = true;
            this.btnInstrumentUpdate.Click += new System.EventHandler(this.btnInstrumentUpdate_Click);
            // 
            // btnInstrumentAdd
            // 
            this.btnInstrumentAdd.Location = new System.Drawing.Point(20, 81);
            this.btnInstrumentAdd.Name = "btnInstrumentAdd";
            this.btnInstrumentAdd.Size = new System.Drawing.Size(73, 23);
            this.btnInstrumentAdd.TabIndex = 3;
            this.btnInstrumentAdd.Text = "Ekle";
            this.btnInstrumentAdd.UseVisualStyleBackColor = true;
            this.btnInstrumentAdd.Click += new System.EventHandler(this.btnInstrumentAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gbxInstrument, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgwInstrument, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 490);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // gbxInstrument
            // 
            this.gbxInstrument.Controls.Add(this.tbxInstrumentName);
            this.gbxInstrument.Controls.Add(this.btnInstrumentAdd);
            this.gbxInstrument.Controls.Add(this.lblInstrument);
            this.gbxInstrument.Controls.Add(this.btnInstrumentDelete);
            this.gbxInstrument.Controls.Add(this.btnInstrumentUpdate);
            this.gbxInstrument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxInstrument.Location = new System.Drawing.Point(364, 3);
            this.gbxInstrument.Name = "gbxInstrument";
            this.gbxInstrument.Size = new System.Drawing.Size(265, 484);
            this.gbxInstrument.TabIndex = 6;
            this.gbxInstrument.TabStop = false;
            // 
            // btnInstrumentDelete
            // 
            this.btnInstrumentDelete.Location = new System.Drawing.Point(183, 81);
            this.btnInstrumentDelete.Name = "btnInstrumentDelete";
            this.btnInstrumentDelete.Size = new System.Drawing.Size(73, 23);
            this.btnInstrumentDelete.TabIndex = 5;
            this.btnInstrumentDelete.Text = "Sil";
            this.btnInstrumentDelete.UseVisualStyleBackColor = true;
            this.btnInstrumentDelete.Click += new System.EventHandler(this.btnInstrumentDelete_Click);
            // 
            // dgwInstrument
            // 
            this.dgwInstrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInstrument.Location = new System.Drawing.Point(3, 3);
            this.dgwInstrument.Name = "dgwInstrument";
            this.dgwInstrument.RowHeadersWidth = 51;
            this.dgwInstrument.RowTemplate.Height = 24;
            this.dgwInstrument.Size = new System.Drawing.Size(355, 484);
            this.dgwInstrument.TabIndex = 1;
            this.dgwInstrument.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInstrumentName_CellClick);
            // 
            // InstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InstrumentForm";
            this.Text = "Enstrüman Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxInstrument.ResumeLayout(false);
            this.gbxInstrument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInstrument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInstrumentName;
        private System.Windows.Forms.Label lblInstrument;
        private System.Windows.Forms.Button btnInstrumentUpdate;
        private System.Windows.Forms.Button btnInstrumentAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnInstrumentDelete;
        private System.Windows.Forms.DataGridView dgwInstrument;
        private System.Windows.Forms.GroupBox gbxInstrument;
    }
}