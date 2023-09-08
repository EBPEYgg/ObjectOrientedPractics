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
            components = new System.ComponentModel.Container();
            CustomersTableLayoutPanel = new TableLayoutPanel();
            CustomersGroupBox = new GroupBox();
            SaveButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            MyAddressControl = new Controls.AddressControl();
            panel1 = new Panel();
            ApplyButton = new Button();
            EditButton = new Button();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            FullNameLabel = new Label();
            IdLabel = new Label();
            ErrorToolTip = new ToolTip(components);
            CustomersTableLayoutPanel.SuspendLayout();
            CustomersGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersTableLayoutPanel
            // 
            CustomersTableLayoutPanel.ColumnCount = 2;
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CustomersTableLayoutPanel.Controls.Add(CustomersGroupBox, 0, 0);
            CustomersTableLayoutPanel.Controls.Add(SelectedItemGroupBox, 1, 0);
            CustomersTableLayoutPanel.Dock = DockStyle.Fill;
            CustomersTableLayoutPanel.Location = new Point(0, 0);
            CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            CustomersTableLayoutPanel.RowCount = 1;
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CustomersTableLayoutPanel.Size = new Size(761, 445);
            CustomersTableLayoutPanel.TabIndex = 0;
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(SaveButton);
            CustomersGroupBox.Controls.Add(DeleteButton);
            CustomersGroupBox.Controls.Add(AddButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Dock = DockStyle.Fill;
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(374, 439);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom;
            SaveButton.Location = new Point(246, 392);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(106, 41);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom;
            DeleteButton.Location = new Point(134, 392);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(106, 41);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom;
            AddButton.Location = new Point(22, 392);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(106, 41);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(362, 364);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Controls.Add(MyAddressControl);
            SelectedItemGroupBox.Controls.Add(panel1);
            SelectedItemGroupBox.Controls.Add(ApplyButton);
            SelectedItemGroupBox.Controls.Add(EditButton);
            SelectedItemGroupBox.Controls.Add(FullNameTextBox);
            SelectedItemGroupBox.Controls.Add(IdTextBox);
            SelectedItemGroupBox.Controls.Add(FullNameLabel);
            SelectedItemGroupBox.Controls.Add(IdLabel);
            SelectedItemGroupBox.Dock = DockStyle.Fill;
            SelectedItemGroupBox.Location = new Point(383, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(375, 439);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected customer";
            // 
            // MyAddressControl
            // 
            MyAddressControl.Address = null;
            MyAddressControl.Location = new Point(-3, 97);
            MyAddressControl.Name = "MyAddressControl";
            MyAddressControl.Size = new Size(381, 145);
            MyAddressControl.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Location = new Point(6, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 91);
            panel1.TabIndex = 21;
            // 
            // ApplyButton
            // 
            ApplyButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApplyButton.Location = new Point(6, 295);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(363, 41);
            ApplyButton.TabIndex = 20;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Visible = false;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EditButton.Location = new Point(6, 248);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(363, 41);
            EditButton.TabIndex = 19;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Enabled = false;
            FullNameTextBox.Location = new Point(79, 68);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(93, 23);
            FullNameTextBox.TabIndex = 14;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(79, 39);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(93, 23);
            IdTextBox.TabIndex = 13;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(6, 71);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 12;
            FullNameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(6, 42);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 11;
            IdLabel.Text = "ID:";
            // 
            // CustomerTabs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersTableLayoutPanel);
            Name = "CustomerTabs";
            Size = new Size(761, 445);
            CustomersTableLayoutPanel.ResumeLayout(false);
            CustomersGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Controls.AddressControl MyAddressControl;
        private ToolTip ErrorToolTip;
    }
}
