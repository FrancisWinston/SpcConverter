using Microsoft.Data.Sqlite;
using Microsoft.Win32.SafeHandles;
using SpcConverter.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Common.Utils
{
    /// <summary>
    /// Singleton класс для работы с настройками программы и настройками пользователей.
    /// </summary>
    public class SettingsManager
    {
        /// <summary>
        /// Ссылка на экземпляр класса.
        /// </summary>
        private static SettingsManager? instance = null;

        /// <summary>
        /// Ссылка на общие настройки программы.
        /// </summary>
        private CommonSettings? commonSettings = null;

        /// <summary>
        /// Приватный конструктор класса.
        /// </summary>
        private SettingsManager()
        {
            try
            {
                string settingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\settings");

                using (var connection = new SqliteConnection($"Data Source={settingsPath}\\commonsettings.db"))
                {
                    connection.Open();

                    SqliteCommand command = new SqliteCommand();
                    command.Connection = connection;
                    command.CommandText = "CREATE TABLE IF NOT EXISTS Params(Key TEXT NOT NULL PRIMARY KEY UNIQUE, Value TEXT)";
                    command.ExecuteNonQuery();
                }


            }
            catch (Exception exception)
            {
                ApplicationLogger.Log("Исключение в процессе инициализации загрузчика настроек!", Level.ERROR);
                ApplicationLogger.SaveExceptionReport(exception);
            }
        }

        /// <summary>
        /// Метод для получения экземпляра класса SettingsManager.
        /// </summary>
        /// <returns>Экземпляр класса SettingsManager.</returns>
        public static SettingsManager GetInstance()
        {
            if (instance == null)
                instance = new SettingsManager();

            return instance;
        }

        /// <summary>
        /// Метод для загрузки общих настроек программы.
        /// </summary>
        public bool LoadCommonSettings()
        {
            bool result = false;

            try
            {
                commonSettings = new CommonSettings();

                string settingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\settings");

                //Подключение к базе данных с настройками.
                using (var connection = new SqliteConnection($"Data Source={settingsPath}\\commonsettings.db"))
                {
                    connection.Open();

                    //Получение данных из базы.
                    SqliteCommand command = new SqliteCommand("SELECT * FROM Params", connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string key = (string)reader["Key"];
                                string value = (string)reader["Value"];

                                commonSettings.Parse(key, value);
                            }
                        }
                    }
                }

                if (!commonSettings.IsValid())
                {
                    commonSettings.SetDefault();
                }

                return true;
            }
            catch (Exception exception)
            {
                ApplicationLogger.Log("Исключение в процессе загрузки общих настроек программы!", Level.ERROR);
                ApplicationLogger.SaveExceptionReport(exception);
            }

            return result;
        }

        /// <summary>
        /// Метод для получения объекта с настройками программы.
        /// </summary>
        /// <returns>Объект - контейнер настроек программы.</returns>
        /// <exception cref="Exception">Исключение, создаваемое при попытке получить незагруженные настройки.</exception>
        public CommonSettings GetCommonSettings()
        {
            if (commonSettings == null)
                throw new Exception("Настройки программы не были загружены!");

            return commonSettings;
        }

        /// <summary>
        /// Метод для сохранения настроек программы.
        /// </summary>
        public bool SaveCommonSettings()
        {
            bool result = false;

            if (commonSettings != null)
            {
                try
                {
                    string settingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\settings");

                    //Подключение к базе данных с настройками.
                    using (var connection = new SqliteConnection($"Data Source={settingsPath}\\commonsettings.db"))
                    {
                        connection.Open();

                        foreach (string key in commonSettings.editedParams)
                        {
                            string? value = commonSettings.Get(key)!.ToString();
                            if (value != null)
                            {
                                SqliteCommand command1 = new SqliteCommand();
                                command1.Connection = connection;
                                command1.CommandText = $"UPDATE Params SET Value='{value}' where Key='{key}'";
                                int command1_result =  command1.ExecuteNonQuery();

                                if (command1_result == 0)
                                {
                                    SqliteCommand command2 = new SqliteCommand();
                                    command2.Connection = connection;
                                    command2.CommandText = $"INSERT INTO Params VALUES ('{key}', '{value}');";
                                    command2.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    result = true;
                }
                catch (Exception exception)
                {
                    ApplicationLogger.Log("Исключение в процессе сохранения общих настроек программы!", Level.ERROR);
                    ApplicationLogger.SaveExceptionReport(exception);
                }
            }

            return result;
        }
    }
}
