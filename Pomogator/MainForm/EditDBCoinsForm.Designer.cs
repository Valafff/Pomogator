namespace Pomogator.MainForm
{
	partial class EditDBCoinsForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox_coinShortName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker_addDateNewCoin = new System.Windows.Forms.DateTimePicker();
			this.textBox_coinName = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.button_delCoinName = new System.Windows.Forms.Button();
			this.button_editCoinName = new System.Windows.Forms.Button();
			this.button_newCoinName = new System.Windows.Forms.Button();
			this.listBox_coinsNameList = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.listBox_coinsNameList, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.93813F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.06187F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.textBox_coinShortName, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.dateTimePicker_addDateNewCoin, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBox_coinName, 1, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 59);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// textBox_coinShortName
			// 
			this.textBox_coinShortName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_coinShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_coinShortName.Location = new System.Drawing.Point(531, 32);
			this.textBox_coinShortName.Name = "textBox_coinShortName";
			this.textBox_coinShortName.Size = new System.Drawing.Size(260, 26);
			this.textBox_coinShortName.TabIndex = 5;
			this.textBox_coinShortName.TextChanged += new System.EventHandler(this.textBox_coinName_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(531, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Короткое название:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(267, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(258, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Название монеты:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(258, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Дата добавления:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateTimePicker_addDateNewCoin
			// 
			this.dateTimePicker_addDateNewCoin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_addDateNewCoin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePicker_addDateNewCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_addDateNewCoin.Location = new System.Drawing.Point(3, 32);
			this.dateTimePicker_addDateNewCoin.Name = "dateTimePicker_addDateNewCoin";
			this.dateTimePicker_addDateNewCoin.Size = new System.Drawing.Size(258, 26);
			this.dateTimePicker_addDateNewCoin.TabIndex = 3;
			// 
			// textBox_coinName
			// 
			this.textBox_coinName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_coinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_coinName.Location = new System.Drawing.Point(267, 32);
			this.textBox_coinName.Name = "textBox_coinName";
			this.textBox_coinName.Size = new System.Drawing.Size(258, 26);
			this.textBox_coinName.TabIndex = 4;
			this.textBox_coinName.TextChanged += new System.EventHandler(this.textBox_coinName_TextChanged);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.Controls.Add(this.button_delCoinName, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.button_editCoinName, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.button_newCoinName, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 68);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 34);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// button_delCoinName
			// 
			this.button_delCoinName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_delCoinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_delCoinName.Location = new System.Drawing.Point(531, 3);
			this.button_delCoinName.Name = "button_delCoinName";
			this.button_delCoinName.Size = new System.Drawing.Size(260, 28);
			this.button_delCoinName.TabIndex = 2;
			this.button_delCoinName.Text = "Удалить валюту из БД";
			this.button_delCoinName.UseVisualStyleBackColor = true;
			this.button_delCoinName.Click += new System.EventHandler(this.button_delCoinName_Click);
			// 
			// button_editCoinName
			// 
			this.button_editCoinName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_editCoinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_editCoinName.Location = new System.Drawing.Point(267, 3);
			this.button_editCoinName.Name = "button_editCoinName";
			this.button_editCoinName.Size = new System.Drawing.Size(258, 28);
			this.button_editCoinName.TabIndex = 1;
			this.button_editCoinName.Text = "Редактировать валюту в БД";
			this.button_editCoinName.UseVisualStyleBackColor = true;
			this.button_editCoinName.Click += new System.EventHandler(this.button_editCoinName_Click);
			// 
			// button_newCoinName
			// 
			this.button_newCoinName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_newCoinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_newCoinName.Location = new System.Drawing.Point(3, 3);
			this.button_newCoinName.Name = "button_newCoinName";
			this.button_newCoinName.Size = new System.Drawing.Size(258, 28);
			this.button_newCoinName.TabIndex = 0;
			this.button_newCoinName.Text = "Добавить новую валюту в БД";
			this.button_newCoinName.UseVisualStyleBackColor = true;
			this.button_newCoinName.Click += new System.EventHandler(this.button_newCoinName_Click);
			// 
			// listBox_coinsNameList
			// 
			this.listBox_coinsNameList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox_coinsNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox_coinsNameList.FormattingEnabled = true;
			this.listBox_coinsNameList.ItemHeight = 20;
			this.listBox_coinsNameList.Location = new System.Drawing.Point(3, 108);
			this.listBox_coinsNameList.Name = "listBox_coinsNameList";
			this.listBox_coinsNameList.Size = new System.Drawing.Size(794, 339);
			this.listBox_coinsNameList.TabIndex = 2;
			this.listBox_coinsNameList.SelectedIndexChanged += new System.EventHandler(this.listBox_coinsNameList_SelectedIndexChanged);
			// 
			// EditDBCoinsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "EditDBCoinsForm";
			this.Text = "Редактирование БД валют";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditDBCoinsForm_FormClosed);
			this.Load += new System.EventHandler(this.EditDBCoinsForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_coinShortName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker_addDateNewCoin;
		private System.Windows.Forms.TextBox textBox_coinName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button button_delCoinName;
		private System.Windows.Forms.Button button_editCoinName;
		private System.Windows.Forms.Button button_newCoinName;
		private System.Windows.Forms.ListBox listBox_coinsNameList;
	}
}