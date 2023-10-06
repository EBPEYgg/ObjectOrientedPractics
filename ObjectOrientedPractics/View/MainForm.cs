using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������������� ��������.
        /// </summary>
        private Store _store = new();

        /// <summary>
        /// �������� ����� ��� ���������� ��� �������� ������.
        /// </summary>
        private string _fileName = "Store.json";

        public MainForm()
        {
            InitializeComponent();
            LoadStoreInfo();
            ItemsTabs.Items = _store.Items;
            CustomerTabs.Customers = _store.Customers;
            CartsTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            ListSorting();
        }

        /// <summary>
        /// �����, ������� ��������� ������ ��� �������� ���������� �������������.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (ItemsTabs.ListBoxItemsCount > 0 || CustomerTabs.ListBoxCustomersCount > 0)
                {
                    string jsonStore = System.Text.Json.JsonSerializer.Serialize(_store);
                    File.WriteAllText(_fileName, jsonStore);
                }
            }
        }

        /// <summary>
        /// �����, ������� ��������� ��������� ���� ��� ���������� ������� ������ � �����������.
        /// </summary>
        private void LoadStoreInfo()
        {
            if (File.Exists(_fileName))
            {
                _store = JsonConvert.DeserializeObject<Store>(File.ReadAllText(_fileName));
            }
        }

        /// <summary>
        /// �����, ������� ��������� ������ � ��������� ������� � �����������.
        /// </summary>
        private void ListSorting()
        {
            ItemsTabs.Sort();
            CustomerTabs.Sort();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                //RefreshData();
                return;
            }
        }
    }
}