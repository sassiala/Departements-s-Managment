using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Program
{
    public class DALParticipation
    {
        public static void Insert(Participation P)
        {
            ProgramMain.bdconx.Open();
            string s = "Insert Into Participation Values ("+P.Matr+","+P.CodeP+",'"+P.Fonction+"')";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            ProgramMain.bdconx.Close();
        }
        public static void Update(Participation OldP, Participation NewP)
        {
            ProgramMain.bdconx.Open();
            string s = "Update Participation Set Matr="+NewP.Matr+",CodeP="+NewP.CodeP+",Fonction="+NewP.Fonction+" where Matr="+OldP.Matr+";";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            ProgramMain.bdconx.Close();
        }
        public static void Update(int Matr,Participation NewP)
        {
            ProgramMain.bdconx.Open();
            string s = "Update Participation Set Matr=" + NewP.Matr + ",CodeP=" + NewP.CodeP + ",Fonction=" + NewP.Fonction + " where Matr=" + Matr + ";";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            ProgramMain.bdconx.Close();
        }
        public static void Delete(Participation P)
        {
            ProgramMain.bdconx.Open();
            string s = "Delete From Participation where Matr="+P.Matr+";";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            ProgramMain.bdconx.Close();
        }
        public static void Delete(int Matr)
        {
            ProgramMain.bdconx.Open();
            string s = "Delete From Participation where Matr=" + Matr + ";";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            ProgramMain.bdconx.Close();
        }
        public static void Affiche()//all
        {
            ProgramMain.bdconx.Open();
            string s = "select * from Participation";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            SqlDataReader rd = cmd.ExecuteReader();
            int Matr;
            int NumP;
            string f;
            if(rd!=null)
            {
                while(rd.Read())
                {
                    Matr = (int)rd[0];
                    NumP = (int)rd[1];
                    f = (string)rd[2];
                    Console.WriteLine(Matr + " " + NumP + " " + f);
                }
            }
            ProgramMain.bdconx.Close();
        }
        public static void Affiche(int Matr)
        {

        }
/*public static void Affiche(int CodeP)
        {

        }*/
        public static void Affiche(string Fonction)
        {

        }
    }
}
