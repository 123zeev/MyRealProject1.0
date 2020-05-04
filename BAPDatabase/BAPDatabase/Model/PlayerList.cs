using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BAPDatabase
{
    [CollectionDataContract]
    public class PlayerList : List<Player>
    {

    }
}
