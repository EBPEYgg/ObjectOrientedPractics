namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTabs
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
            this.components = new System.ComponentModel.Container();
            this.CustomersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SelectedItemGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.DiscountCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ErrorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CustomersTableLayoutPanel.SuspendLayout();
            this.CustomersGroupBox.SuspendLayout();
            this.SelectedItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersTableLayoutPanel
            // 
            this.CustomersTableLayoutPanel.ColumnCount = 2;
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersGroupBox, 0, 0);
            this.CustomersTableLayoutPanel.Controls.Add(this.SelectedItemGroupBox, 1, 0);
            this.CustomersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            this.CustomersTableLayoutPanel.RowCount = 1;
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomersTableLayoutPanel.Size = new System.Drawing.Size(761, 445);
            this.CustomersTableLayoutPanel.TabIndex = 0;
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGroupBox.Controls.Add(this.SaveButton);
            this.CustomersGroupBox.Controls.Add(this.DeleteButton);
            this.CustomersGroupBox.Controls.Add(this.AddButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(374, 439);
            this.CustomersGroupBox.TabIndex = 0;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(247, 392);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(106, 41);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(135, 392);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(106, 41);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddButton.Location = new System.Drawing.Point(23, 392);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 41);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 15;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 22);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(363, 364);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // SelectedItemGroupBox
            // 
            this.SelectedItemGroupBox.Controls.Add(this.RemoveDiscountButton);
            this.SelectedItemGroupBox.Controls.Add(this.AddDiscountButton);
            this.SelectedItemGroupBox.Controls.Add(this.DiscountCheckedListBox);
            this.SelectedItemGroupBox.Controls.Add(this.IsPriorityCheckBox);
            this.SelectedItemGroupBox.Controls.Add(this.AddressControl);
            this.SelectedItemGroupBox.Controls.Add(this.ApplyButton);
            this.SelectedItemGroupBox.Controls.Add(this.EditButton);
            this.SelectedItemGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedItemGroupBox.Controls.Add(this.IdLabel);
            this.SelectedItemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemGroupBox.Location = new System.Drawing.Point(383, 3);
            this.SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            this.SelectedItemGroupBox.Size = new System.Drawing.Size(375, 439);
            this.SelectedItemGroupBox.TabIndex = 1;
            this.SelectedItemGroupBox.TabStop = false;
            this.SelectedItemGroupBox.Text = "Selected customer";
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(210, 393);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(86, 33);
            this.RemoveDiscountButton.TabIndex = 26;
            this.RemoveDiscountButton.Text = "Remove";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(210, 354);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(86, 33);
            this.AddDiscountButton.TabIndex = 25;
            this.AddDiscountButton.Text = "Add";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // DiscountCheckedListBox
            // 
            this.DiscountCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountCheckedListBox.BackColor = System.Drawing.SystemColors.Window;
            this.DiscountCheckedListBox.FormattingEnabled = true;
            this.DiscountCheckedListBox.Location = new System.Drawing.Point(16, 354);
            this.DiscountCheckedListBox.Name = "DiscountCheckedListBox";
            this.DiscountCheckedListBox.Size = new System.Drawing.Size(188, 76);
            this.DiscountCheckedListBox.TabIndex = 24;
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Enabled = false;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(79, 82);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(75, 19);
            this.IsPriorityCheckBox.TabIndex = 23;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Location = new System.Drawing.Point(-3, 108);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(381, 145);
            this.AddressControl.TabIndex = 22;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(6, 307);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(363, 41);
            this.ApplyButton.TabIndex = 20;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Visible = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(6, 260);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(363, 41);
            this.EditButton.TabIndex = 19;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Enabled = false;
            this.FullNameTextBox.Location = new System.Drawing.Point(79, 53);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(93, 23);
            this.FullNameTextBox.TabIndex = 14;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(79, 24);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(93, 23);
            this.IdTextBox.TabIndex = 13;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(6, 56);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FullNameLabel.TabIndex = 12;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 27);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "ID:";
            // 
            // CustomerTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomersTableLayoutPanel);
            this.Name = "CustomerTabs";
            this.Size = new System.Drawing.Size(761, 445);
            this.CustomersTableLayoutPanel.ResumeLayout(false);
            this.CustomersGroupBox.ResumeLayout(false);
            this.SelectedItemGroupBox.ResumeLayout(false);
            this.SelectedItemGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel CustomersTableLayoutPanel;
        private GroupBox CustomersGroupBox;
        private GroupBox SelectedItemGroupBox;
        private ListBox CustomersListBox;
        private Button SaveButton;
        private Button DeleteButton;
        private Button AddButton;
        private Button ApplyButton;
        private Button EditButton;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private Label FullNameLabel;
        private Label IdLabel;
        private Controls.AddressControl AddressControl;
        private ToolTip ErrorToolTip;
        private CheckBox IsPriorityCheckBox;
        private CheckedListBox DiscountCheckedListBox;
        private Button RemoveDiscountButton;
        private Button AddDiscountButton;
    }
}
