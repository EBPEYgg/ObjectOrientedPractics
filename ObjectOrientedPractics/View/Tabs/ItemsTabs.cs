using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий ItemsGroupBox.
    /// </summary>
    public partial class ItemsTabs : UserControl
    {
        /// <summary>
        /// Список с данными о товарах.
        /// </summary>
        private List<Item> _itemsList = new List<Item>();

        /// <summary>
        /// Список с данными текущего выбранного товара.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Копия текущего выбранного товара.
        /// </summary>
        private Item _cloneCurrentItem = new Item();

        /// <summary>
        /// Индекс текущего выбранного элемента перед сортировкой 
        /// для сохранения выбранного элемента в ItemsListBox.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// Индекс текущего выбранного элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _itemsList;
            set => _itemsList = value;
        }

        /// <summary>
        /// Возвращает количество элементов в <see cref="ItemsListBox"/>.
        /// </summary>
        public int ListBoxItemsCount
        {
            get => ItemsListBox.Items.Count;
        }

        public ItemsTabs()
        {
            InitializeComponent();
            ClearItemsInfo();
            ItemsListBox.SelectedIndex = -1;
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.SelectedIndex = -1;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CostTextBox.Text))
                {
                    if (!int.TryParse(CostTextBox.Text, out var number))
                    {
                        CostTextBox.BackColor = Color.LightPink;
                        return;
                    }

                    _cloneCurrentItem.Cost = Convert.ToInt32(CostTextBox.Text);
                    CostTextBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                CostTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, "Введите корректное число.");
            }
            catch (OverflowException)
            {
                CostTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, "Некорректное значение.");
            }
            catch (ArgumentException ex)
            {
                CostTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex != -1 && _cloneCurrentItem.Category != null)
            {
                _cloneCurrentItem.Category = (Category)CategoryComboBox.SelectedItem;
            }
        }

        private void NameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NameRichTextBox.Text))
                {
                    if (Validator.CheckStringContainsOnlyEnglishLetters(NameRichTextBox.Text))
                    {
                        _cloneCurrentItem.Name = NameRichTextBox.Text;
                        NameRichTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        NameRichTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                NameRichTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void DescriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(DescriptionRichTextBox.Text))
                {
                    if (Validator.CheckStringContainsOnlyEnglishLetters(DescriptionRichTextBox.Text))
                    {
                        _cloneCurrentItem.Name = DescriptionRichTextBox.Text;
                        DescriptionRichTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        DescriptionRichTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                DescriptionRichTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearItemsInfo();
            ItemsListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ToggleInputBoxes(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentItem = _itemsList[ItemsListBox.SelectedIndex];
            _itemsList.Remove(_currentItem);
            ItemsListBox.SelectedIndex = -1;
            Sort();
            ClearItemsInfo();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = ItemsListBox.SelectedIndex;
            _cloneCurrentItem = (Item)_itemsList[_selectedIndex].Clone();
            ToggleInputBoxes(true);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CostTextBox.Text) ||
                string.IsNullOrEmpty(NameRichTextBox.Text) ||
                string.IsNullOrEmpty(DescriptionRichTextBox.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка ввода");
                return;
            }

            if (_selectedIndex == -1)
            {
                _currentItem = new Item(
                    NameRichTextBox.Text.ToString().Trim(),
                    DescriptionRichTextBox.Text.ToString().Trim(),
                    Convert.ToInt32(CostTextBox.Text),
                    (Category)CategoryComboBox.SelectedItem);
                _itemsList.Add(_currentItem);
                Sort();
                ToggleInputBoxes(false);
                ClearItemsInfo();
                return;
            }

            _itemsList[_selectedIndex] = _cloneCurrentItem;
            _currentItem = _cloneCurrentItem;
            Sort();
            //SaveItem();
            ToggleInputBoxes(false);
            UpdateItemInfo();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _cloneCurrentItem = (Item)_itemsList[ItemsListBox.SelectedIndex].Clone();
                IdTextBox.Text = _cloneCurrentItem.Id.ToString();
                CostTextBox.Text = _cloneCurrentItem.Cost.ToString();
                NameRichTextBox.Text = _cloneCurrentItem.Name.ToString();
                DescriptionRichTextBox.Text = _cloneCurrentItem.Info.ToString();
                CategoryComboBox.SelectedItem = _cloneCurrentItem.Category;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //SaveItem();
        }

        /// <summary>
        /// Метод, который очищает текстовые поля и ComboBox.
        /// </summary>
        private void ClearItemsInfo()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
            NameRichTextBox.Clear();
            DescriptionRichTextBox.Clear();
        }

        /// <summary>
        /// Метод, который сортирует <see cref="_itemsList"/> и <see cref="ItemsListBox"/>
        /// в алфавитном порядке.
        /// </summary>
        private void Sort()
        {
            _indexBeforeSort = ItemsListBox.SelectedIndex;
            ItemsListBox.SelectedIndexChanged -= ItemsListBox_SelectedIndexChanged;
            _itemsList = _itemsList.OrderBy(item => item.ToString()).ToList();
            ItemsListBox.DataSource = _itemsList;
            ItemsListBox.SelectedIndex = _indexBeforeSort;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Метод, который включает или отключает все TextBox, ComboBox и ApplyButton.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            CostTextBox.Enabled = value;
            NameRichTextBox.Enabled = value;
            DescriptionRichTextBox.Enabled = value;
            CategoryComboBox.Enabled = value;
            ApplyButton.Visible = value;
        }

        /// <summary>
        /// Метод, который обновляет данные текущего выбранного товара в TextBox.
        /// </summary>
        private void UpdateItemInfo()
        {
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameRichTextBox.Text = _currentItem.Name.ToString();
            DescriptionRichTextBox.Text = _currentItem.Info.ToString();
        }
    }
}