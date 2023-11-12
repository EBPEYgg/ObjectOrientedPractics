using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает и задает выбранный индекс покупателя в CustomersListBox.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        public AddDiscountForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.SelectedIndex = -1;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex != -1)
            {
                PercentDiscount percentDiscount = new PercentDiscount();
                percentDiscount.Category = (Category)CategoryComboBox.SelectedItem;
                Customers[SelectedIndex].Discounts.Add(percentDiscount);
                Close();
            }
        }
    }
}
