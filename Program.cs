using SpcConverter.Common.Utils;
using SpcConverter.Forms;

namespace SpcConverter
{
    /// <summary>
    /// ����� ������������� ��� '���������'.
    /// </summary>
    internal static class Program
    {
       
        /// <summary>
        /// ����� ����� � ���������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit!);

            ApplicationLogger.Log("��� '���������' ���� ��������!");

            //������������� ����������.
            InitializeDirs();

            //�������� ��������.
            SettingsManager settingsManager = SettingsManager.GetInstance();
            if (settingsManager.LoadCommonSettings())
            {
                Application.Run(new MainForm());
            }
        }

        /// <summary>
        /// ����� ��� �������� � �������� ����������� ��� ������ ��� "���������" ����������.
        /// </summary>
        private static void InitializeDirs()
        {
            try
            {
                //������������� ����� ��� ����������� ������ ��� "���������".
                var logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\logs");
                if (!Directory.Exists(logPath))
                    Directory.CreateDirectory(logPath);

                //������������� ����� ��� ���������� ���������� ��� "���������".
                var exceptionPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\exceptions");
                if (!Directory.Exists(exceptionPath))
                    Directory.CreateDirectory(exceptionPath);

                //������������� ����� ��� ���������� ���������� ��� "���������".
                var settingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quanttelecom\\SpcConverter\\settings");
                if (!Directory.Exists(settingsPath))
                    Directory.CreateDirectory(settingsPath);

                ApplicationLogger.Log("������������� ����������, ����������� ��� ������ ��� '���������' ������ �������.");
            }
            catch (Exception exception)
            {
                ApplicationLogger.Log("���������� � �������� ������������� ����������, ����������� ��� ������ ��� '���������'", Level.ERROR);
                ApplicationLogger.SaveExceptionReport(exception);
            }
        }

        /// <summary>
        /// ����� ��� ��������� ������� �������� ���������� ������ ��� "���������".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            ApplicationLogger.Log("��� '���������' ���� �����������!\n");
            ApplicationLogger.Flush();
        }
    }
}