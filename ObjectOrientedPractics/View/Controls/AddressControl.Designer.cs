namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            AddressTableLayoutPanel = new TableLayoutPanel();
            AddressGroupBox = new GroupBox();
            ApartmentLabel = new Label();
            CityLabel = new Label();
            BuildingLabel = new Label();
            StreetLabel = new Label();
            CountryLabel = new Label();
            PostIndexLabel = new Label();
            ApartmentTextBox = new TextBox();
            CityTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CountryTextBox = new TextBox();
            PostIndexTextBox = new TextBox();
            ErrorToolTip = new ToolTip(components);
            AddressTableLayoutPanel.SuspendLayout();
            AddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddressTableLayoutPanel
            // 
            AddressTableLayoutPanel.ColumnCount = 1;
            AddressTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AddressTableLayoutPanel.Controls.Add(AddressGroupBox, 0, 0);
            AddressTableLayoutPanel.Dock = DockStyle.Fill;
            AddressTableLayoutPanel.Location = new Point(0, 0);
            AddressTableLayoutPanel.Name = "AddressTableLayoutPanel";
            AddressTableLayoutPanel.RowCount = 1;
            AddressTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AddressTableLayoutPanel.Size = new Size(381, 145);
            AddressTableLayoutPanel.TabIndex = 0;
            // 
            // AddressGroupBox
            // 
            AddressGroupBox.Controls.Add(ApartmentLabel);
            AddressGroupBox.Controls.Add(CityLabel);
            AddressGroupBox.Controls.Add(BuildingLabel);
            AddressGroupBox.Controls.Add(StreetLabel);
            AddressGroupBox.Controls.Add(CountryLabel);
            AddressGroupBox.Controls.Add(PostIndexLabel);
            AddressGroupBox.Controls.Add(ApartmentTextBox);
            AddressGroupBox.Controls.Add(CityTextBox);
            AddressGroupBox.Controls.Add(BuildingTextBox);
            AddressGroupBox.Controls.Add(StreetTextBox);
            AddressGroupBox.Controls.Add(CountryTextBox);
            AddressGroupBox.Controls.Add(PostIndexTextBox);
            AddressGroupBox.Dock = DockStyle.Fill;
            AddressGroupBox.Location = new Point(3, 3);
            AddressGroupBox.Name = "AddressGroupBox";
            AddressGroupBox.Size = new Size(375, 139);
            AddressGroupBox.TabIndex = 0;
            AddressGroupBox.TabStop = false;
            AddressGroupBox.Text = "Delivery Address";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(191, 112);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(67, 15);
            ApartmentLabel.TabIndex = 11;
            ApartmentLabel.Text = "Apartment:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(227, 54);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 10;
            CityLabel.Text = "City:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(6, 112);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(54, 15);
            BuildingLabel.TabIndex = 9;
            BuildingLabel.Text = "Building:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(6, 83);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(40, 15);
            StreetLabel.TabIndex = 8;
            StreetLabel.Text = "Street:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(6, 54);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 7;
            CountryLabel.Text = "Country:";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(6, 25);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(65, 15);
            PostIndexLabel.TabIndex = 6;
            PostIndexLabel.Text = "Post Index:";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(264, 109);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(93, 23);
            ApartmentTextBox.TabIndex = 5;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(264, 51);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(93, 23);
            CityTextBox.TabIndex = 4;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(77, 109);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(93, 23);
            BuildingTextBox.TabIndex = 3;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(77, 80);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(280, 23);
            StreetTextBox.TabIndex = 2;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(77, 51);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(93, 23);
            CountryTextBox.TabIndex = 1;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(77, 22);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(93, 23);
            PostIndexTextBox.TabIndex = 0;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressTableLayoutPanel);
            Name = "AddressControl";
            Size = new Size(381, 145);
            AddressTableLayoutPanel.ResumeLayout(false);
            AddressGroupBox.ResumeLayout(false);
            AddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel AddressTableLayoutPanel;
        private GroupBox AddressGroupBox;
        private Label ApartmentLabel;
        private Label CityLabel;
        private Label BuildingLabel;
        private Label StreetLabel;
        private Label CountryLabel;
        private Label PostIndexLabel;
        private TextBox ApartmentTextBox;
        private TextBox CityTextBox;
        private TextBox BuildingTextBox;
        private TextBox StreetTextBox;
        private TextBox CountryTextBox;
        private TextBox PostIndexTextBox;
        private ToolTip ErrorToolTip;
    }
}
