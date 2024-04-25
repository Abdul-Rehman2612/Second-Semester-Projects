using DELL.Utility;
using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DELL.UI.UsersUI
{
    public partial class CustomerUI : Form
    {
        private CustomerBL customer = null;
        List<OrderDetailsBL> cart = new List<OrderDetailsBL>();
        public CustomerUI(CustomerBL customer)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // maximize windows size
            this.customer = customer;
            LoadProductsData();
        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        private void LoadProductsData() // Loads products' data into the CGridView
        {
            try
            {
                // Retrieve products' data from the data access layer
                PGridView.DataSource = null; // Unbind the data source
                PGridView.Rows.Clear(); // Clear the rows
                List<ProductBL> products = ObjectHandler.GetProductDL().GetAllProducts();
                // Add rows to the DataGridView
                foreach (ProductBL p in products)
                {
                    PGridView.Rows.Add(
                        p.GetProductID(),
                        p.GetProductName(),
                        p.GetProductDetails(),
                        p.GetProductPrice(),
                        p.GetUnitsInStock()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputsP() // Clears input fields for Products
        {
            PInput.Text = "";
            PDInput.Text = "";
            QuantityInput.Text = "";
            PPInput.Text = "";
            UISInput.Text="";
            PNInput.Text="";
        }
        private void LoadDataIntoInputsP(ProductBL product) // Loads data into input fields for Products
        {
            PNInput.Text = product.GetProductName();
            PDInput.Text = product.GetProductDetails();
            UISInput.Text = product.GetUnitsInStock().ToString();
            PPInput.Text = product.GetProductPrice().ToString();
            PInput.Text=product.GetProductID().ToString();
        }
        private void ClearInputs() // Clears input fields for Products
        {
            gunaLabel4.Text = "";
            gunaLabel7.Text = "";
            guna2TextBox1.Text = "";
            gunaLabel11.Text = "";
            gunaLabel8.Text="";
            gunaLabel6.Text="";
        }
        private void LoadDataIntoInputs(OrderDetailsBL od) // Loads data into input fields for Products
        {
            gunaLabel6.Text = od.GetProduct().GetProductName();
            gunaLabel7.Text = od.GetProduct().GetProductDetails();
            gunaLabel11.Text = od.GetQuantity().ToString();
            gunaLabel8.Text = od.GetPrice().ToString();
            gunaLabel4.Text=od.GetProduct().GetProductID().ToString();
        }
        private void PGridView_SelectionChanged(object sender, EventArgs e) // Handles selection change in CGridView
        {
            try
            {
                if (PGridView.SelectedRows.Count > 0)
                {
                    // Retrieve selected row
                    DataGridViewRow selectedRow = PGridView.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < PGridView.Rows.Count)
                    {
                        // Extract data from selected row
                        int productID = Convert.ToInt32(selectedRow.Cells["Column1P"].Value);
                        string productName = selectedRow.Cells["Column2P"].Value?.ToString();
                        string productDetails = selectedRow.Cells["Column3P"].Value?.ToString();
                        double price = Convert.ToDouble(selectedRow.Cells["Column4P"].Value);
                        int unitsInStock = Convert.ToInt32(selectedRow.Cells["Column5P"].Value);
                        // Create product object
                        ProductBL product = new ProductBL(productID, productName, productDetails, price, unitsInStock);
                        LoadDataIntoInputsP(product);
                    }
                    else
                    {
                        ClearInputsP();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e) // Handles selection change in CGridView
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Retrieve selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < dataGridView1.Rows.Count &&
                        selectedRow.Cells["Column1D"].Value != null &&
                        selectedRow.Cells["Column2D"].Value != null &&
                        selectedRow.Cells["Column3D"].Value != null &&
                        selectedRow.Cells["Column4D"].Value != null &&
                        selectedRow.Cells["Column5D"].Value != null)
                    {
                        // Extract data from selected row
                        int productID = Convert.ToInt32(selectedRow.Cells["Column1D"].Value);
                        string productName = selectedRow.Cells["Column2D"].Value?.ToString();
                        string productDetails = selectedRow.Cells["Column3D"].Value?.ToString();
                        double price = Convert.ToDouble(selectedRow.Cells["Column4D"].Value);
                        int quantity = Convert.ToInt32(selectedRow.Cells["Column5D"].Value);
                        // Create product object
                        ProductBL product = ObjectHandler.GetProductDL().GetProductByProductID(productID);
                        OrderDetailsBL od = new OrderDetailsBL(product, quantity, price);
                        LoadDataIntoInputs(od);
                    }
                    else
                    {
                        ClearInputs();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Invalid format. Please check the input data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Overflow occurred while converting data. Please check the input data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AddP_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the product from the data layer
                ProductBL product = ObjectHandler.GetProductDL().GetProductByProductID(Convert.ToInt16(PInput.Text));
                OrderDetailsBL existingDetail = null;
                // Check if the product is already in the cart
                foreach (OrderDetailsBL od in cart)
                {
                    if (od.GetProduct().GetProductID()==product.GetProductID())
                    {
                        existingDetail = new OrderDetailsBL(od);
                    }
                }
                if (existingDetail != null)
                {
                    // Product already exists in the cart, ask user if they want to add more stock
                    DialogResult result = MessageBox.Show("Product already exists in the cart. Do you want to add more stock?", "Product Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (!int.TryParse(QuantityInput.Text, out int quantitsy) || quantitsy <= 0)
                        {
                            MessageBox.Show("Please enter a valid positive quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Convert.ToInt16(UISInput.Text) - quantitsy-existingDetail.GetQuantity() < 0)
                        {
                            MessageBox.Show("Requested quantity exceeds available stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // Add more stock
                        existingDetail.AddQuantity(quantitsy);
                        MessageBox.Show("Stock added to existing product in the cart!");
                        LoadDataForCart();
                        ClearInputsP();
                    }
                    return;
                }

                // Parse the quantity input
                if (!int.TryParse(QuantityInput.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid positive quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if requested quantity exceeds available stock
                if (Convert.ToInt16(UISInput.Text) - quantity < 0)
                {
                    MessageBox.Show("Requested quantity exceeds available stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create an order details object and add it to the cart
                OrderDetailsBL detail = new OrderDetailsBL(product, quantity);
                cart.Add(detail);
                LoadDataForCart();
                ClearInputsP();
                MessageBox.Show("Product added to cart!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataForCart()
        {
            try
            {
                // Retrieve products' data from the data access layer
                dataGridView1.DataSource = null; // Unbind the data source
                dataGridView1.Rows.Clear(); // Clear the rows
                // Add rows to the DataGridView
                foreach (OrderDetailsBL od in cart)
                {
                    dataGridView1.Rows.Add(
                        od.GetProduct().GetProductID(),
                        od.GetProduct().GetProductName(),
                        od.GetProduct().GetProductDetails(),
                        od.GetPrice(),
                        od.GetQuantity()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaLabel4.Text != null)
                {
                    bool check = false;
                    ProductBL product = ObjectHandler.GetProductDL().GetProductByProductID(Convert.ToInt16(gunaLabel4.Text));
                    // Check if the product is in the cart
                    foreach (OrderDetailsBL od in cart)
                    {
                        if (od.GetProduct().GetProductID()==product.GetProductID())
                        {
                            cart.Remove(od);
                            check= true;
                            break;
                        }
                        if (check) { break; }
                    }
                    LoadDataForCart();
                    ClearInputs();
                    MessageBox.Show("Product removed from cart!");
                }
            }
            catch (Exception)
            {
            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaLabel4.Text!= null)
                {
                    // Retrieve the product from the data layer
                    ProductBL product = ObjectHandler.GetProductDL().GetProductByProductID(Convert.ToInt16(gunaLabel4.Text));
                    OrderDetailsBL existingDetail = null;
                    // Check if the product is already in the cart
                    foreach (OrderDetailsBL od in cart)
                    {
                        if (od.GetProduct().GetProductID()==product.GetProductID())
                        {
                            existingDetail = new OrderDetailsBL(od);
                        }
                    }
                    if (existingDetail != null)
                    {
                        // Product already exists in the cart, ask user if they want to add more stock
                        DialogResult result = MessageBox.Show("Do you want to add more stock?", "Product Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (!int.TryParse(QuantityInput.Text, out int quantitsy) || quantitsy <= 0)
                            {
                                MessageBox.Show("Please enter a valid positive quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (Convert.ToInt16(UISInput.Text) - quantitsy-existingDetail.GetQuantity() < 0)
                            {
                                MessageBox.Show("Requested quantity exceeds available stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            // Add more stock
                            existingDetail.AddQuantity(quantitsy);
                            MessageBox.Show("Stock added to existing product in the cart!");
                            LoadDataForCart();
                        }
                        return;
                    }
                }

            }
            catch { }
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            try
            {
                OrderBL order = new OrderBL("Online",DateTime.Now);
                int orderID =  ObjectHandler.GetOrderDL().AddOrder(order, customer.GetUsername());
                order.SetOrderID(orderID);
                customer.AddOrder(order);
                MessageBox.Show("Order placed successfully!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataUser()
        {
            UnameI.Text=customer.GetName();
            UNI.Text=customer.GetUsername();
            UPI.Text=customer.GetPassword();
            UEI.Text=customer.GetEmail();
            DOBI.Value=customer.GetDob();
            UCI.Text=customer.GetContact();
            UAI.Text=customer.GetAddress();
            UGI.Text=customer.GetGender();
        }
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            // Check if username is provided
            string username=customer.GetUsername();
            string email=customer.GetEmail();
            if (UNI.Text!="" && username!=null && email!=null)
            {
                CustomerBL employee = new CustomerBL(UnameI.Text, UNI.Text, UPI.Text, UEI.Text, DOBI.Value, UAI.Text, UCI.Text, UGI.Text, "Active");
                // Update employee
                string message = ObjectHandler.GetCustomerDL().UpdateCustomer(customer, username, email);
                if (message=="True")
                {
                    MessageBox.Show("Admin updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customer.SetName(UnameI.Text); customer.SetUsername(UNI.Text); customer.SetPassword(UPI.Text); customer.SetEmail(UEI.Text); customer.SetDob(DOBI.Value); customer.SetAddress(UAI.Text); customer.SetContact(UCI.Text); customer.SetGender(UGI.Text);
                    LoadDataUser();
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu=new MainMenu();
            mainmenu.Show();
        }
    }
}
