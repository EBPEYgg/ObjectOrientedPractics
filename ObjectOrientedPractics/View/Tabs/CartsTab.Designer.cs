namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CartsTabsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.CartGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.AmountIntLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CartRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CartsTabsTableLayoutPanel.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.CartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartsTabsTableLayoutPanel
            // 
            this.CartsTabsTableLayoutPanel.ColumnCount = 2;
            this.CartsTabsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CartsTabsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CartsTabsTableLayoutPanel.Controls.Add(this.ItemsGroupBox, 0, 0);
            this.CartsTabsTableLayoutPanel.Controls.Add(this.CartGroupBox, 1, 0);
            this.CartsTabsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTabsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CartsTabsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CartsTabsTableLayoutPanel.Name = "CartsTabsTableLayoutPanel";
            this.CartsTabsTableLayoutPanel.RowCount = 1;
            this.CartsTabsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CartsTabsTableLayoutPanel.Size = new System.Drawing.Size(870, 593);
            this.CartsTabsTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.AddToCartButton);
            this.ItemsGroupBox.Controls.Add(this.ItemsListBox);
            this.ItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGroupBox.Location = new System.Drawing.Point(3, 4);
            this.ItemsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsGroupBox.Size = new System.Drawing.Size(429, 585);
            this.ItemsGroupBox.TabIndex = 0;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Items";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCartButton.Location = new System.Drawing.Point(8, 523);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(121, 55);
            this.AddToCartButton.TabIndex = 1;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(7, 29);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(415, 484);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // CartGroupBox
            // 
            this.CartGroupBox.Controls.Add(this.ClearCartButton);
            this.CartGroupBox.Controls.Add(this.RemoveItemButton);
            this.CartGroupBox.Controls.Add(this.CreateOrderButton);
            this.CartGroupBox.Controls.Add(this.AmountIntLabel);
            this.CartGroupBox.Controls.Add(this.AmountLabel);
            this.CartGroupBox.Controls.Add(this.CartRichTextBox);
            this.CartGroupBox.Controls.Add(this.CartLabel);
            this.CartGroupBox.Controls.Add(this.CustomerComboBox);
            this.CartGroupBox.Controls.Add(this.CustomerLabel);
            this.CartGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartGroupBox.Location = new System.Drawing.Point(438, 4);
            this.CartGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CartGroupBox.Name = "CartGroupBox";
            this.CartGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CartGroupBox.Size = new System.Drawing.Size(429, 585);
            this.CartGroupBox.TabIndex = 1;
            this.CartGroupBox.TabStop = false;
            this.CartGroupBox.Text = "Cart";
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClearCartButton.Location = new System.Drawing.Point(325, 348);
            this.ClearCartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(97, 55);
            this.ClearCartButton.TabIndex = 8;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RemoveItemButton.Location = new System.Drawing.Point(221, 348);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(97, 55);
            this.RemoveItemButton.TabIndex = 7;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreateOrderButton.Location = new System.Drawing.Point(7, 349);
            this.CreateOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(110, 55);
            this.CreateOrderButton.TabIndex = 6;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // AmountIntLabel
            // 
            this.AmountIntLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AmountIntLabel.AutoSize = true;
            this.AmountIntLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountIntLabel.Location = new System.Drawing.Point(358, 311);
            this.AmountIntLabel.Name = "AmountIntLabel";
            this.AmountIntLabel.Size = new System.Drawing.Size(70, 32);
            this.AmountIntLabel.TabIndex = 5;
            this.AmountIntLabel.Text = "4999";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(359, 291);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(71, 20);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Amount:";
            // 
            // CartRichTextBox
            // 
            this.CartRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartRichTextBox.Location = new System.Drawing.Point(7, 96);
            this.CartRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CartRichTextBox.Name = "CartRichTextBox";
            this.CartRichTextBox.Size = new System.Drawing.Size(414, 189);
            this.CartRichTextBox.TabIndex = 3;
            this.CartRichTextBox.Text = "";
            this.CartRichTextBox.TextChanged += new System.EventHandler(this.CartRichTextBox_TextChanged);
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(7, 72);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(39, 20);
            this.CartLabel.TabIndex = 2;
            this.CartLabel.Text = "Cart:";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(87, 25);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(334, 28);
            this.CustomerComboBox.TabIndex = 1;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerLabel.Location = new System.Drawing.Point(7, 29);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(82, 20);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartsTabsTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(870, 593);
            this.CartsTabsTableLayoutPanel.ResumeLayout(false);
            this.ItemsGroupBox.ResumeLayout(false);
            this.CartGroupBox.ResumeLayout(false);
            this.CartGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel CartsTabsTableLayoutPanel;
        private GroupBox ItemsGroupBox;
        private GroupBox CartGroupBox;
        private ListBox ItemsListBox;
        private Button AddToCartButton;
        private Label CustomerLabel;
        private ComboBox CustomerComboBox;
        private Label CartLabel;
        private RichTextBox CartRichTextBox;
        private Label AmountLabel;
        private Label AmountIntLabel;
        private Button CreateOrderButton;
        private Button ClearCartButton;
        private Button RemoveItemButton;
    }
}
