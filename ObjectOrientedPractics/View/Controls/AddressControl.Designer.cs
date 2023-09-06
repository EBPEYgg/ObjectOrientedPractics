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
            this.components = new System.ComponentModel.Container();
            this.AddressTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.ErrorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddressTableLayoutPanel.SuspendLayout();
            this.AddressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressTableLayoutPanel
            // 
            this.AddressTableLayoutPanel.ColumnCount = 1;
            this.AddressTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddressTableLayoutPanel.Controls.Add(this.AddressGroupBox, 0, 0);
            this.AddressTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AddressTableLayoutPanel.Name = "AddressTableLayoutPanel";
            this.AddressTableLayoutPanel.RowCount = 1;
            this.AddressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddressTableLayoutPanel.Size = new System.Drawing.Size(381, 145);
            this.AddressTableLayoutPanel.TabIndex = 0;
            // 
            // AddressGroupBox
            // 
            this.AddressGroupBox.Controls.Add(this.ApartmentLabel);
            this.AddressGroupBox.Controls.Add(this.CityLabel);
            this.AddressGroupBox.Controls.Add(this.BuildingLabel);
            this.AddressGroupBox.Controls.Add(this.StreetLabel);
            this.AddressGroupBox.Controls.Add(this.CountryLabel);
            this.AddressGroupBox.Controls.Add(this.PostIndexLabel);
            this.AddressGroupBox.Controls.Add(this.ApartmentTextBox);
            this.AddressGroupBox.Controls.Add(this.CityTextBox);
            this.AddressGroupBox.Controls.Add(this.BuildingTextBox);
            this.AddressGroupBox.Controls.Add(this.StreetTextBox);
            this.AddressGroupBox.Controls.Add(this.CountryTextBox);
            this.AddressGroupBox.Controls.Add(this.PostIndexTextBox);
            this.AddressGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressGroupBox.Location = new System.Drawing.Point(3, 3);
            this.AddressGroupBox.Name = "AddressGroupBox";
            this.AddressGroupBox.Size = new System.Drawing.Size(375, 139);
            this.AddressGroupBox.TabIndex = 0;
            this.AddressGroupBox.TabStop = false;
            this.AddressGroupBox.Text = "Delivery Address";
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Location = new System.Drawing.Point(191, 112);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(67, 15);
            this.ApartmentLabel.TabIndex = 11;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(227, 54);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(31, 15);
            this.CityLabel.TabIndex = 10;
            this.CityLabel.Text = "City:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(6, 112);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(54, 15);
            this.BuildingLabel.TabIndex = 9;
            this.BuildingLabel.Text = "Building:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(6, 83);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(40, 15);
            this.StreetLabel.TabIndex = 8;
            this.StreetLabel.Text = "Street:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(6, 54);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(53, 15);
            this.CountryLabel.TabIndex = 7;
            this.CountryLabel.Text = "Country:";
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Location = new System.Drawing.Point(6, 25);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(65, 15);
            this.PostIndexLabel.TabIndex = 6;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.AccessibleDescription = "Неправильно задан номер квартиры.";
            this.ApartmentTextBox.Location = new System.Drawing.Point(264, 109);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(93, 23);
            this.ApartmentTextBox.TabIndex = 5;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.AccessibleDescription = "Неправильно задан город.";
            this.CityTextBox.Location = new System.Drawing.Point(264, 51);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(93, 23);
            this.CityTextBox.TabIndex = 4;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.AccessibleDescription = "Неправильно задан номер дома.";
            this.BuildingTextBox.Location = new System.Drawing.Point(77, 109);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(93, 23);
            this.BuildingTextBox.TabIndex = 3;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.AccessibleDescription = "Неправильно задана улица.";
            this.StreetTextBox.Location = new System.Drawing.Point(77, 80);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(280, 23);
            this.StreetTextBox.TabIndex = 2;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.AccessibleDescription = "Неправильно задана страна.";
            this.CountryTextBox.Location = new System.Drawing.Point(77, 51);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(93, 23);
            this.CountryTextBox.TabIndex = 1;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.AccessibleDescription = "Неправильно задан почтовый индекс.";
            this.PostIndexTextBox.Location = new System.Drawing.Point(77, 22);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(93, 23);
            this.PostIndexTextBox.TabIndex = 0;
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressTableLayoutPanel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(381, 145);
            this.AddressTableLayoutPanel.ResumeLayout(false);
            this.AddressGroupBox.ResumeLayout(false);
            this.AddressGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
