using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Program
{
    public class Departement
    {
        int _NumDep;
        string _NomDep;
        string _Lieu;
        public int NumDep
        {
            get { return _NumDep; }
            set { _NumDep = value; }
        }
        public string NomDep
        {
            get { return _NomDep; }
            set { _NomDep = value; }
        }
        public string Lieu
        {
            get { return _Lieu; }
            set { _Lieu = value; }
        }
        public Departement()
        {}
        public Departement(DataRow dr)
        {
            NumDep = (int)dr["NumDep"];
            NomDep = (string)dr["NomDep"];
            Lieu = (string)dr["Lieu"];
        }
        public static List<Departement> GetDep(DataTable dt)
        {
            List<Departement> ListeDep = new List<Departement>();
            foreach(DataRow dr in dt.Rows)
                ListeDep.Add(new Departement(dr));
            return ListeDep;
        }
    }
}
