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
        /// Выбранный столбец.
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
            }
        }

        public OrdersTab()
        {
            InitializeComponent();
            AddressControl.ClearAddressInfo();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            StatusComboBox.SelectedIndex = -1;
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
            AddressControl.ClearAddressInfo();
            OrderItemsListBox.Items.Clear();
            AmountIntLabel.Text = "0";
        }

        private void OrdersDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isOrdersFill == true)
            {
                _selectedRow = OrdersDataGridView.CurrentRow.Index;
                IdTextBox.Text = OrdersDataGridView.Rows[_selectedRow].Cells[1].Value.ToString();
                //CreatedTextBox.Text = OrdersDataGridView.Rows[_selectedRow].Cells[2].Value.ToString();
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
            if (StatusComboBox.SelectedIndex != -1 && _isOrdersFill == true 
                && StatusComboBox.Enabled == true)
            {
                _orders[_selectedRow].OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;
            }
        }
    }
}