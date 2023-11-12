using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Forms;

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
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customersList;
            set => _customersList = value;
        }

        /// <summary>
        /// Возвращает количество элементов в <see cref="CustomersListBox"/>.
        /// </summary>
        public int ListBoxCustomersCount
        {
            get => CustomersListBox.Items.Count;
        }

        public CustomerTabs()
        {
            InitializeComponent();
            ClearCustomersInfo();
            CustomersListBox.SelectedIndex = -1;
            AddressControl.Address = _currentCustomer.Address;
            ClearCustomersInfo();
        }

        /// <summary>
        /// Метод, который сортирует <see cref="_customersList"/> и <see cref="CustomersListBox"/>
        /// в алфавитном порядке.
        /// </summary>
        public void Sort()
        {
            if (_customersList != null)
            {
                _indexBeforeSort = CustomersListBox.SelectedIndex;
                CustomersListBox.SelectedIndexChanged -= CustomersListBox_SelectedIndexChanged;
                _customersList = _customersList.OrderBy(customer => customer.ToString()).ToList();
                CustomersListBox.DataSource = _customersList;
                CustomersListBox.SelectedIndex = _indexBeforeSort;
                CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
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

            // создание списка покупателей, если listbox пустой
            if (CustomersListBox.Items.Count == 0)
            {
                _customersList = new();
            }

            // создание нового объекта
            if (_selectedIndex == -1)
            {
                _currentCustomer = new Customer(FullNameTextBox.Text.Trim(),
                    AddressControl.Address.Index, AddressControl.Address.Country,
                    AddressControl.Address.City, AddressControl.Address.Street,
                    AddressControl.Address.Building, AddressControl.Address.Apartment, 
                    IsPriorityCheckBox.Checked);
                _currentCustomer.Order.Address = AddressControl.Address;
                _currentCustomer.Order.IsPriority = IsPriorityCheckBox.Checked;
                _customersList.Add(_currentCustomer);
                Customers = _customersList;
                DiscountCheckedListBox.DataSource = _currentCustomer.Discounts;
                Sort();
                ToggleInputBoxes(false);
                ClearCustomersInfo();
                return;
            }

            // редактирование объекта
            _customersList[_selectedIndex] = _cloneCurrentCustomer;
            _currentCustomer = _cloneCurrentCustomer;
            Sort();
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
                AddressControl.Address = _cloneCurrentCustomer.Address; 
                IsPriorityCheckBox.Checked = _cloneCurrentCustomer.IsPriority;
                DiscountCheckedListBox.DataSource = _cloneCurrentCustomer.Discounts;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // now saving data when switching tabs
            //SaveCustomer();
        }

        /// <summary>
        /// Метод, который очищает текстовые поля.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AddressControl.ClearAddressInfo();
            IsPriorityCheckBox.Checked = false;
        }

        /// <summary>
        /// Метод, который включает или отключает все TextBox и ApplyButton.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            FullNameTextBox.Enabled = value;
            ApplyButton.Visible = value;
            AddressControl.ToggleInputAddressBoxes(value);
            IsPriorityCheckBox.Enabled = value;
        }

        /// <summary>
        /// Метод, который обновляет данные текущего выбранного покупателя в TextBox.
        /// </summary>
        private void UpdateCustomerInfo()
        {
            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressControl.Address = _currentCustomer.Address;
            IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
            _currentCustomer.Order.IsPriority = _currentCustomer.IsPriority;
            _currentCustomer.Order.Address = AddressControl.Address;
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                AddDiscountForm addDiscountForm = new();
                addDiscountForm.SelectedIndex = CustomersListBox.SelectedIndex;
                addDiscountForm.Customers = Customers;
                addDiscountForm.Show();
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountCheckedListBox.SelectedIndex > 0 && CustomersListBox.SelectedIndex != -1)
            {
                Customers[CustomersListBox.SelectedIndex].Discounts.RemoveAt
                    (DiscountCheckedListBox.SelectedIndex);
            }
        }
    }
}