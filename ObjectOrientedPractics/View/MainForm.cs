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
                    File.WriteAllText("Store2.json", jsonStore);
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

        private void ListSorting()
        {
            ItemsTabs.Sort();
            CustomerTabs.Sort();
        }
    }
}