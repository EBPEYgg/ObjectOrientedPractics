using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализация магазина.
        /// </summary>
        private Store _store = new();

        /// <summary>
        /// Название файла для сохранения или загрузки данных.
        /// </summary>
        private string _fileName = "Store.json";

        public MainForm()
        {
            InitializeComponent();
            LoadStoreInfo();
            ItemsTabs.Items = _store.Items;
            CustomerTabs.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;
            PriorityOrdersTab.Items = _store.Items;
            ItemsTabs.ItemsChanged += ItemsTabs_ItemsChanged;
            CustomerTabs.CustomersChanged += CustomerTabs_CustomersChanged;
            ListSorting();
        }

        /// <summary>
        /// Метод, который сохраняет данные при закрытии приложения пользователем.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (ItemsTabs.ListBoxItemsCount > 0 || CustomerTabs.ListBoxCustomersCount > 0)
                {
                    JsonSerializer jsonStore = new JsonSerializer();
                    jsonStore.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
                    jsonStore.NullValueHandling = NullValueHandling.Ignore;
                    jsonStore.TypeNameHandling = TypeNameHandling.Auto;
                    jsonStore.Formatting = Formatting.Indented;

                    using (StreamWriter sw = new StreamWriter(_fileName))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        jsonStore.Serialize(writer, _store, typeof(Store));
                    }
                }
            }
        }

        /// <summary>
        /// Метод, который считывает текстовый файл для заполнения списков товара и покупателей.
        /// </summary>
        private void LoadStoreInfo()
        {
            try
            {
                var jsonSettings = new JsonSerializerSettings{
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore};

                _store = JsonConvert.DeserializeObject<Store>
                    (File.ReadAllText(_fileName), jsonSettings);
            }
            catch (FileNotFoundException)
            {
                string json = System.Text.Json.JsonSerializer.Serialize(_store);
                File.WriteAllText(_fileName, json);
            }
        }

        /// <summary>
        /// Метод, который сортирует списки и листбоксы товаров и покупателей.
        /// </summary>
        private void ListSorting()
        {
            ItemsTabs.Sort();
            CustomerTabs.Sort();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                _store.Items = ItemsTabs.Items;
            }

            if (TabControl.SelectedIndex == 1)
            {
                _store.Customers = CustomerTabs.Customers;
            }

            if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
                OrdersTab.Customers = CartsTab.Customers;

                if (OrdersTab.Customers.Count == 0)
                {
                    OrdersTab.ClearInfo();
                }
            }
        }

        private void ItemsTabs_ItemsChanged(object sender, EventArgs e)
        {
            CartsTab.Items = _store.Items;
            CartsTab.RefreshData();
        }

        private void CustomerTabs_CustomersChanged(object sender, EventArgs e)
        {
            CartsTab.Customers = _store.Customers;
            CartsTab.RefreshData();
        }
    }
}