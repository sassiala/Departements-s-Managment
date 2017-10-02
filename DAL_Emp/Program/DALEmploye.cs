using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Program
{
    public class DALEmploye
    {
        public static void Insert(Employe E)
        {
            ProgramMain.bdconx.Open();
            string s="Insert Into Employe Values ("+E.Matr+",'"+E.NomE+"','"+E.Post+"','"+E.DateEmb+"',"+E.Sup+","+E.Salaire+","+E.Comm+","+E.NumDep+");";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Update(Employe OldE ,Employe NewE)
        {
            ProgramMain.bdconx.Open();
            string s = "Update Employe SET Matr="+NewE.Matr+",NomE="+NewE.NomE+",Post='"+NewE.Post+"',DateEmb='"+NewE.DateEmb+"',Sup="+NewE.Sup+",Salaire="+NewE.Salaire+",Comm="+NewE.Comm+",NumDep="+NewE.NumDep+" where Matr="+OldE.Matr+";";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Update(int OldMatr,Employe NewE)
        {
            ProgramMain.bdconx.Open();
            string s = "Update Employe SET NomE='" + NewE.NomE + "',Post='" + NewE.Post +"',DateEmb='"+NewE.DateEmb+"',Sup=" + NewE.Sup + ",Salaire=" + NewE.Salaire + ",Comm=" + NewE.Comm + ",NumDep=" + NewE.NumDep + " where Matr=" + OldMatr ;
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Delete(int Matr)
        {
            ProgramMain.bdconx.Open();
            string s = "Delete From Employe where Matr=" + Matr;
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Delete(Employe E)
        {
            ProgramMain.bdconx.Open();
            string s = "Delete From Employe where Matr=" + E.Matr + ";";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void AfficheConsole()//all
        {
            ProgramMain.bdconx.Open();
            string s = "Select * from Employe";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            SqlDataReader rd = cmd.ExecuteReader();
            int Matr;
            string NomE;
            string Post;
            DateTime DateEmb;
            int Sup;
            int Salaire;
            int Comm;
            int NumDep;
            if(rd!=null)
            {
                while(rd.Read())
                {
                    
                    Matr = (int)rd["Matr"];
                    NomE = (string)rd["NomE"];
                    Post = (string)rd["Post"];
                    DateEmb = (DateTime)rd["DateEmb"];
                    Sup = (int)rd["Sup"];
                    Salaire = (int)rd["Salaire"];
                    Comm = (int)rd["Comm"];
                    NumDep = (int)rd["NumDep"];
                    Console.WriteLine(Matr + " " + NomE + " " + Post + " " + DateEmb.Day+"/"+DateEmb.Month+"/"+DateEmb.Year+ " " + Sup + " " + Salaire + " " + Comm + " " + NumDep);
                }
            }
            ProgramMain.bdconx.Close();
        }
        public static void Affiche()
        {

        }
        public static void Affiche(int Matr)
        {

        }
        public static void Affiche(string NomE)
        {

        }
      /*  public static void Affiche(int Salaire)
        {

        }
        public static void Affiche(string Post)
        {

        }
        public static void Affiche(string DateEmb)
        {

        }
        public static void Affiche(string Sup)
        {

        }
        public static void Affiche(string Comm)
        {

        }*/
    }
}
