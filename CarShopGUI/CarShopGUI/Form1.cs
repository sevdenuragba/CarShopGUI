using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store mystore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
       
            try
            {
                Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
                MessageBox.Show(c.ToString());
                mystore.CarList.Add(c);
                carInventoryBindingSource.ResetBindings(false);
                ClearData();
            }

            catch
            {
                MessageBox.Show("You made a wrong entry. Please try again.");
             
            }
        }

        private void ClearData()
        {
            txt_make.Text = "";
            txt_model.Text = "";
            txt_price.Text = "";

        }

        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
            Car selected = (Car)lst_inventory.SelectedItem;
            mystore.ShoppingCart.Add(selected);
            cartBindingSource.ResetBindings(false);
        
        }

        private void txt1_make_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = mystore.CarList;
            cartBindingSource.DataSource = mystore.ShoppingCart;
            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            
            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = mystore.Checkout();
            lbl_total.Text = ""+total.ToString()+" $";
            cartBindingSource.ResetBindings(false);
            mystore.ShoppingCart.Clear();
        }

        private void lbl_total_Click(object sender, EventArgs e)
        {
            
        }

        private void lst_cart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

 
}
