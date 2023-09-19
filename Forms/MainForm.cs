using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpcConverter.Forms
{
    /// <summary>
    /// Класс главной формы.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Ссылка на форму справки.
        /// </summary>
        private AboutForm aboutForm;

        /// <summary>
        /// Ссылка на форму настроек.
        /// </summary>
        private SettingsForm settingsForm;

        /// <summary>
        /// Конструктор класса главной формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //Инициализация форм справки и настроек.
            aboutForm = new AboutForm();
            settingsForm = new SettingsForm();
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Открыть справку".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_about_btn_Click(object sender, EventArgs e)
        {
            aboutForm.Show();
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Открыть настройки".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_settings_btn_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Редактировать заголовок".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_header_btn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Начать конвертацию".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_convertation_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
