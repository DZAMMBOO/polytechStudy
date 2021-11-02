using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using AxWMPLib;

namespace polytechStudy
{
    public partial class MainForm : Form
    {
        XmlReader xmlReader;
        public string AllURLs;
        bool videoPlay = false;
        bool updateBut = false;

        public int rX = 35;
        public int rTag = 0;

        public string testNameA;
        public string testDescriptionA;
        public int rightA;
        public int mode;

        public int n;
        public int nv;
        public int rOtv;

        public int qwestCount;
        public string qwestText;

        public string[] answ = new string[6];
        public MainForm()
        {
            InitializeComponent();
            SetMat();
        }

        int bX = 6;
        int bY = 12;
        string selP;
        public void SetMat() //Получаем материалы лекции, создавая кнопки для каждой отдельно
        {
            comboBox1.Items.Clear();
            comboBox1.Text = null;
            string[] allfolders = Directory.GetDirectories(@"Lesson Material/");
            foreach (string folder in allfolders)
            {
                string[] index = folder.Split('/');
                var fname = index[1];
                comboBox1.Items.Add(fname);
            }
        }
        public void SetLecture(string folPath, int ind) //Получаем материалы лекции, создавая кнопки для каждой отдельно
        {
            panelMaterial.Controls.Clear();
            string[] allfolders = Directory.GetDirectories(@"Lesson Material/" + folPath);
            foreach (string folder in allfolders)
            {
                string[] index = folder.Split('\\');
                var ffname = index[ind];
                MyButton(folder, ffname);
            }
        }
        public void MyButton(string folderTag, string folderName) //Конструктор Кнопки для темы
        {
            Button b1 = new Button();
            b1.Location = new Point(bX, bY);
            b1.Size = new Size(265, 32);
            b1.Tag = folderTag;
            b1.Text = folderName;
            b1.UseVisualStyleBackColor = true;
            b1.Click += new EventHandler(b1_click);

            panelMaterial.Controls.Add(b1);
            bY += 38;
        }
        RichTextBox rb1 = new RichTextBox();
        public void crTextBox() 
        {
            rb1.Location = new Point(7, 7);
            rb1.Size = new Size(panelTextVideoTest.Size.Width - 15, panelTextVideoTest.Size.Height - 15);
            rb1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            rb1.ReadOnly = true;
            rb1.Font = new Font(FontFamily.GenericSansSerif, 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            rb1.BackColor = Color.White;
            rb1.Name = "rtb1";

            panelTextVideoTest.Controls.Add(rb1);
        } //Конструктор RichTextBox (для отображения в нем материала лекции)
        AxWindowsMediaPlayer wmp1 = new AxWindowsMediaPlayer();
        public void crWMP(string urls) //Функция отрисовки видеоплеера
        {
            wmp1.Location = new Point(3, 3);
            wmp1.Size = new Size(panelTextVideoTest.Size.Width - 15, panelTextVideoTest.Size.Height - 15);
            wmp1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            wmp1.Font = new Font(FontFamily.GenericSansSerif, 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            wmp1.BackColor = Color.White;
            wmp1.Name = "winMP1";

            panelTextVideoTest.Controls.Add(wmp1);
        } //Конструктор Windows Media Player (для отображения в нем видео лекции)
        public void foreVid(string fPath)
        {
            foreach (string file in Directory.EnumerateFiles(fPath, "*.mp4", SearchOption.AllDirectories))
            {
                comboBox2.Items.Add(Path.GetFileName(file) + Environment.NewLine);
            }
            foreach (string file in Directory.EnumerateFiles(fPath, "*.mvk", SearchOption.AllDirectories))
            {
                comboBox2.Items.Add(Path.GetFileName(file) + Environment.NewLine);
            }
            foreach (string file in Directory.EnumerateFiles(fPath, "*.avi", SearchOption.AllDirectories))
            {
                comboBox2.Items.Add(Path.GetFileName(file) + Environment.NewLine);
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            bX = 6;
            bY = 12;
            if (comboBox1.SelectedIndex > -1)
            {
                SetLecture(comboBox1.SelectedItem.ToString(), 1);
                selP = comboBox1.SelectedItem.ToString();
                comboBox1.BackColor = Color.White;
            }
            else
            {
                comboBox1.BackColor = Color.Red;
            }            
        } //Кнопка обновления материала
        public void b1_click(object sender, EventArgs e) //Функция, которая будет выполняться при нажатии на кнопку
        {
            panelTextVideoTest.Controls.Clear();
            comboBox2.Items.Clear();
            comboBox2.Text = null;
            comboBox2.Enabled = false;
            if (videoPlay == true)
            {
                wmp1.Ctlcontrols.stop();
            }
            Button b = (Button)sender;
            if (Directory.GetFiles(b.Tag.ToString(), "Material.rtf", SearchOption.TopDirectoryOnly).Any())
            {
                panelTextVideoTest.Tag = b.Tag.ToString();
                string materialPath = b.Tag.ToString() + "\\Material.rtf";
                crTextBox();
                rb1.LoadFile(materialPath, RichTextBoxStreamType.RichText);

                if (Directory.GetFiles(b.Tag.ToString(), "Test.xml", SearchOption.AllDirectories).Any())
                {
                    tb1.Enabled = true;
                }
                else
                {
                    tb1.Enabled = false;
                }

                if (Directory.GetFiles(b.Tag.ToString(), "*.mp4", SearchOption.AllDirectories).Any())
                {
                    comboBox2.Enabled = true;
                    foreVid(b.Tag.ToString());
                    AllURLs = b.Tag.ToString();
                    vb1.Enabled = true;
                }
                else if (Directory.GetFiles(b.Tag.ToString(), "*.mkv", SearchOption.AllDirectories).Any())
                {
                    comboBox2.Enabled = true;
                    foreVid(b.Tag.ToString());
                    AllURLs = b.Tag.ToString();
                    vb1.Enabled = true;
                }
                else if (Directory.GetFiles(b.Tag.ToString(), "*.avi", SearchOption.AllDirectories).Any())
                {
                    comboBox2.Enabled = true;
                    foreVid(b.Tag.ToString());
                    AllURLs = b.Tag.ToString();
                    vb1.Enabled = true;
                }
                else
                {
                    vb1.Enabled = false;
                }
            }
            else
            {
                bX = 6;
                bY = 12;
                panelMaterial.Controls.Clear();
                panelTextVideoTest.Controls.Clear();

                string SS = selP + "\\" + b.Text.ToString();
                SetLecture(SS, 2);
            }
        }
        private void tb1_Click(object sender, EventArgs e) //Функция Клика на кнопку Теста
        {
            panelTextVideoTest.Controls.Clear();

            read(Convert.ToString(panelTextVideoTest.Tag));
            drawGroupBox();
            drawDescription();
            TestButton();
            but1.Enabled = true;

        }
        private void vb1_Click(object sender, EventArgs e) //Кнопка запуска видео
        {
            if (comboBox2.SelectedIndex > -1)
            {
                panelTextVideoTest.Controls.Clear();
                //label2.Text = AllURLs + "\\" + comboBox2.SelectedItem;
                crWMP(Convert.ToString(AllURLs + "\\" + comboBox2.SelectedItem));
                wmp1.URL = AllURLs + "\\" + comboBox2.SelectedItem;
                videoPlay = true;
                comboBox2.BackColor = Color.White;
            }
            else
            {
                comboBox2.BackColor = Color.Red;
            }
        }
        GroupBox grBox = new GroupBox();
        private void drawGroupBox() //Конструктор GroupBox (для отображения вариантов ответа)
        {
            grBox.Name = "groupBoxTestVariables";
            grBox.Text = "Варианты Ответов:";
            grBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            grBox.Font = new Font(FontFamily.GenericSansSerif, 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            grBox.Location = new Point(3, 275);
            grBox.Size = new Size(592, 263);

            panelTextVideoTest.Controls.Add(grBox);
        }
        private void read(string testPath) //Функция чтения XML таблицы с тестом
        {
            xmlReader = new XmlTextReader(testPath + "\\Test.xml");
            xmlReader.Read();

            mode = 0;
            ////
            readHead();
            ////
            readDescription();
            ////


        }
        private void readHead() //Чтение Названия теста
        {
            do xmlReader.Read();
            while (xmlReader.Name != "head");
            xmlReader.Read();
            this.Text = "Polytech Study Programm | Test  -  " + xmlReader.Value;
            xmlReader.Read();
        }
        private void readDescription() //Чтние Описания Теста
        {
            do xmlReader.Read();
            while (xmlReader.Name != "description");
            xmlReader.Read();
            testDescriptionA = xmlReader.Value;
            xmlReader.Read();

            do xmlReader.Read();
            while (xmlReader.Name != "qwestion");
            xmlReader.Read();
        }

        private Boolean getQw() //Получить из таблицы варианты ответов
        {
            xmlReader.Read();
            if (xmlReader.Name == "q")
            {
                qwestText = xmlReader.GetAttribute("text");
                qwestCount = Convert.ToInt32(xmlReader.GetAttribute("value"));

                xmlReader.Read();
                int i = 0;

                while (xmlReader.Name != "q")
                {
                    xmlReader.Read();

                    if (xmlReader.Name == "a")
                    {
                        // запоминаем правильный ответ
                        if (xmlReader.GetAttribute("right") == "yes")
                            rightA = i;
                        // считываем вариант ответа
                        xmlReader.Read();
                        if (i < qwestCount) answ[i] = xmlReader.Value;
                        // выходим из узла <a>
                        xmlReader.Read();

                        i++;
                    }
                }

                xmlReader.Read();

                return true;
            }
            else
            {
                return false;
            }
        }
        private void showQw() //Отобразить варианты ответов
        {
            tD.Text = qwestText;
            rX = 20;
            rTag = 0;
            grBox.Controls.Clear();
            for (int i = 0; i < qwestCount; i++)
            {
                drawQwuestBox(answ[i]);
            }
        }
        Label tD = new Label();
        private void drawDescription() //Конструктор Строки Описания Теста
        {
            tD.Name = "testDescription";
            tD.Text = testDescriptionA;
            grBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            tD.Font = new Font(FontFamily.GenericSansSerif, 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tD.Location = new Point(17, 18);
            tD.Size = new Size(550, 115);

            panelTextVideoTest.Controls.Add(tD);
        }
        private void drawQwuestBox(string qwText) //Конструктор галочек для выбора ответа
        {
            RadioButton rb = new RadioButton();
            rb.Name = "testDescription";
            rb.Size = new Size(4500, 24);
            rb.Text = qwText;
            rb.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
            rb.Tag = rTag;
            rb.Font = new Font(FontFamily.GenericSansSerif, 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            rb.Location = new Point(10, rX);
            rb.Click += new EventHandler(RB_Click);


            rX += 30;
            rTag += 1;

            grBox.Controls.Add(rb);
        }
        private void RB_Click(object sender, EventArgs e) //Функция Клика На Вариант Ответа
        {
            RadioButton rdb = (RadioButton)sender;
            rOtv = Convert.ToInt32(rdb.Tag);
            but1.Enabled = true;
        }
        Button but1 = new Button();
        public void TestButton() //Конструктор Кнопки для темы
        {
            but1.Location = new Point(6, 549);
            but1.Size = new Size(120, 37);
            but1.Text = "Начать Тест!";
            but1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            but1.UseVisualStyleBackColor = true;
            but1.Click += new EventHandler(but1_Click);

            panelTextVideoTest.Controls.Add(but1);
        }
        private void but1_Click(object sender, EventArgs e) //Клик на кнопку "Продолжить"
        {
            but1.Text = "Подтвердить!";
            but1.Enabled = false;
            switch (mode)
            {
                case 0:        // начало работы программы
                    this.getQw();
                    this.showQw();
                    but1.Enabled = false;

                    mode = 1;
                    break;
                case 1:
                    nv++;

                    // правильный ли ответ выбран
                    if (rOtv == rightA)
                    {
                        n++;
                    }
                    but1.Enabled = false;
                    //this.Text = ttt + " | nv = " + nv + " | n = " + n;
                    if (this.getQw()) this.showQw();
                    else
                    {
                        // больше вопросов нет
                        grBox.Controls.Clear();
                        grBox.Visible = false;

                        // обработка и вывод результата
                        this.showLevel();

                        // закроет окно теста
                        mode = 2;
                    }
                    break;
                case 2:   // завершение работы программы
                    this.Close(); // закрыть окно
                    break;
            }
        }
        private void showLevel() //Итог!
        {
            // ищем узел <levels>
            do xmlReader.Read();
            while (xmlReader.Name != "levels");
            xmlReader.Read();

            // читаем данные узла
            while (xmlReader.Name != "levels")
            {
                xmlReader.Read();
                int sccore = Convert.ToInt32(xmlReader.GetAttribute("score"));

                if (xmlReader.Name == "level")
                    // n - кол-во правильных ответов,
                    // проверяем, попадаем ли в категорию

                    if (n >= Convert.ToInt32(xmlReader.GetAttribute("score")))
                    {
                        tD.Text =
                        "Тестирование завершено.\n" +
                        "Всего вопросов: " + nv.ToString() + ". " +
                        "Правильных ответов: " + n.ToString() + ".\n" +
                        xmlReader.GetAttribute("text");
                    }
                    else
                    {
                        tD.Text =
                        "Тестирование завершено.\n" +
                        "Всего вопросов: " + nv.ToString() + ". " +
                        "Правильных ответов: " + n.ToString() + ".\n" +
                        "Проходной балл: " + sccore + ".\n" +
                        "Тест не пройден.";
                    }
                break;
            }
        }
        private void paleTurquoisebaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleTurquoise;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void mintCreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MintCream;
        }

        private void springGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SpringGreen;
        }

        private void orchidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orchid;
        }

        private void paleVioletRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleVioletRed;
        }

        private void обновитьМатериалыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bX = 6;
            bY = 12;
            SetMat();
            if (comboBox1.SelectedIndex > -1)
            {
                SetLecture(comboBox1.SelectedItem.ToString(), 1);
                selP = comboBox1.SelectedItem.ToString();
                comboBox1.BackColor = Color.White;
            }
            else
            {
                comboBox1.BackColor = Color.Red;
            }
        }

        private void перезагрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Разработчиком данного програмного" + "\n" + "обеспечения является:" + "\n"
                + "Студент группы - П-16-45Б" + "\n"
                + "Вальгерт Виталий" + "\n",
                "Разработчк",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void открытьПапкуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", @"Lesson Material");
        }
    }
}
