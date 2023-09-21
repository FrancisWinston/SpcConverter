using SpcConverter.Common.Models;
using SpcConverter.Common.Utils;
using SpcConverter.Domain.Converters;
using SpcConverter.Domain.Models.ExcelModels;
using SpcConverter.Domain.Models.KompasModels;
using SpcConverter.Domain.Utils;
using SpcConverter.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Domain
{
    internal class BusinessLogic
    {
        private MainForm mainForm;

        private CommonSettings commonSettings;

    
        public BusinessLogic(MainForm mainForm)
        {
            this.mainForm = mainForm;

            this.commonSettings = SettingsManager.GetInstance().GetCommonSettings();
        }

        /// <summary>
        /// Метод для поиска файлов исходников формата СПО Excel.
        /// </summary>
        /// <returns></returns>
        private List<string> SearchForInput() 
        {
            List<string> output = new List<string>();

            try
            {
                string path = (string)commonSettings.Get("INPUT_DIR")!;
                output.AddRange(Directory.GetFiles(path, searchPattern: "*.xlsx"));

                mainForm.SetInputFileNames(output);
            } catch (Exception exception)
            {
                ApplicationLogger.Log("Исключение в процессе поиска файлов исходников!", Level.ERROR);
                ApplicationLogger.SaveExceptionReport(exception);
            }

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFileNames"></param>
        /// <returns></returns>
        private InputDocument? ReadInput(List<string> inputFileNames)
        {
            InputDocument? output = null;

            try
            {
                
            } catch (Exception exception)
            {
                ApplicationLogger.Log("Исключение в процессе чтения файлов исходников!", Level.ERROR);
                ApplicationLogger.SaveExceptionReport(exception);
            }

            return output;
        }

        private HeaderDocument? ReadHeader()
        {
            HeaderDocument? headerDocument = null;

            try
            {

            } catch(Exception exception)
            {

            }

            return headerDocument;
        }

        private Specification? ConvertToSpecification(InputDocument inputDocument, HeaderDocument? headerDocument)
        {
            Specification? specification = null;

            try
            {
                SpecificationConverter converter = new SpecificationConverter();
            } catch (Exception exception)
            {

            }

            return specification;
        }

        private Listing? ConvertToListing(InputDocument inputDocuments, HeaderDocument? headerDocument)
        {
            Listing? listing = null;

            try
            {
                ListingConverter converter = new ListingConverter();

            } catch (Exception exception)
            {

            }

            return listing;
        }

        private Statement? ConvertToStatement(InputDocument inputDocuments, HeaderDocument? headerDocument)
        {
            Statement? statement = null;

            try
            {
                StatementConverter converter = new StatementConverter();
                
            }
            catch (Exception exception)
            {

            }

            return statement;
        }

        /// <summary>
        /// Метод для создания файлов сконвертированных документов.
        /// </summary>
        /// <param name="specification">Представление спецификации.</param>
        /// <param name="listing">Представление перечня покупных изделий.</param>
        /// <param name="statement">Представление ведомости покупных изделий.</param>
        private void CreateSpcFiles(Specification? specification, Listing? listing, Statement? statement)
        {
            using (KompasUtils kompasUtils = new KompasUtils())
            {
                if (specification != null) 
                    kompasUtils.CreateSpecificationFile(specification);

                if (listing != null)
                    kompasUtils.CreateListingFile(listing);

                if (statement != null)
                    kompasUtils.CreateStatementFile(statement);
            }
        }

        /// <summary>
        /// Метод для запуска основной логики программы - чтения и конвертации исходников в документы СПО Компас 3D.
        /// </summary>
        /// <param name="createListing">Флаг конвертации исходников в перечень покупных изделий.</param>
        /// <param name="createSpecification">>Флаг конвертации исходников в спецификацию.</param>
        /// <param name="createStatement">>Флаг конвертации исходников в ведомость покупных изедлий.</param>
        public void Execute(bool createListing, bool createSpecification, bool createStatement)
        {
            //Получение списка имен файлов исходников.
            List<string> inputFileNames = SearchForInput();
            
            if(inputFileNames.Count != 0)
            {
                //Чтение файлов исходников.
                InputDocument? inputDocument = ReadInput(inputFileNames);

                //Чтение файла заголовка.
                HeaderDocument? headerDocument = ReadHeader();

                if(inputDocument != null && headerDocument != null)
                {
                    //Объявление объектов-представлений целевых документов.
                    Specification? specification = null;
                    Listing? listing = null;
                    Statement? statement = null;

                    //Конвертация в спецификацию.
                    if (createSpecification)
                        specification = ConvertToSpecification(inputDocument, headerDocument);

                    //Конвертация в перечень покупных изделий.
                    if (createListing)
                        listing = ConvertToListing(inputDocument, headerDocument);

                    //Конвретация в ведомость покупных изделий.
                    if (createStatement)
                        statement = ConvertToStatement(inputDocument, headerDocument);

                    //Создание файлов сконвертированных документов.
                    CreateSpcFiles(specification, listing, statement);
                }
            }
        }

        /// <summary>
        /// Метод для редактирования файла-заголовка.
        /// </summary>
        public void EditHeader()
        {

        }
    }
}
