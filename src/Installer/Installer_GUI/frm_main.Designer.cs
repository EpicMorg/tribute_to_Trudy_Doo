namespace Installer_GUI
{
    partial class frm_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tabs_main = new System.Windows.Forms.TabControl();
            this.tab_main = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_step1_next = new System.Windows.Forms.Button();
            this.tab_license = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_step1_back = new System.Windows.Forms.Button();
            this.btn_step2_next = new System.Windows.Forms.Button();
            this.tab_scan_browsers = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dg_founded_browsers = new System.Windows.Forms.DataGridView();
            this.chbx_browsers = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pic_browser = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_step2_back = new System.Windows.Forms.Button();
            this.btn_step3_next = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tab_config_browsers = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_step3_back = new System.Windows.Forms.Button();
            this.btn_step4_next = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tab_addons_installing_for_browsers = new System.Windows.Forms.TabPage();
            this.tab_soft_selection = new System.Windows.Forms.TabPage();
            this.tab_soft_installation = new System.Windows.Forms.TabPage();
            this.tab_errors = new System.Windows.Forms.TabPage();
            this.tab_finish = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabs_main.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_license.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tab_scan_browsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_founded_browsers)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_config_browsers.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs_main
            // 
            this.tabs_main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs_main.Controls.Add(this.tab_main);
            this.tabs_main.Controls.Add(this.tab_license);
            this.tabs_main.Controls.Add(this.tab_scan_browsers);
            this.tabs_main.Controls.Add(this.tab_config_browsers);
            this.tabs_main.Controls.Add(this.tab_addons_installing_for_browsers);
            this.tabs_main.Controls.Add(this.tab_soft_selection);
            this.tabs_main.Controls.Add(this.tab_soft_installation);
            this.tabs_main.Controls.Add(this.tab_errors);
            this.tabs_main.Controls.Add(this.tab_finish);
            this.tabs_main.HotTrack = true;
            this.tabs_main.Location = new System.Drawing.Point(12, 12);
            this.tabs_main.Name = "tabs_main";
            this.tabs_main.SelectedIndex = 0;
            this.tabs_main.Size = new System.Drawing.Size(640, 382);
            this.tabs_main.TabIndex = 0;
            // 
            // tab_main
            // 
            this.tab_main.BackColor = System.Drawing.Color.White;
            this.tab_main.Controls.Add(this.label2);
            this.tab_main.Controls.Add(this.label1);
            this.tab_main.Controls.Add(this.panel1);
            this.tab_main.Controls.Add(this.pictureBox1);
            this.tab_main.Location = new System.Drawing.Point(4, 25);
            this.tab_main.Name = "tab_main";
            this.tab_main.Padding = new System.Windows.Forms.Padding(3);
            this.tab_main.Size = new System.Drawing.Size(632, 353);
            this.tab_main.TabIndex = 0;
            this.tab_main.Text = "Приветствие";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_step1_next);
            this.panel1.Location = new System.Drawing.Point(-7, 311);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(643, 55);
            this.panel1.TabIndex = 2;
            // 
            // btn_step1_next
            // 
            this.btn_step1_next.Location = new System.Drawing.Point(557, 6);
            this.btn_step1_next.Name = "btn_step1_next";
            this.btn_step1_next.Size = new System.Drawing.Size(75, 23);
            this.btn_step1_next.TabIndex = 1;
            this.btn_step1_next.Text = "Next";
            this.btn_step1_next.UseVisualStyleBackColor = true;
            this.btn_step1_next.Click += new System.EventHandler(this.btn_step1_next_Click);
            // 
            // tab_license
            // 
            this.tab_license.BackColor = System.Drawing.Color.White;
            this.tab_license.Controls.Add(this.panel3);
            this.tab_license.Controls.Add(this.richTextBox1);
            this.tab_license.Controls.Add(this.panel2);
            this.tab_license.Location = new System.Drawing.Point(4, 25);
            this.tab_license.Name = "tab_license";
            this.tab_license.Padding = new System.Windows.Forms.Padding(3);
            this.tab_license.Size = new System.Drawing.Size(632, 353);
            this.tab_license.TabIndex = 1;
            this.tab_license.Text = "неЛицензия";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(-7, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 56);
            this.panel3.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(620, 244);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Много текста. Бла бла бла.\nИнфа. Что и о чем.\nможно грузить ртфку\n\nПеречислить вс" +
    "е лицензии устанавливаемых программ.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_step1_back);
            this.panel2.Controls.Add(this.btn_step2_next);
            this.panel2.Location = new System.Drawing.Point(-7, 311);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(643, 55);
            this.panel2.TabIndex = 3;
            // 
            // btn_step1_back
            // 
            this.btn_step1_back.Location = new System.Drawing.Point(476, 6);
            this.btn_step1_back.Name = "btn_step1_back";
            this.btn_step1_back.Size = new System.Drawing.Size(75, 23);
            this.btn_step1_back.TabIndex = 5;
            this.btn_step1_back.Text = "Disagree";
            this.btn_step1_back.UseVisualStyleBackColor = true;
            this.btn_step1_back.Click += new System.EventHandler(this.btn_step1_back_Click);
            // 
            // btn_step2_next
            // 
            this.btn_step2_next.Location = new System.Drawing.Point(557, 6);
            this.btn_step2_next.Name = "btn_step2_next";
            this.btn_step2_next.Size = new System.Drawing.Size(75, 23);
            this.btn_step2_next.TabIndex = 3;
            this.btn_step2_next.Text = "Agree";
            this.btn_step2_next.UseVisualStyleBackColor = true;
            this.btn_step2_next.Click += new System.EventHandler(this.btn_step2_next_Click);
            // 
            // tab_scan_browsers
            // 
            this.tab_scan_browsers.BackColor = System.Drawing.Color.White;
            this.tab_scan_browsers.Controls.Add(this.progressBar1);
            this.tab_scan_browsers.Controls.Add(this.dg_founded_browsers);
            this.tab_scan_browsers.Controls.Add(this.panel5);
            this.tab_scan_browsers.Controls.Add(this.panel4);
            this.tab_scan_browsers.Location = new System.Drawing.Point(4, 25);
            this.tab_scan_browsers.Name = "tab_scan_browsers";
            this.tab_scan_browsers.Size = new System.Drawing.Size(632, 353);
            this.tab_scan_browsers.TabIndex = 2;
            this.tab_scan_browsers.Text = "Скан браузеров";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(623, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 10;
            // 
            // dg_founded_browsers
            // 
            this.dg_founded_browsers.AllowUserToAddRows = false;
            this.dg_founded_browsers.AllowUserToDeleteRows = false;
            this.dg_founded_browsers.BackgroundColor = System.Drawing.Color.White;
            this.dg_founded_browsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_founded_browsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chbx_browsers,
            this.pic_browser,
            this.txt_name});
            this.dg_founded_browsers.Location = new System.Drawing.Point(3, 90);
            this.dg_founded_browsers.Name = "dg_founded_browsers";
            this.dg_founded_browsers.ReadOnly = true;
            this.dg_founded_browsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dg_founded_browsers.Size = new System.Drawing.Size(623, 215);
            this.dg_founded_browsers.TabIndex = 9;
            // 
            // chbx_browsers
            // 
            this.chbx_browsers.HeaderText = "";
            this.chbx_browsers.Name = "chbx_browsers";
            this.chbx_browsers.ReadOnly = true;
            this.chbx_browsers.Width = 32;
            // 
            // pic_browser
            // 
            this.pic_browser.HeaderText = "";
            this.pic_browser.Name = "pic_browser";
            this.pic_browser.ReadOnly = true;
            this.pic_browser.Width = 32;
            // 
            // txt_name
            // 
            this.txt_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_name.HeaderText = "Browser";
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_step2_back);
            this.panel5.Controls.Add(this.btn_step3_next);
            this.panel5.Location = new System.Drawing.Point(-7, 311);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(643, 55);
            this.panel5.TabIndex = 6;
            // 
            // btn_step2_back
            // 
            this.btn_step2_back.Location = new System.Drawing.Point(476, 6);
            this.btn_step2_back.Name = "btn_step2_back";
            this.btn_step2_back.Size = new System.Drawing.Size(75, 23);
            this.btn_step2_back.TabIndex = 5;
            this.btn_step2_back.Text = "Back";
            this.btn_step2_back.UseVisualStyleBackColor = true;
            // 
            // btn_step3_next
            // 
            this.btn_step3_next.Location = new System.Drawing.Point(557, 6);
            this.btn_step3_next.Name = "btn_step3_next";
            this.btn_step3_next.Size = new System.Drawing.Size(75, 23);
            this.btn_step3_next.TabIndex = 3;
            this.btn_step3_next.Text = "Next";
            this.btn_step3_next.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(-7, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(649, 56);
            this.panel4.TabIndex = 8;
            // 
            // tab_config_browsers
            // 
            this.tab_config_browsers.BackColor = System.Drawing.Color.White;
            this.tab_config_browsers.Controls.Add(this.panel6);
            this.tab_config_browsers.Controls.Add(this.panel7);
            this.tab_config_browsers.Location = new System.Drawing.Point(4, 25);
            this.tab_config_browsers.Name = "tab_config_browsers";
            this.tab_config_browsers.Size = new System.Drawing.Size(632, 353);
            this.tab_config_browsers.TabIndex = 3;
            this.tab_config_browsers.Text = "Конфига браузеров";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btn_step3_back);
            this.panel6.Controls.Add(this.btn_step4_next);
            this.panel6.Location = new System.Drawing.Point(-7, 311);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(643, 55);
            this.panel6.TabIndex = 9;
            // 
            // btn_step3_back
            // 
            this.btn_step3_back.Location = new System.Drawing.Point(476, 6);
            this.btn_step3_back.Name = "btn_step3_back";
            this.btn_step3_back.Size = new System.Drawing.Size(75, 23);
            this.btn_step3_back.TabIndex = 5;
            this.btn_step3_back.Text = "Back";
            this.btn_step3_back.UseVisualStyleBackColor = true;
            // 
            // btn_step4_next
            // 
            this.btn_step4_next.Location = new System.Drawing.Point(557, 6);
            this.btn_step4_next.Name = "btn_step4_next";
            this.btn_step4_next.Size = new System.Drawing.Size(75, 23);
            this.btn_step4_next.TabIndex = 3;
            this.btn_step4_next.Text = "Next";
            this.btn_step4_next.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Location = new System.Drawing.Point(-7, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(649, 56);
            this.panel7.TabIndex = 10;
            // 
            // tab_addons_installing_for_browsers
            // 
            this.tab_addons_installing_for_browsers.Location = new System.Drawing.Point(4, 25);
            this.tab_addons_installing_for_browsers.Name = "tab_addons_installing_for_browsers";
            this.tab_addons_installing_for_browsers.Size = new System.Drawing.Size(632, 353);
            this.tab_addons_installing_for_browsers.TabIndex = 4;
            this.tab_addons_installing_for_browsers.Text = "Установка дополнений";
            this.tab_addons_installing_for_browsers.UseVisualStyleBackColor = true;
            // 
            // tab_soft_selection
            // 
            this.tab_soft_selection.Location = new System.Drawing.Point(4, 25);
            this.tab_soft_selection.Name = "tab_soft_selection";
            this.tab_soft_selection.Size = new System.Drawing.Size(632, 353);
            this.tab_soft_selection.TabIndex = 5;
            this.tab_soft_selection.Text = "Выбор софта";
            this.tab_soft_selection.UseVisualStyleBackColor = true;
            // 
            // tab_soft_installation
            // 
            this.tab_soft_installation.Location = new System.Drawing.Point(4, 25);
            this.tab_soft_installation.Name = "tab_soft_installation";
            this.tab_soft_installation.Size = new System.Drawing.Size(632, 353);
            this.tab_soft_installation.TabIndex = 6;
            this.tab_soft_installation.Text = "Soft Installation";
            this.tab_soft_installation.UseVisualStyleBackColor = true;
            // 
            // tab_errors
            // 
            this.tab_errors.Location = new System.Drawing.Point(4, 25);
            this.tab_errors.Name = "tab_errors";
            this.tab_errors.Size = new System.Drawing.Size(632, 353);
            this.tab_errors.TabIndex = 7;
            this.tab_errors.Text = "tab errors";
            this.tab_errors.UseVisualStyleBackColor = true;
            // 
            // tab_finish
            // 
            this.tab_finish.Location = new System.Drawing.Point(4, 25);
            this.tab_finish.Name = "tab_finish";
            this.tab_finish.Size = new System.Drawing.Size(632, 353);
            this.tab_finish.TabIndex = 8;
            this.tab_finish.Text = "tab_finish";
            this.tab_finish.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(185, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Installiation Wizzard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Много текста не осилил";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please accept or decline it";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "License Agreement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Please Wait..";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Scanning for Browsers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "For checked browsers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Addons Selection";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Installer_GUI.Properties.Resources.WizModernImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Installer_GUI.Properties.Resources.WizModernSmallImage;
            this.pictureBox2.Location = new System.Drawing.Point(582, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Installer_GUI.Properties.Resources.WizModernSmallImage;
            this.pictureBox3.Location = new System.Drawing.Point(582, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Installer_GUI.Properties.Resources.WizModernSmallImage;
            this.pictureBox4.Location = new System.Drawing.Point(582, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(688, 426);
            this.Controls.Add(this.tabs_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer <program> - ";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.tabs_main.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.tab_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tab_license.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tab_scan_browsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_founded_browsers)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tab_config_browsers.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs_main;
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.TabPage tab_license;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_step1_next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_step1_back;
        private System.Windows.Forms.Button btn_step2_next;
        private System.Windows.Forms.TabPage tab_scan_browsers;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_step2_back;
        private System.Windows.Forms.Button btn_step3_next;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage tab_config_browsers;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_step3_back;
        private System.Windows.Forms.Button btn_step4_next;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tab_addons_installing_for_browsers;
        private System.Windows.Forms.TabPage tab_soft_selection;
        private System.Windows.Forms.TabPage tab_soft_installation;
        private System.Windows.Forms.TabPage tab_errors;
        private System.Windows.Forms.TabPage tab_finish;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dg_founded_browsers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chbx_browsers;
        private System.Windows.Forms.DataGridViewImageColumn pic_browser;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;


    }
}

