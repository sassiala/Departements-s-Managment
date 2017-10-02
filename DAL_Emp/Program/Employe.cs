using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Program
{
    public class Employe
    {
        int _Matr;
        string _NomE;
        string _Post;
        DateTime _DateEmb;
        int _Sup;
        int _Salaire;
        int _Comm;
        int _NumDep;
        public int Matr
        {
            get { return _Matr; }
            set { _Matr = value; }
        }
        public string NomE
        {
            get { return _NomE; }
            set { _NomE = value; }
        }
        public int Salaire
        {
            get { return _Salaire; }
            set { _Salaire = value; }
        }
        public string Post
        {
            get { return _Post; }
            set { _Post = value; }
        }
        public DateTime DateEmb
        {
            get { return _DateEmb; }
            set { _DateEmb = value; }
        }
        public int Sup
        {
            get { return _Sup; }
            set { _Sup = value; }
        }
        public int Comm
        {
            get { return _Comm; }
            set { _Comm = value; }
        }
        public int NumDep
        {
            get { return _NumDep; }
            set { _NumDep = value; }
        }
        public Employe()
        {

        }
        public Employe(DataRow dr)
        {
            Matr = (int)dr["Matr"];
            NomE = (string)dr["NomE"];
            Salaire = (int)dr["Salaire"];
            Post = (string)dr["Post"];
            DateEmb = (DateTime)dr["DateEmb"];
            Sup = (int)dr["Sup"];
            Comm = (int)dr["Comm"];
            NumDep = (int)dr["NumDep"];
        }
        public static List<Employe> GetEmp(DataTable dt)
        {
            List<Employe> ListEmp = new List<Employe>();
            foreach (DataRow dr in dt.Rows)
                ListEmp.Add(new Employe(dr));
            return ListEmp;
        }
        
    }
}
