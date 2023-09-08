using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий AddressGroupBox.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Инициализация адреса.
        /// </summary>
        private Address _address = new();

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, который очищает все текстовые поля на форме.
        /// </summary>
        public void ClearAddressInfo()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// Метод, который включает или отключает все TextBox на форме.
        /// </summary>
        /// <param name="value">True or false.</param>
        public void ToggleInputAddressBoxes(bool value)
        {
            PostIndexTextBox.Enabled = value;
            CountryTextBox.Enabled = value;
            CityTextBox.Enabled = value;
            StreetTextBox.Enabled = value;
            BuildingTextBox.Enabled = value;
            ApartmentTextBox.Enabled = value;
        }

        //public bool PostIndexTextBoxEnabled
        //{
        //    get => PostIndexTextBox.Enabled;
        //    set => PostIndexTextBox.Enabled = value;
        //}

        ///// <summary>
        ///// Метод, который задает true or false для свойства enabled всех textbox на форме.
        ///// </summary>
        //public bool ToggleInputAddressBox
        //{
        //    set => ToggleInputAddressBoxes(value);
        //}

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(PostIndexTextBox.Text))
                {
                    if (!int.TryParse(PostIndexTextBox.Text, out var number))
                    {
                        PostIndexTextBox.BackColor = Color.LightPink;
                        return;
                    }

                    _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
                    PostIndexTextBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, "Введите корректное число.");
            }
            catch (OverflowException)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, "Некорректное значение.");
            }
            catch (ArgumentException ex)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CountryTextBox.Text))
                {
                    if (Validator.CheckStringContainsOnlyEnglishLetters(CountryTextBox.Text))
                    {
                        _address.Country = CountryTextBox.Text;
                        CountryTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        CountryTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                CountryTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CityTextBox.Text))
                {
                    if (Validator.CheckStringContainsOnlyEnglishLetters(CityTextBox.Text))
                    {
                        _address.City = CityTextBox.Text;
                        CityTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        CityTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                CityTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(StreetTextBox.Text))
                {
                    if (Validator.CheckStringContainsOnlyEnglishLetters(StreetTextBox.Text))
                    {
                        _address.Street = StreetTextBox.Text;
                        StreetTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        StreetTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                StreetTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(BuildingTextBox.Text))
                {
                    if (Validator.CheckStringContainsAddress(BuildingTextBox.Text))
                    {
                        _address.Building = BuildingTextBox.Text;
                        BuildingTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        BuildingTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                BuildingTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ApartmentTextBox.Text))
                {
                    if (Validator.CheckStringContainsAddress(ApartmentTextBox.Text))
                    {
                        _address.Apartment = ApartmentTextBox.Text;
                        ApartmentTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        ApartmentTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }
    }
}