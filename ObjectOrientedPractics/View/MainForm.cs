using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// »нициализаци€ магазина.
        /// </summary>
        private Store _store = new();

        /// <summary>
        /// Ќазвание файла дл€ сохранени€ или загрузки данных.
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
        /// ћетод, который сохран€ет данные при закрытии приложени€ пользователем.
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
        /// ћетод, который считывает текстовый файл дл€ заполнени€ списков товара и покупателей.
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