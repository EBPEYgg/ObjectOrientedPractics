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
                if (_itemsList != null && value != null)
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
            DiscountCheckedListBox.SelectedIndex = -1;
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
            CustomerComboBox.SelectedIndexChanged -= CustomerComboBox_SelectedIndexChanged;
            CustomerComboBox.DataSource = _customersList;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            CustomerComboBox.SelectedIndex = -1;
            DiscountCheckedListBox.DataSource = null;
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
            DiscountAmountIntLabel.Text = "0";
            TotalIntLabel.Text = "0";
            CreateOrderButton.Enabled = false;
        }

        /// <summary>
        /// Метод, который считает размер скидки.
        /// </summary>
        private void CalculateDiscountAmountAndTotal()
        {
            int discountAmount = 0;
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                discountAmount += _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);

                if (!DiscountCheckedListBox.GetItemChecked(i))
                {
                    discountAmount -= _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);
                }
            }
            DiscountAmountIntLabel.Text = discountAmount.ToString();
            TotalIntLabel.Text = (_currentCustomer.Cart.Amount - discountAmount).ToString();
        }

        /// <summary>
        /// Метод, который считает и возвращает размер скидки с вычетом накопительных баллов.
        /// </summary>
        /// <returns>Размер скидки.</returns>
        private int ApplyDiscount()
        {
            int discountAmount = 0;
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += _currentCustomer.Discounts[i].Apply(_currentCustomer.Cart.Items);
                }
                _currentCustomer.Discounts[i].Update(_currentCustomer.Cart.Items);
            }
            return discountAmount;
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
                CalculateDiscountAmountAndTotal();
            }
        }

        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                int discountAmount = 0;
                ItemsListBox.Enabled = true;
                CartListBox.Items.Clear();
                _currentCustomer = _customersList[CustomerComboBox.SelectedIndex];
                CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
                AmountIntLabel.Text = _currentCustomer.Cart.Amount.ToString();
                DiscountCheckedListBox.DataSource = _currentCustomer.Discounts;
                DiscountCheckedListBox.SelectedIndex = -1;

                for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
                {
                    DiscountCheckedListBox.SetItemChecked(i, true);
                    discountAmount += _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);
                }

                DiscountAmountIntLabel.Text = discountAmount.ToString();
                TotalIntLabel.Text = (_currentCustomer.Cart.Amount - discountAmount).ToString();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex != -1)
            {
                _currentCustomer = _customersList[CustomerComboBox.SelectedIndex];

                if (_currentCustomer.IsPriority == true)
                {
                    Order priorityOrder = new PriorityOrder();
                    priorityOrder.CreationDate = DateTime.Now.ToString();
                    priorityOrder.Address = _currentCustomer.Address;
                    priorityOrder.Items = _currentCustomer.Cart.Items;
                    priorityOrder.Amount = _currentCustomer.Cart.Amount;
                    priorityOrder.DiscountAmount = ApplyDiscount();
                    priorityOrder.OrderStatus = OrderStatus.New;
                    priorityOrder.Id = _currentCustomer.Id;
                    priorityOrder.IsPriority = true;
                    _currentCustomer.OrderList.Add((PriorityOrder)priorityOrder);
                }

                else
                {
                    Order order = new PriorityOrder();
                    order.CreationDate = DateTime.Now.ToString();
                    order.Address = _currentCustomer.Address;
                    order.Items = _currentCustomer.Cart.Items;
                    order.Amount = _currentCustomer.Cart.Amount;
                    order.DiscountAmount = ApplyDiscount();
                    order.OrderStatus = OrderStatus.New;
                    order.Id = _currentCustomer.Id;
                    order.IsPriority = false;
                    _currentCustomer.OrderList.Add((PriorityOrder)order);
                }

                List<Item> item = new List<Item>();
                _currentCustomer.Cart.Items = item;
                CalculateDiscountAmountAndTotal();
                CartListBox.Items.Clear();
                AmountIntLabel.Text = "0";
                DiscountAmountIntLabel.Text = "0";
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
                CalculateDiscountAmountAndTotal();

                if (CartListBox.Items.Count == 0)
                {
                    CreateOrderButton.Enabled = false;
                }
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                _currentCustomer = _customersList[CustomerComboBox.SelectedIndex];
                _currentCustomer.Cart.Items.Clear();
                ClearCartInfo();
                CalculateDiscountAmountAndTotal();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentCustomer.Discounts != null)
            {
                CalculateDiscountAmountAndTotal();
            }
        }
    }
}