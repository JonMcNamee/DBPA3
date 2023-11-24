using Microsoft.EntityFrameworkCore;
using System.Configuration;
using McNameeLab3.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.ComponentModel;

namespace McNameeLab3
{

    /*  Jon McNamee
     *  DBP Lab 3 EFCore & LINQ
     *  25 May 2023
     */
    public partial class frmKitchenSupply : Form
    {
        public KitchenContext? context;

        public frmKitchenSupply()
        {
            InitializeComponent();
        }

        private void frmKitchenSupply_Load(object sender, EventArgs e)
        {
            //fills all tables and clears selected rows so that default is unselected items
            PopulateDgv();
            ClearSelection();

            //adds me as a customer if I do not already exist
            bool customerExists = context.Customers.Any(c => c.FirstName == "Jon" && c.LastName == "McNamee");
            if (!customerExists)
            {
                Customer cust = new Customer
                {
                    FirstName = "Jon",
                    LastName = "McNamee"
                };

                context.Customers.Add(cust);
                context.SaveChanges();
            }
        }

        //event for when textbox receives new inputs
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            //if else chain to determine which search to run
            if (tabControl.SelectedTab == tabProducts)
            {            
                try
                {   
                    var filteredProducts = context.Products.Where(p => p.ProductId.ToString().Contains(searchText) || p.ProductName.ToLower().Contains(searchText)).ToList();
                    productBindingSource.DataSource = filteredProducts;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (tabControl.SelectedTab == tabServices)
            {            
                try
                {
                    var filteredServices = context.Services.Where(s => s.ServiceId.ToString().Contains(searchText) || s.ServiceName.ToLower().Contains(searchText)).ToList();
                    serviceBindingSource.DataSource = filteredServices;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (tabControl.SelectedTab == tabOrders)
            {            
                try
                {   //rebuilds orders with correct customer row
                    var filteredOrders = 
                        from o in context.Orders
                        join c in context.Customers on o.CustomerId equals c.CustomerId
                        where o.OrderId.ToString().Contains(searchText) || (c.FirstName + " " + c.LastName).Contains(searchText)
                        select new
                        {
                            o.OrderId,
                            o.CustomerId,                            
                            o.OrderDate,
                            o.TotalAmount,
                            Customer = c.FirstName + " " + c.LastName
                        };

                    dgvOrders.DataSource = filteredOrders.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //code to make orderitems stop displaying if no orders on orders dgv
                if (dgvOrders.Rows.Count == 0)
                {
                    dgvOrderItems.DataSource = null;
                }
            }
        }

        //method to fill datagrid views with database content
        private void PopulateDgv()
        {
            ClearSelection();

            try
            {
                context = new KitchenContext();

                //load commands to get databaase information
                context.Orders.Load();
                context.Products.Load();
                context.Services.Load();
                context.Customers.Load();

                //query created to populate orders table with customer name instead of object
                var queryCustomerName =
                    from o in context.Orders
                    join c in context.Customers on o.CustomerId equals c.CustomerId
                    select new
                    {
                        o.OrderId,
                        o.CustomerId,
                        o.OrderDate,
                        o.TotalAmount,
                        Customer = c.FirstName + " " + c.LastName
                    };
                dgvOrders.DataSource = queryCustomerName.ToList();

                //commands to fill the other datagrids with db info
                productBindingSource.DataSource = context.Products.Local.ToBindingList();
                serviceBindingSource.DataSource = context.Services.Local.ToBindingList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //method to generate orderitems dgv
        private void PopulateOrderItems()
        {
            context.OrderItems.Load();

                var oItemQuery = context.OrderItems.Where(oi
                    => oi.OrderId.ToString().Contains(lblSelectedOrder.Text));

                dgvOrderItems.DataSource = oItemQuery.ToList();
                dgvOrderItems.AutoResizeColumns();
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if(context != null && dgvOrders.SelectedRows.Count == 1)
            {

                //displays currently order items based on selected row
                DataGridViewRow selectedRow = dgvOrders.SelectedRows[0];
                string orderId = selectedRow.Cells[0].Value.ToString();
                lblSelectedOrder.Text = orderId;

                lblSelectedItem.Text = "";
                PopulateOrderItems();
                dgvOrderItems.ClearSelection();
                GetDetails();
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvProducts != null && dgvProducts.SelectedRows.Count >= 1)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                GetItem(selectedRow);
                dgvOrderItems.ClearSelection();
            }
        }

        private void dgvServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts != null && dgvServices.SelectedRows.Count >= 1)
            {
                DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
                GetItem(selectedRow);
                dgvOrderItems.ClearSelection();
            }
        }
        //method to fill selected item
        private void GetItem(DataGridViewRow selectedRow)
        {
                string selectedItem = selectedRow.Cells[0].Value.ToString() + " " + selectedRow.Cells[1].Value.ToString();
                lblSelectedItem.Text = selectedItem;
        }

        //method to clear selected rows and labels
        private void ClearSelection()
        {
            dgvOrders.ClearSelection();
            dgvProducts.ClearSelection();
            dgvServices.ClearSelection();
            dgvOrderItems.ClearSelection();

            lblSelectedOrder.Text = "";
            lblSelectedItem.Text = "";

            lblCustomer.Text = "";
            lblNumItems.Text = "";
            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";

            if (dgvOrders.SelectedRows.Count == 0)
            {
                dgvOrderItems.DataSource = null;
            }

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            var cust = context.Customers.OrderBy(c => c.CustomerId).Last();

            Order newOrder = new Order
            {
                CustomerId = cust.CustomerId,
                OrderDate = DateTime.Today,
                TotalAmount = 0m
            };
            if (!context.Orders.Contains(newOrder))
            {
                //adds new order to order dgv
                context.Orders.Add(newOrder);
                MessageBox.Show("Order Successfully Added", "Create Order Complete");
                context.SaveChanges();
                PopulateDgv();
                ClearSelection();
            }
        }

        private void btnAddRemove_Click(object sender, EventArgs e)
        {
            //Remove functionality
            if(dgvOrderItems.SelectedRows.Count > 0)
            {
                //targets selected order item in dgvOrderItems
                DataGridViewRow selectedRow = dgvOrderItems.SelectedRows[0];
                int lineId = Convert.ToInt32(selectedRow.Cells[0].Value);
                OrderItem delItem = context.OrderItems.First(oi => oi.LineId == lineId);
                
                if(lineId != null)
                {
                    try
                    {
                        //deletes orderItem from database and refreshes dgv display to reflect change
                        context.OrderItems.Remove(delItem);
                        context.SaveChanges();
                        MessageBox.Show("Order Item Successfully Removed.", "Successful Deletion");
                        PopulateDgv();
                        GetDetails();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            //Add functionality for Products
            else if(dgvProducts.SelectedRows.Count > 0)
            { 
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                int prodId = (int)selectedRow.Cells[0].Value;
                int orderId = Convert.ToInt32(lblSelectedOrder.Text);

                decimal price = (decimal)selectedRow.Cells[2].Value;
                OrderItem newItem = new OrderItem
                {
                    ProductId = prodId,
                    OrderId = orderId,
                    Price = price,
                    Quantity = 1
                };

                try
                {
                    context.OrderItems.Add(newItem);
                    context.SaveChanges();
                    PopulateDgv();
                    GetDetails();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } // Add functionality for Services
            else if(dgvServices.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
                int serviceId = (int)selectedRow.Cells[0].Value;
                int orderId = Convert.ToInt32(lblSelectedOrder.Text);
                decimal price = (decimal)selectedRow.Cells[2].Value;

                OrderItem newItem = new OrderItem
                {
                    ServiceId = serviceId,
                    OrderId = orderId,
                    Price = price,
                    Quantity = 1
                };

                try
                {
                    context.OrderItems.Add(newItem);
                    context.SaveChanges();
                    PopulateDgv();
                    GetDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvOrders.SelectedRows.Count > 0)
            {
                //targets selected order in dgvOrders and checks if it has orderItems or not
                DataGridViewRow selectedRow = dgvOrders.SelectedRows[0];
                int orderId = (int)selectedRow.Cells[0].Value;
                bool hasItems = context.OrderItems.Any(oi => oi.OrderId == orderId);
                Order delOrder = context.Orders.First(o => o.OrderId == orderId);

                //checks to make sure order does not have any orderItems before performing deletion
                if (hasItems)
                {
                    MessageBox.Show("Can't delete Order " + orderId.ToString() + " as there are items attached to it.", "Error Deleting");
                }
                else
                {            
                    try
                    {
                        context.Orders.Remove(delOrder);
                        context.SaveChanges();
                        MessageBox.Show("Order Deleted", "Successful Deletion");
                        PopulateDgv();
                        ClearSelection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        //function to populate Order Details groupbox labels based on selected order
        private void GetDetails()
        {
            decimal taxRate = 0.15m;

            int numItems = dgvOrderItems.Rows.Count;
            decimal subtotal = (decimal)dgvOrders.SelectedRows[0].Cells[3].Value;
            string custName = dgvOrders.SelectedRows[0].Cells[4].Value.ToString();

            decimal tax = taxRate * subtotal;
            decimal total = subtotal + tax;

            lblCustomer.Text = custName;
            lblNumItems.Text = numItems.ToString();
            lblSubtotal.Text = subtotal.ToString("c");
            lblTax.Text = tax.ToString("c");
            lblTotal.Text = total.ToString("c");
        }
    }
}