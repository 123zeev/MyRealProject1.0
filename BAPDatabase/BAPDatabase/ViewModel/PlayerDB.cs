using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BAPDatabase
{
    public class PlayerDB : BaseDB
    {
        public PlayerList PList;
        public PlayerDB()
        {
            PList = new PlayerList();
        }
        public PlayerList SelectAll()
        {
            string query = "SELECT * FROM [Player]";
            base.ExecuteReader(query);
            return PList;
        }

        public Player SelectPlayerByID(int id)
        {
            string query = string.Format("SELECT * FROM [Player] WHERE PlayerID = {0}", id);
            base.ExecuteReader(query);
            if (PList.Count > 0)
                return PList[0];
            return null;
        }

        public Player SelectPlayerByNameAndPassword(string fname, string pass)
        {
            string query = string.Format("SELECT * FROM [Player] WHERE PlayerPrivateName = '{0}' AND PlayerPassward = '{1}'", fname, pass);
            base.ExecuteReader(query);
            if (PList.Count > 0)
                return PList[0];
            return null;
        }

        public void InsertNewPlayer(Player p)
        {
            string query = string.Format("INSERT INTO [Player] () VALUES ('{0}',{1})", p.PlayerPrivateName, p.PlayerAge);
            base.Execute(query);
        }

        public override void CreateModel()
        {
            PList.Clear();
            Player p;
            while (reader.Read())
            {
                p = new Player();
                p.PlayerID = int.Parse(reader["PlayerID"].ToString());
                p.PlayerAge = int.Parse(reader["PlayerAge"].ToString());
                // continue
                p.PlayerPrivateName = reader["PlayerPrivateName"].ToString();
                p.PlayerRememberMe = bool.Parse(reader["PlayerRememberMe"].ToString());
                PList.Add(p);
            }
        }
    }
}
