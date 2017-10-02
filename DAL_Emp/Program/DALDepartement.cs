using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Program
{
    public class DALDepartement
    {
        public static void Insert(Departement D)
        {
            ProgramMain.bdconx.Open();
            string s = "Insert Into Departement Values (" + D.NumDep + ",'" + D.NomDep + "','" + D.Lieu + "')";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Update(Departement OldD,Departement NewD)
        {
            ProgramMain.bdconx.Open();
            string s = "Update Departement set NumDep="+NewD.NumDep+",NomDep='"+NewD.NomDep+"',Lieu='"+NewD.Lieu+"' where NumDep="+OldD.NumDep+";";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Update(int NumDep, Departement NewD)
        {
            ProgramMain.bdconx.Open();
            string s = "Update Departement set NumDep=" + NewD.NumDep + ",NomDep='" + NewD.NomDep + "',Lieu='" + NewD.Lieu + "' where NumDep=" + NumDep + ";";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Delete(int NumDep)
        {
            ProgramMain.bdconx.Open();
            string s = "Delete From Departement where NumDep="+NumDep;
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void AfficheConsole()//all
        {
            ProgramMain.bdconx.Open();
            int NumDep;
            string NomDep;
            string Lieu;
            string s = "Select * from Departement";

            SqlCommand cmd = new SqlCommand(s,ProgramMain.bdconx);
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd!=null)
            {
                while(rd.Read())
                {
                    NumDep = (int)rd["NumDep"];
                    NomDep = (string)rd["NomDep"];
                    Lieu = (string)rd["Lieu"];
                    Console.WriteLine(NumDep + " " + NomDep + " " + Lieu);
                }
            }
            ProgramMain.bdconx.Close();
        }
        public static void Affiche()
        {

        }
        public static void Affiche(int NumDep)
        {
            ProgramMain.bdconx.Open();

            ProgramMain.bdconx.Close();
        }
        public static void Affiche(string NomDep)
        {
            ProgramMain.bdconx.Open();

            ProgramMain.bdconx.Close();
        }
       /* public static void Affiche(string Lieu)
        {
            Program.bdconx.Open();

            Program.bdconx.Close();
        }*/
    }
}
