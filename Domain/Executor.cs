using SpcConverter.Domain.Models.ExcelModels;
using SpcConverter.Domain.Models.KompasModels;
using SpcConverter.Forms;
using System;
using System.Collections.Generic;
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
            return null;
        }

        private List<InputDocument> ReadInput(List<string> inputFileNames)
        {
            return null;
        }

        private HeaderDocument ReadHeader()
        {
            return null;
        }

        private Specification ConvertToSpecification(List<InputDocument> inputDocuments, HeaderDocument headerDocument)
        {
            return null;
        }

        private Listing ConvertToListing(List<InputDocument> inputDocuments, HeaderDocument headerDocument)
        {
            return null;
        }

        private Statement ConvertToStatement(List<InputDocument> inputDocuments, HeaderDocument headerDocument)
        {
            return null;
        }

        private void CreateSpcFiles(Specification specification, Listing listing, Statement statement)
        {

        }

        public void Execute(bool createListing, bool createSpecification, bool createStatement)
        {
            try
            {
                //
                List<string> inputFileNames = SearchForInput();
                //
                List<InputDocument> inputDocuments = ReadInput(inputFileNames);
                //
                HeaderDocument headerDocument= ReadHeader();


                Specification specification = null;
                Listing listing = null;
                Statement statement = null;

                //
                if(createSpecification)
                    specification = ConvertToSpecification(inputDocuments, headerDocument);
                //
                if(createListing)
                    listing = ConvertToListing(inputDocuments, headerDocument);
                //
                if(createStatement)
                    statement = ConvertToStatement(inputDocuments, headerDocument);
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
