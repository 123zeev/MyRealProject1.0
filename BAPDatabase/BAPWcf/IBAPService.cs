using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAPDatabase;
using System.ServiceModel;

namespace BAPWcf
{
    [ServiceContract]
    public interface IBAPService
    {
        // Player Methods
        [OperationContract]
        PlayerList SelectAllPlayers();


    }
}
