using DELL.Utility;
using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DELL.UI.UsersUI
{
    public partial class CustomerUI : Form
    {
        private CustomerBL customer = null;
        List<OrderDetailsBL> cart = new List<OrderDetailsBL>();
        public CustomerUI(CustomerBL customer)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.customer = customer;
            LoadStats();
            LoadDataForCustomerID();
            LoadProductsData();
            LoadCustomersOrdersData();
            LoadDataUser();
        }
        private void LoadStats()
        {
            try
            {
                int count = ObjectHandler.GetOrderDL().GetOrderCountForCustomer(customer.GetUsername());
                DataShow1.Text = $"Orders placed: {count}";
                DataShow2.Text = $"Products bought: {BoughtProductsCount()}";
                count = ObjectHandler.GetOrderDL().GetOrderCount();
                DataShow3.Text = $": {count}";
                DataShow4.Text = $"Amount spent: {AmountSpent()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double AmountSpent()
        {
            double pCount = 0.0;
            if (customer.GetOrders() != null)
            {
                if (customer.GetOrders().Count > 0)
                {
                    foreach (OrderBL order in customer.GetOrders())
                    {
                        pCount += order.GetTotalPrice();
                    }
                }
            }
            return pCount;
        }

        private int BoughtProductsCount()
        {
            int pCount = 0;
            if (customer.GetOrders() != null)
            {
                if (customer.GetOrders().Count > 0)
                {
                    foreach (OrderBL order in customer.GetOrders())
                    {
                        foreach (OrderDetailsBL orderDetails in order.GetOrderDetails())
                        {
                            pCount += orderDetails.GetQuantity();
                        }
                    }
                }
            }
            return pCount;
        }

        private void LoadProductsData()
        {
            try
            {
                PGridView.DataSource = null;
                PGridView.Rows.Clear();
                List<ProductBL> products = ObjectHandler.GetProductDL().GetAllProducts();
                foreach (ProductBL p in products)
                {
                    if (cart.Count > 0)
                    {
                        foreach (OrderDetailsBL od in cart)
                        {
                            if (od.GetProduct().GetProductID() == p.GetProductID())
                            {
                                PGridView.Rows.Add(
                                    p.GetProductID(),
                                    p.GetProductName(),
                                    p.GetProductDetails(),
                                    p.GetProductPrice(),
                                    p.GetUnitsInStock() - od.GetQuantity()
                                );
                            }
                        }
                    }
                    else
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputsP()
        {
            PInput.Text = "";
            PDInput.Text = "";
            QuantityInput.Text = "";
            PPInput.Text = "";
            UISInput.Text = "";
            PNInput.Text = "";
        }

        private void LoadDataIntoInputsP(ProductBL product)
        {
            PNInput.Text = product.GetProductName();
            PDInput.Text = product.GetProductDetails();
            UISInput.Text = product.GetUnitsInStock().ToString();
            PPInput.Text = product.GetProductPrice().ToString();
            PInput.Text = product.GetProductID().ToString();
        }

        private void ClearInputs()
        {
            gunaLabel4.Text = "";
            gunaLabel7.Text = "";
            guna2TextBox1.Text = "";
            gunaLabel11.Text = "";
            gunaLabel8.Text = "";
            gunaLabel6.Text = "";
        }

        private void LoadDataIntoInputs(OrderDetailsBL od)
        {
            gunaLabel6.Text = od.GetProduct().GetProductName();
            gunaLabel7.Text = od.GetProduct().GetProductDetails();
            gunaLabel11.Text = od.GetQuantity().ToString();
            gunaLabel8.Text = od.GetPrice().ToString();
            gunaLabel4.Text = od.GetProduct().GetProductID().ToString();
        }

        private void PGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (PGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = PGridView.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < PGridView.Rows.Count)
                    {
                        int productID = Convert.ToInt32(selectedRow.Cells["Column1P"].Value);
                        string productName = selectedRow.Cells["Column2P"].Value?.ToString();
                        string productDetails = selectedRow.Cells["Column3P"].Value?.ToString();
                        double price = Convert.ToDouble(selectedRow.Cells["Column4P"].Value);
                        int unitsInStock = Convert.ToInt32(selectedRow.Cells["Column5P"].Value);
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

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < dataGridView1.Rows.Count &&
                        selectedRow.Cells["Column1D"].Value != null &&
                        selectedRow.Cells["Column2D"].Value != null &&
                        selectedRow.Cells["Column3D"].Value != null &&
                        selectedRow.Cells["Column4D"].Value != null &&
                        selectedRow.Cells["Column5D"].Value != null)
                    {
                        int productID = Convert.ToInt32(selectedRow.Cells["Column1D"].Value);
                        string productName = selectedRow.Cells["Column2D"].Value?.ToString();
                        string productDetails = selectedRow.Cells["Column3D"].Value?.ToString();
                        double price = Convert.ToDouble(selectedRow.Cells["Column4D"].Value);
                        int quantity = Convert.ToInt32(selectedRow.Cells["Column5D"].Value);
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
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddP_Click(object sender, EventArgs e)
        {
            try
            {
                if (PInput.Text != null)
                {
                    ProductBL product = ObjectHandler.GetProductDL().GetProductByProductID(Convert.ToInt16(PInput.Text));
                    OrderDetailsBL existingDetail = null;
                    foreach (OrderDetailsBL od in cart)
                    {
                        if (od.GetProduct().GetProductID() == product.GetProductID())
                        {
                            existingDetail = od;
                        }
                    }
                    if (existingDetail != null)
                    {
                        DialogResult result = MessageBox.Show("Product already exists in the cart. Do you want to add more stock?", "Product Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (!int.TryParse(QuantityInput.Text, out int quantitsy) || quantitsy <= 0)
                            {
                                MessageBox.Show("Please enter a valid positive quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (Convert.ToInt16(UISInput.Text) - quantitsy - existingDetail.GetQuantity() < 0)
                            {
                                MessageBox.Show("Requested quantity exceeds available stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            existingDetail.AddQuantity(quantitsy);
                            MessageBox.Show("Stock added to existing product in the cart!");
                            LoadDataForCart();
                            LoadProductsData();
                            ClearInputsP();
                        }
                        return;
                    }
                    if (!int.TryParse(QuantityInput.Text, out int quantity) || quantity <= 0)
                    {
                        MessageBox.Show("Please enter a valid positive quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Convert.ToInt16(UISInput.Text) - quantity < 0)
                    {
                        MessageBox.Show("Requested quantity exceeds available stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    OrderDetailsBL detail = new OrderDetailsBL(product, quantity);
                    cart.Add(detail);
                    LoadDataForCart();
                    LoadProductsData();
                    ClearInputsP();
                    MessageBox.Show("Product added to cart!");
                }
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
                dataGridView1.Rows.Clear();
                if (cart != null)
                {
                    if (cart.Count > 0)
                    {
                        dataGridView1.DataSource = null;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomersOrdersData() // Load customer order into grid
        {
            try
            {
                // Retrieve customers' data from the data access layer
                COGridView.DataSource = null; // Unbind the data source
                COGridView.Rows.Clear(); // Clear the rows
                List<CustomerBL> customers = ObjectHandler.GetCustomerDL().GetAllCustomers();
                // Add rows to the DataGridView
                foreach (CustomerBL c in customers)
                {
                    if (c.GetUsername()==customer.GetUsername())
                    {
                        foreach (OrderBL order in c.GetOrders())
                        {
                            // Check if the order belongs to the selected customer
                            if (c.GetUsername() == CustomerIDCO.Text && order.GetEmployee()!=null)
                            {
                                _=COGridView.Rows.Add(
                                    order.GetOrderID(),
                                    order.GetEmployee().GetUsername(),
                                    order.GetOrderType(),
                                    order.GetOrderDate(),
                                    order.GetTotalPrice()
                                );
                            }
                            else if (c.GetUsername() == CustomerIDCO.Text && order.GetEmployee()==null)
                            {
                                _=COGridView.Rows.Add(
                                    order.GetOrderID(),
                                    "N.A.",
                                    order.GetOrderType(),
                                    order.GetOrderDate(),
                                    order.GetTotalPrice()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataForCustomerID() // Load data for customer ID
        {
            try
            {
                List<CustomerBL> customers = ObjectHandler.GetCustomerDL().GetAllCustomers();
                CustomerIDCO.Items.Clear();

                foreach (CustomerBL cust in customers)
                {
                    foreach(OrderBL o in cust.GetOrders())
                    // Add customer usernames to the combo box
                    CustomerIDCO.Items.Add(o.GetOrderID());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CustomerIDCO_SelectionChanged(object sender, EventArgs e) // Load customer data
        {
            if (CustomerIDCO.SelectedItem != null) // Check if selected
            {
                LoadCustomersOrdersData(); // Load orders
                CustTO.Text=ObjectHandler.GetOrderDL().GetOrderCountForCustomer(CustomerIDCO.Text).ToString();
                COGridView.ClearSelection();
                ClearInputsCO();
            }
        }
        private void COGridView_SelectionChanged(object sender, EventArgs e) // Handle selection change
        {
            try
            {
                if (COGridView.SelectedRows.Count > 0) // If row selected
                {
                    DataGridViewRow selectedRow = COGridView.SelectedRows[0]; // Get selected row
                    if (selectedRow.Index >= 0 && selectedRow.Index < COGridView.Rows.Count) // Valid index
                    {
                        if (int.TryParse(selectedRow.Cells["Column1CO"].Value?.ToString(), out int orderID)) // Parse order ID
                        {
                            string employeeID = selectedRow.Cells["Column2CO"].Value?.ToString(); // Get employee ID
                            string orderType = selectedRow.Cells["Column3CO"].Value?.ToString(); // Get order type
                            if (DateTime.TryParse(selectedRow.Cells["Column4CO"].Value?.ToString(), out DateTime orderDate)) // Parse order date
                            {
                                if (double.TryParse(selectedRow.Cells["Column5CO"].Value?.ToString(), out double totalPrice)) // Parse total price
                                {
                                    string customername = ObjectHandler.GetCustomerDL().GetCustomerByUsername(customer.GetUsername()).GetName(); // Get customer name
                                    EmployeeBL employee = ObjectHandler.GetEmployeeDL().GetEmployeebyUsername(employeeID); // Get employee
                                    OrderBL order = new OrderBL(orderID, orderType, orderDate, employee, totalPrice); // Create order
                                    LoadDataIntoInputsCO(order); // Load data
                                }
                            }
                        }
                        else
                        {
                            ClearInputsCO(); // Clear inputs
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error
            }
        }
        private void ClearInputsCO() // Clear input fields related to customer orders
        {
            EmployeeIDCOTXT.Text = "";
            OrderDateCOTXT.Text = "";
            TotalPriceCO.Text = "";
            OIDTXT.Text = "";
        }
        private void LoadDataIntoInputsCO(OrderBL order) // Load order data into input fields related to customer orders
        {
            if (order.GetEmployee()!=null)
            {
                EmployeeIDCOTXT.Text = order.GetEmployee().GetUsername();
            }
            else
            {
                EmployeeIDCOTXT.Text ="N.A";
            }
            CustTO.Text=ObjectHandler.GetOrderDL().GetOrderCountForCustomer(customer.GetUsername()).ToString();
            OrderDateCOTXT.Text = order.GetOrderDate().ToString("yyyy-MM-dd");
            OIDTXT.Text = order.GetOrderID().ToString();
            TotalPriceCO.Text = order.GetTotalPrice().ToString();
        }
        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaLabel4.Text != null)
                {
                    bool check = false;
                    ProductBL product = ObjectHandler.GetProductDL().GetProductByProductID(Convert.ToInt16(gunaLabel4.Text));
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
                    LoadProductsData();
                    ClearInputs();
                    MessageBox.Show("Product removed from cart!");
                }
            }
            catch (Exception)
            {
            }
        }
        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaLabel4.Text!= null)
                {

                    ProductBL product = ObjectHandler.GetProductDL().GetProductByProductID(Convert.ToInt16(gunaLabel4.Text));
                    OrderDetailsBL existingDetail = null;
                    foreach (OrderDetailsBL od in cart)
                    {
                        if (od.GetProduct().GetProductID()==product.GetProductID())
                        {
                            existingDetail = od;
                        }
                    }
                    if (existingDetail != null)
                    {
                        DialogResult result = MessageBox.Show("Do you want to update stock?", "Product Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (!int.TryParse(guna2TextBox1.Text, out int quantitsy) || quantitsy<0)
                            {
                                MessageBox.Show("Please enter a valid positive quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (product.GetUnitsInStock() - quantitsy < 0)
                            {
                                MessageBox.Show("Requested quantity exceeds available stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            existingDetail.SetQuantity(quantitsy);
                            MessageBox.Show("Stock updated to existing product in the cart!");
                            LoadDataForCart();
                            LoadProductsData();
                        }
                        return;
                    }
                }

            }
            catch { }
        }
        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cart!=null)
                {
                    if (cart.Count>0)
                    {
                        OrderBL order = new OrderBL("Online", DateTime.Now, cart);
                        order.SetOrderID(ObjectHandler.GetOrderDL().AddOrder(order, customer.GetUsername()));
                        foreach(OrderDetailsBL od in order.GetOrderDetails())
                        {
                            ObjectHandler.GetOrderDetailsDL().AddOrderDetails(order);
                        }
                        cart.Clear();
                        customer.AddOrder(order);
                        MessageBox.Show("Order placed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataForCart();
                    }
                    else
                    {
                        MessageBox.Show("No product selected!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No product selected!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
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
        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            string username = customer.GetUsername();
            string email = customer.GetEmail();
            if (UNI.Text!="" && username!=null && email!=null)
            {
                CustomerBL employee = new CustomerBL(UnameI.Text, UNI.Text, UPI.Text, UEI.Text, DOBI.Value, UAI.Text, UCI.Text, UGI.Text, "Active");
                string message = ObjectHandler.GetCustomerDL().UpdateCustomer(customer, username, email);
                if (message=="True")
                {
                    MessageBox.Show("Admin updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customer.SetName(UnameI.Text); customer.SetUsername(UNI.Text); customer.SetPassword(UPI.Text); customer.SetEmail(UEI.Text); customer.SetDob(DOBI.Value); customer.SetAddress(UAI.Text); customer.SetContact(UCI.Text); customer.SetGender(UGI.Text);
                    LoadDataUser();
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BunifuButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }
    }
}
