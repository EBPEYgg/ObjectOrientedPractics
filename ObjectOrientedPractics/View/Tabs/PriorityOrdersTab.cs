using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Приоритетный заказ.
        /// </summary>
        private PriorityOrder _priorityOrder = new PriorityOrder();

        /// <summary>
        /// Счетчик.
        /// </summary>
        private int _counter = 1;

        /// <summary>
        /// Считчик вещей в заказе.
        /// </summary>
        private int _itemsInOrderCount = 0;

        /// <summary>
        /// Стоимость заказа.
        /// </summary>
        private int _amount = 0;

        /// <summary>
        /// Возвращает и задает список вещей.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Возвращает и задает приоритетный заказ.
        /// </summary>
        public PriorityOrder PriorityOrder
        {
            get => _priorityOrder;
            set => _priorityOrder = value;
        }

        /// <summary>
        /// Рандом.
        /// </summary>
        Random random = new Random();

        public PriorityOrdersTab()
        {
            InitializeComponent();
            DeliveryTimeComboBox.Items.AddRange(new string[] {"9:00 - 11:00", "11:00 - 13:00",
                "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00"});
            AddressControl.Address = new Address();
            AddressControl.ClearAddressInfo();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            IdTextBox.Text = _counter.ToString();
            //PriorityOrder.Id = _counter;
            CreatedTextBox.Text = DateTime.Now.ToString();
            PriorityOrder.CreationDate = DateTime.Now.ToString();
            PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            int itemsCount = Items.Count;
            int randomItem = random.Next(0, itemsCount);
            OrderItemsListBox.Items.Add(Items[randomItem]);
            PriorityOrder.Items.Add(Items[randomItem]);
            _amount += PriorityOrder.Items[_itemsInOrderCount].Cost;
            PriorityOrder.Amount = _amount;
            AmountIntLabel.Text = _amount.ToString();
            _itemsInOrderCount++;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = OrderItemsListBox.SelectedIndex;
            if (OrderItemsListBox.Items.Count > 0 && OrderItemsListBox.SelectedIndex != -1)
            {
                PriorityOrder.Items.RemoveAt(selectedIndex);
                OrderItemsListBox.Items.RemoveAt(selectedIndex);
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.Items.Count > 0)
            {
                _counter++;
                ClearOrderButton.Enabled = false;
                OrderItemsListBox.Items.Clear();
                AmountIntLabel.Text = "0";
                AddressControl.ClearAddressInfo();
                CreatedTextBox.Text = DateTime.Now.ToString();
                IdTextBox.Text = (_counter).ToString();
                StatusComboBox.SelectedIndex = 0;
                DeliveryTimeComboBox.SelectedIndex = -1;
                _amount = 0;
                _itemsInOrderCount = 0;

                PriorityOrder = new PriorityOrder();
                //PriorityOrder.AllOrdersCount = _counter;
                PriorityOrder.CreationDate = DateTime.Now.ToString();
                PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;
                AddressControl.Address = new Address();
                AddressControl.ClearAddressInfo();
            }
        }

        private void OrderItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex == -1)
            {
                RemoveItemButton.Enabled = false;
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DeliveryTimeComboBox.Text))
            {
                PriorityOrder.RequestedDeliveryTime = DeliveryTimeComboBox.SelectedItem.ToString();
            }
        }
    }
}
