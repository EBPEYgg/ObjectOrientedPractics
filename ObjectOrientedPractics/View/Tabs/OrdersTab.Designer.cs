namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.OrdersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedOrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.AmountIntLabel = new System.Windows.Forms.Label();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.PriorityOptionsPanel = new System.Windows.Forms.Panel();
            this.OrdersTableLayoutPanel.SuspendLayout();
            this.OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SelectedOrdersGroupBox.SuspendLayout();
            this.PriorityOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersTableLayoutPanel
            // 
            this.OrdersTableLayoutPanel.ColumnCount = 2;
            this.OrdersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrdersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrdersTableLayoutPanel.Controls.Add(this.OrdersGroupBox, 0, 0);
            this.OrdersTableLayoutPanel.Controls.Add(this.SelectedOrdersGroupBox, 1, 0);
            this.OrdersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.OrdersTableLayoutPanel.Name = "OrdersTableLayoutPanel";
            this.OrdersTableLayoutPanel.RowCount = 1;
            this.OrdersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrdersTableLayoutPanel.Size = new System.Drawing.Size(761, 445);
            this.OrdersTableLayoutPanel.TabIndex = 0;
            // 
            // OrdersGroupBox
            // 
            this.OrdersGroupBox.Controls.Add(this.OrdersDataGridView);
            this.OrdersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.OrdersGroupBox.Name = "OrdersGroupBox";
            this.OrdersGroupBox.Size = new System.Drawing.Size(374, 439);
            this.OrdersGroupBox.TabIndex = 0;
            this.OrdersGroupBox.TabStop = false;
            this.OrdersGroupBox.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AllowUserToResizeColumns = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            this.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 19);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.RowHeadersWidth = 51;
            this.OrdersDataGridView.RowTemplate.Height = 25;
            this.OrdersDataGridView.Size = new System.Drawing.Size(368, 417);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrdersDataGridView_MouseClick);
            // 
            // SelectedOrdersGroupBox
            // 
            this.SelectedOrdersGroupBox.Controls.Add(this.PriorityOptionsPanel);
            this.SelectedOrdersGroupBox.Controls.Add(this.SelectedOrderLabel);
            this.SelectedOrdersGroupBox.Controls.Add(this.AddressControl);
            this.SelectedOrdersGroupBox.Controls.Add(this.AmountIntLabel);
            this.SelectedOrdersGroupBox.Controls.Add(this.AmountLabel);
            this.SelectedOrdersGroupBox.Controls.Add(this.OrderItemsListBox);
            this.SelectedOrdersGroupBox.Controls.Add(this.OrderItemsLabel);
            this.SelectedOrdersGroupBox.Controls.Add(this.StatusComboBox);
            this.SelectedOrdersGroupBox.Controls.Add(this.StatusLabel);
            this.SelectedOrdersGroupBox.Controls.Add(this.CreatedLabel);
            this.SelectedOrdersGroupBox.Controls.Add(this.IdLabel);
            this.SelectedOrdersGroupBox.Controls.Add(this.CreatedTextBox);
            this.SelectedOrdersGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedOrdersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedOrdersGroupBox.Location = new System.Drawing.Point(383, 3);
            this.SelectedOrdersGroupBox.Name = "SelectedOrdersGroupBox";
            this.SelectedOrdersGroupBox.Size = new System.Drawing.Size(375, 439);
            this.SelectedOrdersGroupBox.TabIndex = 1;
            this.SelectedOrdersGroupBox.TabStop = false;
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedOrderLabel.Location = new System.Drawing.Point(6, 19);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(92, 15);
            this.SelectedOrderLabel.TabIndex = 14;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(85, 21);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(94, 23);
            this.DeliveryTimeComboBox.TabIndex = 12;
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(-3, 131);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(381, 145);
            this.AddressControl.TabIndex = 13;
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(0, 24);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(79, 15);
            this.DeliveryTimeLabel.TabIndex = 11;
            this.DeliveryTimeLabel.Text = "Delivery time:";
            // 
            // AmountIntLabel
            // 
            this.AmountIntLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountIntLabel.AutoSize = true;
            this.AmountIntLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountIntLabel.Location = new System.Drawing.Point(346, 408);
            this.AmountIntLabel.Name = "AmountIntLabel";
            this.AmountIntLabel.Size = new System.Drawing.Size(23, 25);
            this.AmountIntLabel.TabIndex = 12;
            this.AmountIntLabel.Text = "0";
            this.AmountIntLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(0, 0);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(94, 15);
            this.PriorityOptionsLabel.TabIndex = 10;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(314, 393);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(55, 15);
            this.AmountLabel.TabIndex = 11;
            this.AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 15;
            this.OrderItemsListBox.Location = new System.Drawing.Point(6, 296);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(363, 94);
            this.OrderItemsListBox.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderItemsLabel.Location = new System.Drawing.Point(17, 278);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(69, 15);
            this.OrderItemsLabel.TabIndex = 8;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Enabled = false;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(63, 101);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 23);
            this.StatusComboBox.TabIndex = 7;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(6, 104);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(42, 15);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(6, 72);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(51, 15);
            this.CreatedLabel.TabIndex = 5;
            this.CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 43);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "ID:";
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Enabled = false;
            this.CreatedTextBox.Location = new System.Drawing.Point(63, 69);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.Size = new System.Drawing.Size(121, 23);
            this.CreatedTextBox.TabIndex = 1;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(63, 40);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(121, 23);
            this.IdTextBox.TabIndex = 0;
            // 
            // PriorityOptionsPanel
            // 
            this.PriorityOptionsPanel.Controls.Add(this.PriorityOptionsLabel);
            this.PriorityOptionsPanel.Controls.Add(this.DeliveryTimeLabel);
            this.PriorityOptionsPanel.Controls.Add(this.DeliveryTimeComboBox);
            this.PriorityOptionsPanel.Location = new System.Drawing.Point(190, 19);
            this.PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            this.PriorityOptionsPanel.Size = new System.Drawing.Size(200, 100);
            this.PriorityOptionsPanel.TabIndex = 15;
            this.PriorityOptionsPanel.Visible = false;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrdersTableLayoutPanel);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(761, 445);
            this.OrdersTableLayoutPanel.ResumeLayout(false);
            this.OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.SelectedOrdersGroupBox.ResumeLayout(false);
            this.SelectedOrdersGroupBox.PerformLayout();
            this.PriorityOptionsPanel.ResumeLayout(false);
            this.PriorityOptionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel OrdersTableLayoutPanel;
        private GroupBox OrdersGroupBox;
        private GroupBox SelectedOrdersGroupBox;
        private DataGridView OrdersDataGridView;
        private ComboBox StatusComboBox;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IdLabel;
        private TextBox CreatedTextBox;
        private TextBox IdTextBox;
        private Label OrderItemsLabel;
        private ListBox OrderItemsListBox;
        private Label AmountIntLabel;
        private Label AmountLabel;
        private Controls.AddressControl AddressControl;
        private Label SelectedOrderLabel;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private Label PriorityOptionsLabel;
        private Panel PriorityOptionsPanel;
    }
}
