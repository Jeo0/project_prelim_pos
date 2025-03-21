﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lesson3___example3
{
    public partial class Plesson3_form : Form
    {
        //codes for declaring a variables that is accessible to the whole
        //form and can be access for one object to another
        private double total_amount = 0;
        private int total_qty = 0;

        public Plesson3_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
            //disabling textboxes
            priceTxtBox.Enabled = false;
            discountAmountTxtBox.Enabled = false;
            changeTxtBox.Enabled = false;
            totalBillsTxtBox.Enabled = false;
            discountAmountTxtBox.Enabled = false;
            totalQtyTxtBox.Enabled = false;

            //codes for inserting image to a picturebox
            string variable = "E:\\school\\3rdyr\\2ndsem\\ecp\\prelim\\--quiqui\\Quiz1_Elective\\images\\dinner\\";
            pizzaPic1.Image = System.Drawing.Image.FromFile(variable + "d1.jfif");
            pizzaPic2.Image = System.Drawing.Image.FromFile(variable + "d2.jfif");
            pizzaPic3.Image = System.Drawing.Image.FromFile(variable + "d3.jfif");
            pizzaPic4.Image = System.Drawing.Image.FromFile(variable + "d4.jfif");
            pizzaPic5.Image = System.Drawing.Image.FromFile(variable + "d5.jfif");
            pizzaPic6.Image = System.Drawing.Image.FromFile(variable + "d6.jfif");
            pizzaPic7.Image = System.Drawing.Image.FromFile(variable + "d7.jfif");
            pizzaPic8.Image = System.Drawing.Image.FromFile(variable + "d8.jfif");
            pizzaPic9.Image = System.Drawing.Image.FromFile(variable + "d9.jfif");
            pizzaPic10.Image = System.Drawing.Image.FromFile(variable + "d10.jfif");
            pizzaPic11.Image = System.Drawing.Image.FromFile(variable + "d11.jfif");
            pizzaPic12.Image = System.Drawing.Image.FromFile(variable + "d12.jfif");
            pizzaPic13.Image = System.Drawing.Image.FromFile(variable + "d13.jfif");
            pizzaPic14.Image = System.Drawing.Image.FromFile(variable + "d14.jfif");
            pizzaPic15.Image = System.Drawing.Image.FromFile(variable + "d15.jfif");
            pizzaPic16.Image = System.Drawing.Image.FromFile(variable + "d16.jfif");
            pizzaPic17.Image = System.Drawing.Image.FromFile(variable + "d17.jfif");
            pizzaPic18.Image = System.Drawing.Image.FromFile(variable + "d18.jfif");
            pizzaPic19.Image = System.Drawing.Image.FromFile(variable + "d19.jfif");
            pizzaPic20.Image = System.Drawing.Image.FromFile(variable + "d20.jfif");

            //codes to disable to checkboxes
            //A
            friedchickenCheckBox.Enabled = false;
            friesCheckbox.Enabled = false;
            cokeCheckBox.Enabled = false;
            sidedishCheckBox.Enabled = false;
            specialpizzaCheckbox.Enabled = false;
            //B
            halohaloCheckbox.Enabled = false;
            chickenCheckbox.Enabled = false;
            carbonaraCheckBox.Enabled = false;
            famfriesCheckBox.Enabled = false;
            hawaiianCheckBox.Enabled = false;




        }

        private void FoodBundleAradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
            string variable = "E:\\school\\3rdyr\\2ndsem\\ecp\\prelim\\jude\\Projects\\lesson3---example3\\imgs\\";
            double price;
            //code for changing the form background
            this.BackColor = Color.LightCyan;
            //code for food bundle B not to be selected
            FoodBundleBradiobtn.Checked = false;
            //inserting image inside picturebox
            displayPictureBox.Image = System.Drawing.Image.FromFile(variable + "foodbundle1.jfif");
            //codes to check the checkboxes for A
            friedchickenCheckBox.Checked = true;
            friesCheckbox.Checked = true;
            cokeCheckBox.Checked = true;
            sidedishCheckBox.Checked = true;
            specialpizzaCheckbox.Checked = true;
            //codes to uncheck checkboxes for B
            halohaloCheckbox.Checked = false;
            chickenCheckbox.Checked = false;
            carbonaraCheckBox.Checked = false;
            famfriesCheckBox.Checked = false;
            hawaiianCheckBox.Checked = false;

            //codes for displaying data inside the textboxes
            priceTxtBox.Text = "1,000.00";
            discountAmountTxtBox.Text = "200.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            //codes for inserting data inside the listbox
            displayListBox.Items.Add(FoodBundleAradiobtn.Text + " " + priceTxtBox .Text);
            displayListBox.Items.Add(" Discount Amount: " + " "+ discountAmountTxtBox.Text);
            
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();





        }

        private void FoodBundleBradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
            string variable = "E:\\school\\3rdyr\\2ndsem\\ecp\\prelim\\jude\\Projects\\lesson3---example3\\imgs\\";
            double price;
            //code for changing the form background
            this.BackColor = Color.LightBlue;
            //code for food bundle B not to be selected
            FoodBundleAradiobtn.Checked = false;
            //inserting image inside picturebox
            displayPictureBox.Image = System.Drawing.Image.FromFile(variable + "foodbundle2.jfif");
            //codes to check the checkboxes for A
            friedchickenCheckBox.Checked = false;
            friesCheckbox.Checked = false;
            cokeCheckBox.Checked = false;
            sidedishCheckBox.Checked = false;
            specialpizzaCheckbox.Checked = false;
            //codes to uncheck checkboxes for B
            halohaloCheckbox.Checked = true;
            chickenCheckbox.Checked = true;
            carbonaraCheckBox.Checked = true;
            famfriesCheckBox.Checked = true;
            hawaiianCheckBox.Checked = true;

            //codes for displaying data inside the textboxes
            priceTxtBox.Text = "1,299.00";
            discountAmountTxtBox.Text = "194.85";
            
            //codes for inserting data inside the listbox
            displayListBox.Items.Add(FoodBundleBradiobtn.Text + " " + priceTxtBox.Text);
            displayListBox.Items.Add(" Discount Amount: " + " " + discountAmountTxtBox.Text);

            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }


        private void calcbills_Click_1(object sender, EventArgs e)
        {
            double cash_given=0, change=0, total_amountPaid=0;
            try {
                total_amountPaid = Convert.ToDouble(totalBillsTxtBox.Text);
            }
            catch (Exception asd)  {
                MessageBox.Show(asd.Message);
                totalBillsTxtBox.Focus();
            }

            try {
                cash_given = Convert.ToDouble(cashGivenTxtBox.Text); 
            }
            catch (Exception asd)  {
                MessageBox.Show(asd.Message);
                cashGivenTxtBox.Focus();
            }

            try {
                change = cash_given - total_amountPaid;
            }
            catch (Exception asd)  {
                MessageBox.Show(asd.Message);
            }

            changeTxtBox.Text = change.ToString("n");                                 // safe
            displayListBox.Items.Add("Total Bills:  " + totalBillsTxtBox.Text);
            displayListBox.Items.Add("Cash Given:  " + cashGivenTxtBox.Text);
            displayListBox.Items.Add("Total No. of Items:  " + totalQtyTxtBox.Text);  // safe

            if (cash_given < total_amountPaid)
            {
                MessageBox.Show("Insufficient cash! Please enter an amount greater than or equal to the total bill.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form
            Plesson3_printform print = new Plesson3_printform();

            //codes for displaying the contents of the listbox from other form to the
            //current form.
            print.printDisplayListBox.Items.AddRange(this.displayListBox.Items);
            //code for displaying the other form
            print.Show();

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            //codes to remove selected data inside the listbox
            displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            
            //codes to uncheck all given checkboxes
            FoodBundleAradiobtn.Checked = false;
            FoodBundleBradiobtn.Checked = false;

            //code for inserting default image inside the picturebox

            //code for unchecking
            cokeCheckBox.Checked = false;
            friedchickenCheckBox.Checked = false;
            friesCheckbox.Checked = false;
            sidedishCheckBox.Checked = false;
            specialpizzaCheckbox.Checked = false;

            carbonaraCheckBox.Checked = false;
            chickenCheckbox.Checked = false;
            famfriesCheckBox.Checked = false;
            halohaloCheckbox.Checked = false;
            hawaiianCheckBox.Checked = false;

            //codes for clearing the textboxes
            priceTxtBox.Clear();
            quantityTxtBox.Clear();
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;

            discountAmountTxtBox.Clear();

            displayPictureBox.Image = null;

            displayListBox.Items.Clear();



        }

        private void quantityTxtBox_TextChanged(object sender, EventArgs e)
        {
            double price = 0, discounted_amount = 0, discount_amount = 0;
            int qty = 0;

            // Ensure input values are not empty before conversion
            try {
              if (!string.IsNullOrWhiteSpace(priceTxtBox.Text))
                  price = Convert.ToDouble(priceTxtBox.Text);
            } catch(Exception asd) {
              MessageBox.Show(asd.Message);
              priceTxtBox.Focus();
            }

            try {
              if (!string.IsNullOrWhiteSpace(quantityTxtBox.Text))
                  qty = Convert.ToInt32(quantityTxtBox.Text);
            } catch (Exception asd){
              MessageBox.Show(asd.Message);
              quantityTxtBox.Focus();
            }

            try {
              if (!string.IsNullOrWhiteSpace(discountAmountTxtBox.Text))
                  discount_amount = Convert.ToDouble(discountAmountTxtBox.Text);
            } catch (Exception asd){
              MessageBox.Show(asd.Message);
              discountAmountTxtBox.Focus();
            }

            // Prevent negative calculations
            if (qty > 0)
            {
                discounted_amount = (price * qty) - (discount_amount * qty);
                total_qty += qty;
                total_amount += discounted_amount;
            }
            else
            {
                discounted_amount = 0;
            }

            // Display results
            totalQtyTxtBox.Text = total_qty.ToString();
            totalBillsTxtBox.Text = total_amount.ToString("n");
            discountedAmounttxtBox.Text = discounted_amount.ToString("n");


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store
            //inside the variable
            price = Convert.ToDouble(priceTxtBox.Text);
            //codes to insert text property value of a checkbox inside the listbox
            displayListBox.Items.Add(checkBox2.Text + " " + priceTxtBox.Text);
            //codes for putting text property value of the textbox
            quantityTxtBox.Text = "0";
            //codes for the cursor inside the textbox once the event of the object
            //triggred
            quantityTxtBox.Focus();


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            double price;
 
            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "550.50";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox3.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "600.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox4.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "750.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox5.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "500.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox6.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "750.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox7.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "700.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox8.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "850.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox9.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "450.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox10.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "650.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox11.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "575.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox12.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "565.50";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox13.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "580.50";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox14.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "600.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox15.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "545.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox16.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "505.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox17.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "490.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox18.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "555.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox19.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "615.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox20.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "605.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListBox.Items.Add(checkBox21.Text + " " + priceTxtBox.Text);
            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }

        private void displayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void discountedAmounttxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
