using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Practice5.Comp_tech;
using static Practice5.Keyboard;

namespace Practice5
{
    public partial class AddScreen : Form
    {
        public AddScreen()
        {
            InitializeComponent();
            foreach (Colour elem in Enum.GetValues(typeof(Colour)))
            {
                comboBoxColour.Items.Add(elem.ToString());
            }
        }



        

        private void AddScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveScreen_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение данных из полей
                string Firm = textBoxFirm.Text;

                // Валидация данных
                if (string.IsNullOrWhiteSpace(Firm))
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Colour.TryParse(comboBoxColour.SelectedItem.ToString(), out Colour colour);
                int.TryParse(textBoxPrice.Text, out int price);
                float.TryParse(textBoxDiagonal.Text, out float diagonal);
                int.TryParse(textBoxHeight.Text, out int height);
                int.TryParse(textBoxWidth.Text, out int width);
                int.TryParse(textBoxFrequence.Text, out int frequency);

                if (price <= 0 || diagonal <= 0 || height <= 0 || width <= 0 || frequency <= 0)
                {
                    MessageBox.Show("Цена или диагональ, или высота, или ширина, или частота экрана равна или меньше нуля. Пожалуйста, введите значения больше нуля.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Создание нового экземпляра класса
                Screen scsave = new Screen();
                scsave.firm = Firm;
                scsave.colour = colour;
                scsave.price = price;
                scsave.diagonal = diagonal;
                scsave.height = height;
                scsave.width = width;
                scsave.frequency = frequency;

                // Сохранение в список
                MainForm.devices.Add(scsave);

                // Уведомление об успешном сохранении
                MessageBox.Show("Товар успешно сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
