using SpcConverter.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Common.Models
{

    /// <summary>
    /// Класс представление общих настроек программы.
    /// </summary>
    public class CommonSettings
    {
        /// <summary>
        /// Список параметров, которые были отредактированы в ходе работы СПО 'Монитор'.
        /// </summary>
        public List<string> editedParams;

        /// <summary>
        /// Коллекция со всеми параметрами и их значениями.
        /// </summary>
        private Dictionary<string, object> commonParams;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public CommonSettings()
        {
            editedParams = new List<string>();
            commonParams = new Dictionary<string, object>();
        }

        /// <summary>
        /// Метод для парсинга значения в строковом виде
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Parse(string key, string value)
        {
            switch (key)
            {
                /*
                 * input_dir_path.Text = (string)commonSettings.Get("INPUT_DIR")!;
                output_dir_path.Text = (string)commonSettings.Get("OUTPUT_DIR")!;
                header_path.Text = (string)commonSettings.Get("HEADER_PATH")!;
                graphic_path.Text = (string)commonSettings.Get("LYT_PATH")!;
                subsection_table_path.Text = (string)commonSettings.Get("TABLE_PATH")!;
                developer.Text = (string)commonSettings.Get("DEVELOPER")!;
                revisor.Text = (string)commonSettings.Get("REVISOR")!;
                controlled.Text = (string)commonSettings.Get("CONTROLLED")!;
                approved.Text = (string)commonSettings.Get("APPROVED")!;
                 */
                case "VERSION":
                    commonParams["VERSION"] = value;
                    break;
                case "INPUT_DIR":
                    commonParams["INPUT_DIR"] = value;
                    break;
                case "OUTPUT_DIR":
                    commonParams["OUTPUT_DIR"] = value;
                    break;
                case "HEADER_PATH":
                    commonParams["HEADER_PATH"] = value;
                    break;
                case "LYT_PATH":
                    commonParams["LYT_PATH"] = value;
                    break;
                case "TABLE_PATH":
                    commonParams["TABLE_PATH"] = value;
                    break;
                case "DEVELOPER":
                    commonParams["DEVELOPER"] = value;
                    break;
                case "REVISOR":
                    commonParams["REVISOR"] = value;
                    break;
                case "CONTROLLED":
                    commonParams["CONTROLLED"] = value;
                    break;
                case "APPROVED":
                    commonParams["APPROVED"] = value;
                    break;
                default:
                    ApplicationLogger.Log("Обнаружено неизвестное значение в файле общих настроек программы!", Level.WARN);
                    break;
            }
        }

        /// <summary>
        /// Метод для изменения параметра настроек.
        /// </summary>
        /// <param name="key">Имя параметра настроек.</param>
        /// <param name="value">Значение настроек.</param>
        public void Set(string key, object value)
        {
            if (commonParams.ContainsKey(key))
            {
                commonParams[key] = value;
                editedParams.Add(key);
            }
        }

        /// <summary>
        /// Метод для получения параметра настроек.
        /// </summary>
        /// <param name="key">Имя параметра настроек.</param>
        /// <returns>Значение настроек.</returns>
        public object? Get(string key)
        {
            object? value = null;

            if (commonParams.ContainsKey(key))
                value = commonParams[key];

            return value;
        }


        /// <summary>
        /// Метод для валидации общих настроек программы.
        /// </summary>
        /// <returns>Флаг валидности загруженных общих настроек программы.</returns>
        public bool IsValid()
        {
            bool result = true;

            if (!commonParams.ContainsKey("INPUT_DIR") ||
               !commonParams.ContainsKey("OUTPUT_DIR") ||
               !commonParams.ContainsKey("HEADER_PATH") ||
               !commonParams.ContainsKey("LYT_PATH") ||
               !commonParams.ContainsKey("TABLE_PATH") ||
               !commonParams.ContainsKey("DEVELOPER") ||
               !commonParams.ContainsKey("REVISOR") ||
               !commonParams.ContainsKey("CONTROLLED") ||
               !commonParams.ContainsKey("APPROVED"))
            {
                ApplicationLogger.Log("Проверка валидации общих настроек выявила их невалидное состояние!", Level.WARN);
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Метод для установки настроек по умолчанию.
        /// </summary>
        public void SetDefault()
        {
            commonParams.Clear();
            commonParams["VERSION"] = "1.0.0";
            commonParams["INPUT_DIR"] = Application.StartupPath;
            commonParams["OUTPUT_DIR"] = Application.StartupPath;
            commonParams["HEADER_PATH"] = Application.StartupPath;
            commonParams["LYT_PATH"] = Application.StartupPath;
            commonParams["TABLE_PATH"] = Application.StartupPath;
            commonParams["DEVELOPER"] = "";
            commonParams["REVISOR"] = "";
            commonParams["CONTROLLED"] = "";
            commonParams["APPROVED"] = "";
            ApplicationLogger.Log("Установлены общие настройки СПО по умолчанию.");
        }
    }
}
