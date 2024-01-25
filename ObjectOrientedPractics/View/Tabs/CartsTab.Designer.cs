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
            CartsTabsTableLayoutPanel = new TableLayoutPanel();
            ItemsGroupBox = new GroupBox();
            AddToCartButton = new Button();
            ItemsListBox = new ListBox();
            CartGroupBox = new GroupBox();
            DiscountAmountIntLabel = new Label();
            DiscountAmountLabel = new Label();
            TotalIntLabel = new Label();
            TotalLabel = new Label();
            DiscountCheckedListBox = new CheckedListBox();
            CartListBox = new ListBox();
            ClearCartButton = new Button();
            RemoveItemButton = new Button();
            CreateOrderButton = new Button();
            AmountIntLabel = new Label();
            AmountLabel = new Label();
            CartLabel = new Label();
            CustomerComboBox = new ComboBox();
            CustomerLabel = new Label();
            CartsTabsTableLayoutPanel.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            CartGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CartsTabsTableLayoutPanel
            // 
            CartsTabsTableLayoutPanel.ColumnCount = 2;
            CartsTabsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CartsTabsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CartsTabsTableLayoutPanel.Controls.Add(ItemsGroupBox, 0, 0);
            CartsTabsTableLayoutPanel.Controls.Add(CartGroupBox, 1, 0);
            CartsTabsTableLayoutPanel.Dock = DockStyle.Fill;
            CartsTabsTableLayoutPanel.Location = new Point(0, 0);
            CartsTabsTableLayoutPanel.Name = "CartsTabsTableLayoutPanel";
            CartsTabsTableLayoutPanel.RowCount = 1;
            CartsTabsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CartsTabsTableLayoutPanel.Size = new Size(761, 445);
            CartsTabsTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(AddToCartButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Dock = DockStyle.Fill;
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(374, 439);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(7, 392);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(106, 41);
            AddToCartButton.TabIndex = 1;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.Enabled = false;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 22);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(363, 364);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // CartGroupBox
            // 
            CartGroupBox.Controls.Add(DiscountAmountIntLabel);
            CartGroupBox.Controls.Add(DiscountAmountLabel);
            CartGroupBox.Controls.Add(TotalIntLabel);
            CartGroupBox.Controls.Add(TotalLabel);
            CartGroupBox.Controls.Add(DiscountCheckedListBox);
            CartGroupBox.Controls.Add(CartListBox);
            CartGroupBox.Controls.Add(ClearCartButton);
            CartGroupBox.Controls.Add(RemoveItemButton);
            CartGroupBox.Controls.Add(CreateOrderButton);
            CartGroupBox.Controls.Add(AmountIntLabel);
            CartGroupBox.Controls.Add(AmountLabel);
            CartGroupBox.Controls.Add(CartLabel);
            CartGroupBox.Controls.Add(CustomerComboBox);
            CartGroupBox.Controls.Add(CustomerLabel);
            CartGroupBox.Dock = DockStyle.Fill;
            CartGroupBox.Location = new Point(383, 3);
            CartGroupBox.Name = "CartGroupBox";
            CartGroupBox.Size = new Size(375, 439);
            CartGroupBox.TabIndex = 1;
            CartGroupBox.TabStop = false;
            CartGroupBox.Text = "Cart";
            // 
            // DiscountAmountIntLabel
            // 
            DiscountAmountIntLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DiscountAmountIntLabel.AutoSize = true;
            DiscountAmountIntLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountAmountIntLabel.Location = new Point(6, 324);
            DiscountAmountIntLabel.Name = "DiscountAmountIntLabel";
            DiscountAmountIntLabel.Size = new Size(14, 15);
            DiscountAmountIntLabel.TabIndex = 14;
            DiscountAmountIntLabel.Text = "0";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountAmountLabel.Location = new Point(6, 309);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(107, 15);
            DiscountAmountLabel.TabIndex = 13;
            DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // TotalIntLabel
            // 
            TotalIntLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TotalIntLabel.AutoSize = true;
            TotalIntLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TotalIntLabel.Location = new Point(6, 392);
            TotalIntLabel.Name = "TotalIntLabel";
            TotalIntLabel.Size = new Size(23, 25);
            TotalIntLabel.TabIndex = 12;
            TotalIntLabel.Text = "0";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.Location = new Point(6, 377);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(46, 15);
            TotalLabel.TabIndex = 11;
            TotalLabel.Text = "TOTAL:";
            TotalLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DiscountCheckedListBox
            // 
            DiscountCheckedListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountCheckedListBox.BackColor = Color.FromArgb(249, 249, 249);
            DiscountCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountCheckedListBox.FormattingEnabled = true;
            DiscountCheckedListBox.Location = new Point(130, 309);
            DiscountCheckedListBox.Name = "DiscountCheckedListBox";
            DiscountCheckedListBox.Size = new Size(239, 108);
            DiscountCheckedListBox.TabIndex = 10;
            DiscountCheckedListBox.SelectedIndexChanged += DiscountCheckedListBox_SelectedIndexChanged;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(6, 71);
            CartListBox.Margin = new Padding(3, 2, 3, 2);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(363, 139);
            CartListBox.TabIndex = 9;
            CartListBox.SelectedIndexChanged += CartListBox_SelectedIndexChanged;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearCartButton.Location = new Point(284, 261);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(85, 41);
            ClearCartButton.TabIndex = 8;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(193, 261);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(85, 41);
            RemoveItemButton.TabIndex = 7;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateOrderButton.Enabled = false;
            CreateOrderButton.Location = new Point(6, 262);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(96, 41);
            CreateOrderButton.TabIndex = 6;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // AmountIntLabel
            // 
            AmountIntLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AmountIntLabel.AutoSize = true;
            AmountIntLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AmountIntLabel.Location = new Point(6, 234);
            AmountIntLabel.Name = "AmountIntLabel";
            AmountIntLabel.Size = new Size(23, 25);
            AmountIntLabel.TabIndex = 5;
            AmountIntLabel.Text = "0";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(6, 218);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(55, 15);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount:";
            AmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(6, 54);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(32, 15);
            CartLabel.TabIndex = 2;
            CartLabel.Text = "Cart:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(76, 19);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(293, 23);
            CustomerComboBox.TabIndex = 1;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerLabel.Location = new Point(6, 22);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(64, 15);
            CustomerLabel.TabIndex = 0;
            CustomerLabel.Text = "Customer:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartsTabsTableLayoutPanel);
            Name = "CartsTab";
            Size = new Size(761, 445);
            CartsTabsTableLayoutPanel.ResumeLayout(false);
            ItemsGroupBox.ResumeLayout(false);
            CartGroupBox.ResumeLayout(false);
            CartGroupBox.PerformLayout();
            ResumeLayout(false);
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
        private Label AmountLabel;
        private Label AmountIntLabel;
        private Button CreateOrderButton;
        private Button ClearCartButton;
        private Button RemoveItemButton;
        private ListBox CartListBox;
        private Label TotalIntLabel;
        private Label TotalLabel;
        private CheckedListBox DiscountCheckedListBox;
        private Label DiscountAmountIntLabel;
        private Label DiscountAmountLabel;
    }
}
