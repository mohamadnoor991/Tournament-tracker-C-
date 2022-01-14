using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    //TODO - Wire up the CreatePrize for text files.
    /// <summary>
    /// Create the connection to the text file
    /// </summary>
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizesModels.csv";
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the text file and Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizesModels();

            //Find the max ID
            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            //Add the new record with the new ID
            prizes.Add(model);

            // Convert the prizes to List<string>
            // Save the list<string> to the text file 
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
