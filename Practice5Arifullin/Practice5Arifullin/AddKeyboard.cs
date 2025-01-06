using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Practice5.Comp_tech;
using static Practice5.Keyboard;

namespace Practice5
{
    public partial class AddKeyboard : Form
    {
        public AddKeyboard()
        {
            InitializeComponent();
            foreach (Colour elem in Enum.GetValues(typeof(Colour)))
            {
                comboBoxColour.Items.Add(elem.ToString());
            }
            foreach (KB_form elem in Enum.GetValues(typeof(KB_form)))
            {
                comboBoxFormat.Items.Add(elem.ToString());
            }
            foreach (SizeType elem in Enum.GetValues(typeof(SizeType)))
            {
                comboBoxSize.Items.Add(elem.ToString());
            }
            foreach (Type_KB elem in Enum.GetValues(typeof(Type_KB)))
            {
                comboBoxType.Items.Add(elem.ToString());
            }
        }



        private void btnSaveKeyboard_Click(object sender, EventArgs e)
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
                KB_form.TryParse(comboBoxFormat.SelectedItem.ToString(), out KB_form Format);
                KB_Size.TryParse(comboBoxSize.SelectedItem.ToString(), out KB_Size size);
                Type_KB.TryParse(comboBoxType.SelectedItem.ToString(), out Type_KB type);
                int.TryParse(textBoxPrice.Text, out int price);
                int.TryParse(textBoxDurability.Text, out int durability);

                if (price <= 0 || durability <= 0)
                {
                    MessageBox.Show("Цена или долговечность клавиатуры равна нулю или меньше нуля. Пожалуйста, введите значения больше нуля.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Создание нового экземпляра класса
                Keyboard kbsave = new Keyboard();
                kbsave.firm = Firm;
                kbsave.colour = colour;
                kbsave.Format = Format;
                kbsave.Size = size;
                kbsave.Type = type;
                kbsave.price = price;
                kbsave.durability = durability;

                // Сохранение в список
                MainForm.devices.Add(kbsave);

                // Уведомление об успешном сохранении
                MessageBox.Show("Товар успешно сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void AddKeyboard_Load(object sender, EventArgs e)
        {

        }
    }
}
