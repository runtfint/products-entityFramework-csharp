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
            dataGridView1.DataSource = context.Products.ToList();
            dataGridView1.Columns["Guid"].HeaderText = "Инвентаризационный номер";
            dataGridView1.Columns["Name"].HeaderText = "Наименование";
            dataGridView1.Columns["ExpiryDate"].HeaderText = "Дата истечения срока годности";
            dataGridView1.Columns["Quantity"].HeaderText = "Количество на складе";
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                Guid = Guid.NewGuid(),
                Name = textBox1.Text,
                ExpiryDate = dateTimePicker1.Value,
                Quantity = int.Parse(textBox2.Text)
            };

            context.Products.Add(newProduct);
            context.SaveChanges();
            dataGridView1.DataSource = context.Products.ToList();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
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
            dataGridView1.DataSource = products;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string queryGuid = textBox3.Text;
            List<Product> products = context.Products.ToList();

            products = products.FindAll(p => p.Guid.ToString().Contains(queryGuid));

            dataGridView1.DataSource = products;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime queryDate = dateTimePicker2.Value;
            List<Product> products = context.Products.ToList();

            products = products.FindAll(p => p.ExpiryDate.Date == queryDate.Date);
            Console.WriteLine(queryDate.ToString());

            dataGridView1.DataSource = products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Products.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Product selectedProduct = (Product)selectedRow.DataBoundItem;


                Product productToDelete = context.Products.FirstOrDefault(p => p.Guid == selectedProduct.Guid);

                context.Products.Remove(productToDelete);
                context.SaveChanges();
                dataGridView1.DataSource = context.Products.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Product selectedProduct = (Product)selectedRow.DataBoundItem;

                int newQuantity = int.Parse(textBox4.Text);

                Product productToUpdate = context.Products.FirstOrDefault(p => p.Guid == selectedProduct.Guid);

                productToUpdate.Quantity = newQuantity;
                context.SaveChanges();
                dataGridView1.DataSource = context.Products.ToList();
            }
        }
    }
}