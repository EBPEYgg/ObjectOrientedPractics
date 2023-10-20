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
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountIntLabel = new System.Windows.Forms.Label();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.PriorityOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PriorityOrderGroupBox
            // 
            this.PriorityOrderGroupBox.Controls.Add(this.ClearOrderButton);
            this.PriorityOrderGroupBox.Controls.Add(this.RemoveItemButton);
            this.PriorityOrderGroupBox.Controls.Add(this.AddItemButton);
            this.PriorityOrderGroupBox.Controls.Add(this.AddressControl);
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
            this.PriorityOrderGroupBox.Name = "PriorityOrderGroupBox";
            this.PriorityOrderGroupBox.Size = new System.Drawing.Size(761, 445);
            this.PriorityOrderGroupBox.TabIndex = 0;
            this.PriorityOrderGroupBox.TabStop = false;
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedOrderLabel.Location = new System.Drawing.Point(391, 19);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(92, 15);
            this.SelectedOrderLabel.TabIndex = 0;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(391, 134);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(94, 15);
            this.PriorityOptionsLabel.TabIndex = 4;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(391, 44);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(391, 73);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(51, 15);
            this.CreatedLabel.TabIndex = 2;
            this.CreatedLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(391, 102);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(42, 15);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status:";
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(391, 159);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(79, 15);
            this.DeliveryTimeLabel.TabIndex = 5;
            this.DeliveryTimeLabel.Text = "Delivery time:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(476, 41);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(121, 23);
            this.IdTextBox.TabIndex = 6;
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Enabled = false;
            this.CreatedTextBox.Location = new System.Drawing.Point(476, 70);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.Size = new System.Drawing.Size(121, 23);
            this.CreatedTextBox.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(476, 99);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 23);
            this.StatusComboBox.TabIndex = 8;
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(476, 156);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(121, 23);
            this.DeliveryTimeComboBox.TabIndex = 9;
            this.DeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 15;
            this.OrderItemsListBox.Location = new System.Drawing.Point(6, 37);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(362, 289);
            this.OrderItemsListBox.TabIndex = 10;
            this.OrderItemsListBox.SelectedIndexChanged += new System.EventHandler(this.OrderItemsListBox_SelectedIndexChanged);
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderItemsLabel.Location = new System.Drawing.Point(6, 19);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(75, 15);
            this.OrderItemsLabel.TabIndex = 11;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(292, 329);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(76, 21);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountIntLabel
            // 
            this.AmountIntLabel.AutoSize = true;
            this.AmountIntLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountIntLabel.Location = new System.Drawing.Point(349, 350);
            this.AmountIntLabel.Name = "AmountIntLabel";
            this.AmountIntLabel.Size = new System.Drawing.Size(19, 21);
            this.AmountIntLabel.TabIndex = 13;
            this.AmountIntLabel.Text = "0";
            this.AmountIntLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(382, 186);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(381, 145);
            this.AddressControl.TabIndex = 14;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(6, 386);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(117, 40);
            this.AddItemButton.TabIndex = 15;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(129, 386);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(117, 40);
            this.RemoveItemButton.TabIndex = 16;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Location = new System.Drawing.Point(252, 386);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(117, 40);
            this.ClearOrderButton.TabIndex = 17;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriorityOrderGroupBox);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(761, 445);
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
        private Controls.AddressControl AddressControl;
        private Button ClearOrderButton;
        private Button RemoveItemButton;
        private Button AddItemButton;
    }
}
