using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;

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
        private Address _address = new Address();

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                PostIndexTextBox.Text = value?.Index.ToString();
                CountryTextBox.Text = value?.Country;
                CityTextBox.Text = value?.City;
                StreetTextBox.Text = value?.Street;
                BuildingTextBox.Text = value?.Building;
                ApartmentTextBox.Text = value?.Apartment;
            }
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

        public bool CheckInputAddressValues()
        {
            if (PostIndexTextBox.BackColor == Color.LightPink || 
                CountryTextBox.BackColor == Color.LightPink ||
                CityTextBox.BackColor == Color.LightPink ||
                StreetTextBox.BackColor == Color.LightPink ||
                BuildingTextBox.BackColor == Color.LightPink ||
                ApartmentTextBox.BackColor == Color.LightPink)
            {
                return false;
            }
            return true;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PostIndexTextBox.BackColor = Color.White;
                if (!string.IsNullOrEmpty(PostIndexTextBox.Text))
                {
                    if (!int.TryParse(PostIndexTextBox.Text, out var number))
                    {
                        PostIndexTextBox.BackColor = Color.LightPink;
                        throw new ArgumentException("Индекс должен состоять только из цифр.");
                    }

                    _address.Index = int.Parse(PostIndexTextBox.Text);
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