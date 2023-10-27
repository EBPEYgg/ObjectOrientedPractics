namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            this.PriorityOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.AmountIntLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.PriorityOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PriorityOrderGroupBox
            // 
            this.PriorityOrderGroupBox.Controls.Add(this.AddressControl);
            this.PriorityOrderGroupBox.Controls.Add(this.ClearOrderButton);
            this.PriorityOrderGroupBox.Controls.Add(this.RemoveItemButton);
            this.PriorityOrderGroupBox.Controls.Add(this.AddItemButton);
            this.PriorityOrderGroupBox.Controls.Add(this.AmountIntLabel);
            this.PriorityOrderGroupBox.Controls.Add(this.AmountLabel);
            this.PriorityOrderGroupBox.Controls.Add(this.OrderItemsLabel);
            this.PriorityOrderGroupBox.Controls.Add(this.OrderItemsListBox);
            this.PriorityOrderGroupBox.Controls.Add(this.DeliveryTimeComboBox);
            this.PriorityOrderGroupBox.Controls.Add(this.StatusComboBox);
            this.PriorityOrderGroupBox.Controls.Add(this.CreatedTextBox);
            this.PriorityOrderGroupBox.Controls.Add(this.IdTextBox);
            this.PriorityOrderGroupBox.Controls.Add(this.DeliveryTimeLabel);
            this.PriorityOrderGroupBox.Controls.Add(this.StatusLabel);
            this.PriorityOrderGroupBox.Controls.Add(this.CreatedLabel);
            this.PriorityOrderGroupBox.Controls.Add(this.IdLabel);
            this.PriorityOrderGroupBox.Controls.Add(this.PriorityOptionsLabel);
            this.PriorityOrderGroupBox.Controls.Add(this.SelectedOrderLabel);
            this.PriorityOrderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityOrderGroupBox.Location = new System.Drawing.Point(0, 0);
            this.PriorityOrderGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriorityOrderGroupBox.Name = "PriorityOrderGroupBox";
            this.PriorityOrderGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriorityOrderGroupBox.Size = new System.Drawing.Size(870, 593);
            this.PriorityOrderGroupBox.TabIndex = 0;
            this.PriorityOrderGroupBox.TabStop = false;
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Location = new System.Drawing.Point(437, 267);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(435, 193);
            this.AddressControl.TabIndex = 18;
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearOrderButton.Enabled = false;
            this.ClearOrderButton.Location = new System.Drawing.Point(288, 532);
            this.ClearOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(134, 53);
            this.ClearOrderButton.TabIndex = 17;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemButton.Enabled = false;
            this.RemoveItemButton.Location = new System.Drawing.Point(147, 532);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(134, 53);
            this.RemoveItemButton.TabIndex = 16;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemButton.Location = new System.Drawing.Point(7, 532);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(134, 53);
            this.AddItemButton.TabIndex = 15;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // AmountIntLabel
            // 
            this.AmountIntLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountIntLabel.AutoSize = true;
            this.AmountIntLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountIntLabel.Location = new System.Drawing.Point(400, 487);
            this.AmountIntLabel.Name = "AmountIntLabel";
            this.AmountIntLabel.Size = new System.Drawing.Size(24, 28);
            this.AmountIntLabel.TabIndex = 13;
            this.AmountIntLabel.Text = "0";
            this.AmountIntLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(335, 459);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(93, 28);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount:";
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderItemsLabel.Location = new System.Drawing.Point(7, 25);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(93, 20);
            this.OrderItemsLabel.TabIndex = 11;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 20;
            this.OrderItemsListBox.Location = new System.Drawing.Point(7, 49);
            this.OrderItemsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(413, 404);
            this.OrderItemsListBox.TabIndex = 10;
            this.OrderItemsListBox.SelectedIndexChanged += new System.EventHandler(this.OrderItemsListBox_SelectedIndexChanged);
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliveryTimeComboBox.Enabled = false;
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(544, 215);
            this.DeliveryTimeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(138, 28);
            this.DeliveryTimeComboBox.TabIndex = 9;
            this.DeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.Enabled = false;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(544, 132);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(138, 28);
            this.StatusComboBox.TabIndex = 8;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Enabled = false;
            this.CreatedTextBox.Location = new System.Drawing.Point(544, 93);
            this.CreatedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.Size = new System.Drawing.Size(138, 27);
            this.CreatedTextBox.TabIndex = 7;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(544, 55);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(138, 27);
            this.IdTextBox.TabIndex = 6;
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(447, 219);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(100, 20);
            this.DeliveryTimeLabel.TabIndex = 5;
            this.DeliveryTimeLabel.Text = "Delivery time:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(447, 136);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 20);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(447, 97);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(64, 20);
            this.CreatedLabel.TabIndex = 2;
            this.CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(447, 59);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID:";
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(447, 185);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(120, 20);
            this.PriorityOptionsLabel.TabIndex = 4;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedOrderLabel.Location = new System.Drawing.Point(447, 25);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(111, 20);
            this.SelectedOrderLabel.TabIndex = 0;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriorityOrderGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(870, 593);
            this.PriorityOrderGroupBox.ResumeLayout(false);
            this.PriorityOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox PriorityOrderGroupBox;
        private Label DeliveryTimeLabel;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IdLabel;
        private Label PriorityOptionsLabel;
        private Label SelectedOrderLabel;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private TextBox IdTextBox;
        private ComboBox DeliveryTimeComboBox;
        private Label OrderItemsLabel;
        private ListBox OrderItemsListBox;
        private Label AmountLabel;
        private Label AmountIntLabel;
        private Button ClearOrderButton;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private Controls.AddressControl AddressControl;
    }
}
