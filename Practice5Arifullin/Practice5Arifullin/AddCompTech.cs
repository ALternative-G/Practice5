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
    public partial class AddCompTech : Form
    {
        public AddCompTech()
        {
            InitializeComponent();
            foreach (Colour elem in Enum.GetValues(typeof(Colour)))
            {
                comboBoxColour.Items.Add(elem.ToString());
            }
        }



        private void AddCompTech_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveComponent_Click(object sender, EventArgs e)
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

                if (price <= 0)
                {
                    MessageBox.Show("Цена равна или меньше нуля. Пожалуйста, введите значения больше нуля.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Создание нового экземпляра класса
                Comp_tech ctsave = new Comp_tech();
                ctsave.firm = Firm;
                ctsave.colour = colour;
                ctsave.price = price;

                // Сохранение в список
                MainForm.devices.Add(ctsave);

                // Уведомление об успешном сохранении
                MessageBox.Show("Товар успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
