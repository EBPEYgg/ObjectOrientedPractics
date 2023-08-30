using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий CustomerGroupBox.
    /// </summary>
    public partial class CustomerTabs : UserControl
    {
        /// <summary>
        /// Список с данными о покупателях.
        /// </summary>
        private List<Customer> _customersList = new List<Customer>();

        /// <summary>
        /// Список с данными текущего выбранного покупателя.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Копия текущего выбранного покупателя.
        /// </summary>
        private Customer _cloneCurrentCustomer = new();

        /// <summary>
        /// Индекс текущего выбранного элемента перед сортировкой 
        /// для сохранения выбранного элемента в CustomersListBox.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// Индекс текущего выбранного элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Название файла для сохранения или загрузки данных.
        /// </summary>
        private string _fileName = "Customers.json";

        AddressControl AddressControl;

        public CustomerTabs()
        {
            InitializeComponent();
            LoadCustomersInfo();
            ClearCustomersInfo();
            CustomersListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Метод, который сохраняет данные всех покупателей в json файл (Customers.json).
        /// </summary>
        public void SaveCustomer()
        {
            if (CustomersListBox.Items.Count != 0)
            {
                var jsonString = System.Text.Json.JsonSerializer.Serialize(_customersList);
                File.WriteAllText("Customers.json", jsonString);
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(FullNameTextBox.Text))
                {
                    if (Validator.CheckStringContainsOnlyEnglishLetters(FullNameTextBox.Text))
                    {
                        _cloneCurrentCustomer.Fullname = FullNameTextBox.Text;
                        FullNameTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        FullNameTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                FullNameTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearCustomersInfo();
            CustomersListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ToggleInputBoxes(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer = _customersList[CustomersListBox.SelectedIndex];
            _customersList.Remove(_currentCustomer);
            CustomersListBox.SelectedIndex = -1;
            SaveCustomer();
            Sort();
            ClearCustomersInfo();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = CustomersListBox.SelectedIndex;
            _cloneCurrentCustomer = (Customer)_customersList[_selectedIndex].Clone();
            ToggleInputBoxes(true);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка ввода");
                return;
            }

            if (_selectedIndex == -1)
            {
                _currentCustomer = new Customer(FullNameTextBox.Text.Trim(),
                    AddressControl.Address.Index, AddressControl.Address.Country,
                    AddressControl.Address.City, AddressControl.Address.Street,
                    AddressControl.Address.Building, AddressControl.Address.Apartment);
                _customersList.Add(_currentCustomer);
                Sort();
                SaveCustomer();
                ToggleInputBoxes(false);
                ClearCustomersInfo();
                return;
            }

            _customersList[_selectedIndex] = _cloneCurrentCustomer;
            _currentCustomer = _cloneCurrentCustomer;
            Sort();
            SaveCustomer();
            ToggleInputBoxes(false);
            UpdateCustomerInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _cloneCurrentCustomer = (Customer)_customersList[CustomersListBox.SelectedIndex].Clone();
                IdTextBox.Text = _cloneCurrentCustomer.Id.ToString();
                FullNameTextBox.Text = _cloneCurrentCustomer.Fullname.ToString();
                //AddressRichTextBox.Text = _cloneCurrentCustomer.Address.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }

        /// <summary>
        /// Метод, который построчно считывает текстовый файл 
        /// для заполнения <see cref="CustomersListBox"/> и <see cref="_customersList"/>.
        /// </summary>
        private void LoadCustomersInfo()
        {
            if (File.Exists(_fileName))
            {
                _customersList = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(_fileName));
                Sort();
            }
        }

        /// <summary>
        /// Метод, который очищает текстовые поля.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            //PostIndexTextBox.Clear();
        }

        /// <summary>
        /// Метод, который сортирует <see cref="_customersList"/> и <see cref="CustomersListBox"/>
        /// в алфавитном порядке.
        /// </summary>
        private void Sort()
        {
            _indexBeforeSort = CustomersListBox.SelectedIndex;
            CustomersListBox.SelectedIndexChanged -= CustomersListBox_SelectedIndexChanged;
            _customersList = _customersList.OrderBy(customer => customer.ToString()).ToList();
            CustomersListBox.DataSource = _customersList;
            CustomersListBox.SelectedIndex = _indexBeforeSort;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Метод, который включает или отключает все TextBox и ApplyButton.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            FullNameTextBox.Enabled = value;
            //PostIndexTextBox.Enabled = value;
            ApplyButton.Visible = value;
        }

        /// <summary>
        /// Метод, который обновляет данные текущего выбранного покупателя в TextBox.
        /// </summary>
        private void UpdateCustomerInfo()
        {
            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            //PostIndexTextBox.Text = _currentAddress.Index.ToString();
        }
    }
}