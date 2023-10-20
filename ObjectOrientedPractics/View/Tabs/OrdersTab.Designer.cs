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
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.AmountIntLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.OrdersTableLayoutPanel.SuspendLayout();
            this.OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SelectedOrdersGroupBox.SuspendLayout();
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
            this.OrdersTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdersTableLayoutPanel.Name = "OrdersTableLayoutPanel";
            this.OrdersTableLayoutPanel.RowCount = 1;
            this.OrdersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrdersTableLayoutPanel.Size = new System.Drawing.Size(870, 593);
            this.OrdersTableLayoutPanel.TabIndex = 0;
            // 
            // OrdersGroupBox
            // 
            this.OrdersGroupBox.Controls.Add(this.OrdersDataGridView);
            this.OrdersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersGroupBox.Location = new System.Drawing.Point(3, 4);
            this.OrdersGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdersGroupBox.Name = "OrdersGroupBox";
            this.OrdersGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdersGroupBox.Size = new System.Drawing.Size(429, 585);
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
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 24);
            this.OrdersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.RowHeadersWidth = 51;
            this.OrdersDataGridView.RowTemplate.Height = 25;
            this.OrdersDataGridView.Size = new System.Drawing.Size(423, 557);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrdersDataGridView_MouseClick);
            // 
            // SelectedOrdersGroupBox
            // 
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
            this.SelectedOrdersGroupBox.Location = new System.Drawing.Point(438, 4);
            this.SelectedOrdersGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedOrdersGroupBox.Name = "SelectedOrdersGroupBox";
            this.SelectedOrdersGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedOrdersGroupBox.Size = new System.Drawing.Size(429, 585);
            this.SelectedOrdersGroupBox.TabIndex = 1;
            this.SelectedOrdersGroupBox.TabStop = false;
            this.SelectedOrdersGroupBox.Text = "Selected Order";
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(-3, 165);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(435, 193);
            this.AddressControl.TabIndex = 13;
            // 
            // AmountIntLabel
            // 
            this.AmountIntLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountIntLabel.AutoSize = true;
            this.AmountIntLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountIntLabel.Location = new System.Drawing.Point(358, 536);
            this.AmountIntLabel.Name = "AmountIntLabel";
            this.AmountIntLabel.Size = new System.Drawing.Size(28, 32);
            this.AmountIntLabel.TabIndex = 12;
            this.AmountIntLabel.Text = "0";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(359, 516);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(71, 20);
            this.AmountLabel.TabIndex = 11;
            this.AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 20;
            this.OrderItemsListBox.Location = new System.Drawing.Point(7, 387);
            this.OrderItemsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(414, 124);
            this.OrderItemsListBox.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderItemsLabel.Location = new System.Drawing.Point(19, 363);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(87, 20);
            this.OrderItemsLabel.TabIndex = 8;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Enabled = false;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(85, 127);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(138, 28);
            this.StatusComboBox.TabIndex = 7;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(19, 131);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 20);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(19, 88);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(64, 20);
            this.CreatedLabel.TabIndex = 5;
            this.CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(19, 49);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "ID:";
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Enabled = false;
            this.CreatedTextBox.Location = new System.Drawing.Point(85, 84);
            this.CreatedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.Size = new System.Drawing.Size(138, 27);
            this.CreatedTextBox.TabIndex = 1;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(85, 45);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(138, 27);
            this.IdTextBox.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrdersTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(870, 593);
            this.OrdersTableLayoutPanel.ResumeLayout(false);
            this.OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.SelectedOrdersGroupBox.ResumeLayout(false);
            this.SelectedOrdersGroupBox.PerformLayout();
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
    }
}
