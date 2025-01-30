namespace Acme.DersTakip.WinUI
{
    partial class ScheduleAppearanceForm
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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsFlyout.HtmlTemplate.Styles = "body {\n  padding: 11px;\n}";
            this.schedulerControl1.Size = new System.Drawing.Size(800, 450);
            this.schedulerControl1.Start = new System.DateTime(2025, 1, 29, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.DataSource = this.scheduleDtoBindingSource;
            this.schedulerDataStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerDataStorage1.Appointments.Mappings.Label = "InstrumentId";
            this.schedulerDataStorage1.Appointments.Mappings.ResourceId = "TeacherId";
            this.schedulerDataStorage1.Appointments.Mappings.Start = "ScheduleDateTime";
            this.schedulerDataStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerDataStorage1.Appointments.Mappings.Subject = "StudentName";
            // 
            // 
            // 
            this.schedulerDataStorage1.Labels.DataSource = this.instrumentBindingSource;
            this.schedulerDataStorage1.Labels.Mappings.DisplayName = "Name";
            this.schedulerDataStorage1.Labels.Mappings.Id = "Id";
            // 
            // 
            // 
            this.schedulerDataStorage1.Resources.DataSource = this.teacherBindingSource;
            this.schedulerDataStorage1.Resources.Mappings.Caption = "FullName";
            this.schedulerDataStorage1.Resources.Mappings.Id = "Id";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Acme.DersTakip.Entity.Concrete.Teacher);
            // 
            // instrumentBindingSource
            // 
            this.instrumentBindingSource.DataSource = typeof(Acme.DersTakip.Entity.Concrete.Instrument);
            // 
            // scheduleDtoBindingSource
            // 
            this.scheduleDtoBindingSource.DataSource = typeof(Acme.DersTakip.WinUI.DTOs.ScheduleDto);
            // 
            // ScheduleAppearanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.schedulerControl1);
            this.Name = "ScheduleAppearanceForm";
            this.Text = "Takvim Görünümü";
            this.Load += new System.EventHandler(this.ScheduleAppearanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private System.Windows.Forms.BindingSource scheduleDtoBindingSource;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.BindingSource instrumentBindingSource;
    }
}