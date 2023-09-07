namespace SpcConverter.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progress_groupBox = new GroupBox();
            read_header_checkbox = new CheckBox();
            finished_checkbox = new CheckBox();
            file_creation_checkBox = new CheckBox();
            read_input_checkBox = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox4 = new CheckBox();
            convertation_checkBox = new CheckBox();
            checkBox3 = new CheckBox();
            action_groupBox = new GroupBox();
            open_settings_btn = new Button();
            edit_header_btn = new Button();
            open_about_btn = new Button();
            start_convertation_btn = new Button();
            input_files_groupBox = new GroupBox();
            input_list = new ListBox();
            convertation_destination_groupBox = new GroupBox();
            statement_checkBox = new CheckBox();
            listing_checkBox = new CheckBox();
            specification_checkBox = new CheckBox();
            progress_groupBox.SuspendLayout();
            action_groupBox.SuspendLayout();
            input_files_groupBox.SuspendLayout();
            convertation_destination_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // progress_groupBox
            // 
            progress_groupBox.Controls.Add(read_header_checkbox);
            progress_groupBox.Controls.Add(finished_checkbox);
            progress_groupBox.Controls.Add(file_creation_checkBox);
            progress_groupBox.Controls.Add(read_input_checkBox);
            progress_groupBox.Controls.Add(checkBox1);
            progress_groupBox.Controls.Add(checkBox4);
            progress_groupBox.Controls.Add(convertation_checkBox);
            progress_groupBox.Controls.Add(checkBox3);
            progress_groupBox.ForeColor = SystemColors.ControlText;
            progress_groupBox.Location = new Point(402, 204);
            progress_groupBox.Name = "progress_groupBox";
            progress_groupBox.Size = new Size(217, 225);
            progress_groupBox.TabIndex = 5;
            progress_groupBox.TabStop = false;
            progress_groupBox.Text = "Прогресс";
            // 
            // read_header_checkbox
            // 
            read_header_checkbox.AutoCheck = false;
            read_header_checkbox.AutoSize = true;
            read_header_checkbox.ForeColor = SystemColors.ControlText;
            read_header_checkbox.Location = new Point(6, 72);
            read_header_checkbox.Name = "read_header_checkbox";
            read_header_checkbox.Size = new Size(123, 19);
            read_header_checkbox.TabIndex = 3;
            read_header_checkbox.Text = "Чтение заголовка";
            read_header_checkbox.UseVisualStyleBackColor = true;
            // 
            // finished_checkbox
            // 
            finished_checkbox.AutoCheck = false;
            finished_checkbox.AutoSize = true;
            finished_checkbox.ForeColor = SystemColors.ControlText;
            finished_checkbox.Location = new Point(6, 197);
            finished_checkbox.Name = "finished_checkbox";
            finished_checkbox.Size = new Size(67, 19);
            finished_checkbox.TabIndex = 4;
            finished_checkbox.Text = "Готово!";
            finished_checkbox.UseVisualStyleBackColor = true;
            // 
            // file_creation_checkBox
            // 
            file_creation_checkBox.AutoCheck = false;
            file_creation_checkBox.AutoSize = true;
            file_creation_checkBox.ForeColor = SystemColors.ControlText;
            file_creation_checkBox.Location = new Point(6, 172);
            file_creation_checkBox.Name = "file_creation_checkBox";
            file_creation_checkBox.Size = new Size(206, 19);
            file_creation_checkBox.TabIndex = 2;
            file_creation_checkBox.Text = "Создание файлов ПО Компас 3D";
            file_creation_checkBox.UseVisualStyleBackColor = true;
            // 
            // read_input_checkBox
            // 
            read_input_checkBox.AutoCheck = false;
            read_input_checkBox.AutoSize = true;
            read_input_checkBox.ForeColor = SystemColors.ControlText;
            read_input_checkBox.Location = new Point(6, 47);
            read_input_checkBox.Name = "read_input_checkBox";
            read_input_checkBox.Size = new Size(133, 19);
            read_input_checkBox.TabIndex = 0;
            read_input_checkBox.Text = "Чтение исходников";
            read_input_checkBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoCheck = false;
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ControlText;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Поиск исходников";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoCheck = false;
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = SystemColors.ControlText;
            checkBox4.Location = new Point(6, 147);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(167, 19);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Конвертация в ведомость";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // convertation_checkBox
            // 
            convertation_checkBox.AutoCheck = false;
            convertation_checkBox.AutoSize = true;
            convertation_checkBox.ForeColor = SystemColors.ControlText;
            convertation_checkBox.Location = new Point(6, 97);
            convertation_checkBox.Name = "convertation_checkBox";
            convertation_checkBox.Size = new Size(194, 19);
            convertation_checkBox.TabIndex = 1;
            convertation_checkBox.Text = "Конвертация в спецификацию";
            convertation_checkBox.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoCheck = false;
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = SystemColors.ControlText;
            checkBox3.Location = new Point(6, 122);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(161, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Конвертация в перечень";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // action_groupBox
            // 
            action_groupBox.Controls.Add(open_settings_btn);
            action_groupBox.Controls.Add(edit_header_btn);
            action_groupBox.Controls.Add(open_about_btn);
            action_groupBox.Controls.Add(start_convertation_btn);
            action_groupBox.ForeColor = SystemColors.ControlText;
            action_groupBox.Location = new Point(12, 345);
            action_groupBox.Name = "action_groupBox";
            action_groupBox.Size = new Size(384, 84);
            action_groupBox.TabIndex = 4;
            action_groupBox.TabStop = false;
            action_groupBox.Text = "Действия";
            // 
            // open_settings_btn
            // 
            open_settings_btn.BackColor = SystemColors.ButtonFace;
            open_settings_btn.ForeColor = SystemColors.ControlText;
            open_settings_btn.Location = new Point(6, 51);
            open_settings_btn.Name = "open_settings_btn";
            open_settings_btn.Size = new Size(178, 23);
            open_settings_btn.TabIndex = 3;
            open_settings_btn.Text = "Открыть настройки";
            open_settings_btn.UseVisualStyleBackColor = false;
            open_settings_btn.Click += open_settings_btn_Click;
            // 
            // edit_header_btn
            // 
            edit_header_btn.BackColor = SystemColors.ButtonFace;
            edit_header_btn.ForeColor = SystemColors.ControlText;
            edit_header_btn.Location = new Point(193, 22);
            edit_header_btn.Name = "edit_header_btn";
            edit_header_btn.Size = new Size(178, 23);
            edit_header_btn.TabIndex = 2;
            edit_header_btn.Text = "Редактировать заголовок";
            edit_header_btn.UseVisualStyleBackColor = false;
            edit_header_btn.Click += edit_header_btn_Click;
            // 
            // open_about_btn
            // 
            open_about_btn.BackColor = SystemColors.ButtonFace;
            open_about_btn.ForeColor = SystemColors.ControlText;
            open_about_btn.Location = new Point(6, 22);
            open_about_btn.Name = "open_about_btn";
            open_about_btn.Size = new Size(178, 23);
            open_about_btn.TabIndex = 1;
            open_about_btn.Text = "Открыть инструкцию";
            open_about_btn.UseVisualStyleBackColor = false;
            open_about_btn.Click += open_about_btn_Click;
            // 
            // start_convertation_btn
            // 
            start_convertation_btn.BackColor = SystemColors.Info;
            start_convertation_btn.ForeColor = SystemColors.ControlText;
            start_convertation_btn.Location = new Point(193, 51);
            start_convertation_btn.Name = "start_convertation_btn";
            start_convertation_btn.Size = new Size(178, 23);
            start_convertation_btn.TabIndex = 0;
            start_convertation_btn.Text = "Начать конвертацию";
            start_convertation_btn.UseVisualStyleBackColor = false;
            start_convertation_btn.Click += start_convertation_btn_Click;
            // 
            // input_files_groupBox
            // 
            input_files_groupBox.Controls.Add(input_list);
            input_files_groupBox.ForeColor = SystemColors.ControlText;
            input_files_groupBox.Location = new Point(12, 12);
            input_files_groupBox.Name = "input_files_groupBox";
            input_files_groupBox.Size = new Size(607, 186);
            input_files_groupBox.TabIndex = 3;
            input_files_groupBox.TabStop = false;
            input_files_groupBox.Text = "Исходники";
            // 
            // input_list
            // 
            input_list.ForeColor = SystemColors.ControlText;
            input_list.FormattingEnabled = true;
            input_list.ItemHeight = 15;
            input_list.Location = new Point(6, 22);
            input_list.Name = "input_list";
            input_list.Size = new Size(595, 154);
            input_list.TabIndex = 0;
            // 
            // convertation_destination_groupBox
            // 
            convertation_destination_groupBox.Controls.Add(statement_checkBox);
            convertation_destination_groupBox.Controls.Add(listing_checkBox);
            convertation_destination_groupBox.Controls.Add(specification_checkBox);
            convertation_destination_groupBox.Location = new Point(12, 204);
            convertation_destination_groupBox.Name = "convertation_destination_groupBox";
            convertation_destination_groupBox.Size = new Size(209, 104);
            convertation_destination_groupBox.TabIndex = 6;
            convertation_destination_groupBox.TabStop = false;
            convertation_destination_groupBox.Text = "Конвертировать в";
            // 
            // statement_checkBox
            // 
            statement_checkBox.AutoSize = true;
            statement_checkBox.Location = new Point(6, 72);
            statement_checkBox.Name = "statement_checkBox";
            statement_checkBox.Size = new Size(191, 19);
            statement_checkBox.TabIndex = 2;
            statement_checkBox.Text = "Ведомость покупных изделий";
            statement_checkBox.UseVisualStyleBackColor = true;
            // 
            // listing_checkBox
            // 
            listing_checkBox.AutoSize = true;
            listing_checkBox.Location = new Point(6, 47);
            listing_checkBox.Name = "listing_checkBox";
            listing_checkBox.Size = new Size(186, 19);
            listing_checkBox.TabIndex = 1;
            listing_checkBox.Text = "Перечень покупных изделий";
            listing_checkBox.UseVisualStyleBackColor = true;
            // 
            // specification_checkBox
            // 
            specification_checkBox.AutoSize = true;
            specification_checkBox.Location = new Point(6, 22);
            specification_checkBox.Name = "specification_checkBox";
            specification_checkBox.Size = new Size(113, 19);
            specification_checkBox.TabIndex = 0;
            specification_checkBox.Text = "Спецификацию";
            specification_checkBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(convertation_destination_groupBox);
            Controls.Add(progress_groupBox);
            Controls.Add(action_groupBox);
            Controls.Add(input_files_groupBox);
            MaximumSize = new Size(640, 480);
            MinimumSize = new Size(640, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СПО \"Конвертер\"";
            progress_groupBox.ResumeLayout(false);
            progress_groupBox.PerformLayout();
            action_groupBox.ResumeLayout(false);
            input_files_groupBox.ResumeLayout(false);
            convertation_destination_groupBox.ResumeLayout(false);
            convertation_destination_groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox progress_groupBox;
        private CheckBox finished_checkbox;
        private CheckBox read_header_checkbox;
        private CheckBox file_creation_checkBox;
        private CheckBox convertation_checkBox;
        private CheckBox read_input_checkBox;
        private GroupBox action_groupBox;
        private Button open_settings_btn;
        private Button edit_header_btn;
        private Button open_about_btn;
        private Button start_convertation_btn;
        private GroupBox input_files_groupBox;
        private ListBox input_list;
        private GroupBox convertation_destination_groupBox;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CheckBox statement_checkBox;
        private CheckBox listing_checkBox;
        private CheckBox specification_checkBox;
    }
}