namespace Lesson_3_Module_2_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fuel_to_pay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fuel_sum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fuel_quant = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_fuel_sum = new System.Windows.Forms.RadioButton();
            this.rdb_fuel_quant = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.fuel_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fuel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_cocacola = new System.Windows.Forms.CheckBox();
            this.cb_potatofree = new System.Windows.Forms.CheckBox();
            this.cb_hamburger = new System.Windows.Forms.CheckBox();
            this.cb_hotdog = new System.Windows.Forms.CheckBox();
            this.cocacola_price = new System.Windows.Forms.TextBox();
            this.cocacola_quant = new System.Windows.Forms.TextBox();
            this.potatofree_price = new System.Windows.Forms.TextBox();
            this.potatofree_quant = new System.Windows.Forms.TextBox();
            this.hamburger_price = new System.Windows.Forms.TextBox();
            this.hamburger_quant = new System.Windows.Forms.TextBox();
            this.hotdog_price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hotdog_quant = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cafe_to_pay = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_calc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.all_to_pay = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.but_add_current = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.all_per_shift = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fuel_sum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fuel_quant);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fuel_price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fuel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(37, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.fuel_to_pay);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(16, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 105);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "До оплати:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(238, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "грн.";
            // 
            // fuel_to_pay
            // 
            this.fuel_to_pay.BackColor = System.Drawing.SystemColors.Info;
            this.fuel_to_pay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fuel_to_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuel_to_pay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fuel_to_pay.Location = new System.Drawing.Point(109, 39);
            this.fuel_to_pay.Name = "fuel_to_pay";
            this.fuel_to_pay.ReadOnly = true;
            this.fuel_to_pay.Size = new System.Drawing.Size(127, 34);
            this.fuel_to_pay.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(263, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "грн.";
            // 
            // fuel_sum
            // 
            this.fuel_sum.Location = new System.Drawing.Point(157, 197);
            this.fuel_sum.Name = "fuel_sum";
            this.fuel_sum.ReadOnly = true;
            this.fuel_sum.Size = new System.Drawing.Size(100, 25);
            this.fuel_sum.TabIndex = 8;
            this.fuel_sum.TextChanged += new System.EventHandler(this.fuel_sum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(263, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "л.";
            // 
            // fuel_quant
            // 
            this.fuel_quant.Location = new System.Drawing.Point(157, 152);
            this.fuel_quant.Name = "fuel_quant";
            this.fuel_quant.Size = new System.Drawing.Size(100, 25);
            this.fuel_quant.TabIndex = 6;
            this.fuel_quant.TextChanged += new System.EventHandler(this.fuel_quant_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_fuel_sum);
            this.panel1.Controls.Add(this.rdb_fuel_quant);
            this.panel1.Location = new System.Drawing.Point(16, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 90);
            this.panel1.TabIndex = 5;
            // 
            // rdb_fuel_sum
            // 
            this.rdb_fuel_sum.AutoSize = true;
            this.rdb_fuel_sum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdb_fuel_sum.Location = new System.Drawing.Point(7, 52);
            this.rdb_fuel_sum.Name = "rdb_fuel_sum";
            this.rdb_fuel_sum.Size = new System.Drawing.Size(65, 21);
            this.rdb_fuel_sum.TabIndex = 1;
            this.rdb_fuel_sum.TabStop = true;
            this.rdb_fuel_sum.Text = "Сума";
            this.toolTip1.SetToolTip(this.rdb_fuel_sum, "Кількість пального на сумму в гривні");
            this.rdb_fuel_sum.UseVisualStyleBackColor = true;
            this.rdb_fuel_sum.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // rdb_fuel_quant
            // 
            this.rdb_fuel_quant.AutoSize = true;
            this.rdb_fuel_quant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdb_fuel_quant.Location = new System.Drawing.Point(7, 14);
            this.rdb_fuel_quant.Name = "rdb_fuel_quant";
            this.rdb_fuel_quant.Size = new System.Drawing.Size(90, 21);
            this.rdb_fuel_quant.TabIndex = 0;
            this.rdb_fuel_quant.TabStop = true;
            this.rdb_fuel_quant.Text = "Кількість";
            this.toolTip1.SetToolTip(this.rdb_fuel_quant, "Кількість пального в літрах");
            this.rdb_fuel_quant.UseVisualStyleBackColor = true;
            this.rdb_fuel_quant.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(263, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "грн.";
            // 
            // fuel_price
            // 
            this.fuel_price.Location = new System.Drawing.Point(125, 73);
            this.fuel_price.Name = "fuel_price";
            this.fuel_price.ReadOnly = true;
            this.fuel_price.Size = new System.Drawing.Size(132, 25);
            this.fuel_price.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ціна";
            // 
            // fuel
            // 
            this.fuel.FormattingEnabled = true;
            this.fuel.Items.AddRange(new object[] {
            "А-92",
            "А-95",
            "ДТ",
            "ДТевро",
            "Газ"});
            this.fuel.Location = new System.Drawing.Point(126, 28);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(131, 25);
            this.fuel.TabIndex = 1;
            this.fuel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бензин";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_cocacola);
            this.groupBox3.Controls.Add(this.cb_potatofree);
            this.groupBox3.Controls.Add(this.cb_hamburger);
            this.groupBox3.Controls.Add(this.cb_hotdog);
            this.groupBox3.Controls.Add(this.cocacola_price);
            this.groupBox3.Controls.Add(this.cocacola_quant);
            this.groupBox3.Controls.Add(this.potatofree_price);
            this.groupBox3.Controls.Add(this.potatofree_quant);
            this.groupBox3.Controls.Add(this.hamburger_price);
            this.groupBox3.Controls.Add(this.hamburger_quant);
            this.groupBox3.Controls.Add(this.hotdog_price);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.hotdog_quant);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(381, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 386);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Міні-Кафе";
            // 
            // cb_cocacola
            // 
            this.cb_cocacola.AutoSize = true;
            this.cb_cocacola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_cocacola.Location = new System.Drawing.Point(30, 181);
            this.cb_cocacola.Name = "cb_cocacola";
            this.cb_cocacola.Size = new System.Drawing.Size(98, 21);
            this.cb_cocacola.TabIndex = 23;
            this.cb_cocacola.Text = "Кока-кола";
            this.cb_cocacola.UseVisualStyleBackColor = true;
            this.cb_cocacola.Click += new System.EventHandler(this.cb_cocacola_Click);
            // 
            // cb_potatofree
            // 
            this.cb_potatofree.AutoSize = true;
            this.cb_potatofree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_potatofree.Location = new System.Drawing.Point(30, 141);
            this.cb_potatofree.Name = "cb_potatofree";
            this.cb_potatofree.Size = new System.Drawing.Size(121, 21);
            this.cb_potatofree.TabIndex = 22;
            this.cb_potatofree.Text = "Картопля-фрі";
            this.cb_potatofree.UseVisualStyleBackColor = true;
            this.cb_potatofree.Click += new System.EventHandler(this.cb_potatofree_Click);
            // 
            // cb_hamburger
            // 
            this.cb_hamburger.AutoSize = true;
            this.cb_hamburger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_hamburger.Location = new System.Drawing.Point(30, 96);
            this.cb_hamburger.Name = "cb_hamburger";
            this.cb_hamburger.Size = new System.Drawing.Size(100, 21);
            this.cb_hamburger.TabIndex = 21;
            this.cb_hamburger.Text = "Гамбургер";
            this.cb_hamburger.UseVisualStyleBackColor = true;
            this.cb_hamburger.Click += new System.EventHandler(this.cb_hamburger_Click);
            // 
            // cb_hotdog
            // 
            this.cb_hotdog.AutoSize = true;
            this.cb_hotdog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_hotdog.Location = new System.Drawing.Point(30, 56);
            this.cb_hotdog.Name = "cb_hotdog";
            this.cb_hotdog.Size = new System.Drawing.Size(81, 21);
            this.cb_hotdog.TabIndex = 20;
            this.cb_hotdog.Text = "Хот-дог";
            this.cb_hotdog.UseVisualStyleBackColor = true;
            this.cb_hotdog.Click += new System.EventHandler(this.cb_hotdog_Click);
            // 
            // cocacola_price
            // 
            this.cocacola_price.Location = new System.Drawing.Point(179, 181);
            this.cocacola_price.Name = "cocacola_price";
            this.cocacola_price.ReadOnly = true;
            this.cocacola_price.Size = new System.Drawing.Size(55, 25);
            this.cocacola_price.TabIndex = 19;
            // 
            // cocacola_quant
            // 
            this.cocacola_quant.Location = new System.Drawing.Point(254, 181);
            this.cocacola_quant.Name = "cocacola_quant";
            this.cocacola_quant.Size = new System.Drawing.Size(61, 25);
            this.cocacola_quant.TabIndex = 18;
            this.cocacola_quant.TextChanged += new System.EventHandler(this.quant_TextChanged);
            // 
            // potatofree_price
            // 
            this.potatofree_price.Location = new System.Drawing.Point(179, 141);
            this.potatofree_price.Name = "potatofree_price";
            this.potatofree_price.ReadOnly = true;
            this.potatofree_price.Size = new System.Drawing.Size(55, 25);
            this.potatofree_price.TabIndex = 17;
            // 
            // potatofree_quant
            // 
            this.potatofree_quant.Location = new System.Drawing.Point(254, 141);
            this.potatofree_quant.Name = "potatofree_quant";
            this.potatofree_quant.Size = new System.Drawing.Size(61, 25);
            this.potatofree_quant.TabIndex = 16;
            this.potatofree_quant.TextChanged += new System.EventHandler(this.quant_TextChanged);
            // 
            // hamburger_price
            // 
            this.hamburger_price.Location = new System.Drawing.Point(179, 94);
            this.hamburger_price.Name = "hamburger_price";
            this.hamburger_price.ReadOnly = true;
            this.hamburger_price.Size = new System.Drawing.Size(55, 25);
            this.hamburger_price.TabIndex = 15;
            // 
            // hamburger_quant
            // 
            this.hamburger_quant.Location = new System.Drawing.Point(254, 94);
            this.hamburger_quant.Name = "hamburger_quant";
            this.hamburger_quant.Size = new System.Drawing.Size(61, 25);
            this.hamburger_quant.TabIndex = 14;
            this.hamburger_quant.TextChanged += new System.EventHandler(this.quant_TextChanged);
            // 
            // hotdog_price
            // 
            this.hotdog_price.Location = new System.Drawing.Point(179, 53);
            this.hotdog_price.Name = "hotdog_price";
            this.hotdog_price.ReadOnly = true;
            this.hotdog_price.Size = new System.Drawing.Size(55, 25);
            this.hotdog_price.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(251, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Кількість";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(190, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ціна";
            // 
            // hotdog_quant
            // 
            this.hotdog_quant.Location = new System.Drawing.Point(254, 53);
            this.hotdog_quant.Name = "hotdog_quant";
            this.hotdog_quant.Size = new System.Drawing.Size(61, 25);
            this.hotdog_quant.TabIndex = 11;
            this.hotdog_quant.TextChanged += new System.EventHandler(this.quant_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cafe_to_pay);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(16, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 105);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "До оплати:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(245, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "грн.";
            // 
            // cafe_to_pay
            // 
            this.cafe_to_pay.BackColor = System.Drawing.SystemColors.Info;
            this.cafe_to_pay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cafe_to_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cafe_to_pay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cafe_to_pay.Location = new System.Drawing.Point(117, 39);
            this.cafe_to_pay.Name = "cafe_to_pay";
            this.cafe_to_pay.ReadOnly = true;
            this.cafe_to_pay.Size = new System.Drawing.Size(127, 34);
            this.cafe_to_pay.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.but_calc);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.all_to_pay);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(37, 434);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(664, 112);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ВСЬОГО до сплати:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // but_calc
            // 
            this.but_calc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.but_calc.Location = new System.Drawing.Point(132, 24);
            this.but_calc.Name = "but_calc";
            this.but_calc.Size = new System.Drawing.Size(178, 63);
            this.but_calc.TabIndex = 14;
            this.but_calc.Text = "Прорахувати";
            this.toolTip1.SetToolTip(this.but_calc, "Прорахунок загальноі суми до виплати");
            this.but_calc.UseVisualStyleBackColor = true;
            this.but_calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(560, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "грн.";
            // 
            // all_to_pay
            // 
            this.all_to_pay.BackColor = System.Drawing.SystemColors.Info;
            this.all_to_pay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.all_to_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.all_to_pay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.all_to_pay.Location = new System.Drawing.Point(431, 45);
            this.all_to_pay.Name = "all_to_pay";
            this.all_to_pay.ReadOnly = true;
            this.all_to_pay.Size = new System.Drawing.Size(127, 34);
            this.all_to_pay.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.but_add_current);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.all_per_shift);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox6.Location = new System.Drawing.Point(37, 563);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(664, 80);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Всього виручка за зміну:";
            // 
            // but_add_current
            // 
            this.but_add_current.ForeColor = System.Drawing.SystemColors.ControlText;
            this.but_add_current.Location = new System.Drawing.Point(83, 31);
            this.but_add_current.Name = "but_add_current";
            this.but_add_current.Size = new System.Drawing.Size(174, 32);
            this.but_add_current.TabIndex = 18;
            this.but_add_current.Text = "Додати поточну суму";
            this.toolTip1.SetToolTip(this.but_add_current, "Додає поточну суму до загальної за добу");
            this.but_add_current.UseVisualStyleBackColor = true;
            this.but_add_current.Click += new System.EventHandler(this.but_add_current_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(560, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "грн.";
            // 
            // all_per_shift
            // 
            this.all_per_shift.BackColor = System.Drawing.SystemColors.Info;
            this.all_per_shift.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.all_per_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.all_per_shift.ForeColor = System.Drawing.SystemColors.WindowText;
            this.all_per_shift.Location = new System.Drawing.Point(374, 24);
            this.all_per_shift.Name = "all_per_shift";
            this.all_per_shift.ReadOnly = true;
            this.all_per_shift.Size = new System.Drawing.Size(184, 34);
            this.all_per_shift.TabIndex = 16;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 685);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStripDropDownButton1.Enabled = false;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(100, 24);
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(737, 711);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "BestOil";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox fuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fuel_to_pay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fuel_sum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fuel_quant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_fuel_sum;
        private System.Windows.Forms.RadioButton rdb_fuel_quant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fuel_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_cocacola;
        private System.Windows.Forms.CheckBox cb_potatofree;
        private System.Windows.Forms.CheckBox cb_hamburger;
        private System.Windows.Forms.CheckBox cb_hotdog;
        private System.Windows.Forms.TextBox cocacola_price;
        private System.Windows.Forms.TextBox cocacola_quant;
        private System.Windows.Forms.TextBox potatofree_price;
        private System.Windows.Forms.TextBox potatofree_quant;
        private System.Windows.Forms.TextBox hamburger_price;
        private System.Windows.Forms.TextBox hamburger_quant;
        private System.Windows.Forms.TextBox hotdog_price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hotdog_quant;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cafe_to_pay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_calc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox all_to_pay;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button but_add_current;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox all_per_shift;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

