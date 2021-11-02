
namespace polytechStudy
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMaterial = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьЗаднийФонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paleTurquoisebaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mintCreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.springGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orchidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paleVioletRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьМатериалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelTextVideoTest = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.vb1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMaterial
            // 
            this.panelMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaterial.Location = new System.Drawing.Point(10, 87);
            this.panelMaterial.Name = "panelMaterial";
            this.panelMaterial.Size = new System.Drawing.Size(281, 594);
            this.panelMaterial.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.обновленияToolStripMenuItem,
            this.оРазработчикеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьЗаднийФонToolStripMenuItem,
            this.перезагрузитьToolStripMenuItem});
            this.менюToolStripMenuItem.Image = global::polytechStudy.Properties.Resources._042_settings;
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.менюToolStripMenuItem.Text = "Настройки";
            // 
            // сменитьЗаднийФонToolStripMenuItem
            // 
            this.сменитьЗаднийФонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paleTurquoisebaseToolStripMenuItem,
            this.cyanToolStripMenuItem,
            this.mintCreamToolStripMenuItem,
            this.springGreenToolStripMenuItem,
            this.orchidToolStripMenuItem,
            this.paleVioletRedToolStripMenuItem});
            this.сменитьЗаднийФонToolStripMenuItem.Image = global::polytechStudy.Properties.Resources._001_web_browser;
            this.сменитьЗаднийФонToolStripMenuItem.Name = "сменитьЗаднийФонToolStripMenuItem";
            this.сменитьЗаднийФонToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.сменитьЗаднийФонToolStripMenuItem.Text = "Сменить Задний Фон";
            // 
            // paleTurquoisebaseToolStripMenuItem
            // 
            this.paleTurquoisebaseToolStripMenuItem.Image = global::polytechStudy.Properties.Resources.PaleTurquoise_base_;
            this.paleTurquoisebaseToolStripMenuItem.Name = "paleTurquoisebaseToolStripMenuItem";
            this.paleTurquoisebaseToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.paleTurquoisebaseToolStripMenuItem.Text = "PaleTurquoise(base)";
            this.paleTurquoisebaseToolStripMenuItem.Click += new System.EventHandler(this.paleTurquoisebaseToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Image = global::polytechStudy.Properties.Resources.Cyan;
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.cyanToolStripMenuItem.Text = "Cyan";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.cyanToolStripMenuItem_Click);
            // 
            // mintCreamToolStripMenuItem
            // 
            this.mintCreamToolStripMenuItem.Image = global::polytechStudy.Properties.Resources.MintCream;
            this.mintCreamToolStripMenuItem.Name = "mintCreamToolStripMenuItem";
            this.mintCreamToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.mintCreamToolStripMenuItem.Text = "MintCream";
            this.mintCreamToolStripMenuItem.Click += new System.EventHandler(this.mintCreamToolStripMenuItem_Click);
            // 
            // springGreenToolStripMenuItem
            // 
            this.springGreenToolStripMenuItem.Image = global::polytechStudy.Properties.Resources.SpringGreen;
            this.springGreenToolStripMenuItem.Name = "springGreenToolStripMenuItem";
            this.springGreenToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.springGreenToolStripMenuItem.Text = "SpringGreen";
            this.springGreenToolStripMenuItem.Click += new System.EventHandler(this.springGreenToolStripMenuItem_Click);
            // 
            // orchidToolStripMenuItem
            // 
            this.orchidToolStripMenuItem.Image = global::polytechStudy.Properties.Resources.Orchid;
            this.orchidToolStripMenuItem.Name = "orchidToolStripMenuItem";
            this.orchidToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.orchidToolStripMenuItem.Text = "Orchid";
            this.orchidToolStripMenuItem.Click += new System.EventHandler(this.orchidToolStripMenuItem_Click);
            // 
            // paleVioletRedToolStripMenuItem
            // 
            this.paleVioletRedToolStripMenuItem.Image = global::polytechStudy.Properties.Resources.PaleVioletRed;
            this.paleVioletRedToolStripMenuItem.Name = "paleVioletRedToolStripMenuItem";
            this.paleVioletRedToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.paleVioletRedToolStripMenuItem.Text = "PaleVioletRed";
            this.paleVioletRedToolStripMenuItem.Click += new System.EventHandler(this.paleVioletRedToolStripMenuItem_Click);
            // 
            // перезагрузитьToolStripMenuItem
            // 
            this.перезагрузитьToolStripMenuItem.Image = global::polytechStudy.Properties.Resources._012_cpu;
            this.перезагрузитьToolStripMenuItem.Name = "перезагрузитьToolStripMenuItem";
            this.перезагрузитьToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.перезагрузитьToolStripMenuItem.Text = "Перезагрузить";
            this.перезагрузитьToolStripMenuItem.Click += new System.EventHandler(this.перезагрузитьToolStripMenuItem_Click_1);
            // 
            // обновленияToolStripMenuItem
            // 
            this.обновленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьМатериалыToolStripMenuItem,
            this.открытьПапкуToolStripMenuItem});
            this.обновленияToolStripMenuItem.Image = global::polytechStudy.Properties.Resources._016_computer;
            this.обновленияToolStripMenuItem.Name = "обновленияToolStripMenuItem";
            this.обновленияToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.обновленияToolStripMenuItem.Text = "Материалы";
            // 
            // обновитьМатериалыToolStripMenuItem
            // 
            this.обновитьМатериалыToolStripMenuItem.Image = global::polytechStudy.Properties.Resources._047_download;
            this.обновитьМатериалыToolStripMenuItem.Name = "обновитьМатериалыToolStripMenuItem";
            this.обновитьМатериалыToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.обновитьМатериалыToolStripMenuItem.Text = "Обновить материалы";
            this.обновитьМатериалыToolStripMenuItem.Click += new System.EventHandler(this.обновитьМатериалыToolStripMenuItem_Click_1);
            // 
            // открытьПапкуToolStripMenuItem
            // 
            this.открытьПапкуToolStripMenuItem.Image = global::polytechStudy.Properties.Resources._049_upload;
            this.открытьПапкуToolStripMenuItem.Name = "открытьПапкуToolStripMenuItem";
            this.открытьПапкуToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.открытьПапкуToolStripMenuItem.Text = "Открыть папку";
            this.открытьПапкуToolStripMenuItem.Click += new System.EventHandler(this.открытьПапкуToolStripMenuItem_Click_1);
            // 
            // оРазработчикеToolStripMenuItem
            // 
            this.оРазработчикеToolStripMenuItem.Image = global::polytechStudy.Properties.Resources._003_hacker;
            this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(140, 23);
            this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
            this.оРазработчикеToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикеToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор предмета:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 30);
            this.comboBox1.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "027-captcha.png");
            this.imageList1.Images.SetKeyName(1, "005-worldwide.png");
            this.imageList1.Images.SetKeyName(2, "019-lightbulb.png");
            // 
            // panelTextVideoTest
            // 
            this.panelTextVideoTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTextVideoTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTextVideoTest.Location = new System.Drawing.Point(297, 87);
            this.panelTextVideoTest.Name = "panelTextVideoTest";
            this.panelTextVideoTest.Size = new System.Drawing.Size(600, 594);
            this.panelTextVideoTest.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(571, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 30);
            this.comboBox2.TabIndex = 3;
            // 
            // vb1
            // 
            this.vb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vb1.Enabled = false;
            this.vb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vb1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vb1.ImageKey = "019-lightbulb.png";
            this.vb1.ImageList = this.imageList1;
            this.vb1.Location = new System.Drawing.Point(756, 51);
            this.vb1.Name = "vb1";
            this.vb1.Size = new System.Drawing.Size(73, 30);
            this.vb1.TabIndex = 8;
            this.vb1.Text = "Видео";
            this.vb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vb1.UseVisualStyleBackColor = true;
            this.vb1.Click += new System.EventHandler(this.vb1_Click);
            // 
            // tb1
            // 
            this.tb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb1.Enabled = false;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tb1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tb1.ImageKey = "019-lightbulb.png";
            this.tb1.ImageList = this.imageList1;
            this.tb1.Location = new System.Drawing.Point(835, 51);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(62, 30);
            this.tb1.TabIndex = 7;
            this.tb1.Text = "Тест";
            this.tb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb1.UseVisualStyleBackColor = true;
            this.tb1.Click += new System.EventHandler(this.tb1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateButton.ImageIndex = 0;
            this.updateButton.ImageList = this.imageList1;
            this.updateButton.Location = new System.Drawing.Point(195, 51);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 30);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Обновить";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(909, 693);
            this.Controls.Add(this.vb1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.panelTextVideoTest);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMaterial);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Polytech Study Programm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMaterial;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelTextVideoTest;
        private System.Windows.Forms.Button tb1;
        private System.Windows.Forms.ToolStripMenuItem обновленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьМатериалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьЗаднийФонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезагрузитьToolStripMenuItem;
        private System.Windows.Forms.Button vb1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem paleTurquoisebaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mintCreamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem springGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orchidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paleVioletRedToolStripMenuItem;
    }
}

