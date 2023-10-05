using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private Store _store = new();

        private List<Item> _items = new();

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem = new();

        private List<Customer> _customers = new();

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer = new();

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        public CartsTab()
        {
            InitializeComponent();
            //ItemsTabs.Items = _store.Items;
            //CustomerTabs.Customers = _store.Customers;
            //ListSorting();
            CustomerComboBox.DataSource = Customers;
            CustomerComboBox.SelectedIndex = -1;
        }

        ///// <summary>
        ///// TODO: xml.
        ///// </summary>
        //public void ListSorting()
        //{
        //    ItemsTabs.Sort();
        //    CustomerTabs.Sort();
        //}

        private void AddToCartButton_Click(object sender, EventArgs e)
        {

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
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