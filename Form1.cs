using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter3
{
    public partial class Form1 : Form
    {
        public static double current_rupees = 1;
        public static double current_dollar = 0.0060;
        public static double current_cdollars = 0.0082;
        public static double current_euro = 0.0054;
        public static double current_liras = 0.041;
        public static double current_yuan = 0043;
        public static double current_riyal = 0.023;
        public static double current_pound = 0.0048;
        public static double current_dinar = 0.0019;
        public static double current_dirham = 0.022;
        //Previous//
        public static double previous_rupees = 1;
        public static double previous_dollar = 0.0060;
        public static double previous_cdollars = 0.0082;
        public static double previous_euro = 0.0054;
        public static double previous_liras = 0.041;
        public static double previous_yuan = 0043;
        public static double previous_riyal = 0.023;
        public static double previous_pound = 0.0048;
        public static double previous_dinar = 0.0019;
        public static double previous_dirham = 0.022;


        public Form1()
        {
            InitializeComponent();
        }

        private void conv_button1_Click(object sender, EventArgs e)
        {
            double i = double.Parse(amount_txt.Text);

            //if amount is converted from pakistani rupee
            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = Math.Round(i * current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = Math.Round(i * current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = Math.Round(i * current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t €";

            }
            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = Math.Round(i * current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Yuan")
            {
                double conver = Math.Round(i * current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = Math.Round(i * current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t SAR";
            }
            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = Math.Round(i * current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t £";
            }

            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = Math.Round(i * current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = Math.Round(i * current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }
            if (from_comboBox1.SelectedItem == "Rupees" && to_comboBox2.SelectedItem == "Rupees")
            {

                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }

            //If amount is converted from Canadian Dollar

            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Rupees")
            {
                double conver = Math.Round(i / current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }
            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = Math.Round(i * current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = Math.Round(i * current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t €";

            }
            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = Math.Round(i * current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Yuan")
            {
                double conver = Math.Round(i * current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = Math.Round(i * current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t SAR";
            }
            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = Math.Round(i * current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t £";
            }

            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = Math.Round(i * current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == "Cdollars" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = Math.Round(i * current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }

            //If amount is converted from Dollars

            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Rupees")
            {
                double conver = Math.Round(i / current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }
            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = Math.Round(i * current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = Math.Round(i * current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t €";

            }
            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = Math.Round(i * current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Yuan")
            {
                double conver = Math.Round(i * current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = Math.Round(i * current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t SAR";
            }
            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = Math.Round(i * current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t £";
            }

            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = Math.Round(i * current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == "Dollar" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = Math.Round(i * current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }

            //If amount is converted from Euros
            if (from_comboBox1.SelectedItem == "Euro" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t €";

            }
            if (from_comboBox1.SelectedItem == "Euro" && to_comboBox2.SelectedItem == "Rupees")
            {
                double conver = Math.Round(i / current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }
            if (from_comboBox1.SelectedItem == "Euro" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = Math.Round(i * current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Euro" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = Math.Round(i * current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";

            }
            if (from_comboBox1.SelectedItem == "Euro" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = Math.Round(i * current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Euro" && to_comboBox2.SelectedItem == "Yuan")
            {
                double conver = Math.Round(i * current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Euro" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = Math.Round(i * current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t SAR";
            }
            if (from_comboBox1.SelectedItem == "Euro" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = Math.Round(i * current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t £";
            }

            if (from_comboBox1.SelectedItem == "Euro" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = Math.Round(i * current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == " Euro" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = Math.Round(i * current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }

            //If amount is converted from Turkish Lira
            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Rupees")
            {
                double conver = Math.Round(i / current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }
            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = Math.Round(i * current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = Math.Round(i * current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";

            }
            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = Math.Round(i * current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t € ";
            }
            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Yuan")
            {
                double conver = Math.Round(i * current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = Math.Round(i * current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t SAR";
            }
            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = Math.Round(i * current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t £";
            }

            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = Math.Round(i * current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == "Liras" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = Math.Round(i * current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }

            //If amount is converted from Chinese Yuan
            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Yuan")
            {
                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Rupees")
            {
                double conver = Math.Round(i / current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }
            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = Math.Round(i * current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = Math.Round(i * current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";

            }
            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = Math.Round(i * current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t € ";
            }
            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = Math.Round(i * current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = Math.Round(i * current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t SAR";
            }
            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = Math.Round(i * current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t £";
            }

            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = Math.Round(i * current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == "Yuan" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = Math.Round(i * current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }

            //If amount is converted from Saudi Riyal
            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t SAR";
            }
            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Rupees")
            {
                double conver = Math.Round(i / current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }
            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = Math.Round(i * current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = Math.Round(i * current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";

            }
            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = Math.Round(i * current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t € ";
            }
            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = Math.Round(i * current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Yuan")
            {

                double conver = Math.Round(i * current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = Math.Round(i * current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t £";
            }

            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = Math.Round(i * current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == "Riyal" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = Math.Round(i * current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }

            //If amount is converted from Pound Sterling
            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t £";
            }
            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Rupees")
            {
                double conver = Math.Round(i / current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }
            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = Math.Round(i * current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = Math.Round(i * current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";

            }
            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = Math.Round(i * current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t € ";
            }
            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = Math.Round(i * current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Yuan")
            {

                double conver = Math.Round(i * current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = Math.Round(i * current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t SR";
            }

            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = Math.Round(i * current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == "Pounds" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = Math.Round(i * current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }

            //If amount is converted from Kuwaiti Dinar
            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Rupees")
            {
                double conver = Math.Round(i / current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }
            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = Math.Round(i * current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = Math.Round(i * current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";

            }
            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = Math.Round(i * current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t € ";
            }
            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = Math.Round(i * current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Yuan")
            {

                double conver = Math.Round(i * current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = Math.Round(i * current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t SR";
            }

            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = Math.Round(i * current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t  £";
            }
            if (from_comboBox1.SelectedItem == "Dinar" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = Math.Round(i * current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }
            //If amount is converted from UAE Dirham
            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Dirham")
            {

                double conver = i;
                display_txt.Text = "Converted Amount:" + conver + "\t AED";
            }
            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Rupees")
            {
                double conver = Math.Round(i / current_dirham, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t Rs";
            }
            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Cdollars")
            {
                double conver = Math.Round(i * current_cdollars, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";
            }
            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Dollar")
            {
                double conver = Math.Round(i * current_dollar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t $";

            }
            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Euro")
            {
                double conver = Math.Round(i * current_euro, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t € ";
            }
            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Liras")
            {
                double conver = Math.Round(i * current_liras, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t TL";
            }
            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Yuan")
            {

                double conver = Math.Round(i * current_yuan, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t CNY";
            }
            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Riyal")
            {

                double conver = Math.Round(i * current_riyal, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t SR";
            }

            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Dinar")
            {

                double conver = Math.Round(i * current_dinar, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t KD";
            }
            if (from_comboBox1.SelectedItem == "Dirham" && to_comboBox2.SelectedItem == "Pounds")
            {

                double conver = Math.Round(i * current_pound, 2);
                display_txt.Text = "Converted Amount:" + conver + "\t  £";
            }

        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            if (to_comboBox2.SelectedItem == "Dollar")
            {
                previous_dollar = current_dollar;
                current_dollar = double.Parse(amount_txt.Text);
                cur_label.Text = current_dollar.ToString();
                pre_label.Text = previous_dollar.ToString();
            }
            if (to_comboBox2.SelectedItem == "Cdollars")
            {
                previous_cdollars = current_cdollars;
                current_cdollars = double.Parse(amount_txt.Text);
                cur_label.Text = current_cdollars.ToString();
                pre_label.Text = previous_cdollars.ToString();
            }
            if (to_comboBox2.SelectedItem == "Rupees")
            {
                previous_rupees = current_rupees;
                current_rupees = double.Parse(amount_txt.Text);
                cur_label.Text = current_rupees.ToString();
                pre_label.Text = previous_rupees.ToString();
            }

            if (to_comboBox2.SelectedItem == "Euro")
            {
                previous_euro = current_euro;
                current_euro = double.Parse(amount_txt.Text);
                cur_label.Text = current_euro.ToString();
                pre_label.Text = previous_euro.ToString();
            }
            if (to_comboBox2.SelectedItem == "Liras")
            {
                previous_liras = current_liras;
                current_liras = double.Parse(amount_txt.Text);
                cur_label.Text = current_liras.ToString();
                pre_label.Text = previous_liras.ToString();
            }
            if (to_comboBox2.SelectedItem == "Yuan")
            {
                previous_yuan = current_yuan;
                current_yuan = double.Parse(amount_txt.Text);
                cur_label.Text = current_yuan.ToString();
                pre_label.Text = previous_yuan.ToString();
            }
            if (to_comboBox2.SelectedItem == "Riyal")
            {
                previous_riyal = current_riyal;
                current_riyal = double.Parse(amount_txt.Text);
                cur_label.Text = current_riyal.ToString();
                pre_label.Text = previous_riyal.ToString();
            }
            if (to_comboBox2.SelectedItem == "Pounds")
            {
                previous_pound = current_pound;
                current_pound = double.Parse(amount_txt.Text);
                cur_label.Text = current_pound.ToString();
                pre_label.Text = previous_pound.ToString();
            }
            if (to_comboBox2.SelectedItem == "Dinar")
            {
                previous_dinar = current_dinar;
                current_dinar = double.Parse(amount_txt.Text);
                cur_label.Text = current_dinar.ToString();
                pre_label.Text = previous_dinar.ToString();
            }
            if (to_comboBox2.SelectedItem == "Dirham")
            {
                previous_dirham = current_dirham;
                current_dirham = double.Parse(amount_txt.Text);
                cur_label.Text = current_dirham.ToString();
                pre_label.Text = previous_dirham.ToString();
            }


        }
    }
}
