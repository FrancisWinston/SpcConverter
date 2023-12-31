﻿
using Microsoft.WindowsAPICodePack.Dialogs;
using SpcConverter.Common.Models;
using SpcConverter.Common.Utils;
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
    /// Класс формы настроек.
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Ссылка на класс для управления настройками СПО.
        /// </summary>
        private SettingsManager settingsManager;

        /// <summary>
        /// Флаг того были ли внесены изменения в форму.
        /// </summary>
        private bool isEdited = false;

        /// <summary>
        /// Конструктор формы настроек.
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();

            settingsManager = SettingsManager.GetInstance();

            try
            {
                CommonSettings commonSettings = settingsManager.GetCommonSettings();
                input_dir_path.Text = (string)commonSettings.Get("INPUT_DIR")!;
                output_dir_path.Text = (string)commonSettings.Get("OUTPUT_DIR")!;
                header_path.Text = (string)commonSettings.Get("HEADER_PATH")!;
                graphic_path.Text = (string)commonSettings.Get("LYT_PATH")!;
                subsection_table_path.Text = (string)commonSettings.Get("TABLE_PATH")!;
                developer.Text = (string)commonSettings.Get("DEVELOPER")!;
                revisor.Text = (string)commonSettings.Get("REVISOR")!;
                controlled.Text = (string)commonSettings.Get("CONTROLLED")!;
                approved.Text = (string)commonSettings.Get("APPROVED")!;

            }
            catch (Exception exception)
            {
                ApplicationLogger.Log("Исключение в процессе получения исходных настроек формой редактирования настроек!", Level.ERROR);
                ApplicationLogger.SaveExceptionReport(exception);
            }

        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Выбрать" папку с исходниками.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void select_input_dir_btn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                input_dir_path.Text = dialog.FileName;
                isEdited = true;
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Выбрать" папку для сохранения результатов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void select_output_dir_btn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                output_dir_path.Text = dialog.FileName;
                isEdited = true;
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Выбрать" файл с заголовком.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void select_header_dir_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Filters.Add(new CommonFileDialogFilter("Электронные таблицы (*.xlsx)", ".xlsx"));

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                header_path.Text = dialog.FileName;
                isEdited = true;
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Выбрать" graphic.lyt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void select_graphic_btn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Filters.Add(new CommonFileDialogFilter("Стили КОМПАС 3D (*.lyt)", ".lyt"));

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                graphic_path.Text = dialog.FileName;
                isEdited = true;
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Выбрать" таблицу подразделов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void select_subsection_table_btn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Filters.Add(new CommonFileDialogFilter("Текстовые файлы (*.txt)", ".txt"));

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                subsection_table_path.Text = dialog.FileName;
                isEdited = true;
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Сбросить по умолчанию".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Сброс настроек", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            CommonSettings commonSettings = SettingsManager.GetInstance().GetCommonSettings();
            commonSettings.SetDefault();

            input_dir_path.Text = (string)commonSettings.Get("INPUT_DIR")!;
            output_dir_path.Text = (string)commonSettings.Get("OUTPUT_DIR")!;
            header_path.Text = (string)commonSettings.Get("HEADER_PATH")!;
            graphic_path.Text = (string)commonSettings.Get("LYT_PATH")!;
            subsection_table_path.Text = (string)commonSettings.Get("TABLE_PATH")!;
            developer.Text = (string)commonSettings.Get("DEVELOPER")!;
            revisor.Text = (string)commonSettings.Get("REVISOR")!;
            controlled.Text = (string)commonSettings.Get("CONTROLLED")!;
            approved.Text = (string)commonSettings.Get("APPROVED")!;

            SettingsManager.GetInstance().SaveCommonSettings();

            isEdited = false;
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Сохранить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdited)
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Сохранение настроек", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                CommonSettings commonSettings = settingsManager.GetCommonSettings();
                commonSettings.Set("INPUT_DIR", input_dir_path.Text);
                commonSettings.Set("OUTPUT_DIR", output_dir_path.Text);
                commonSettings.Set("HEADER_PATH", header_path.Text);
                commonSettings.Set("LYT_PATH", graphic_path.Text);
                commonSettings.Set("TABLE_PATH", subsection_table_path.Text);
                commonSettings.Set("DEVELOPER", developer.Text);
                commonSettings.Set("REVISOR", revisor.Text);
                commonSettings.Set("CONTROLLED", controlled.Text);
                commonSettings.Set("APPROVED", approved.Text);

                settingsManager.SaveCommonSettings();

            }
            catch (Exception exception)
            {
                ApplicationLogger.Log("Исключение в процессе сохранения настроек формой редактирования настроек!", Level.ERROR);
                ApplicationLogger.SaveExceptionReport(exception);
            }

            this.Hide();
        }

        /// <summary>
        /// Обработка события закрытия формы настроек.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        /// <summary>
        /// Обработка события активации поля ввода фамилии разработчика.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void developer_Enter(object sender, EventArgs e)
        {
            isEdited = true;
        }

        /// <summary>
        /// Обработка события активации поля ввода фамилии проверяющего.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void revisor_TextChanged(object sender, EventArgs e)
        {
            isEdited = true;
        }

        /// <summary>
        /// Обработка события активации поля ввода фамилии контролирующего.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controlled_TextChanged(object sender, EventArgs e)
        {
            isEdited = true;
        }

        /// <summary>
        /// Обработка события активации поля ввода фамилии заверяющего.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void approved_TextChanged(object sender, EventArgs e)
        {
            isEdited = true;
        }
    }
}
