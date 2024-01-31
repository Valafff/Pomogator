using System;
using System.Windows.Forms;

namespace Pomogator
{
	partial class ExpenceIncomeForm
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
			this.tableLayoutPanel_ExpenceIncomeGrig = new System.Windows.Forms.TableLayoutPanel();
			this.lb_coinPair = new System.Windows.Forms.Label();
			this.lb_Kind = new System.Windows.Forms.Label();
			this.dateTimePicker_open = new System.Windows.Forms.DateTimePicker();
			this.lb_Date = new System.Windows.Forms.Label();
			this.comboBox_Kind = new System.Windows.Forms.ComboBox();
			this.lb_category = new System.Windows.Forms.Label();
			this.comboBox_Category = new System.Windows.Forms.ComboBox();
			this.lb_Income = new System.Windows.Forms.Label();
			this.lb_Expence = new System.Windows.Forms.Label();
			this.lb_numberLots = new System.Windows.Forms.Label();
			this.lb_status = new System.Windows.Forms.Label();
			this.lb_tag = new System.Windows.Forms.Label();
			this.numericUpDown_numberLots = new System.Windows.Forms.NumericUpDown();
			this.comboBox_CoinPair = new System.Windows.Forms.ComboBox();
			this.comboBox_positionStatus = new System.Windows.Forms.ComboBox();
			this.tb_tag = new System.Windows.Forms.TextBox();
			this.textBox_Income = new System.Windows.Forms.TextBox();
			this.textBox_Expence = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьНовуюПозициюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox_DefaultCoin = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTextBox_search = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripComboBox_CategorySearch = new System.Windows.Forms.ToolStripComboBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox_notes = new System.Windows.Forms.GroupBox();
			this.textBox_notes = new System.Windows.Forms.TextBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.groupBox_CurrenPosInfo = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lb_currCoinInfo = new System.Windows.Forms.Label();
			this.lb_saldoInfo = new System.Windows.Forms.Label();
			this.lb_statusInfo = new System.Windows.Forms.Label();
			this.lb_closeDateInfo = new System.Windows.Forms.Label();
			this.lb_lotcountInfo = new System.Windows.Forms.Label();
			this.lb_totalExpenceInfo = new System.Windows.Forms.Label();
			this.lb_categoryInfo = new System.Windows.Forms.Label();
			this.lb_dateOpenInfo = new System.Windows.Forms.Label();
			this.lb_tagInfo = new System.Windows.Forms.Label();
			this.lb_totalIncomInfo = new System.Windows.Forms.Label();
			this.lb_kindInfo = new System.Windows.Forms.Label();
			this.lb_ID = new System.Windows.Forms.Label();
			this.lb_openDate = new System.Windows.Forms.Label();
			this.lb_closeDate = new System.Windows.Forms.Label();
			this.lb_kindI2 = new System.Windows.Forms.Label();
			this.lb_category2 = new System.Windows.Forms.Label();
			this.lb_status2 = new System.Windows.Forms.Label();
			this.lb_totalIncome = new System.Windows.Forms.Label();
			this.lb_totalExpence = new System.Windows.Forms.Label();
			this.lb_saldo2 = new System.Windows.Forms.Label();
			this.ln_tag2 = new System.Windows.Forms.Label();
			this.lb_coin2 = new System.Windows.Forms.Label();
			this.lb_lotCount = new System.Windows.Forms.Label();
			this.lb_IDInfo = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_writePosition = new System.Windows.Forms.Button();
			this.btn_UpdatePosition = new System.Windows.Forms.Button();
			this.btn_deletePosition = new System.Windows.Forms.Button();
			this.groupBox_WorkPositionField = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView_positions = new System.Windows.Forms.DataGridView();
			this.my_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.openDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.closeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expence = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lotCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_refreshDataGrid = new System.Windows.Forms.Button();
			this.comboBox_GroupData = new System.Windows.Forms.ComboBox();
			this.btn_ReversSort = new System.Windows.Forms.Button();
			this.lb_dateFromTitel = new System.Windows.Forms.Label();
			this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
			this.label_EndDateTitel = new System.Windows.Forms.Label();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.statusStripExIncForm = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel_numberPositions = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelBufferNow = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelBufferNowData = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel_MonthIncome = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelMonthExpence = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel_MonthSaldo = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel_ExpenceIncomeGrig.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numberLots)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox_notes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.groupBox_CurrenPosInfo.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox_WorkPositionField.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_positions)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.statusStripExIncForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel_ExpenceIncomeGrig
			// 
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnCount = 9;
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.97191F));
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.81672F));
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.81672F));
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80279F));
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80279F));
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.099598F));
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.68743F));
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.00103F));
			this.tableLayoutPanel_ExpenceIncomeGrig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.00103F));
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.lb_coinPair, 6, 0);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.lb_Kind, 2, 0);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.dateTimePicker_open, 0, 1);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.lb_Date, 0, 0);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.comboBox_Kind, 2, 1);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.lb_category, 1, 0);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.comboBox_Category, 1, 1);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.lb_Income, 3, 0);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.lb_Expence, 4, 0);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.lb_numberLots, 5, 0);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.lb_status, 7, 0);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.lb_tag, 8, 0);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.numericUpDown_numberLots, 5, 1);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.comboBox_CoinPair, 6, 1);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.comboBox_positionStatus, 7, 1);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.tb_tag, 8, 1);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.textBox_Income, 3, 1);
			this.tableLayoutPanel_ExpenceIncomeGrig.Controls.Add(this.textBox_Expence, 4, 1);
			this.tableLayoutPanel_ExpenceIncomeGrig.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel_ExpenceIncomeGrig.Location = new System.Drawing.Point(0, 27);
			this.tableLayoutPanel_ExpenceIncomeGrig.Name = "tableLayoutPanel_ExpenceIncomeGrig";
			this.tableLayoutPanel_ExpenceIncomeGrig.RowCount = 2;
			this.tableLayoutPanel_ExpenceIncomeGrig.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel_ExpenceIncomeGrig.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel_ExpenceIncomeGrig.Size = new System.Drawing.Size(1434, 45);
			this.tableLayoutPanel_ExpenceIncomeGrig.TabIndex = 1000;
			// 
			// lb_coinPair
			// 
			this.lb_coinPair.AutoSize = true;
			this.lb_coinPair.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_coinPair.Location = new System.Drawing.Point(1036, 0);
			this.lb_coinPair.Name = "lb_coinPair";
			this.lb_coinPair.Size = new System.Drawing.Size(161, 13);
			this.lb_coinPair.TabIndex = 1001;
			this.lb_coinPair.Text = "Валюта/валютная пара";
			// 
			// lb_Kind
			// 
			this.lb_Kind.AutoSize = true;
			this.lb_Kind.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_Kind.Location = new System.Drawing.Point(386, 0);
			this.lb_Kind.Name = "lb_Kind";
			this.lb_Kind.Size = new System.Drawing.Size(206, 13);
			this.lb_Kind.TabIndex = 1002;
			this.lb_Kind.Text = "Вид расхода/прихода";
			// 
			// dateTimePicker_open
			// 
			this.dateTimePicker_open.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePicker_open.Location = new System.Drawing.Point(3, 16);
			this.dateTimePicker_open.Name = "dateTimePicker_open";
			this.dateTimePicker_open.Size = new System.Drawing.Size(165, 20);
			this.dateTimePicker_open.TabIndex = 0;
			// 
			// lb_Date
			// 
			this.lb_Date.AutoSize = true;
			this.lb_Date.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_Date.Location = new System.Drawing.Point(3, 0);
			this.lb_Date.Name = "lb_Date";
			this.lb_Date.Size = new System.Drawing.Size(165, 13);
			this.lb_Date.TabIndex = 1004;
			this.lb_Date.Text = "Дата открытия позиции";
			// 
			// comboBox_Kind
			// 
			this.comboBox_Kind.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_Kind.FormattingEnabled = true;
			this.comboBox_Kind.Location = new System.Drawing.Point(386, 16);
			this.comboBox_Kind.Name = "comboBox_Kind";
			this.comboBox_Kind.Size = new System.Drawing.Size(206, 21);
			this.comboBox_Kind.TabIndex = 2;
			this.comboBox_Kind.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kind_TextUpdate);
			this.comboBox_Kind.TextUpdate += new System.EventHandler(this.comboBox_Kind_TextUpdate);
			// 
			// lb_category
			// 
			this.lb_category.AutoSize = true;
			this.lb_category.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_category.Location = new System.Drawing.Point(174, 0);
			this.lb_category.Name = "lb_category";
			this.lb_category.Size = new System.Drawing.Size(206, 13);
			this.lb_category.TabIndex = 1006;
			this.lb_category.Text = "Категория расхода/прихода";
			// 
			// comboBox_Category
			// 
			this.comboBox_Category.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_Category.FormattingEnabled = true;
			this.comboBox_Category.Location = new System.Drawing.Point(174, 16);
			this.comboBox_Category.Name = "comboBox_Category";
			this.comboBox_Category.Size = new System.Drawing.Size(206, 21);
			this.comboBox_Category.TabIndex = 1;
			this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
			this.comboBox_Category.TextUpdate += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
			// 
			// lb_Income
			// 
			this.lb_Income.AutoSize = true;
			this.lb_Income.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_Income.Location = new System.Drawing.Point(598, 0);
			this.lb_Income.Name = "lb_Income";
			this.lb_Income.Size = new System.Drawing.Size(148, 13);
			this.lb_Income.TabIndex = 1008;
			this.lb_Income.Text = "Приход";
			// 
			// lb_Expence
			// 
			this.lb_Expence.AutoSize = true;
			this.lb_Expence.Location = new System.Drawing.Point(752, 0);
			this.lb_Expence.Name = "lb_Expence";
			this.lb_Expence.Size = new System.Drawing.Size(43, 13);
			this.lb_Expence.TabIndex = 1009;
			this.lb_Expence.Text = "Расход";
			// 
			// lb_numberLots
			// 
			this.lb_numberLots.AutoSize = true;
			this.lb_numberLots.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_numberLots.Location = new System.Drawing.Point(906, 0);
			this.lb_numberLots.Name = "lb_numberLots";
			this.lb_numberLots.Size = new System.Drawing.Size(124, 13);
			this.lb_numberLots.TabIndex = 1010;
			this.lb_numberLots.Text = "Количество лотов";
			// 
			// lb_status
			// 
			this.lb_status.AutoSize = true;
			this.lb_status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_status.Location = new System.Drawing.Point(1203, 0);
			this.lb_status.Name = "lb_status";
			this.lb_status.Size = new System.Drawing.Size(108, 13);
			this.lb_status.TabIndex = 1011;
			this.lb_status.Text = "Статус позиции";
			// 
			// lb_tag
			// 
			this.lb_tag.AutoSize = true;
			this.lb_tag.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_tag.Location = new System.Drawing.Point(1317, 0);
			this.lb_tag.Name = "lb_tag";
			this.lb_tag.Size = new System.Drawing.Size(114, 13);
			this.lb_tag.TabIndex = 1012;
			this.lb_tag.Text = "Тег";
			// 
			// numericUpDown_numberLots
			// 
			this.numericUpDown_numberLots.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDown_numberLots.Location = new System.Drawing.Point(906, 16);
			this.numericUpDown_numberLots.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.numericUpDown_numberLots.Name = "numericUpDown_numberLots";
			this.numericUpDown_numberLots.Size = new System.Drawing.Size(124, 20);
			this.numericUpDown_numberLots.TabIndex = 5;
			this.numericUpDown_numberLots.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// comboBox_CoinPair
			// 
			this.comboBox_CoinPair.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_CoinPair.FormattingEnabled = true;
			this.comboBox_CoinPair.Location = new System.Drawing.Point(1036, 16);
			this.comboBox_CoinPair.Name = "comboBox_CoinPair";
			this.comboBox_CoinPair.Size = new System.Drawing.Size(161, 21);
			this.comboBox_CoinPair.TabIndex = 6;
			this.comboBox_CoinPair.Text = "рубль";
			this.comboBox_CoinPair.SelectedIndexChanged += new System.EventHandler(this.comboBox_CoinPair_SelectedIndexChanged);
			// 
			// comboBox_positionStatus
			// 
			this.comboBox_positionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_positionStatus.FormattingEnabled = true;
			this.comboBox_positionStatus.Items.AddRange(new object[] {
            "закрыта",
            "открыта"});
			this.comboBox_positionStatus.Location = new System.Drawing.Point(1203, 16);
			this.comboBox_positionStatus.Name = "comboBox_positionStatus";
			this.comboBox_positionStatus.Size = new System.Drawing.Size(108, 21);
			this.comboBox_positionStatus.TabIndex = 7;
			this.comboBox_positionStatus.Text = "закрыта";
			// 
			// tb_tag
			// 
			this.tb_tag.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_tag.Location = new System.Drawing.Point(1317, 16);
			this.tb_tag.Name = "tb_tag";
			this.tb_tag.Size = new System.Drawing.Size(114, 20);
			this.tb_tag.TabIndex = 8;
			// 
			// textBox_Income
			// 
			this.textBox_Income.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_Income.Location = new System.Drawing.Point(598, 16);
			this.textBox_Income.Name = "textBox_Income";
			this.textBox_Income.Size = new System.Drawing.Size(148, 20);
			this.textBox_Income.TabIndex = 3;
			this.textBox_Income.Text = "0";
			this.textBox_Income.TextChanged += new System.EventHandler(this.textBox_Income_TextChanged);
			this.textBox_Income.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Income_KeyPress);
			// 
			// textBox_Expence
			// 
			this.textBox_Expence.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_Expence.Location = new System.Drawing.Point(752, 16);
			this.textBox_Expence.Name = "textBox_Expence";
			this.textBox_Expence.Size = new System.Drawing.Size(148, 20);
			this.textBox_Expence.TabIndex = 4;
			this.textBox_Expence.Text = "0";
			this.textBox_Expence.TextChanged += new System.EventHandler(this.textBox_Expence_TextChanged);
			this.textBox_Expence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Expence_KeyPress);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripTextBox_search,
            this.toolStripComboBox_CategorySearch});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1434, 27);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовуюПозициюToolStripMenuItem,
            this.toolStripMenuItem2});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 23);
			this.toolStripMenuItem1.Text = "Файл";
			// 
			// создатьНовуюПозициюToolStripMenuItem
			// 
			this.создатьНовуюПозициюToolStripMenuItem.Name = "создатьНовуюПозициюToolStripMenuItem";
			this.создатьНовуюПозициюToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
			this.создатьНовуюПозициюToolStripMenuItem.Text = "Создать новую позицию";
			this.создатьНовуюПозициюToolStripMenuItem.Click += new System.EventHandler(this.создатьНовуюПозициюToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_DefaultCoin});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(239, 22);
			this.toolStripMenuItem2.Text = "Задать валюту по умолчанию";
			// 
			// toolStripComboBox_DefaultCoin
			// 
			this.toolStripComboBox_DefaultCoin.Name = "toolStripComboBox_DefaultCoin";
			this.toolStripComboBox_DefaultCoin.Size = new System.Drawing.Size(121, 23);
			this.toolStripComboBox_DefaultCoin.TextChanged += new System.EventHandler(this.toolStripComboBox_DefaultCoin_TextChanged);
			// 
			// toolStripTextBox_search
			// 
			this.toolStripTextBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolStripTextBox_search.Name = "toolStripTextBox_search";
			this.toolStripTextBox_search.Size = new System.Drawing.Size(200, 23);
			this.toolStripTextBox_search.Enter += new System.EventHandler(this.toolStripTextBox_search_Enter);
			this.toolStripTextBox_search.Leave += new System.EventHandler(this.toolStripTextBox_search_Leave);
			this.toolStripTextBox_search.TextChanged += new System.EventHandler(this.toolStripTextBox_search_TextChanged);
			// 
			// toolStripComboBox_CategorySearch
			// 
			this.toolStripComboBox_CategorySearch.Items.AddRange(new object[] {
            "ID",
            "Категория",
            "Вид",
            "Тег",
            "Валютная пара",
            "Примечания",
            "Статус позиции"});
			this.toolStripComboBox_CategorySearch.Name = "toolStripComboBox_CategorySearch";
			this.toolStripComboBox_CategorySearch.Size = new System.Drawing.Size(121, 23);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitContainer1.Location = new System.Drawing.Point(0, 72);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox_notes);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1434, 120);
			this.splitContainer1.SplitterDistance = 478;
			this.splitContainer1.TabIndex = 1020;
			this.splitContainer1.TabStop = false;
			// 
			// groupBox_notes
			// 
			this.groupBox_notes.Controls.Add(this.textBox_notes);
			this.groupBox_notes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_notes.Location = new System.Drawing.Point(0, 0);
			this.groupBox_notes.Name = "groupBox_notes";
			this.groupBox_notes.Size = new System.Drawing.Size(478, 120);
			this.groupBox_notes.TabIndex = 1021;
			this.groupBox_notes.TabStop = false;
			this.groupBox_notes.Text = "Примечание";
			// 
			// textBox_notes
			// 
			this.textBox_notes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_notes.Location = new System.Drawing.Point(3, 16);
			this.textBox_notes.Multiline = true;
			this.textBox_notes.Name = "textBox_notes";
			this.textBox_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_notes.Size = new System.Drawing.Size(472, 101);
			this.textBox_notes.TabIndex = 9;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.groupBox_CurrenPosInfo);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer2.Size = new System.Drawing.Size(952, 120);
			this.splitContainer2.SplitterDistance = 85;
			this.splitContainer2.TabIndex = 1023;
			this.splitContainer2.TabStop = false;
			// 
			// groupBox_CurrenPosInfo
			// 
			this.groupBox_CurrenPosInfo.Controls.Add(this.tableLayoutPanel3);
			this.groupBox_CurrenPosInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_CurrenPosInfo.Location = new System.Drawing.Point(0, 0);
			this.groupBox_CurrenPosInfo.Name = "groupBox_CurrenPosInfo";
			this.groupBox_CurrenPosInfo.Size = new System.Drawing.Size(952, 85);
			this.groupBox_CurrenPosInfo.TabIndex = 1024;
			this.groupBox_CurrenPosInfo.TabStop = false;
			this.groupBox_CurrenPosInfo.Text = "Информация по текущей позиции";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Window;
			this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel3.ColumnCount = 8;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel3.Controls.Add(this.lb_currCoinInfo, 7, 2);
			this.tableLayoutPanel3.Controls.Add(this.lb_saldoInfo, 5, 2);
			this.tableLayoutPanel3.Controls.Add(this.lb_statusInfo, 3, 2);
			this.tableLayoutPanel3.Controls.Add(this.lb_closeDateInfo, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.lb_lotcountInfo, 7, 1);
			this.tableLayoutPanel3.Controls.Add(this.lb_totalExpenceInfo, 5, 1);
			this.tableLayoutPanel3.Controls.Add(this.lb_categoryInfo, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.lb_dateOpenInfo, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.lb_tagInfo, 7, 0);
			this.tableLayoutPanel3.Controls.Add(this.lb_totalIncomInfo, 5, 0);
			this.tableLayoutPanel3.Controls.Add(this.lb_kindInfo, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.lb_ID, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.lb_openDate, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.lb_closeDate, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.lb_kindI2, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.lb_category2, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.lb_status2, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this.lb_totalIncome, 4, 0);
			this.tableLayoutPanel3.Controls.Add(this.lb_totalExpence, 4, 1);
			this.tableLayoutPanel3.Controls.Add(this.lb_saldo2, 4, 2);
			this.tableLayoutPanel3.Controls.Add(this.ln_tag2, 6, 0);
			this.tableLayoutPanel3.Controls.Add(this.lb_coin2, 6, 2);
			this.tableLayoutPanel3.Controls.Add(this.lb_lotCount, 6, 1);
			this.tableLayoutPanel3.Controls.Add(this.lb_IDInfo, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(946, 66);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// lb_currCoinInfo
			// 
			this.lb_currCoinInfo.AutoSize = true;
			this.lb_currCoinInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_currCoinInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_currCoinInfo.Location = new System.Drawing.Point(830, 43);
			this.lb_currCoinInfo.Name = "lb_currCoinInfo";
			this.lb_currCoinInfo.Size = new System.Drawing.Size(112, 22);
			this.lb_currCoinInfo.TabIndex = 23;
			this.lb_currCoinInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_saldoInfo
			// 
			this.lb_saldoInfo.AutoSize = true;
			this.lb_saldoInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_saldoInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_saldoInfo.Location = new System.Drawing.Point(594, 43);
			this.lb_saldoInfo.Name = "lb_saldoInfo";
			this.lb_saldoInfo.Size = new System.Drawing.Size(111, 22);
			this.lb_saldoInfo.TabIndex = 22;
			this.lb_saldoInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_statusInfo
			// 
			this.lb_statusInfo.AutoSize = true;
			this.lb_statusInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_statusInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_statusInfo.Location = new System.Drawing.Point(358, 43);
			this.lb_statusInfo.Name = "lb_statusInfo";
			this.lb_statusInfo.Size = new System.Drawing.Size(111, 22);
			this.lb_statusInfo.TabIndex = 21;
			this.lb_statusInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_closeDateInfo
			// 
			this.lb_closeDateInfo.AutoSize = true;
			this.lb_closeDateInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_closeDateInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_closeDateInfo.Location = new System.Drawing.Point(122, 43);
			this.lb_closeDateInfo.Name = "lb_closeDateInfo";
			this.lb_closeDateInfo.Size = new System.Drawing.Size(111, 22);
			this.lb_closeDateInfo.TabIndex = 20;
			this.lb_closeDateInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_lotcountInfo
			// 
			this.lb_lotcountInfo.AutoSize = true;
			this.lb_lotcountInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_lotcountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_lotcountInfo.Location = new System.Drawing.Point(830, 22);
			this.lb_lotcountInfo.Name = "lb_lotcountInfo";
			this.lb_lotcountInfo.Size = new System.Drawing.Size(112, 20);
			this.lb_lotcountInfo.TabIndex = 19;
			this.lb_lotcountInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_totalExpenceInfo
			// 
			this.lb_totalExpenceInfo.AutoSize = true;
			this.lb_totalExpenceInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_totalExpenceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_totalExpenceInfo.Location = new System.Drawing.Point(594, 22);
			this.lb_totalExpenceInfo.Name = "lb_totalExpenceInfo";
			this.lb_totalExpenceInfo.Size = new System.Drawing.Size(111, 20);
			this.lb_totalExpenceInfo.TabIndex = 18;
			this.lb_totalExpenceInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_categoryInfo
			// 
			this.lb_categoryInfo.AutoSize = true;
			this.lb_categoryInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_categoryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_categoryInfo.Location = new System.Drawing.Point(358, 22);
			this.lb_categoryInfo.Name = "lb_categoryInfo";
			this.lb_categoryInfo.Size = new System.Drawing.Size(111, 20);
			this.lb_categoryInfo.TabIndex = 17;
			this.lb_categoryInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_dateOpenInfo
			// 
			this.lb_dateOpenInfo.AutoSize = true;
			this.lb_dateOpenInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_dateOpenInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_dateOpenInfo.Location = new System.Drawing.Point(122, 22);
			this.lb_dateOpenInfo.Name = "lb_dateOpenInfo";
			this.lb_dateOpenInfo.Size = new System.Drawing.Size(111, 20);
			this.lb_dateOpenInfo.TabIndex = 16;
			this.lb_dateOpenInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_tagInfo
			// 
			this.lb_tagInfo.AutoSize = true;
			this.lb_tagInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_tagInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_tagInfo.Location = new System.Drawing.Point(830, 1);
			this.lb_tagInfo.Name = "lb_tagInfo";
			this.lb_tagInfo.Size = new System.Drawing.Size(112, 20);
			this.lb_tagInfo.TabIndex = 15;
			this.lb_tagInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_totalIncomInfo
			// 
			this.lb_totalIncomInfo.AutoSize = true;
			this.lb_totalIncomInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_totalIncomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_totalIncomInfo.Location = new System.Drawing.Point(594, 1);
			this.lb_totalIncomInfo.Name = "lb_totalIncomInfo";
			this.lb_totalIncomInfo.Size = new System.Drawing.Size(111, 20);
			this.lb_totalIncomInfo.TabIndex = 14;
			this.lb_totalIncomInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_kindInfo
			// 
			this.lb_kindInfo.AutoSize = true;
			this.lb_kindInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_kindInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_kindInfo.Location = new System.Drawing.Point(358, 1);
			this.lb_kindInfo.Name = "lb_kindInfo";
			this.lb_kindInfo.Size = new System.Drawing.Size(111, 20);
			this.lb_kindInfo.TabIndex = 13;
			this.lb_kindInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// lb_ID
			// 
			this.lb_ID.AutoSize = true;
			this.lb_ID.BackColor = System.Drawing.SystemColors.Window;
			this.lb_ID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_ID.Location = new System.Drawing.Point(4, 1);
			this.lb_ID.Name = "lb_ID";
			this.lb_ID.Size = new System.Drawing.Size(111, 20);
			this.lb_ID.TabIndex = 0;
			this.lb_ID.Text = "ID";
			// 
			// lb_openDate
			// 
			this.lb_openDate.AutoSize = true;
			this.lb_openDate.BackColor = System.Drawing.SystemColors.Window;
			this.lb_openDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_openDate.Location = new System.Drawing.Point(4, 22);
			this.lb_openDate.Name = "lb_openDate";
			this.lb_openDate.Size = new System.Drawing.Size(111, 20);
			this.lb_openDate.TabIndex = 1;
			this.lb_openDate.Text = "Дата созд./ред.";
			// 
			// lb_closeDate
			// 
			this.lb_closeDate.AutoSize = true;
			this.lb_closeDate.BackColor = System.Drawing.SystemColors.Window;
			this.lb_closeDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_closeDate.Location = new System.Drawing.Point(4, 43);
			this.lb_closeDate.Name = "lb_closeDate";
			this.lb_closeDate.Size = new System.Drawing.Size(111, 22);
			this.lb_closeDate.TabIndex = 2;
			this.lb_closeDate.Text = "Дата закрытия";
			// 
			// lb_kindI2
			// 
			this.lb_kindI2.AutoSize = true;
			this.lb_kindI2.BackColor = System.Drawing.SystemColors.Window;
			this.lb_kindI2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_kindI2.Location = new System.Drawing.Point(240, 1);
			this.lb_kindI2.Name = "lb_kindI2";
			this.lb_kindI2.Size = new System.Drawing.Size(111, 20);
			this.lb_kindI2.TabIndex = 3;
			this.lb_kindI2.Text = "Вид";
			// 
			// lb_category2
			// 
			this.lb_category2.AutoSize = true;
			this.lb_category2.BackColor = System.Drawing.SystemColors.Window;
			this.lb_category2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_category2.Location = new System.Drawing.Point(240, 22);
			this.lb_category2.Name = "lb_category2";
			this.lb_category2.Size = new System.Drawing.Size(111, 20);
			this.lb_category2.TabIndex = 4;
			this.lb_category2.Text = "Категория";
			// 
			// lb_status2
			// 
			this.lb_status2.AutoSize = true;
			this.lb_status2.Location = new System.Drawing.Point(240, 43);
			this.lb_status2.Name = "lb_status2";
			this.lb_status2.Size = new System.Drawing.Size(61, 13);
			this.lb_status2.TabIndex = 5;
			this.lb_status2.Text = "Состояние";
			// 
			// lb_totalIncome
			// 
			this.lb_totalIncome.AutoSize = true;
			this.lb_totalIncome.BackColor = System.Drawing.SystemColors.Window;
			this.lb_totalIncome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_totalIncome.Location = new System.Drawing.Point(476, 1);
			this.lb_totalIncome.Name = "lb_totalIncome";
			this.lb_totalIncome.Size = new System.Drawing.Size(111, 20);
			this.lb_totalIncome.TabIndex = 6;
			this.lb_totalIncome.Text = "Весь приход";
			// 
			// lb_totalExpence
			// 
			this.lb_totalExpence.AutoSize = true;
			this.lb_totalExpence.BackColor = System.Drawing.SystemColors.Window;
			this.lb_totalExpence.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_totalExpence.Location = new System.Drawing.Point(476, 22);
			this.lb_totalExpence.Name = "lb_totalExpence";
			this.lb_totalExpence.Size = new System.Drawing.Size(111, 20);
			this.lb_totalExpence.TabIndex = 7;
			this.lb_totalExpence.Text = "Весь расход";
			// 
			// lb_saldo2
			// 
			this.lb_saldo2.AutoSize = true;
			this.lb_saldo2.BackColor = System.Drawing.SystemColors.Window;
			this.lb_saldo2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_saldo2.Location = new System.Drawing.Point(476, 43);
			this.lb_saldo2.Name = "lb_saldo2";
			this.lb_saldo2.Size = new System.Drawing.Size(111, 22);
			this.lb_saldo2.TabIndex = 8;
			this.lb_saldo2.Text = "Сальдо";
			// 
			// ln_tag2
			// 
			this.ln_tag2.AutoSize = true;
			this.ln_tag2.BackColor = System.Drawing.SystemColors.Window;
			this.ln_tag2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ln_tag2.Location = new System.Drawing.Point(712, 1);
			this.ln_tag2.Name = "ln_tag2";
			this.ln_tag2.Size = new System.Drawing.Size(111, 20);
			this.ln_tag2.TabIndex = 9;
			this.ln_tag2.Text = "Тег";
			// 
			// lb_coin2
			// 
			this.lb_coin2.AutoSize = true;
			this.lb_coin2.BackColor = System.Drawing.SystemColors.Window;
			this.lb_coin2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_coin2.Location = new System.Drawing.Point(712, 43);
			this.lb_coin2.Name = "lb_coin2";
			this.lb_coin2.Size = new System.Drawing.Size(111, 22);
			this.lb_coin2.TabIndex = 10;
			this.lb_coin2.Text = "Валюта";
			// 
			// lb_lotCount
			// 
			this.lb_lotCount.AutoSize = true;
			this.lb_lotCount.BackColor = System.Drawing.SystemColors.Window;
			this.lb_lotCount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_lotCount.Location = new System.Drawing.Point(712, 22);
			this.lb_lotCount.Name = "lb_lotCount";
			this.lb_lotCount.Size = new System.Drawing.Size(111, 20);
			this.lb_lotCount.TabIndex = 11;
			this.lb_lotCount.Text = "Количество лотов";
			// 
			// lb_IDInfo
			// 
			this.lb_IDInfo.AutoSize = true;
			this.lb_IDInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lb_IDInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_IDInfo.Location = new System.Drawing.Point(122, 1);
			this.lb_IDInfo.Name = "lb_IDInfo";
			this.lb_IDInfo.Size = new System.Drawing.Size(111, 20);
			this.lb_IDInfo.TabIndex = 12;
			this.lb_IDInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_IDInfo_MouseDoubleClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.btn_writePosition, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_UpdatePosition, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_deletePosition, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 31);
			this.tableLayoutPanel1.TabIndex = 1025;
			// 
			// btn_writePosition
			// 
			this.btn_writePosition.AutoSize = true;
			this.btn_writePosition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_writePosition.Location = new System.Drawing.Point(3, 3);
			this.btn_writePosition.Name = "btn_writePosition";
			this.btn_writePosition.Size = new System.Drawing.Size(311, 25);
			this.btn_writePosition.TabIndex = 10;
			this.btn_writePosition.Text = "Записать новую позицию/продолжить комплексную";
			this.btn_writePosition.UseVisualStyleBackColor = true;
			this.btn_writePosition.Click += new System.EventHandler(this.btn_writePosition_Click);
			// 
			// btn_UpdatePosition
			// 
			this.btn_UpdatePosition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_UpdatePosition.Enabled = false;
			this.btn_UpdatePosition.Location = new System.Drawing.Point(320, 3);
			this.btn_UpdatePosition.Name = "btn_UpdatePosition";
			this.btn_UpdatePosition.Size = new System.Drawing.Size(311, 25);
			this.btn_UpdatePosition.TabIndex = 11;
			this.btn_UpdatePosition.Text = "Перезаписать позицию";
			this.btn_UpdatePosition.UseVisualStyleBackColor = true;
			this.btn_UpdatePosition.Click += new System.EventHandler(this.btn_UpdatePosition_Click);
			// 
			// btn_deletePosition
			// 
			this.btn_deletePosition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_deletePosition.Enabled = false;
			this.btn_deletePosition.Location = new System.Drawing.Point(637, 3);
			this.btn_deletePosition.Name = "btn_deletePosition";
			this.btn_deletePosition.Size = new System.Drawing.Size(312, 25);
			this.btn_deletePosition.TabIndex = 12;
			this.btn_deletePosition.Text = "Удалить позицию";
			this.btn_deletePosition.UseVisualStyleBackColor = true;
			this.btn_deletePosition.Click += new System.EventHandler(this.btn_deletePosition_Click);
			// 
			// groupBox_WorkPositionField
			// 
			this.groupBox_WorkPositionField.Controls.Add(this.tableLayoutPanel2);
			this.groupBox_WorkPositionField.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_WorkPositionField.Location = new System.Drawing.Point(0, 192);
			this.groupBox_WorkPositionField.Name = "groupBox_WorkPositionField";
			this.groupBox_WorkPositionField.Size = new System.Drawing.Size(1434, 569);
			this.groupBox_WorkPositionField.TabIndex = 1027;
			this.groupBox_WorkPositionField.TabStop = false;
			this.groupBox_WorkPositionField.Text = "Работа с записанными позициями";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.dataGridView_positions, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1428, 550);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// dataGridView_positions
			// 
			this.dataGridView_positions.AllowUserToAddRows = false;
			this.dataGridView_positions.AllowUserToDeleteRows = false;
			this.dataGridView_positions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_positions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_positions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.my_key,
            this.openDate,
            this.closeDate,
            this.category,
            this.kind,
            this.tag,
            this.income,
            this.expence,
            this.saldo,
            this.lotCount,
            this.coin,
            this.status});
			this.dataGridView_positions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_positions.Location = new System.Drawing.Point(3, 41);
			this.dataGridView_positions.MultiSelect = false;
			this.dataGridView_positions.Name = "dataGridView_positions";
			this.dataGridView_positions.ReadOnly = true;
			this.dataGridView_positions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_positions.Size = new System.Drawing.Size(1422, 506);
			this.dataGridView_positions.TabIndex = 2;
			this.dataGridView_positions.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_positions_CellMouseDoubleClick);
			// 
			// my_key
			// 
			this.my_key.FillWeight = 40F;
			this.my_key.HeaderText = "ID";
			this.my_key.Name = "my_key";
			this.my_key.ReadOnly = true;
			// 
			// openDate
			// 
			this.openDate.FillWeight = 60F;
			this.openDate.HeaderText = "Дата созд./ред.";
			this.openDate.Name = "openDate";
			this.openDate.ReadOnly = true;
			// 
			// closeDate
			// 
			this.closeDate.FillWeight = 60F;
			this.closeDate.HeaderText = "Дата закр.";
			this.closeDate.Name = "closeDate";
			this.closeDate.ReadOnly = true;
			// 
			// category
			// 
			this.category.FillWeight = 150F;
			this.category.HeaderText = "Категория";
			this.category.Name = "category";
			this.category.ReadOnly = true;
			// 
			// kind
			// 
			this.kind.FillWeight = 150F;
			this.kind.HeaderText = "Наименование";
			this.kind.Name = "kind";
			this.kind.ReadOnly = true;
			// 
			// tag
			// 
			this.tag.FillWeight = 50F;
			this.tag.HeaderText = "Тег";
			this.tag.Name = "tag";
			this.tag.ReadOnly = true;
			// 
			// income
			// 
			this.income.FillWeight = 80F;
			this.income.HeaderText = "Приход";
			this.income.Name = "income";
			this.income.ReadOnly = true;
			// 
			// expence
			// 
			this.expence.FillWeight = 80F;
			this.expence.HeaderText = "Расход";
			this.expence.Name = "expence";
			this.expence.ReadOnly = true;
			// 
			// saldo
			// 
			this.saldo.FillWeight = 80F;
			this.saldo.HeaderText = "Сальдо";
			this.saldo.Name = "saldo";
			this.saldo.ReadOnly = true;
			// 
			// lotCount
			// 
			this.lotCount.FillWeight = 50F;
			this.lotCount.HeaderText = "Кол-во лотов";
			this.lotCount.Name = "lotCount";
			this.lotCount.ReadOnly = true;
			// 
			// coin
			// 
			this.coin.FillWeight = 50F;
			this.coin.HeaderText = "Валюта";
			this.coin.Name = "coin";
			this.coin.ReadOnly = true;
			// 
			// status
			// 
			this.status.FillWeight = 50F;
			this.status.HeaderText = "Состояние";
			this.status.Name = "status";
			this.status.ReadOnly = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 7;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.140351F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.140351F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
			this.tableLayoutPanel4.Controls.Add(this.btn_refreshDataGrid, 4, 0);
			this.tableLayoutPanel4.Controls.Add(this.comboBox_GroupData, 5, 0);
			this.tableLayoutPanel4.Controls.Add(this.btn_ReversSort, 6, 0);
			this.tableLayoutPanel4.Controls.Add(this.lb_dateFromTitel, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.dateTimePickerStart, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.label_EndDateTitel, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.dateTimePickerEnd, 3, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1422, 32);
			this.tableLayoutPanel4.TabIndex = 3;
			// 
			// btn_refreshDataGrid
			// 
			this.btn_refreshDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_refreshDataGrid.Location = new System.Drawing.Point(675, 3);
			this.btn_refreshDataGrid.Name = "btn_refreshDataGrid";
			this.btn_refreshDataGrid.Size = new System.Drawing.Size(243, 26);
			this.btn_refreshDataGrid.TabIndex = 1;
			this.btn_refreshDataGrid.Text = "Обновить данные";
			this.btn_refreshDataGrid.UseVisualStyleBackColor = true;
			this.btn_refreshDataGrid.Click += new System.EventHandler(this.btn_refreshDataGrid_Click);
			// 
			// comboBox_GroupData
			// 
			this.comboBox_GroupData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_GroupData.FormattingEnabled = true;
			this.comboBox_GroupData.Items.AddRange(new object[] {
            "ДАТА создания",
            "ДАТА закрытия",
            "КАТЕГОРИЯ",
            "ВИД",
            "ТЕГ",
            "ВАЛЮТА",
            "СТАТУС (закрыт/открыт)",
            "ID"});
			this.comboBox_GroupData.Location = new System.Drawing.Point(924, 3);
			this.comboBox_GroupData.Name = "comboBox_GroupData";
			this.comboBox_GroupData.Size = new System.Drawing.Size(243, 21);
			this.comboBox_GroupData.TabIndex = 2;
			this.comboBox_GroupData.SelectedIndexChanged += new System.EventHandler(this.comboBox_GroupData_SelectedIndexChanged);
			this.comboBox_GroupData.Enter += new System.EventHandler(this.comboBox_GroupData_Enter);
			this.comboBox_GroupData.Leave += new System.EventHandler(this.comboBox_GroupData_Leave);
			// 
			// btn_ReversSort
			// 
			this.btn_ReversSort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_ReversSort.Location = new System.Drawing.Point(1173, 3);
			this.btn_ReversSort.Name = "btn_ReversSort";
			this.btn_ReversSort.Size = new System.Drawing.Size(246, 26);
			this.btn_ReversSort.TabIndex = 3;
			this.btn_ReversSort.Text = "Напраление сортировки ↕";
			this.btn_ReversSort.UseVisualStyleBackColor = true;
			this.btn_ReversSort.Click += new System.EventHandler(this.btn_sortDatafromDB_Click);
			// 
			// lb_dateFromTitel
			// 
			this.lb_dateFromTitel.AutoSize = true;
			this.lb_dateFromTitel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_dateFromTitel.Location = new System.Drawing.Point(3, 0);
			this.lb_dateFromTitel.Name = "lb_dateFromTitel";
			this.lb_dateFromTitel.Size = new System.Drawing.Size(81, 32);
			this.lb_dateFromTitel.TabIndex = 4;
			this.lb_dateFromTitel.Text = "Начать с:";
			// 
			// dateTimePickerStart
			// 
			this.dateTimePickerStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerStart.Location = new System.Drawing.Point(90, 3);
			this.dateTimePickerStart.Name = "dateTimePickerStart";
			this.dateTimePickerStart.Size = new System.Drawing.Size(243, 20);
			this.dateTimePickerStart.TabIndex = 5;
			this.dateTimePickerStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// label_EndDateTitel
			// 
			this.label_EndDateTitel.AutoSize = true;
			this.label_EndDateTitel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_EndDateTitel.Location = new System.Drawing.Point(339, 0);
			this.label_EndDateTitel.Name = "label_EndDateTitel";
			this.label_EndDateTitel.Size = new System.Drawing.Size(81, 32);
			this.label_EndDateTitel.TabIndex = 6;
			this.label_EndDateTitel.Text = "Закончить:";
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerEnd.Location = new System.Drawing.Point(426, 3);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(243, 20);
			this.dateTimePickerEnd.TabIndex = 7;
			this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// statusStripExIncForm
			// 
			this.statusStripExIncForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_numberPositions,
            this.toolStripStatusLabelBufferNow,
            this.toolStripStatusLabelBufferNowData,
            this.toolStripStatusLabel_MonthIncome,
            this.toolStripStatusLabelMonthExpence,
            this.toolStripStatusLabel_MonthSaldo});
			this.statusStripExIncForm.Location = new System.Drawing.Point(0, 739);
			this.statusStripExIncForm.Name = "statusStripExIncForm";
			this.statusStripExIncForm.Size = new System.Drawing.Size(1434, 22);
			this.statusStripExIncForm.TabIndex = 1028;
			// 
			// toolStripStatusLabel_numberPositions
			// 
			this.toolStripStatusLabel_numberPositions.Name = "toolStripStatusLabel_numberPositions";
			this.toolStripStatusLabel_numberPositions.Size = new System.Drawing.Size(125, 17);
			this.toolStripStatusLabel_numberPositions.Text = "Прочитано данных: 0";
			// 
			// toolStripStatusLabelBufferNow
			// 
			this.toolStripStatusLabelBufferNow.Name = "toolStripStatusLabelBufferNow";
			this.toolStripStatusLabelBufferNow.Size = new System.Drawing.Size(170, 17);
			this.toolStripStatusLabelBufferNow.Text = "Текущий элемент в буффере:";
			// 
			// toolStripStatusLabelBufferNowData
			// 
			this.toolStripStatusLabelBufferNowData.Name = "toolStripStatusLabelBufferNowData";
			this.toolStripStatusLabelBufferNowData.Size = new System.Drawing.Size(27, 17);
			this.toolStripStatusLabelBufferNowData.Text = "null";
			// 
			// toolStripStatusLabel_MonthIncome
			// 
			this.toolStripStatusLabel_MonthIncome.Name = "toolStripStatusLabel_MonthIncome";
			this.toolStripStatusLabel_MonthIncome.Size = new System.Drawing.Size(77, 17);
			this.toolStripStatusLabel_MonthIncome.Text = "ПРИХОД ЗА ";
			// 
			// toolStripStatusLabelMonthExpence
			// 
			this.toolStripStatusLabelMonthExpence.Name = "toolStripStatusLabelMonthExpence";
			this.toolStripStatusLabelMonthExpence.Size = new System.Drawing.Size(75, 17);
			this.toolStripStatusLabelMonthExpence.Text = "РАСХОД ЗА ";
			// 
			// toolStripStatusLabel_MonthSaldo
			// 
			this.toolStripStatusLabel_MonthSaldo.Name = "toolStripStatusLabel_MonthSaldo";
			this.toolStripStatusLabel_MonthSaldo.Size = new System.Drawing.Size(58, 17);
			this.toolStripStatusLabel_MonthSaldo.Text = "САЛЬДО ";
			// 
			// ExpenceIncomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1434, 761);
			this.Controls.Add(this.statusStripExIncForm);
			this.Controls.Add(this.groupBox_WorkPositionField);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.tableLayoutPanel_ExpenceIncomeGrig);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ExpenceIncomeForm";
			this.Text = "Форма учета расхода/прихода";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpenceIncomeForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExpenceIncomeForm_FormClosed);
			this.Load += new System.EventHandler(this.ExpenceIncomeForm_Load);
			this.tableLayoutPanel_ExpenceIncomeGrig.ResumeLayout(false);
			this.tableLayoutPanel_ExpenceIncomeGrig.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numberLots)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox_notes.ResumeLayout(false);
			this.groupBox_notes.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.groupBox_CurrenPosInfo.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox_WorkPositionField.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_positions)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.statusStripExIncForm.ResumeLayout(false);
			this.statusStripExIncForm.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ExpenceIncomeGrig;
		private System.Windows.Forms.DateTimePicker dateTimePicker_open;
		private System.Windows.Forms.Label lb_Date;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.Label lb_Kind;
		private System.Windows.Forms.ComboBox comboBox_Kind;
		private Label lb_category;
		private ComboBox comboBox_Category;
		private Label lb_Income;
		private Label lb_Expence;
		private Label lb_numberLots;
		private Label lb_coinPair;
		private Label lb_status;
		private Label lb_tag;
		private SplitContainer splitContainer1;
		private GroupBox groupBox_notes;
		private NumericUpDown numericUpDown_numberLots;
		private ComboBox comboBox_CoinPair;
		private ComboBox comboBox_positionStatus;
		private TextBox tb_tag;
		private TextBox textBox_Income;
		private TextBox textBox_Expence;
		private SplitContainer splitContainer2;
		private Button btn_writePosition;
		private TableLayoutPanel tableLayoutPanel1;
		private GroupBox groupBox_CurrenPosInfo;
		private GroupBox groupBox_WorkPositionField;
		private TableLayoutPanel tableLayoutPanel2;
		private ImageList imageList1;
		private Button btn_refreshDataGrid;
		public DataGridView dataGridView_positions;
		private Button btn_UpdatePosition;
		private Button btn_deletePosition;
		private TableLayoutPanel tableLayoutPanel3;
		private Label lb_ID;
		private Label lb_openDate;
		private Label lb_closeDate;
		private Label lb_kindI2;
		private Label lb_category2;
		private Label lb_status2;
		private Label lb_totalIncome;
		private Label lb_totalExpence;
		private Label lb_saldo2;
		private Label ln_tag2;
		private Label lb_coin2;
		private Label lb_lotCount;
		public Label lb_IDInfo;
		public Label lb_currCoinInfo;
		public Label lb_saldoInfo;
		public Label lb_statusInfo;
		public Label lb_closeDateInfo;
		public Label lb_lotcountInfo;
		public Label lb_totalExpenceInfo;
		public Label lb_categoryInfo;
		public Label lb_dateOpenInfo;
		public Label lb_tagInfo;
		public Label lb_totalIncomInfo;
		public Label lb_kindInfo;
		public TextBox textBox_notes;
		private ToolStripMenuItem создатьНовуюПозициюToolStripMenuItem;
		private TableLayoutPanel tableLayoutPanel4;
		private ComboBox comboBox_GroupData;
		private Button btn_ReversSort;
		private Label lb_dateFromTitel;
		private DateTimePicker dateTimePickerStart;
		private Label label_EndDateTitel;
		private DateTimePicker dateTimePickerEnd;
		private DataGridViewTextBoxColumn my_key;
		private DataGridViewTextBoxColumn openDate;
		private DataGridViewTextBoxColumn closeDate;
		private DataGridViewTextBoxColumn category;
		private DataGridViewTextBoxColumn kind;
		private DataGridViewTextBoxColumn tag;
		private DataGridViewTextBoxColumn income;
		private DataGridViewTextBoxColumn expence;
		private DataGridViewTextBoxColumn saldo;
		private DataGridViewTextBoxColumn lotCount;
		private DataGridViewTextBoxColumn coin;
		private DataGridViewTextBoxColumn status;
		private StatusStrip statusStripExIncForm;
		private ToolStripStatusLabel toolStripStatusLabel_numberPositions;
		private ToolStripStatusLabel toolStripStatusLabelBufferNow;
		private ToolStripStatusLabel toolStripStatusLabelBufferNowData;
		private ToolStripTextBox toolStripTextBox_search;
		private ToolStripComboBox toolStripComboBox_CategorySearch;
		private ToolStripStatusLabel toolStripStatusLabel_MonthIncome;
		private ToolStripStatusLabel toolStripStatusLabelMonthExpence;
		private ToolStripStatusLabel toolStripStatusLabel_MonthSaldo;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripComboBox toolStripComboBox_DefaultCoin;
	}
	//public DataGridViewTextBoxColumn my_key;
	//public DataGridViewTextBoxColumn openDate;
	//public DataGridViewTextBoxColumn closeDate;
	//public DataGridViewTextBoxColumn kind;
	//public DataGridViewTextBoxColumn tag;
	//public DataGridViewTextBoxColumn saldo;
	//public DataGridViewTextBoxColumn lotCount;
	//public DataGridViewTextBoxColumn coin;
	//public DataGridViewTextBoxColumn status;
	//public Label lb_IDInfo;
	//public Label lb_currCoinInfo;
	//public Label lb_saldoInfo;
	//public Label lb_statusInfo;
	//public Label lb_closeDateInfo;
	//public Label lb_lotcountInfo;
	//public Label lb_totalExpenceInfo;
	//public Label lb_categoryInfo;
	//public Label lb_dateOpenInfo;
	//public Label lb_tagInfo;
	//public Label lb_totalIncomInfo;
	//public Label lb_kindInfo;
	//public TextBox textBox_notes;
	// public для sourcecode

				//this.btn_sortDatafromDB.Text = "Напраление сортировки \u2195";

				//this.toolStripStatusLabel_MonthIncome.Text = "приход за " +
				//((DateTime.Now.Month == 1) ? "январь" :
				//(DateTime.Now.Month == 2) ? "февраль" :
				//(DateTime.Now.Month == 3) ? "март" :
				//(DateTime.Now.Month == 4) ? "апрель" :
				//(DateTime.Now.Month == 5) ? "май" :
				//(DateTime.Now.Month == 6) ? "июнь" :
				//(DateTime.Now.Month == 7) ? "июль" :
				//(DateTime.Now.Month == 8) ? "август" :
				//(DateTime.Now.Month == 9) ? "сентябрь" :
				//(DateTime.Now.Month == 10) ? "октябрь" :
				//(DateTime.Now.Month == 11) ? "ноябрь" :
				//"декабрь");

	}