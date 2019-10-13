namespace RapidAppDev
{
    partial class UserEvents
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventCalendarDataSet = new RapidAppDev.EventCalendarDataSet();
            this.eventsTableAdapter = new RapidAppDev.EventCalendarDataSetTableAdapters.EventsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.eventCalendarDataSet1 = new RapidAppDev.EventCalendarDataSet1();
            this.eventsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter1 = new RapidAppDev.EventCalendarDataSet1TableAdapters.EventsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCalendarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCalendarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(305, 60);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Azure;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Azure;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateSelected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.eventDetailsDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.eventCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 334);
            this.dataGridView1.TabIndex = 28;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.MinimumWidth = 180;
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            this.eventNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // eventDetailsDataGridViewTextBoxColumn
            // 
            this.eventDetailsDataGridViewTextBoxColumn.DataPropertyName = "EventDetails";
            this.eventDetailsDataGridViewTextBoxColumn.HeaderText = "EventDetails";
            this.eventDetailsDataGridViewTextBoxColumn.MinimumWidth = 400;
            this.eventDetailsDataGridViewTextBoxColumn.Name = "eventDetailsDataGridViewTextBoxColumn";
            this.eventDetailsDataGridViewTextBoxColumn.Width = 400;
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // eventCostDataGridViewTextBoxColumn
            // 
            this.eventCostDataGridViewTextBoxColumn.DataPropertyName = "EventCost";
            this.eventCostDataGridViewTextBoxColumn.HeaderText = "EventCost";
            this.eventCostDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.eventCostDataGridViewTextBoxColumn.Name = "eventCostDataGridViewTextBoxColumn";
            this.eventCostDataGridViewTextBoxColumn.Width = 70;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.eventCalendarDataSet;
            // 
            // eventCalendarDataSet
            // 
            this.eventCalendarDataSet.DataSetName = "EventCalendarDataSet";
            this.eventCalendarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(601, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 62);
            this.button1.TabIndex = 29;
            this.button1.Text = "ΕΞΑΓΩΓΗ ΠΛΗΡΟΦΟΡΙΩΝ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // eventCalendarDataSet1
            // 
            this.eventCalendarDataSet1.DataSetName = "EventCalendarDataSet1";
            this.eventCalendarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsBindingSource1
            // 
            this.eventsBindingSource1.DataMember = "Events";
            this.eventsBindingSource1.DataSource = this.eventCalendarDataSet1;
            // 
            // eventsTableAdapter1
            // 
            this.eventsTableAdapter1.ClearBeforeFill = true;
            // 
            // UserEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(844, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "UserEvents";
            this.Load += new System.EventHandler(this.UserEvents_Load);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCalendarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCalendarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EventCalendarDataSet eventCalendarDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private EventCalendarDataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private EventCalendarDataSet1 eventCalendarDataSet1;
        private System.Windows.Forms.BindingSource eventsBindingSource1;
        private EventCalendarDataSet1TableAdapters.EventsTableAdapter eventsTableAdapter1;
    }
}
