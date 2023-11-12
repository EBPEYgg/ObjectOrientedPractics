﻿namespace ObjectOrientedPractics.View.Tabs
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
            this.DiscountAmountIntLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.TotalIntLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.DiscountCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.AmountIntLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
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
            this.ItemsListBox.Enabled = false;
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(7, 29);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(416, 484);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // CartGroupBox
            // 
            this.CartGroupBox.Controls.Add(this.DiscountAmountIntLabel);
            this.CartGroupBox.Controls.Add(this.DiscountAmountLabel);
            this.CartGroupBox.Controls.Add(this.TotalIntLabel);
            this.CartGroupBox.Controls.Add(this.TotalLabel);
            this.CartGroupBox.Controls.Add(this.DiscountCheckedListBox);
            this.CartGroupBox.Controls.Add(this.CartListBox);
            this.CartGroupBox.Controls.Add(this.ClearCartButton);
            this.CartGroupBox.Controls.Add(this.RemoveItemButton);
            this.CartGroupBox.Controls.Add(this.CreateOrderButton);
            this.CartGroupBox.Controls.Add(this.AmountIntLabel);
            this.CartGroupBox.Controls.Add(this.AmountLabel);
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
            // DiscountAmountIntLabel
            // 
            this.DiscountAmountIntLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountAmountIntLabel.AutoSize = true;
            this.DiscountAmountIntLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountAmountIntLabel.Location = new System.Drawing.Point(390, 444);
            this.DiscountAmountIntLabel.Name = "DiscountAmountIntLabel";
            this.DiscountAmountIntLabel.Size = new System.Drawing.Size(36, 20);
            this.DiscountAmountIntLabel.TabIndex = 14;
            this.DiscountAmountIntLabel.Text = "499";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountAmountLabel.Location = new System.Drawing.Point(424, 412);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(137, 20);
            this.DiscountAmountLabel.TabIndex = 13;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // TotalIntLabel
            // 
            this.TotalIntLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalIntLabel.AutoSize = true;
            this.TotalIntLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalIntLabel.Location = new System.Drawing.Point(421, 535);
            this.TotalIntLabel.Name = "TotalIntLabel";
            this.TotalIntLabel.Size = new System.Drawing.Size(70, 32);
            this.TotalIntLabel.TabIndex = 12;
            this.TotalIntLabel.Text = "4500";
            this.TotalIntLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalLabel.Location = new System.Drawing.Point(421, 515);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(58, 20);
            this.TotalLabel.TabIndex = 11;
            this.TotalLabel.Text = "TOTAL:";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DiscountCheckedListBox
            // 
            this.DiscountCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.DiscountCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountCheckedListBox.FormattingEnabled = true;
            this.DiscountCheckedListBox.Location = new System.Drawing.Point(9, 412);
            this.DiscountCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiscountCheckedListBox.Name = "DiscountCheckedListBox";
            this.DiscountCheckedListBox.Size = new System.Drawing.Size(273, 154);
            this.DiscountCheckedListBox.TabIndex = 10;
            this.DiscountCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountCheckedListBox_SelectedIndexChanged);
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 20;
            this.CartListBox.Location = new System.Drawing.Point(7, 95);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(414, 184);
            this.CartListBox.TabIndex = 9;
            this.CartListBox.SelectedIndexChanged += new System.EventHandler(this.CartListBox_SelectedIndexChanged);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateOrderButton.Enabled = false;
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
            this.AmountIntLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountIntLabel.AutoSize = true;
            this.AmountIntLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountIntLabel.Location = new System.Drawing.Point(395, 311);
            this.AmountIntLabel.Name = "AmountIntLabel";
            this.AmountIntLabel.Size = new System.Drawing.Size(28, 32);
            this.AmountIntLabel.TabIndex = 5;
            this.AmountIntLabel.Text = "0";
            this.AmountIntLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(415, 291);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(71, 20);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Amount:";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
