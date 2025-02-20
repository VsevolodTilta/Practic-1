﻿namespace Общежитие
{
	partial class studentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.общежитиеDataSet = new Общежитие.ОбщежитиеDataSet();
			this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentTableAdapter = new Общежитие.ОбщежитиеDataSetTableAdapters.StudentTableAdapter();
			this.studentkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.privielegecodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colonizedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.buttonRefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentkodDataGridViewTextBoxColumn,
            this.sNPDataGridViewTextBoxColumn,
            this.birthyearDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.privielegecodDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.colonizedateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.studentBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(2, 1);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1043, 259);
			this.dataGridView1.TabIndex = 0;
			// 
			// общежитиеDataSet
			// 
			this.общежитиеDataSet.DataSetName = "ОбщежитиеDataSet";
			this.общежитиеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// studentBindingSource
			// 
			this.studentBindingSource.DataMember = "Student";
			this.studentBindingSource.DataSource = this.общежитиеDataSet;
			// 
			// studentTableAdapter
			// 
			this.studentTableAdapter.ClearBeforeFill = true;
			// 
			// studentkodDataGridViewTextBoxColumn
			// 
			this.studentkodDataGridViewTextBoxColumn.DataPropertyName = "student_kod";
			this.studentkodDataGridViewTextBoxColumn.HeaderText = "student_kod";
			this.studentkodDataGridViewTextBoxColumn.Name = "studentkodDataGridViewTextBoxColumn";
			// 
			// sNPDataGridViewTextBoxColumn
			// 
			this.sNPDataGridViewTextBoxColumn.DataPropertyName = "SNP";
			this.sNPDataGridViewTextBoxColumn.HeaderText = "SNP";
			this.sNPDataGridViewTextBoxColumn.Name = "sNPDataGridViewTextBoxColumn";
			// 
			// birthyearDataGridViewTextBoxColumn
			// 
			this.birthyearDataGridViewTextBoxColumn.DataPropertyName = "Birth_year";
			this.birthyearDataGridViewTextBoxColumn.HeaderText = "Birth_year";
			this.birthyearDataGridViewTextBoxColumn.Name = "birthyearDataGridViewTextBoxColumn";
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// groupDataGridViewTextBoxColumn
			// 
			this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
			this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
			this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
			// 
			// privielegecodDataGridViewTextBoxColumn
			// 
			this.privielegecodDataGridViewTextBoxColumn.DataPropertyName = "Privielege_cod";
			this.privielegecodDataGridViewTextBoxColumn.HeaderText = "Privielege_cod";
			this.privielegecodDataGridViewTextBoxColumn.Name = "privielegecodDataGridViewTextBoxColumn";
			// 
			// passportDataGridViewTextBoxColumn
			// 
			this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
			this.passportDataGridViewTextBoxColumn.HeaderText = "Passport";
			this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
			// 
			// roomDataGridViewTextBoxColumn
			// 
			this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
			this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
			this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
			// 
			// colonizedateDataGridViewTextBoxColumn
			// 
			this.colonizedateDataGridViewTextBoxColumn.DataPropertyName = "Colonize_date";
			this.colonizedateDataGridViewTextBoxColumn.HeaderText = "Colonize_date";
			this.colonizedateDataGridViewTextBoxColumn.Name = "colonizedateDataGridViewTextBoxColumn";
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.AllowMerge = false;
			this.bindingNavigator1.BindingSource = this.studentBindingSource;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
			this.bindingNavigator1.Location = new System.Drawing.Point(2, 263);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(294, 25);
			this.bindingNavigator1.TabIndex = 1;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.buttonRefresh.Location = new System.Drawing.Point(268, 263);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(777, 23);
			this.buttonRefresh.TabIndex = 2;
			this.buttonRefresh.Text = "Обновить";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// studentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1046, 291);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "studentForm";
			this.Text = "studentForm";
			this.Load += new System.EventHandler(this.studentForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private ОбщежитиеDataSet общежитиеDataSet;
		private System.Windows.Forms.BindingSource studentBindingSource;
		private ОбщежитиеDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentkodDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sNPDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthyearDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn privielegecodDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colonizedateDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.Button buttonRefresh;
	}
}