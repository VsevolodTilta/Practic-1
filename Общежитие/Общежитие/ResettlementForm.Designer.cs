﻿namespace Общежитие
{
	partial class ResettlementForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResettlementForm));
			System.Windows.Forms.Label room_nLabel;
			System.Windows.Forms.Label value_nLabel;
			System.Windows.Forms.Label amountLabel;
			System.Windows.Forms.Label toolsLabel;
			System.Windows.Forms.Label flourLabel;
			this.общежитиеDataSet = new Общежитие.ОбщежитиеDataSet();
			this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.roomTableAdapter = new Общежитие.ОбщежитиеDataSetTableAdapters.roomTableAdapter();
			this.tableAdapterManager = new Общежитие.ОбщежитиеDataSetTableAdapters.TableAdapterManager();
			this.roomBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.roomBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.room_nTextBox = new System.Windows.Forms.TextBox();
			this.value_nTextBox = new System.Windows.Forms.TextBox();
			this.amountTextBox = new System.Windows.Forms.TextBox();
			this.toolsTextBox = new System.Windows.Forms.TextBox();
			this.flourTextBox = new System.Windows.Forms.TextBox();
			this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentTableAdapter = new Общежитие.ОбщежитиеDataSetTableAdapters.StudentTableAdapter();
			this.studentDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			room_nLabel = new System.Windows.Forms.Label();
			value_nLabel = new System.Windows.Forms.Label();
			amountLabel = new System.Windows.Forms.Label();
			toolsLabel = new System.Windows.Forms.Label();
			flourLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roomBindingNavigator)).BeginInit();
			this.roomBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// общежитиеDataSet
			// 
			this.общежитиеDataSet.DataSetName = "ОбщежитиеDataSet";
			this.общежитиеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// roomBindingSource
			// 
			this.roomBindingSource.DataMember = "room";
			this.roomBindingSource.DataSource = this.общежитиеDataSet;
			// 
			// roomTableAdapter
			// 
			this.roomTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.LgotaTableAdapter = null;
			this.tableAdapterManager.roomTableAdapter = this.roomTableAdapter;
			this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
			this.tableAdapterManager.UpdateOrder = Общежитие.ОбщежитиеDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// roomBindingNavigator
			// 
			this.roomBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.roomBindingNavigator.BindingSource = this.roomBindingSource;
			this.roomBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.roomBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.roomBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.roomBindingNavigatorSaveItem});
			this.roomBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.roomBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.roomBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.roomBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.roomBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.roomBindingNavigator.Name = "roomBindingNavigator";
			this.roomBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.roomBindingNavigator.Size = new System.Drawing.Size(1052, 25);
			this.roomBindingNavigator.TabIndex = 0;
			this.roomBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// roomBindingNavigatorSaveItem
			// 
			this.roomBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.roomBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roomBindingNavigatorSaveItem.Image")));
			this.roomBindingNavigatorSaveItem.Name = "roomBindingNavigatorSaveItem";
			this.roomBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.roomBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.roomBindingNavigatorSaveItem.Click += new System.EventHandler(this.roomBindingNavigatorSaveItem_Click);
			// 
			// room_nLabel
			// 
			room_nLabel.AutoSize = true;
			room_nLabel.Location = new System.Drawing.Point(112, 70);
			room_nLabel.Name = "room_nLabel";
			room_nLabel.Size = new System.Drawing.Size(89, 13);
			room_nLabel.TabIndex = 1;
			room_nLabel.Text = "Номер комнаты";
			// 
			// room_nTextBox
			// 
			this.room_nTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Room_n", true));
			this.room_nTextBox.Location = new System.Drawing.Point(207, 67);
			this.room_nTextBox.Name = "room_nTextBox";
			this.room_nTextBox.Size = new System.Drawing.Size(100, 20);
			this.room_nTextBox.TabIndex = 2;
			// 
			// value_nLabel
			// 
			value_nLabel.AutoSize = true;
			value_nLabel.Location = new System.Drawing.Point(112, 96);
			value_nLabel.Name = "value_nLabel";
			value_nLabel.Size = new System.Drawing.Size(62, 13);
			value_nLabel.TabIndex = 3;
			value_nLabel.Text = "Стоимость";
			// 
			// value_nTextBox
			// 
			this.value_nTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Value_n", true));
			this.value_nTextBox.Location = new System.Drawing.Point(207, 93);
			this.value_nTextBox.Name = "value_nTextBox";
			this.value_nTextBox.Size = new System.Drawing.Size(100, 20);
			this.value_nTextBox.TabIndex = 4;
			// 
			// amountLabel
			// 
			amountLabel.AutoSize = true;
			amountLabel.Location = new System.Drawing.Point(112, 122);
			amountLabel.Name = "amountLabel";
			amountLabel.Size = new System.Drawing.Size(66, 13);
			amountLabel.TabIndex = 5;
			amountLabel.Text = "Количество";
			// 
			// amountTextBox
			// 
			this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Amount", true));
			this.amountTextBox.Location = new System.Drawing.Point(207, 119);
			this.amountTextBox.Name = "amountTextBox";
			this.amountTextBox.Size = new System.Drawing.Size(100, 20);
			this.amountTextBox.TabIndex = 6;
			// 
			// toolsLabel
			// 
			toolsLabel.AutoSize = true;
			toolsLabel.Location = new System.Drawing.Point(112, 148);
			toolsLabel.Name = "toolsLabel";
			toolsLabel.Size = new System.Drawing.Size(62, 13);
			toolsLabel.TabIndex = 7;
			toolsLabel.Text = "Инвентарь";
			// 
			// toolsTextBox
			// 
			this.toolsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Tools", true));
			this.toolsTextBox.Location = new System.Drawing.Point(207, 145);
			this.toolsTextBox.Name = "toolsTextBox";
			this.toolsTextBox.Size = new System.Drawing.Size(100, 20);
			this.toolsTextBox.TabIndex = 8;
			// 
			// flourLabel
			// 
			flourLabel.AutoSize = true;
			flourLabel.Location = new System.Drawing.Point(112, 174);
			flourLabel.Name = "flourLabel";
			flourLabel.Size = new System.Drawing.Size(33, 13);
			flourLabel.TabIndex = 9;
			flourLabel.Text = "Этаж";
			// 
			// flourTextBox
			// 
			this.flourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Flour", true));
			this.flourTextBox.Location = new System.Drawing.Point(207, 171);
			this.flourTextBox.Name = "flourTextBox";
			this.flourTextBox.Size = new System.Drawing.Size(100, 20);
			this.flourTextBox.TabIndex = 10;
			// 
			// studentBindingSource
			// 
			this.studentBindingSource.DataMember = "roomStudent";
			this.studentBindingSource.DataSource = this.roomBindingSource;
			// 
			// studentTableAdapter
			// 
			this.studentTableAdapter.ClearBeforeFill = true;
			// 
			// studentDataGridView
			// 
			this.studentDataGridView.AutoGenerateColumns = false;
			this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			this.studentDataGridView.DataSource = this.studentBindingSource;
			this.studentDataGridView.Location = new System.Drawing.Point(7, 206);
			this.studentDataGridView.Name = "studentDataGridView";
			this.studentDataGridView.Size = new System.Drawing.Size(1042, 217);
			this.studentDataGridView.TabIndex = 11;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "student_kod";
			this.dataGridViewTextBoxColumn1.HeaderText = "student_kod";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "SNP";
			this.dataGridViewTextBoxColumn2.HeaderText = "SNP";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Birth_year";
			this.dataGridViewTextBoxColumn3.HeaderText = "Birth_year";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
			this.dataGridViewTextBoxColumn4.HeaderText = "Gender";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
			this.dataGridViewTextBoxColumn5.HeaderText = "Address";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Group";
			this.dataGridViewTextBoxColumn6.HeaderText = "Group";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Privielege_cod";
			this.dataGridViewTextBoxColumn7.HeaderText = "Privielege_cod";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Passport";
			this.dataGridViewTextBoxColumn8.HeaderText = "Passport";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Room";
			this.dataGridViewTextBoxColumn9.HeaderText = "Room";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Colonize_date";
			this.dataGridViewTextBoxColumn10.HeaderText = "Colonize_date";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(890, 166);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 29);
			this.button1.TabIndex = 12;
			this.button1.Text = "Подтвердить изменения";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ResettlementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1052, 425);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.studentDataGridView);
			this.Controls.Add(room_nLabel);
			this.Controls.Add(this.room_nTextBox);
			this.Controls.Add(value_nLabel);
			this.Controls.Add(this.value_nTextBox);
			this.Controls.Add(amountLabel);
			this.Controls.Add(this.amountTextBox);
			this.Controls.Add(toolsLabel);
			this.Controls.Add(this.toolsTextBox);
			this.Controls.Add(flourLabel);
			this.Controls.Add(this.flourTextBox);
			this.Controls.Add(this.roomBindingNavigator);
			this.Name = "ResettlementForm";
			this.Text = "ResettlementForm";
			this.Load += new System.EventHandler(this.ResettlementForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roomBindingNavigator)).EndInit();
			this.roomBindingNavigator.ResumeLayout(false);
			this.roomBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ОбщежитиеDataSet общежитиеDataSet;
		private System.Windows.Forms.BindingSource roomBindingSource;
		private ОбщежитиеDataSetTableAdapters.roomTableAdapter roomTableAdapter;
		private ОбщежитиеDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator roomBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton roomBindingNavigatorSaveItem;
		private ОбщежитиеDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
		private System.Windows.Forms.TextBox room_nTextBox;
		private System.Windows.Forms.TextBox value_nTextBox;
		private System.Windows.Forms.TextBox amountTextBox;
		private System.Windows.Forms.TextBox toolsTextBox;
		private System.Windows.Forms.TextBox flourTextBox;
		private System.Windows.Forms.BindingSource studentBindingSource;
		private System.Windows.Forms.DataGridView studentDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.Button button1;
	}
}