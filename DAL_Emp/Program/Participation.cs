using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Program
{
    public class Participation
    {
        int _Matr;
        int _CodeP;
        string _Fonction;
        public int Matr
        {
            get { return _Matr; }
            set { _Matr = value; }
        }
        public int CodeP
        {
            get { return _CodeP; }
            set { _CodeP = value; }
        }
        public string Fonction
        {
            get { return _Fonction; }
            set { _Fonction = value; }
        }
        public Participation()
        {

        }
        public Participation(DataRow dr)
        {
            Matr = (int)dr["Matr"];
            CodeP = (int)dr["CodeP"];
            Fonction = (string)dr["Fonction"];
        }
        public static List<Participation> GetPar(DataTable dt)
        {
            List<Participation> ListPar = new List<Participation>();
            foreach (DataRow dr in dt.Rows)
                ListPar.Add(new Participation(dr));
            return ListPar;
        }
    }
}
