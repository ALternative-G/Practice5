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

namespace Practice5
{
    public partial class MainForm : Form
    {
        public static List<Comp_tech> devices = new List<Comp_tech>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddComponent_Click(object sender, EventArgs e)
        {
            using (AddCompTech AddCompTech = new AddCompTech())
            {
                AddCompTech.ShowDialog();
            }
        }

        private void buttonAddKeyboard_Click(object sender, EventArgs e)
        {
            using (AddKeyboard AddKeyboard = new AddKeyboard())
            {
                AddKeyboard.ShowDialog();
            }
        }

        private void buttonAddScreen_Click(object sender, EventArgs e)
        {
            using (AddScreen AddScreen = new AddScreen())
            {
                AddScreen.ShowDialog();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (!devices.Any())
            {
                MessageBox.Show("Список объектов пуст.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPrint.Text = "";
                return;
            }

            var deviceInfo = string.Join("\n\n", devices.Select(device =>
                $"{device.ToString()}" +
                $"{Environment.NewLine}" +
                $"{Environment.NewLine}"));

            textBoxPrint.Text = deviceInfo;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                if (!devices.Any())
                {
                    MessageBox.Show("Нет элементов для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int.TryParse(textBoxDelete.Text, out int number);

                number -= 1;
                if (number >= 0 && number < devices.Count)
                {
                    devices.RemoveAt(number);
                    // Уведомление об успешном сохранении
                    MessageBox.Show("Продукт был успешно удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Такого индекса нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
