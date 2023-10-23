using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _itemsList = new();

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem = new();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customersList = new();

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer = new();

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customersList;
            set
            {
                if (value != null)
                {
                    _customersList = value;
                    _customersList = _customersList.OrderBy(customer => customer.ToString()).ToList();
                    CustomerComboBox.DataSource = _customersList;
                    CustomerComboBox.SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _itemsList;
            set
            {
                if (_itemsList != null)
                {
                    _itemsList = value;
                    _itemsList = _itemsList.OrderBy(item => item.ToString()).ToList();
                    ItemsListBox.DataSource = _itemsList;
                    ItemsListBox.SelectedIndex = -1;
                }
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, который обновляет данные на вкладке при переключении вкладок.
        /// </summary>
        public void RefreshData()
        {
            _itemsList = _itemsList.OrderBy(item => item.ToString()).ToList();
            ItemsListBox.DataSource = _itemsList;
            ItemsListBox.SelectedIndex = -1;
            _customersList = _customersList.OrderBy(customer => customer.ToString()).ToList();
            CustomerComboBox.DataSource = _customersList;
            CustomerComboBox.SelectedIndex = -1;
            ItemsListBox.Enabled = false;
            ClearCartInfo();
        }

        /// <summary>
        /// Метод для очистки корзины покупателя.
        /// </summary>
        private void ClearCartInfo()
        {
            CartListBox.Items.Clear();
            AmountIntLabel.Text = "0";
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex != -1)
            {
                _currentCustomer = _customersList[CustomerComboBox.SelectedIndex];
                _currentItem = _itemsList[ItemsListBox.SelectedIndex];
                _currentCustomer.Cart.Items.Add(_currentItem);
                CartListBox.Items.Add(_currentItem);
                AmountIntLabel.Text = _currentCustomer.Cart.Amount.ToString();
                CreateOrderButton.Enabled = true;
            }
        }

        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                ItemsListBox.Enabled = true;
                CartListBox.Items.Clear();
                _currentCustomer = _customersList[CustomerComboBox.SelectedIndex];
                CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
                AmountIntLabel.Text = _currentCustomer.Cart.Amount.ToString();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex != -1)
            {
                _currentCustomer = _customersList[CustomerComboBox.SelectedIndex];
                Order order = new Order(
                    DateTime.Now.ToString(), 
                    _currentCustomer.Address, 
                    _currentCustomer.Cart, 
                    OrderStatus.New);
                _currentCustomer.OrderList.Add(order);

                List<Item> item = new List<Item>();
                _currentCustomer.Cart.Items = item;
                CartListBox.Items.Clear();
                AmountIntLabel.Text = "0";
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex != -1)
            {
                _currentCustomer = _customersList[CustomerComboBox.SelectedIndex];
                _currentItem = _currentCustomer.Cart.Items[CartListBox.SelectedIndex];
                _currentCustomer.Cart.Items.Remove(_currentItem);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
                AmountIntLabel.Text = _currentCustomer.Cart.Amount.ToString();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                _currentCustomer = _customersList[CustomerComboBox.SelectedIndex];
                _currentCustomer.Cart.Items.Clear();
                ClearCartInfo();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}