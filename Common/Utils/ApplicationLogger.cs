using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Common.Utils
{
    /// <summary>
    /// Перечисление возможных уровней важности лога.
    /// </summary>
    public enum Level { TRACE, DEBUG, INFO, WARN, ERROR };

    /// <summary>
    /// Статический класс, логирующий процесс работы СПО "Конвертер".
    /// </summary>
    public static class ApplicationLogger
    {
        /// <summary>
        /// Буфер логгера.
        /// </summary>
        private static List<string> buffer = new List<string>();

        /// <summary>
        /// Метод для логирования единичного лога.
        /// </summary>
        /// <param name="log">Сообщение лога.</param>
        /// <param name="level">Уровень важности лога</param>
        public static void Log(string log, Level level = Level.INFO)
        {
            try
            {
                string timestamp = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss:ff");

                switch (level)
                {
                    case Level.TRACE:
                        buffer.Add($"TRACE - {timestamp} - {log}");
                        break;
                    case Level.DEBUG:
                        buffer.Add($"DEBUG - {timestamp} - {log}");
                        break;
                    case Level.INFO:
                        buffer.Add($"INFO - {timestamp} - {log}");
                        break;
                    case Level.WARN:
                        buffer.Add($"WARN - {timestamp} - {log}");
                        Flush();
                        break;
                    case Level.ERROR:
                        buffer.Add($"ERROR - {timestamp} - {log}");
                        Flush();
                        break;
                }

                if (buffer.Count == 100)
                    Flush();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Метод для сохранения отчета об исключени.
        /// </summary>
        /// <param name="exception">Исключение.</param>
        public static void SaveExceptionReport(Exception exception)
        {
            try
            {
                var fileName = $"{DateTime.Now.ToString("ddMMyyyyHHssmmff")}.converterException";
                var dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\exceptions");
                var filePath = $"{dirPath}\\{fileName}";

                string report = string.Join(Environment.NewLine,
                                $"Дата и время: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss:ff")}",
                                $"",
                                $"Сообщение:",
                                $"{exception.Message}",
                                "",
                                $"Стек:",
                                $"{exception.StackTrace}");

                File.WriteAllText(filePath, report);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Метод для записи буфера логгера в файл.
        /// </summary>
        public static void Flush()
        {
            try
            {
                var fileName = $"{DateTime.Now.ToString("ddMMyyyy")}.converterlog";
                var dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\logs");
                var filePath = $"{dirPath}\\{fileName}";

                File.AppendAllLines(filePath, buffer);
                buffer.Clear();

            }
            catch (Exception) { }
        }
    }
}
