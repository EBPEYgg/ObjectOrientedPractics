using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private Order _order = new();

        public OrdersTab()
        {
            InitializeComponent();
            AddressControl.ClearAddressInfo();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            StatusComboBox.SelectedIndex = -1;
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (StatusComboBox.SelectedIndex != -1 && _cloneCurrentItem.StatusOrder != null)
            //{
            //    _cloneCurrentItem.Category = (StatusOrder)StatusComboBox.SelectedItem;
            //}
        }

        private void OrderItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}