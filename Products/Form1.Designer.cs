namespace Products
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProductDataGridView = new DataGridView();
            AddProductButton = new Button();
            productNameText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            productQuantityText = new TextBox();
            productDateSelect = new DateTimePicker();
            label3 = new Label();
            sortingComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            searchByNumberText = new TextBox();
            label6 = new Label();
            searchByDateSelect = new DateTimePicker();
            wipeDateButton = new Button();
            DeleteProductButton = new Button();
            changeProductQuantityText = new TextBox();
            label7 = new Label();
            UpdateProductButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Location = new Point(12, 12);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.RowTemplate.Height = 25;
            ProductDataGridView.Size = new Size(727, 323);
            ProductDataGridView.TabIndex = 0;
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(745, 174);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(197, 45);
            AddProductButton.TabIndex = 1;
            AddProductButton.Text = "Добавить товар";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += button1_Click;
            // 
            // productNameText
            // 
            productNameText.Location = new Point(745, 27);
            productNameText.Name = "productNameText";
            productNameText.Size = new Size(197, 23);
            productNameText.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(745, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Название товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(745, 116);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Остаток на складе";
            // 
            // productQuantityText
            // 
            productQuantityText.Location = new Point(745, 134);
            productQuantityText.Name = "productQuantityText";
            productQuantityText.Size = new Size(197, 23);
            productQuantityText.TabIndex = 4;
            productQuantityText.TextChanged += textBox2_TextChanged;
            // 
            // productDateSelect
            // 
            productDateSelect.Location = new Point(745, 81);
            productDateSelect.Name = "productDateSelect";
            productDateSelect.Size = new Size(200, 23);
            productDateSelect.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(745, 63);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 8;
            label3.Text = "Срок годности";
            // 
            // sortingComboBox
            // 
            sortingComboBox.FormattingEnabled = true;
            sortingComboBox.Items.AddRange(new object[] { "Алфавиту", "Длине названия", "Много на складе", "Мало на складе" });
            sortingComboBox.Location = new Point(12, 370);
            sortingComboBox.Name = "sortingComboBox";
            sortingComboBox.Size = new Size(213, 23);
            sortingComboBox.TabIndex = 9;
            sortingComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 352);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 10;
            label4.Text = "Сортировка по";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 352);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 11;
            label5.Text = "Поиск по номеру";
            // 
            // searchByNumberText
            // 
            searchByNumberText.Location = new Point(248, 370);
            searchByNumberText.Name = "searchByNumberText";
            searchByNumberText.Size = new Size(231, 23);
            searchByNumberText.TabIndex = 12;
            searchByNumberText.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(508, 352);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 13;
            label6.Text = "Поиск по дате";
            // 
            // searchByDateSelect
            // 
            searchByDateSelect.Location = new Point(508, 370);
            searchByDateSelect.Name = "searchByDateSelect";
            searchByDateSelect.Size = new Size(200, 23);
            searchByDateSelect.TabIndex = 15;
            searchByDateSelect.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // wipeDateButton
            // 
            wipeDateButton.Location = new Point(508, 399);
            wipeDateButton.Name = "wipeDateButton";
            wipeDateButton.Size = new Size(131, 23);
            wipeDateButton.TabIndex = 16;
            wipeDateButton.Text = "Сбросить дату";
            wipeDateButton.UseVisualStyleBackColor = true;
            wipeDateButton.Click += button2_Click;
            // 
            // DeleteProductButton
            // 
            DeleteProductButton.Location = new Point(748, 415);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new Size(197, 23);
            DeleteProductButton.TabIndex = 17;
            DeleteProductButton.Text = "Удалить товар";
            DeleteProductButton.UseVisualStyleBackColor = true;
            DeleteProductButton.Click += button3_Click;
            // 
            // changeProductQuantityText
            // 
            changeProductQuantityText.Location = new Point(745, 274);
            changeProductQuantityText.Name = "changeProductQuantityText";
            changeProductQuantityText.Size = new Size(197, 23);
            changeProductQuantityText.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(745, 256);
            label7.Name = "label7";
            label7.Size = new Size(128, 15);
            label7.TabIndex = 19;
            label7.Text = "Изменить количество";
            // 
            // UpdateProductButton
            // 
            UpdateProductButton.Location = new Point(745, 303);
            UpdateProductButton.Name = "UpdateProductButton";
            UpdateProductButton.Size = new Size(197, 23);
            UpdateProductButton.TabIndex = 20;
            UpdateProductButton.Text = "Изменить";
            UpdateProductButton.UseVisualStyleBackColor = true;
            UpdateProductButton.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(UpdateProductButton);
            Controls.Add(label7);
            Controls.Add(changeProductQuantityText);
            Controls.Add(DeleteProductButton);
            Controls.Add(wipeDateButton);
            Controls.Add(searchByDateSelect);
            Controls.Add(label6);
            Controls.Add(searchByNumberText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(sortingComboBox);
            Controls.Add(label3);
            Controls.Add(productDateSelect);
            Controls.Add(label2);
            Controls.Add(productQuantityText);
            Controls.Add(label1);
            Controls.Add(productNameText);
            Controls.Add(AddProductButton);
            Controls.Add(ProductDataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductDataGridView;
        private Button AddProductButton;
        private TextBox productNameText;
        private Label label1;
        private Label label2;
        private TextBox productQuantityText;
        private DateTimePicker productDateSelect;
        private Label label3;
        private ComboBox sortingComboBox;
        private Label label4;
        private Label label5;
        private TextBox searchByNumberText;
        private Label label6;
        private DateTimePicker searchByDateSelect;
        private Button wipeDateButton;
        private Button DeleteProductButton;
        private TextBox changeProductQuantityText;
        private Label label7;
        private Button UpdateProductButton;
    }
}