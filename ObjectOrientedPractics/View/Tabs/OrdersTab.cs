using ObjectOrientedPractics.Model;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customersList = new();

        /// <summary>
        /// Список заказов.
        /// </summary>
        private BindingList<Order> _orders = new BindingList<Order>();

        /// <summary>
        /// Выбранный приоритетный заказ.
        /// </summary>
        private PriorityOrder _selectedPriorityOrder = new PriorityOrder();

        /// <summary>
        /// Выбранная строка.
        /// </summary>
        private int _selectedRow;

        /// <summary>
        /// Проверка на заполнение <see cref="_orders"/>.
        /// </summary>
        private bool _isOrdersFill = false;

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customersList;
            set
            {
                _customersList = value;
                for (int i = 0; i < _customersList?.Count; i++)
                {
                    for (int j = 0; j < _customersList[i].OrderList.Count; j++)
                    {
                        _orders.Add(_customersList[i].OrderList[j]);
                        _isOrdersFill = true;
                    }
                }
                OrdersDataGridView.DataSource = _orders;
                OrdersDataGridView.Columns["AllOrdersCount"].Visible = false;
                OrdersDataGridView.Columns["IsPriority"].Visible = false;
            }
        }

        public OrdersTab()
        {
            InitializeComponent();
            AddressControl.ClearAddressInfo();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            StatusComboBox.SelectedIndex = -1;
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.Items.AddRange(new string[] {"9:00 - 11:00", "11:00 - 13:00",
                "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00"});
        }

        /// <summary>
        /// Метод, который обновляет данные на вкладке при переключении вкладок.
        /// </summary>
        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
        }

        /// <summary>
        /// Метод, который очищает все текстовые поля.
        /// </summary>
        public void ClearInfo()
        {
            IdTextBox.Text = String.Empty;
            StatusComboBox.SelectedIndex = -1;
            CreatedTextBox.Text = String.Empty;
            DeliveryTimeComboBox.SelectedIndex = -1;
            PriorityOptionsPanel.Visible = false;
            AddressControl.ClearAddressInfo();
            OrderItemsListBox.Items.Clear();
            AmountIntLabel.Text = "0";
        }

        private void OrdersDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isOrdersFill == true)
            {
                _selectedRow = OrdersDataGridView.CurrentRow.Index;

                if (_orders[_selectedRow].IsPriority == true)
                {
                    PriorityOptionsPanel.Visible = true;
                    _selectedPriorityOrder = (PriorityOrder)_orders[_selectedRow];

                    if (_selectedPriorityOrder.RequestedDeliveryTime != null &&
                        _selectedPriorityOrder.RequestedDeliveryTime != string.Empty)
                    {
                        DeliveryTimeComboBox.Text = _selectedPriorityOrder.RequestedDeliveryTime.ToString();
                    }

                    else
                    {
                        DeliveryTimeComboBox.SelectedIndex = -1;
                    }
                }

                else
                {
                    PriorityOptionsPanel.Visible = false;
                }

                IdTextBox.Text = OrdersDataGridView.Rows[_selectedRow].Cells[1].Value.ToString();
                CreatedTextBox.Text = OrdersDataGridView.Rows[_selectedRow].Cells[2].Value.ToString();
                AddressControl.Address = (Address)OrdersDataGridView.Rows[_selectedRow].Cells[3].Value;
                AmountIntLabel.Text = OrdersDataGridView.Rows[_selectedRow].Cells[4].Value.ToString();
                StatusComboBox.Text = OrdersDataGridView.Rows[_selectedRow].Cells[5].Value.ToString();
                OrderItemsListBox.Items.Clear();
                OrderItemsListBox.Items.AddRange(_orders[_selectedRow].Items.ToArray());
                StatusComboBox.Enabled = true;
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex != -1 
                && _isOrdersFill == true 
                && StatusComboBox.Enabled == true)
            {
                _orders[_selectedRow].OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;
                OrdersDataGridView.InvalidateRow(_selectedRow);
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPriorityOrder.RequestedDeliveryTime = DeliveryTimeComboBox.Text;
        }
    }
}