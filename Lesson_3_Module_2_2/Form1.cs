using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            hotdog_price.Text = HotDog.ToString("N2");
            hamburger_price.Text = Hambur.ToString("N2");
            potatofree_price.Text = PotFree.ToString("N2");
            cocacola_price.Text = Coca.ToString("N2");
            Reset();
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
            toolStripDropDownButton1.Text = DateTime.Now.DayOfWeek.ToString();
        }

        public double a92 = 40;
        public double a95 = 45;
        public double DT = 39;
        public double DTeuro = 41;
        public double Gas = 28;

        public double HotDog = 45;
        public double Hambur = 72;
        public double PotFree = 36;
        public double Coca = 42;

        public double allpershift = 0;
        public int timeLeft=0;

        public void Reset()
        {
            cb_hotdog.Checked = false;
            cb_hamburger.Checked = false;
            cb_potatofree.Checked = false;
            cb_cocacola.Checked = false;
            hotdog_quantNumericUpDown.Text = String.Empty;
            hamburger_quantNumericUpDown.Text = String.Empty;
            potatofree_quantNumericUpDown.Text=String.Empty;
            cocacola_quantNumericUpDown.Text=String.Empty;
            hotdog_quantNumericUpDown.Enabled = false;
            hamburger_quantNumericUpDown.Enabled=false;
            potatofree_quantNumericUpDown.Enabled = false;
            cocacola_quantNumericUpDown.Enabled = false;
            fuel.Text = "A-92";
            fuel_price.Text = a92.ToString();
            rdb_fuel_quant.Checked = true;
            fuel_quant.Text = 10.ToString("N2");
            cafe_to_pay.Text = 0.ToString("N2");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fuel.SelectedIndex == 0)
            {
                fuel_price.Text = a92.ToString();
            }
            else if (fuel.SelectedIndex == 1)
            {
                fuel_price.Text = a95.ToString();
            }
            else if (fuel.SelectedIndex == 2)
            {
                fuel_price.Text = DT.ToString();
            }
            else if (fuel.SelectedIndex == 3)
            {
                fuel_price.Text = DTeuro.ToString();
            }
            else if (fuel.SelectedIndex == 4)
            {
                fuel_price.Text = Gas.ToString();
            }
            fuel_to_pay.Text = RozrahAvtozapravka().ToString("N2");
        }

        private double RozrahAvtozapravka()
        {
            double toOplata = 0;
            if (rdb_fuel_quant.Checked)
            {
                toOplata = double.Parse(fuel_quant.Text) * double.Parse(fuel_price.Text);
            }
            else if (rdb_fuel_sum.Checked)
            {
                toOplata = double.Parse(fuel_sum.Text);
                fuel_quant.Text = (toOplata / double.Parse(fuel_price.Text)).ToString("N2");
            }
            return toOplata;
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            if (rdb_fuel_quant.Checked)
            {
                fuel_quant.ReadOnly = false;
                fuel_sum.ReadOnly = true;
                fuel_quant.Text = 10.ToString("N2");
                fuel_sum.Text = string.Empty;
            }
            else if (rdb_fuel_sum.Checked)
            {
                fuel_quant.ReadOnly = true;
                fuel_sum.ReadOnly = false;
                fuel_sum.Text = 100.ToString("N2");
                fuel_quant.Text = string.Empty;
            }
            fuel_to_pay.Text = RozrahAvtozapravka().ToString("N2");
        }

        private void fuel_quant_TextChanged(object sender, EventArgs e)
        {
            fuel_to_pay.Text = RozrahAvtozapravka().ToString("N2");
        }

        private void fuel_sum_TextChanged(object sender, EventArgs e)
        {
            fuel_to_pay.Text = RozrahAvtozapravka().ToString("N2");
        }


        private decimal RozrahMiniCafe()
        {
            decimal toOplata = 0;

            if (cb_hotdog.Checked)
            {
                toOplata += decimal.Parse(hotdog_price.Text) * hotdog_quantNumericUpDown.Value;
            }

            if (cb_hamburger.Checked)
            {
                toOplata += decimal .Parse(hamburger_price.Text) * hamburger_quantNumericUpDown.Value;
            }

            if (cb_potatofree.Checked)
            {
                toOplata += decimal.Parse(potatofree_price.Text) * potatofree_quantNumericUpDown.Value;
            }

            if (cb_cocacola.Checked)
            {
                toOplata += decimal.Parse(cocacola_price.Text) * cocacola_quantNumericUpDown.Value;
            }

            return toOplata;
        }

        private void quant_TextChanged(object sender, EventArgs e)
        {
            if (sender.ToString()!=null)
                cafe_to_pay.Text = RozrahMiniCafe().ToString("N2");
        }

        private void cb_hotdog_Click(object sender, EventArgs e)
        {
            if (cb_hotdog.Checked)
            {
                hotdog_quantNumericUpDown.Enabled = true;
                hotdog_quantNumericUpDown.Value = 0;
            }
            else
            {
                hotdog_quantNumericUpDown.Enabled = false;
                hotdog_quantNumericUpDown.Text = string.Empty;
            }
        }

        private void cb_hamburger_Click(object sender, EventArgs e)
        {
            if (cb_hamburger.Checked)
            {
                hamburger_quantNumericUpDown.Enabled = true;
                hamburger_quantNumericUpDown.Value = 0;
            }
            else
            {
                hamburger_quantNumericUpDown.Enabled= false;
                hamburger_quantNumericUpDown.Text = string.Empty;
            }
        }

        private void cb_potatofree_Click(object sender, EventArgs e)
        {
            if (cb_potatofree.Checked)
            {
                potatofree_quantNumericUpDown.Enabled= true;
                potatofree_quantNumericUpDown.Value = 0;
            }
            else
            {
                potatofree_quantNumericUpDown.Enabled = false;
                potatofree_quantNumericUpDown.Text = string.Empty;
            }
        }

        private void cb_cocacola_Click(object sender, EventArgs e)
        {
            if (cb_cocacola.Checked)
            {
                cocacola_quantNumericUpDown.Enabled = true;
                cocacola_quantNumericUpDown.Value=0;
            }
            else
            {
                cocacola_quantNumericUpDown.Enabled = false;
                cocacola_quantNumericUpDown.Text = string.Empty;
            }
        }

        private void calc_Click(object sender, EventArgs e)
        {
            all_to_pay.Text = (double.Parse(fuel_to_pay.Text) + double.Parse(cafe_to_pay.Text)).ToString("N2");
        }

        private void but_add_current_Click(object sender, EventArgs e)
        {
            allpershift += double.Parse(all_to_pay.Text);
            all_per_shift.Text = allpershift.ToString("N2");
            DialogResult result;
            do
            {
                Thread.Sleep(3000);
                result = MessageBox.Show("Наступний клієнт?", "Message window", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            } while (result == DialogResult.Cancel);
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 1)
            {
                toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
                timeLeft --;
            }
            else
            {
                toolStripStatusLabel1.Text = DateTime.Now.ToShortTimeString();
                timeLeft ++;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(FormWindowState.Minimized == WindowState)
            {
                Hide();
                this.notifyIcon1.Visible = true;
                //this.notifyIcon1.ShowBalloonTip(3);

            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }
    }
}