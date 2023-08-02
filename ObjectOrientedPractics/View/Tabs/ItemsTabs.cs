﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using Newtonsoft.Json;

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
        private Item _cloneCurrentItem = new();

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
        /// Название файла для сохранения или загрузки данных.
        /// </summary>
        private string _fileName = "Items.json";

        public ItemsTabs()
        {
            InitializeComponent();
            LoadItemsInfo();
            ClearItemsInfo();
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Метод, который сохраняет данные всех товаров в json файл (Items.json).
        /// </summary>
        public void SaveItem()
        {
            if (ItemsListBox.Items.Count != 0)
            {
                var jsonString = System.Text.Json.JsonSerializer.Serialize(_itemsList);
                File.WriteAllText("Items.json", jsonString);
            }
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
                //ErrorToolTip.SetToolTip((Control)sender, "Введите корректное число.");
            }
            catch (OverflowException)
            {
                CostTextBox.BackColor = Color.LightPink;
                //ErrorToolTip.SetToolTip((Control)sender, "Некорректное значение.");
            }
            catch (ArgumentException ex)
            {
                CostTextBox.BackColor = Color.LightPink;
                //ErrorToolTip.SetToolTip((Control)sender, ex.Message);
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
                //TODO: ToolTip.
                //ErrorToolTip.SetToolTip((Control)sender, ex.Message);
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
                //ErrorToolTip.SetToolTip((Control)sender, ex.Message);
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
            SaveItem();
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
                    NameRichTextBox.Text.ToString(),
                    DescriptionRichTextBox.Text.ToString(),
                    Convert.ToInt32(CostTextBox.Text));
                _itemsList.Add(_currentItem);
                Sort();
                SaveItem();
                ToggleInputBoxes(false);
                return;
            }

            _itemsList[_selectedIndex] = _cloneCurrentItem;
            _currentItem = _cloneCurrentItem;
            Sort();
            SaveItem();
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
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        /// <summary>
        /// Метод, который построчно считывает текстовый файл 
        /// для заполнения <see cref="ItemsListBox"/> и <see cref="_itemsList"/>.
        /// </summary>
        private void LoadItemsInfo()
        {
            if (File.Exists(_fileName))
            {
                _itemsList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(_fileName));
                Sort();
            }
        }

        /// <summary>
        /// Метод, который очищает текстовые поля.
        /// </summary>
        private void ClearItemsInfo()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
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
        /// Метод, который включает или отключает все TextBox и ApplyButton.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            CostTextBox.Enabled = value;
            NameRichTextBox.Enabled = value;
            DescriptionRichTextBox.Enabled = value;
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