namespace SpcConverter.Forms
{
    partial class SettingsForm
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
            path_groupBox = new GroupBox();
            subsection_table_path_label = new Label();
            graphic_path_label = new Label();
            header_path_label = new Label();
            output_path_label = new Label();
            input_path_label = new Label();
            subsection_table_path = new TextBox();
            select_subsection_table_btn = new Button();
            graphic_path = new TextBox();
            select_graphic_btn = new Button();
            header_path = new TextBox();
            select_header_dir = new Button();
            output_dir_path = new TextBox();
            select_output_dir_btn = new Button();
            input_dir_path = new TextBox();
            select_input_dir_btn = new Button();
            stamp_groupBox = new GroupBox();
            approved_label = new Label();
            controller_label = new Label();
            revisor_label = new Label();
            developer_label = new Label();
            developer = new TextBox();
            revisor = new TextBox();
            approved = new TextBox();
            controlled = new TextBox();
            save_btn = new Button();
            reset_btn = new Button();
            path_groupBox.SuspendLayout();
            stamp_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // path_groupBox
            // 
            path_groupBox.Controls.Add(subsection_table_path_label);
            path_groupBox.Controls.Add(graphic_path_label);
            path_groupBox.Controls.Add(header_path_label);
            path_groupBox.Controls.Add(output_path_label);
            path_groupBox.Controls.Add(input_path_label);
            path_groupBox.Controls.Add(subsection_table_path);
            path_groupBox.Controls.Add(select_subsection_table_btn);
            path_groupBox.Controls.Add(graphic_path);
            path_groupBox.Controls.Add(select_graphic_btn);
            path_groupBox.Controls.Add(header_path);
            path_groupBox.Controls.Add(select_header_dir);
            path_groupBox.Controls.Add(output_dir_path);
            path_groupBox.Controls.Add(select_output_dir_btn);
            path_groupBox.Controls.Add(input_dir_path);
            path_groupBox.Controls.Add(select_input_dir_btn);
            path_groupBox.Location = new Point(12, 12);
            path_groupBox.Name = "path_groupBox";
            path_groupBox.Size = new Size(600, 172);
            path_groupBox.TabIndex = 30;
            path_groupBox.TabStop = false;
            path_groupBox.Text = "Пути к директориям и файлам";
            // 
            // subsection_table_path_label
            // 
            subsection_table_path_label.AutoSize = true;
            subsection_table_path_label.Location = new Point(6, 146);
            subsection_table_path_label.Name = "subsection_table_path_label";
            subsection_table_path_label.Size = new Size(126, 15);
            subsection_table_path_label.TabIndex = 44;
            subsection_table_path_label.Text = "Таблица подразедлов";
            // 
            // graphic_path_label
            // 
            graphic_path_label.AutoSize = true;
            graphic_path_label.Location = new Point(6, 117);
            graphic_path_label.Name = "graphic_path_label";
            graphic_path_label.Size = new Size(95, 15);
            graphic_path_label.TabIndex = 43;
            graphic_path_label.Text = "Файл graphic.lyt";
            // 
            // header_path_label
            // 
            header_path_label.AutoSize = true;
            header_path_label.Location = new Point(6, 89);
            header_path_label.Name = "header_path_label";
            header_path_label.Size = new Size(113, 15);
            header_path_label.TabIndex = 42;
            header_path_label.Text = "Файл с заголовком";
            // 
            // output_path_label
            // 
            output_path_label.AutoSize = true;
            output_path_label.Location = new Point(6, 60);
            output_path_label.Name = "output_path_label";
            output_path_label.Size = new Size(128, 15);
            output_path_label.TabIndex = 41;
            output_path_label.Text = "Папка с результатами";
            // 
            // input_path_label
            // 
            input_path_label.AutoSize = true;
            input_path_label.Location = new Point(7, 31);
            input_path_label.Name = "input_path_label";
            input_path_label.Size = new Size(127, 15);
            input_path_label.TabIndex = 40;
            input_path_label.Text = "Папка с исходниками";
            // 
            // subsection_table_path
            // 
            subsection_table_path.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            subsection_table_path.Location = new Point(139, 143);
            subsection_table_path.Name = "subsection_table_path";
            subsection_table_path.ReadOnly = true;
            subsection_table_path.Size = new Size(373, 19);
            subsection_table_path.TabIndex = 39;
            // 
            // select_subsection_table_btn
            // 
            select_subsection_table_btn.Location = new Point(519, 142);
            select_subsection_table_btn.Name = "select_subsection_table_btn";
            select_subsection_table_btn.Size = new Size(75, 23);
            select_subsection_table_btn.TabIndex = 38;
            select_subsection_table_btn.Text = "Выбрать";
            select_subsection_table_btn.UseVisualStyleBackColor = true;
            select_subsection_table_btn.Click += select_subsection_table_btn_Click;
            // 
            // graphic_path
            // 
            graphic_path.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            graphic_path.Location = new Point(139, 114);
            graphic_path.Name = "graphic_path";
            graphic_path.ReadOnly = true;
            graphic_path.Size = new Size(374, 19);
            graphic_path.TabIndex = 37;
            // 
            // select_graphic_btn
            // 
            select_graphic_btn.Location = new Point(519, 114);
            select_graphic_btn.Name = "select_graphic_btn";
            select_graphic_btn.Size = new Size(75, 23);
            select_graphic_btn.TabIndex = 36;
            select_graphic_btn.Text = "Выбрать";
            select_graphic_btn.UseVisualStyleBackColor = true;
            select_graphic_btn.Click += select_graphic_btn_Click;
            // 
            // header_path
            // 
            header_path.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            header_path.Location = new Point(139, 85);
            header_path.Name = "header_path";
            header_path.ReadOnly = true;
            header_path.Size = new Size(374, 19);
            header_path.TabIndex = 35;
            // 
            // select_header_dir
            // 
            select_header_dir.Location = new Point(519, 85);
            select_header_dir.Name = "select_header_dir";
            select_header_dir.Size = new Size(75, 23);
            select_header_dir.TabIndex = 34;
            select_header_dir.Text = "Выбрать";
            select_header_dir.UseVisualStyleBackColor = true;
            select_header_dir.Click += select_header_dir_Click;
            // 
            // output_dir_path
            // 
            output_dir_path.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            output_dir_path.Location = new Point(140, 56);
            output_dir_path.Name = "output_dir_path";
            output_dir_path.ReadOnly = true;
            output_dir_path.Size = new Size(373, 19);
            output_dir_path.TabIndex = 33;
            // 
            // select_output_dir_btn
            // 
            select_output_dir_btn.Location = new Point(519, 56);
            select_output_dir_btn.Name = "select_output_dir_btn";
            select_output_dir_btn.Size = new Size(75, 23);
            select_output_dir_btn.TabIndex = 32;
            select_output_dir_btn.Text = "Выбрать";
            select_output_dir_btn.UseVisualStyleBackColor = true;
            select_output_dir_btn.Click += select_output_dir_btn_Click;
            // 
            // input_dir_path
            // 
            input_dir_path.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            input_dir_path.Location = new Point(139, 27);
            input_dir_path.Name = "input_dir_path";
            input_dir_path.ReadOnly = true;
            input_dir_path.Size = new Size(374, 19);
            input_dir_path.TabIndex = 31;
            // 
            // select_input_dir_btn
            // 
            select_input_dir_btn.Location = new Point(519, 27);
            select_input_dir_btn.Name = "select_input_dir_btn";
            select_input_dir_btn.Size = new Size(75, 23);
            select_input_dir_btn.TabIndex = 30;
            select_input_dir_btn.Text = "Выбрать";
            select_input_dir_btn.UseVisualStyleBackColor = true;
            select_input_dir_btn.Click += select_input_dir_btn_Click;
            // 
            // stamp_groupBox
            // 
            stamp_groupBox.Controls.Add(approved_label);
            stamp_groupBox.Controls.Add(controller_label);
            stamp_groupBox.Controls.Add(revisor_label);
            stamp_groupBox.Controls.Add(developer_label);
            stamp_groupBox.Controls.Add(developer);
            stamp_groupBox.Controls.Add(revisor);
            stamp_groupBox.Controls.Add(approved);
            stamp_groupBox.Controls.Add(controlled);
            stamp_groupBox.Location = new Point(12, 190);
            stamp_groupBox.Name = "stamp_groupBox";
            stamp_groupBox.Size = new Size(301, 151);
            stamp_groupBox.TabIndex = 32;
            stamp_groupBox.TabStop = false;
            stamp_groupBox.Text = "Основная надпись";
            // 
            // approved_label
            // 
            approved_label.AutoSize = true;
            approved_label.Location = new Point(7, 120);
            approved_label.Name = "approved_label";
            approved_label.Size = new Size(73, 15);
            approved_label.TabIndex = 8;
            approved_label.Text = "Утверждено";
            // 
            // controller_label
            // 
            controller_label.AutoSize = true;
            controller_label.Location = new Point(6, 91);
            controller_label.Name = "controller_label";
            controller_label.Size = new Size(98, 15);
            controller_label.TabIndex = 7;
            controller_label.Text = "Нормоконтроль";
            // 
            // revisor_label
            // 
            revisor_label.AutoSize = true;
            revisor_label.Location = new Point(7, 62);
            revisor_label.Name = "revisor_label";
            revisor_label.Size = new Size(63, 15);
            revisor_label.TabIndex = 6;
            revisor_label.Text = "Проверил";
            // 
            // developer_label
            // 
            developer_label.AutoSize = true;
            developer_label.Location = new Point(7, 33);
            developer_label.Name = "developer_label";
            developer_label.Size = new Size(70, 15);
            developer_label.TabIndex = 5;
            developer_label.Text = "Разработал";
            // 
            // developer
            // 
            developer.Location = new Point(140, 30);
            developer.Name = "developer";
            developer.Size = new Size(151, 23);
            developer.TabIndex = 4;
            // 
            // revisor
            // 
            revisor.Location = new Point(140, 59);
            revisor.Name = "revisor";
            revisor.Size = new Size(151, 23);
            revisor.TabIndex = 3;
            // 
            // approved
            // 
            approved.Location = new Point(139, 117);
            approved.Name = "approved";
            approved.Size = new Size(151, 23);
            approved.TabIndex = 1;
            // 
            // controlled
            // 
            controlled.Location = new Point(139, 88);
            controlled.Name = "controlled";
            controlled.Size = new Size(151, 23);
            controlled.TabIndex = 0;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(455, 406);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(157, 23);
            save_btn.TabIndex = 33;
            save_btn.Text = "Сохранить";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(292, 406);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(157, 23);
            reset_btn.TabIndex = 34;
            reset_btn.Text = "Сбросить по умолчанию";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(reset_btn);
            Controls.Add(save_btn);
            Controls.Add(stamp_groupBox);
            Controls.Add(path_groupBox);
            MaximumSize = new Size(640, 480);
            MinimumSize = new Size(640, 480);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СПО \"Конвертер\" - Настройки";
            FormClosing += SettingsForm_FormClosing;
            path_groupBox.ResumeLayout(false);
            path_groupBox.PerformLayout();
            stamp_groupBox.ResumeLayout(false);
            stamp_groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox path_groupBox;
        private Label subsection_table_path_label;
        private Label graphic_path_label;
        private Label header_path_label;
        private Label output_path_label;
        private Label input_path_label;
        private TextBox subsection_table_path;
        private Button select_subsection_table_btn;
        private TextBox graphic_path;
        private Button select_graphic_btn;
        private TextBox header_path;
        private Button select_header_dir;
        private TextBox output_dir_path;
        private Button select_output_dir_btn;
        private TextBox input_dir_path;
        private Button select_input_dir_btn;
        private GroupBox stamp_groupBox;
        private Label approved_label;
        private Label controller_label;
        private Label revisor_label;
        private Label developer_label;
        private TextBox developer;
        private TextBox revisor;
        private TextBox approved;
        private TextBox controlled;
        private Button save_btn;
        private Button reset_btn;
    }
}