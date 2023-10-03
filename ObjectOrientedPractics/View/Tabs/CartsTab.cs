using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Инициализация магазина.
        /// </summary>
        private Store _store = new();

        private Cart _cart = new();

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _store.Customers;
            set => _store.Customers = value;
        }

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _store.Items;
            set => _store.Items = value;
        }

        public CartsTab()
        {
            InitializeComponent();
            CustomerComboBox.DataSource = _store.Customers;
            CustomerComboBox.SelectedIndex = -1;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CartRichTextBox_TextChanged(object sender, EventArgs e)
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