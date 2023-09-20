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
    internal class Executor
    {
        private MainForm mainForm;

        public Executor(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private List<string> SearchForInput() 
        {
            List<string> output = new List<string>();

            try
            {

            } catch (Exception exception)
            {

            }

            return output;
        }

        private InputDocument ReadInput(List<string> inputFileNames)
        {
            InputDocument output = new InputDocument();

            try
            {

            } catch (Exception exception)
            {

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
                StatementConverter statementConverter = new StatementConverter();
                //statement = statementConverter.Convert()
            }
            catch (Exception exception)
            {

            }

            return statement;
        }

        private void CreateSpcFiles(Specification? specification, Listing? listing, Statement? statement)
        {
            try
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
            } catch(Exception exception)
            {

            }
        }

        public void Execute(bool createListing, bool createSpecification, bool createStatement)
        {
            try
            {
                //
                List<string> inputFileNames = SearchForInput();
                //
                InputDocument inputDocument = ReadInput(inputFileNames);
                //
                HeaderDocument? headerDocument= ReadHeader();


                Specification? specification = null;
                Listing? listing = null;
                Statement? statement = null;

                //
                if(createSpecification)
                    specification = ConvertToSpecification(inputDocument, headerDocument);
                //
                if(createListing)
                    listing = ConvertToListing(inputDocument, headerDocument);
                //
                if(createStatement)
                    statement = ConvertToStatement(inputDocument, headerDocument);
                //
                CreateSpcFiles(specification, listing, statement);
            }
            catch (Exception exception)
            {

            }
        }

        public void EditHeader()
        {
            try
            {

            } catch (Exception exception)
            {

            }
        }
    }
}
