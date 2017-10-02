using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Program
{
    public class Projet
    {
        int _CodeP;
        public int CodeP
        {
            get { return _CodeP; }
            set { _CodeP = value; }
        }
        string _NomP;
        
        public string NomP
        {
            get { return _NomP; }
            set { _NomP = value; }
        }
        public Projet()
        {
            CodeP = 0;
            NomP = null;
        }
       
        public Projet(DataRow dr)
        {
            CodeP = (int)dr["CodeP"];
            NomP = (string)dr["NomP"];
        }
        public static List<Projet> GetProjet (DataTable dt)
        {
            List<Projet> ListProjet = new List<Projet>();
            foreach (DataRow dr in dt.Rows)
                ListProjet.Add(new Projet(dr));
            return ListProjet;
        }

    }
}













