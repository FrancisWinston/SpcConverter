using SpcConverter.Common.Utils;
using SpcConverter.Forms;

namespace SpcConverter
{
    /// <summary>
    /// Класс представление СПО 'Конвертер'.
    /// </summary>
    internal static class Program
    {
       
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit!);

            ApplicationLogger.Log("СПО 'Конвертер' было запущено!");

            //Инициализация директорий.
            InitializeDirs();

            //Загрузка настроек.
            SettingsManager settingsManager = SettingsManager.GetInstance();
            if (settingsManager.LoadCommonSettings())
            {
                Application.Run(new MainForm());
            }
        }

        /// <summary>
        /// Метод для проверки и создания необходимых для работы СПО "Конвертер" директорий.
        /// </summary>
        private static void InitializeDirs()
        {
            try
            {
                //Инициализация папки для логирования работы СПО "Конвертер".
                var logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\logs");
                if (!Directory.Exists(logPath))
                    Directory.CreateDirectory(logPath);

                //Инициализация папки для сохранения исключений СПО "Конвертер".
                var exceptionPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\exceptions");
                if (!Directory.Exists(exceptionPath))
                    Directory.CreateDirectory(exceptionPath);

                //Инициализация папки для сохранения параметров СПО "Конвертер".
                var settingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\settings");
                if (!Directory.Exists(settingsPath))
                    Directory.CreateDirectory(settingsPath);

                ApplicationLogger.Log("Инициализация директорий, необходимых для работы СПО 'Конвертер' прошла успешно.");
            }
            catch (Exception exception)
            {
                ApplicationLogger.Log("Исключение в процессе инициализации директорий, необходимых для работы СПО 'Конвертер'", Level.ERROR);
                ApplicationLogger.SaveExceptionReport(exception);
            }
        }

        /// <summary>
        /// Метод для обработки события штатного завершения работы СПО "Конвертер".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            ApplicationLogger.Log("СПО 'Конвертер' было остановлено!\n");
            ApplicationLogger.Flush();
        }
    }
}