using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Products
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private CatalogDbContext context = new CatalogDbContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductDataGridView.DataSource = context.Products.ToList();
            ProductDataGridView.Columns["Guid"].HeaderText = "Инвентаризационный номер";
            ProductDataGridView.Columns["Name"].HeaderText = "Наименование";
            ProductDataGridView.Columns["ExpiryDate"].HeaderText = "Дата истечения срока годности";
            ProductDataGridView.Columns["Quantity"].HeaderText = "Количество на складе";
            ProductDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            sortingComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                Guid = Guid.NewGuid(),
                Name = productNameText.Text,
                ExpiryDate = productDateSelect.Value,
                Quantity = int.Parse(productQuantityText.Text)
            };

            context.Products.Add(newProduct);
            context.SaveChanges();
            ProductDataGridView.DataSource = context.Products.ToList();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = sortingComboBox.SelectedIndex;
            List<Product> products = context.Products.ToList();

            switch (selectedIndex)
            {
                case 0:
                    products = products.OrderBy(p => p.Name).ToList();
                    break;
                case 1:
                    products = products.OrderBy(p => p.Name.Length).ToList();
                    break;
                case 2:
                    products = products.OrderBy(p => p.Quantity).Reverse().ToList();
                    break;
                case 3:
                    products = products.OrderBy(p => p.Quantity).ToList();
                    break;
            }
            ProductDataGridView.DataSource = products;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string queryGuid = searchByNumberText.Text;
            List<Product> products = context.Products.ToList();

            products = products.FindAll(p => p.Guid.ToString().Contains(queryGuid));

            ProductDataGridView.DataSource = products;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime queryDate = searchByDateSelect.Value;
            List<Product> products = context.Products.ToList();

            products = products.FindAll(p => p.ExpiryDate.Date == queryDate.Date);

            ProductDataGridView.DataSource = products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDataGridView.DataSource = context.Products.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ProductDataGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = ProductDataGridView.SelectedRows[0];
                Product selectedProduct = (Product)selectedRow.DataBoundItem;


                Product productToDelete = context.Products.FirstOrDefault(p => p.Guid == selectedProduct.Guid);

                context.Products.Remove(productToDelete);
                context.SaveChanges();
                ProductDataGridView.DataSource = context.Products.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ProductDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductDataGridView.SelectedRows[0];
                Product selectedProduct = (Product)selectedRow.DataBoundItem;

                int newQuantity = int.Parse(changeProductQuantityText.Text);

                Product productToUpdate = context.Products.FirstOrDefault(p => p.Guid == selectedProduct.Guid);

                productToUpdate.Quantity = newQuantity;
                context.SaveChanges();
                ProductDataGridView.DataSource = context.Products.ToList();
            }
        }
    }
}