using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PointOfSaleSystem
{
    public partial class PlaceOrderControl : UserControl
    {
        public PlaceOrderControl()
        {
            InitializeComponent();
        }

        private void PlaceOrderControl_Load(object sender, EventArgs e)
        {
            AddCategory();
            itemPanel.Controls.Clear();
            LoadProducts();
        }

        // Adds buttons to the panel based on the category table in the database
        private void AddCategory()
        {
            string qry = "SELECT * FROM Category";
            SqlCommand cmd = new SqlCommand(qry, LoginForm.connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            categoryPanel.Controls.Clear();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button Btn = new Guna.UI2.WinForms.Guna2Button
                    {
                        FillColor = Color.Wheat,
                        ForeColor = Color.Black,
                        Size = new Size(111, 45),
                        ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                        Text = row["catName"].ToString()
                    };

                    categoryPanel.Controls.Add(Btn);
                }
            }
        }

        // Adds items to the itemPanel
        private void AddItems(string id, string item, string cat, string price, Image pimage)
        {
            var w = new productControl()
            {
                PItem = item,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(id)
            };

            itemPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (productControl)ss;

                // Check if item already exists in the DataGridView
                foreach (DataGridViewRow items in itemReceipt.Rows)
                {
                    if (Convert.ToInt32(items.Cells["dgvId"].Value) == wdg.id)
                    {
                        items.Cells["dgvQty"].Value = int.Parse(items.Cells["dgvQty"].Value.ToString()) + 1;
                        items.Cells["dgvAmount"].Value = double.Parse(items.Cells["dgvQty"].Value.ToString()) * double.Parse(items.Cells["dgvPrice"].Value.ToString());
                        GetTotal();
                        return;
                    }
                }

                // Add new product to the DataGridView
                itemReceipt.Rows.Add(new object[] { 0, wdg.id, wdg.PItem, 1, wdg.PPrice, double.Parse(wdg.PPrice) });
                GetTotal();
            };
        }

        // Loads products from the database and displays them in the itemPanel
        private void LoadProducts()
        {
            string qry = "SELECT * FROM products INNER JOIN category ON catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, LoginForm.connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow item in dataTable.Rows)
            {
                byte[] imageArray = (byte[])item["pImage"];
                using (var ms = new MemoryStream(imageArray))
                {
                    Image productImage = Image.FromStream(ms);
                    AddItems(item["pID"].ToString(), item["pItem"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), productImage);
                }
            }
        }

        // Filters products based on the text entered in the search box
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            foreach (productControl product in itemPanel.Controls)
            {
                product.Visible = product.PItem.ToLower().Contains(searchBox.Text.Trim().ToLower());
            }
        }

        // Handles formatting for the itemReceipt DataGridView
        private void itemReceipt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Check if the row index is valid and it's the Sr# column
            {
                // Assign the serial number only if the row is not new and has valid data in other columns
                if (itemReceipt.Rows[e.RowIndex].Cells["dgvId"].Value != null)
                {
                    e.Value = e.RowIndex + 1;
                }
            }
        }

        // Calculates and displays the total amount in the TotalText TextBox
        private void GetTotal()
        {
            double total = 0;

            foreach (DataGridViewRow item in itemReceipt.Rows)
            {
                if (item.Cells["dgvAmount"].Value != null)
                {
                    total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
                }
            }

            TotalText.Text = total.ToString("N2");
        }
    }
}
