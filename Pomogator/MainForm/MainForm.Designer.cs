namespace Pomogator
{
	partial class Pomogator_MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.расходПриходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.формироватьБюджетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.калькуляторХОМЯКАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.инвентаризацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.заметкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.задатьПутьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.созданиеРезервнойКопииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настроитьОбменныеКурсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_importBD_v1_07 = new System.Windows.Forms.ToolStripMenuItem();
			this.настроитьPINКодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openFileDialogDB_path = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog_BackUp = new System.Windows.Forms.FolderBrowserDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расходПриходToolStripMenuItem,
            this.формироватьБюджетToolStripMenuItem,
            this.калькуляторХОМЯКАToolStripMenuItem,
            this.инвентаризацияToolStripMenuItem,
            this.заметкиToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// расходПриходToolStripMenuItem
			// 
			this.расходПриходToolStripMenuItem.Name = "расходПриходToolStripMenuItem";
			this.расходПриходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
			this.расходПриходToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.расходПриходToolStripMenuItem.Text = "Расход/Приход";
			this.расходПриходToolStripMenuItem.Click += new System.EventHandler(this.расходПриходToolStripMenuItem_Click);
			// 
			// формироватьБюджетToolStripMenuItem
			// 
			this.формироватьБюджетToolStripMenuItem.Name = "формироватьБюджетToolStripMenuItem";
			this.формироватьБюджетToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.формироватьБюджетToolStripMenuItem.Text = "Формировать бюджет";
			// 
			// калькуляторХОМЯКАToolStripMenuItem
			// 
			this.калькуляторХОМЯКАToolStripMenuItem.Name = "калькуляторХОМЯКАToolStripMenuItem";
			this.калькуляторХОМЯКАToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.калькуляторХОМЯКАToolStripMenuItem.Text = "Калькулятор ХОМЯКА";
			// 
			// инвентаризацияToolStripMenuItem
			// 
			this.инвентаризацияToolStripMenuItem.Name = "инвентаризацияToolStripMenuItem";
			this.инвентаризацияToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.инвентаризацияToolStripMenuItem.Text = "Инвентаризация";
			// 
			// заметкиToolStripMenuItem
			// 
			this.заметкиToolStripMenuItem.Name = "заметкиToolStripMenuItem";
			this.заметкиToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.заметкиToolStripMenuItem.Text = "Заметки";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьПутьБДToolStripMenuItem,
            this.созданиеРезервнойКопииToolStripMenuItem,
            this.настроитьОбменныеКурсыToolStripMenuItem,
            this.ToolStripMenuItem_importBD_v1_07,
            this.настроитьPINКодToolStripMenuItem});
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			// 
			// задатьПутьБДToolStripMenuItem
			// 
			this.задатьПутьБДToolStripMenuItem.Name = "задатьПутьБДToolStripMenuItem";
			this.задатьПутьБДToolStripMenuItem.Size = new System.Drawing.Size(347, 22);
			this.задатьПутьБДToolStripMenuItem.Text = "Задать путь БД";
			this.задатьПутьБДToolStripMenuItem.Click += new System.EventHandler(this.задатьПутьБДToolStripMenuItem_Click);
			// 
			// созданиеРезервнойКопииToolStripMenuItem
			// 
			this.созданиеРезервнойКопииToolStripMenuItem.Name = "созданиеРезервнойКопииToolStripMenuItem";
			this.созданиеРезервнойКопииToolStripMenuItem.Size = new System.Drawing.Size(347, 22);
			this.созданиеРезервнойКопииToolStripMenuItem.Text = "Создание резервной копии БД";
			this.созданиеРезервнойКопииToolStripMenuItem.Click += new System.EventHandler(this.созданиеРезервнойКопииToolStripMenuItem_Click);
			// 
			// настроитьОбменныеКурсыToolStripMenuItem
			// 
			this.настроитьОбменныеКурсыToolStripMenuItem.Name = "настроитьОбменныеКурсыToolStripMenuItem";
			this.настроитьОбменныеКурсыToolStripMenuItem.Size = new System.Drawing.Size(347, 22);
			this.настроитьОбменныеКурсыToolStripMenuItem.Text = "Редактировать БД валют";
			this.настроитьОбменныеКурсыToolStripMenuItem.Click += new System.EventHandler(this.editCoinsDBToolStripMenuItem_Click);
			// 
			// ToolStripMenuItem_importBD_v1_07
			// 
			this.ToolStripMenuItem_importBD_v1_07.Name = "ToolStripMenuItem_importBD_v1_07";
			this.ToolStripMenuItem_importBD_v1_07.Size = new System.Drawing.Size(347, 22);
			this.ToolStripMenuItem_importBD_v1_07.Text = "Импорт БД v1.07";
			this.ToolStripMenuItem_importBD_v1_07.Click += new System.EventHandler(this.ToolStripMenuItem_importBD_v1_07_Click);
			// 
			// настроитьPINКодToolStripMenuItem
			// 
			this.настроитьPINКодToolStripMenuItem.Name = "настроитьPINКодToolStripMenuItem";
			this.настроитьPINКодToolStripMenuItem.Size = new System.Drawing.Size(347, 22);
			this.настроитьPINКодToolStripMenuItem.Text = "Задать PIN-код (по умолчанию PIN-код - пароль)";
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			// 
			// Pomogator_MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 861);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Pomogator_MainForm";
			this.Text = "ПОМОГАТОР";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem расходПриходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem формироватьБюджетToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem калькуляторХОМЯКАToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem инвентаризацияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem заметкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem задатьПутьБДToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem настроитьPINКодToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem настроитьОбменныеКурсыToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem созданиеРезервнойКопииToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_importBD_v1_07;
		private System.Windows.Forms.OpenFileDialog openFileDialogDB_path;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_BackUp;
	}
}

