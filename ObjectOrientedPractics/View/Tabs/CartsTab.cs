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
                _customersList = value;
                CustomerComboBox.DataSource = _customersList;
                CustomerComboBox.SelectedIndex = -1;
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
                _itemsList = value;
                ItemsListBox.DataSource = _itemsList;
                ItemsListBox.SelectedIndex = -1;
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {

        }

        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {

        }
    }
}