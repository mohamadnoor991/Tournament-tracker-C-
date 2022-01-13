using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// The contract that will be used to make the connection between the form and the data sourse.
    /// </summary>
  public  interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model); /*Method to save and return the data from prizeForm*/

    }
}
