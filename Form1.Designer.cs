namespace Проектная_работа
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формулаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дискримиантToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислениеКорнейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формулыСокращённогоУмноженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.формулаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.файлToolStripMenuItem.Text = "Файл ";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // формулаToolStripMenuItem
            // 
            this.формулаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дискримиантToolStripMenuItem,
            this.вычислениеКорнейToolStripMenuItem,
            this.формулыСокращённогоУмноженияToolStripMenuItem});
            this.формулаToolStripMenuItem.Name = "формулаToolStripMenuItem";
            this.формулаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.формулаToolStripMenuItem.Text = "Формула";
            // 
            // дискримиантToolStripMenuItem
            // 
            this.дискримиантToolStripMenuItem.Name = "дискримиантToolStripMenuItem";
            this.дискримиантToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.дискримиантToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.дискримиантToolStripMenuItem.Text = "Дискриминант";
            this.дискримиантToolStripMenuItem.Click += new System.EventHandler(this.дискримиантToolStripMenuItem_Click);
            // 
            // вычислениеКорнейToolStripMenuItem
            // 
            this.вычислениеКорнейToolStripMenuItem.Name = "вычислениеКорнейToolStripMenuItem";
            this.вычислениеКорнейToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.вычислениеКорнейToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.вычислениеКорнейToolStripMenuItem.Text = "Вычисление корней";
            this.вычислениеКорнейToolStripMenuItem.Click += new System.EventHandler(this.вычислениеКорнейToolStripMenuItem_Click);
            // 
            // формулыСокращённогоУмноженияToolStripMenuItem
            // 
            this.формулыСокращённогоУмноженияToolStripMenuItem.Name = "формулыСокращённогоУмноженияToolStripMenuItem";
            this.формулыСокращённогоУмноженияToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.формулыСокращённогоУмноженияToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.формулыСокращённогоУмноженияToolStripMenuItem.Text = "Формулы сокращённого умножения";
            this.формулыСокращённогоУмноженияToolStripMenuItem.Click += new System.EventHandler(this.формулыСокращённогоУмноженияToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.справкаToolStripMenuItem.AutoSize = false;
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(348, 262);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Математический справочник 8 класс";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формулаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислениеКорнейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формулыСокращённогоУмноженияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дискримиантToolStripMenuItem;
    }
}

