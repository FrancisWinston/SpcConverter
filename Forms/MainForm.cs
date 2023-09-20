using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Executor = SpcConverter.Domain.Executor;

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
        /// Ссылка на объект для обеспечения процесса конвертации.
        /// </summary>
        private Executor executor;

        /// <summary>
        /// Конструктор класса главной формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //Инициализация форм справки и настроек.
            aboutForm = new AboutForm();
            settingsForm = new SettingsForm();

            //Инициализация объекта для обеспечения процесса конвертации.
            executor = new Executor(this);
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
            executor.EditHeader();
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Начать конвертацию".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_convertation_btn_Click(object sender, EventArgs e)
        {
            bool createListing = listing_checkBox.Checked;
            bool createSpecification = specification_checkBox.Checked;
            bool createStatement = statement_checkBox.Checked;

            executor.Execute(createListing, createSpecification, createStatement);
        }

        public void SetProgress(byte b)
        {
            search_input_checkBox.Checked = (b & 0b00000001) != 0;
            read_input_checkBox.Checked = (b & 0b00000010) != 0;
            read_header_checkbox.Checked = (b & 0b00000100) != 0;
            convertation_specification_checkBox.Checked = (b & 0b00001000) != 0;
            convertation_listing_checkBox.Checked = (b & 0b00010000) != 0;
            convertation_statement_checkBox.Checked = (b & 0b00100000) != 0;
            file_creation_checkBox.Checked = (b & 0b01000000) != 0;
            finished_checkBox.Checked = (b & 0b10000000) != 0;
        }
    }
}
