namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTabs
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
            ItemsTableLayoutPanel = new TableLayoutPanel();
            ItemsGroupBox = new GroupBox();
            SaveButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            ApplyButton = new Button();
            EditButton = new Button();
            DescriptionRichTextBox = new RichTextBox();
            DescriptionLabel = new Label();
            NameRichTextBox = new RichTextBox();
            NameLabel = new Label();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            CostLabel = new Label();
            IdLabel = new Label();
            ItemsTableLayoutPanel.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsTableLayoutPanel
            // 
            ItemsTableLayoutPanel.ColumnCount = 2;
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ItemsTableLayoutPanel.Controls.Add(ItemsGroupBox, 0, 0);
            ItemsTableLayoutPanel.Controls.Add(SelectedItemGroupBox, 1, 0);
            ItemsTableLayoutPanel.Dock = DockStyle.Fill;
            ItemsTableLayoutPanel.Location = new Point(0, 0);
            ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            ItemsTableLayoutPanel.RowCount = 1;
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemsTableLayoutPanel.Size = new Size(696, 445);
            ItemsTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(SaveButton);
            ItemsGroupBox.Controls.Add(DeleteButton);
            ItemsGroupBox.Controls.Add(AddButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Dock = DockStyle.Fill;
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(342, 439);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom;
            SaveButton.Location = new Point(230, 392);
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
            DeleteButton.Location = new Point(118, 392);
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
            AddButton.Location = new Point(6, 392);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(106, 41);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 22);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(330, 364);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Controls.Add(ApplyButton);
            SelectedItemGroupBox.Controls.Add(EditButton);
            SelectedItemGroupBox.Controls.Add(DescriptionRichTextBox);
            SelectedItemGroupBox.Controls.Add(DescriptionLabel);
            SelectedItemGroupBox.Controls.Add(NameRichTextBox);
            SelectedItemGroupBox.Controls.Add(NameLabel);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(IdTextBox);
            SelectedItemGroupBox.Controls.Add(CostLabel);
            SelectedItemGroupBox.Controls.Add(IdLabel);
            SelectedItemGroupBox.Dock = DockStyle.Fill;
            SelectedItemGroupBox.Location = new Point(351, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(342, 439);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected item";
            // 
            // ApplyButton
            // 
            ApplyButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApplyButton.Location = new Point(6, 392);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(330, 41);
            ApplyButton.TabIndex = 10;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Visible = false;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EditButton.Location = new Point(6, 345);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(330, 41);
            EditButton.TabIndex = 9;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionRichTextBox.Enabled = false;
            DescriptionRichTextBox.Location = new Point(6, 235);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(330, 96);
            DescriptionRichTextBox.TabIndex = 8;
            DescriptionRichTextBox.Text = "";
            DescriptionRichTextBox.TextChanged += DescriptionRichTextBox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(6, 217);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Description:";
            // 
            // NameRichTextBox
            // 
            NameRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameRichTextBox.Enabled = false;
            NameRichTextBox.Location = new Point(6, 118);
            NameRichTextBox.Name = "NameRichTextBox";
            NameRichTextBox.Size = new Size(330, 96);
            NameRichTextBox.TabIndex = 6;
            NameRichTextBox.Text = "";
            NameRichTextBox.TextChanged += NameRichTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 100);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name:";
            // 
            // CostTextBox
            // 
            CostTextBox.Enabled = false;
            CostTextBox.Location = new Point(48, 68);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(100, 23);
            CostTextBox.TabIndex = 3;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(48, 39);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 2;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(6, 71);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 1;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(6, 42);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // ItemsTabs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsTableLayoutPanel);
            Name = "ItemsTabs";
            Size = new Size(696, 445);
            ItemsTableLayoutPanel.ResumeLayout(false);
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ItemsTableLayoutPanel;
        private GroupBox ItemsGroupBox;
        private GroupBox SelectedItemGroupBox;
        private ListBox ItemsListBox;
        private Button DeleteButton;
        private Button AddButton;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label CostLabel;
        private Label IdLabel;
        private Label NameLabel;
        private RichTextBox DescriptionRichTextBox;
        private Label DescriptionLabel;
        private RichTextBox NameRichTextBox;
        private Button SaveButton;
        private Button ApplyButton;
        private Button EditButton;
    }
}
