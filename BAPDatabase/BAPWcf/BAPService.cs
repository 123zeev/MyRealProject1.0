using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAPDatabase;
using System.ServiceModel;

namespace BAPWcf
{
    public class BAPService : IBAPService
    {
        PlayerDB pdb = new PlayerDB();

        //Player Methods
        public PlayerList SelectAllPlayers()
        {
            return pdb.SelectAll();
        }
    }
}
