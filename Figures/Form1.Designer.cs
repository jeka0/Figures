﻿
namespace Figures
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drawButt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textCircleRadius = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textCircleY = new System.Windows.Forms.TextBox();
            this.textCircleX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textEllipsB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textEllipsY = new System.Windows.Forms.TextBox();
            this.textEllipsX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textEllipsM = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textModelL1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textModelY = new System.Windows.Forms.TextBox();
            this.textModelX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.textSpeedL1 = new System.Windows.Forms.TextBox();
            this.textOffsetL1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textOffsetL2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textSpeedL2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textModelL2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonLeft2 = new System.Windows.Forms.RadioButton();
            this.radioButtonRight2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 462);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Координаты";
            // 
            // drawButt
            // 
            this.drawButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawButt.Location = new System.Drawing.Point(678, 454);
            this.drawButt.Name = "drawButt";
            this.drawButt.Size = new System.Drawing.Size(102, 27);
            this.drawButt.TabIndex = 6;
            this.drawButt.Text = "Отрисовать";
            this.drawButt.UseVisualStyleBackColor = true;
            this.drawButt.Click += new System.EventHandler(this.drawButt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(665, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(133, 337);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.buttonRemove);
            this.tabPage1.Controls.Add(this.panel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(125, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(33, 205);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(34, 234);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(0, 44);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(125, 154);
            this.panel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(91, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textCircleRadius);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textCircleY);
            this.tabPage2.Controls.Add(this.textCircleX);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(125, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textCircleRadius
            // 
            this.textCircleRadius.Location = new System.Drawing.Point(36, 126);
            this.textCircleRadius.Name = "textCircleRadius";
            this.textCircleRadius.Size = new System.Drawing.Size(56, 20);
            this.textCircleRadius.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(34, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Радиус";
            // 
            // textCircleY
            // 
            this.textCircleY.Location = new System.Drawing.Point(71, 73);
            this.textCircleY.Name = "textCircleY";
            this.textCircleY.Size = new System.Drawing.Size(48, 20);
            this.textCircleY.TabIndex = 12;
            // 
            // textCircleX
            // 
            this.textCircleX.Location = new System.Drawing.Point(16, 73);
            this.textCircleX.Name = "textCircleX";
            this.textCircleX.Size = new System.Drawing.Size(48, 20);
            this.textCircleX.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(91, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(34, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "Координаты центра";
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColor.Location = new System.Drawing.Point(699, 355);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(92, 49);
            this.buttonColor.TabIndex = 8;
            this.buttonColor.Text = "Изменить цвет";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(672, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 15);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textEllipsM);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.textEllipsB);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textEllipsY);
            this.tabPage3.Controls.Add(this.textEllipsX);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(125, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textEllipsB
            // 
            this.textEllipsB.Location = new System.Drawing.Point(36, 125);
            this.textEllipsB.Name = "textEllipsB";
            this.textEllipsB.Size = new System.Drawing.Size(56, 20);
            this.textEllipsB.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(-4, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Большая полуось";
            // 
            // textEllipsY
            // 
            this.textEllipsY.Location = new System.Drawing.Point(71, 72);
            this.textEllipsY.Name = "textEllipsY";
            this.textEllipsY.Size = new System.Drawing.Size(48, 20);
            this.textEllipsY.TabIndex = 19;
            // 
            // textEllipsX
            // 
            this.textEllipsX.Location = new System.Drawing.Point(16, 72);
            this.textEllipsX.Name = "textEllipsX";
            this.textEllipsX.Size = new System.Drawing.Size(48, 20);
            this.textEllipsX.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(91, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(34, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(13, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 41);
            this.label11.TabIndex = 15;
            this.label11.Text = "Координаты центра";
            // 
            // textEllipsM
            // 
            this.textEllipsM.Location = new System.Drawing.Point(36, 169);
            this.textEllipsM.Name = "textEllipsM";
            this.textEllipsM.Size = new System.Drawing.Size(56, 20);
            this.textEllipsM.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Малая полуось";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(678, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 38);
            this.panel1.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Обычный режим";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Заливка";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Controls.Add(this.textSpeedL2);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.textModelL2);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.textOffsetL2);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.textOffsetL1);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.textSpeedL1);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.textModelL1);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.textModelY);
            this.tabPage4.Controls.Add(this.textModelX);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(125, 311);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textModelL1
            // 
            this.textModelL1.Location = new System.Drawing.Point(10, 103);
            this.textModelL1.Name = "textModelL1";
            this.textModelL1.Size = new System.Drawing.Size(56, 20);
            this.textModelL1.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Длина L1";
            // 
            // textModelY
            // 
            this.textModelY.Location = new System.Drawing.Point(71, 59);
            this.textModelY.Name = "textModelY";
            this.textModelY.Size = new System.Drawing.Size(48, 20);
            this.textModelY.TabIndex = 19;
            // 
            // textModelX
            // 
            this.textModelX.Location = new System.Drawing.Point(16, 59);
            this.textModelX.Name = "textModelX";
            this.textModelX.Size = new System.Drawing.Size(48, 20);
            this.textModelX.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(91, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(34, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "X";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(13, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 41);
            this.label16.TabIndex = 15;
            this.label16.Text = "Координаты центра";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonLeft);
            this.panel2.Controls.Add(this.radioButtonRight);
            this.panel2.Location = new System.Drawing.Point(6, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 38);
            this.panel2.TabIndex = 22;
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.AutoSize = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(3, 18);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(106, 17);
            this.radioButtonLeft.TabIndex = 1;
            this.radioButtonLeft.Text = "Против часовой";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.AutoSize = true;
            this.radioButtonRight.Checked = true;
            this.radioButtonRight.Location = new System.Drawing.Point(4, 1);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(83, 17);
            this.radioButtonRight.TabIndex = 0;
            this.radioButtonRight.TabStop = true;
            this.radioButtonRight.Text = "По часовой";
            this.radioButtonRight.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(63, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "Скорость";
            // 
            // textSpeedL1
            // 
            this.textSpeedL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSpeedL1.Location = new System.Drawing.Point(75, 101);
            this.textSpeedL1.Name = "textSpeedL1";
            this.textSpeedL1.Size = new System.Drawing.Size(44, 22);
            this.textSpeedL1.TabIndex = 24;
            // 
            // textOffsetL1
            // 
            this.textOffsetL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOffsetL1.Location = new System.Drawing.Point(16, 203);
            this.textOffsetL1.Name = "textOffsetL1";
            this.textOffsetL1.Size = new System.Drawing.Size(44, 22);
            this.textOffsetL1.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(4, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 30);
            this.label18.TabIndex = 25;
            this.label18.Text = "Смещение L1";
            // 
            // textOffsetL2
            // 
            this.textOffsetL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOffsetL2.Location = new System.Drawing.Point(71, 203);
            this.textOffsetL2.Name = "textOffsetL2";
            this.textOffsetL2.Size = new System.Drawing.Size(44, 22);
            this.textOffsetL2.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(63, 170);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 30);
            this.label19.TabIndex = 27;
            this.label19.Text = "Смещение L2";
            // 
            // textSpeedL2
            // 
            this.textSpeedL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSpeedL2.Location = new System.Drawing.Point(73, 246);
            this.textSpeedL2.Name = "textSpeedL2";
            this.textSpeedL2.Size = new System.Drawing.Size(44, 22);
            this.textSpeedL2.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(61, 227);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 19);
            this.label20.TabIndex = 31;
            this.label20.Text = "Скорость";
            // 
            // textModelL2
            // 
            this.textModelL2.Location = new System.Drawing.Point(8, 248);
            this.textModelL2.Name = "textModelL2";
            this.textModelL2.Size = new System.Drawing.Size(56, 20);
            this.textModelL2.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(1, 227);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 16);
            this.label21.TabIndex = 29;
            this.label21.Text = "Длина L2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonLeft2);
            this.panel3.Controls.Add(this.radioButtonRight2);
            this.panel3.Location = new System.Drawing.Point(4, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 38);
            this.panel3.TabIndex = 33;
            // 
            // radioButtonLeft2
            // 
            this.radioButtonLeft2.AutoSize = true;
            this.radioButtonLeft2.Location = new System.Drawing.Point(3, 18);
            this.radioButtonLeft2.Name = "radioButtonLeft2";
            this.radioButtonLeft2.Size = new System.Drawing.Size(106, 17);
            this.radioButtonLeft2.TabIndex = 1;
            this.radioButtonLeft2.Text = "Против часовой";
            this.radioButtonLeft2.UseVisualStyleBackColor = true;
            // 
            // radioButtonRight2
            // 
            this.radioButtonRight2.AutoSize = true;
            this.radioButtonRight2.Checked = true;
            this.radioButtonRight2.Location = new System.Drawing.Point(4, 1);
            this.radioButtonRight2.Name = "radioButtonRight2";
            this.radioButtonRight2.Size = new System.Drawing.Size(83, 17);
            this.radioButtonRight2.TabIndex = 0;
            this.radioButtonRight2.TabStop = true;
            this.radioButtonRight2.Text = "По часовой";
            this.radioButtonRight2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.drawButt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawButt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textCircleY;
        private System.Windows.Forms.TextBox textCircleX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCircleRadius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textEllipsM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textEllipsB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEllipsY;
        private System.Windows.Forms.TextBox textEllipsX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.TextBox textModelL1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textModelY;
        private System.Windows.Forms.TextBox textModelX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textOffsetL2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textOffsetL1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textSpeedL1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonLeft2;
        private System.Windows.Forms.RadioButton radioButtonRight2;
        private System.Windows.Forms.TextBox textSpeedL2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textModelL2;
        private System.Windows.Forms.Label label21;
    }
}

