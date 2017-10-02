using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Program
{
    public class DALProjet
    {
        public static void Insert(Projet p)
        {
            ProgramMain.bdconx.Open();
            string s = "Insert Into Projet Values (" + p.CodeP + ",'" + p.NomP + "')";
            SqlCommand cmd = new SqlCommand(s,ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();

        }
        public static void Update(Projet OldP,Projet NewP)
        {
            ProgramMain.bdconx.Open();
            string s = "Update Projet SET CodeP=" + NewP.CodeP + ",NomP='" + NewP.NomP + "' WHERE CodeP=" + OldP.CodeP;
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Update(int OldCodeP,Projet NewP)
        {
            ProgramMain.bdconx.Open();
            string s = "Update Projet SET CodeP=" + NewP.CodeP + ",NomP='" + NewP.NomP + "' WHERE CodeP=" + OldCodeP;
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Delete(Projet p)
        {
            ProgramMain.bdconx.Open();
            string s = "Delete From Projet where CodeP=" + p.CodeP;
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();
        }
        public static void Delete(int CodeP)
        {
            ProgramMain.bdconx.Open();
            string s = "Delete From Projet where CodeP=" +CodeP;
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            cmd.ExecuteNonQuery();
            ProgramMain.bdconx.Close();

        }
        public static void Affiche()//all
        {
            ProgramMain.bdconx.Open();
            string s = "select * from Projet";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            SqlDataReader rd = cmd.ExecuteReader();
            int a;
            string b;
            if(rd!=null)
            {
                while(rd.Read())
                {
                    //Console.WriteLine((string)rd[0]+(string)rd[1]);
                    a=(int)rd["CodeP"];
                    b=(string)rd["NomP"];
                    Console.WriteLine(a +"  "+ b);
                }
            }
            ProgramMain.bdconx.Close();
        }
     /*   public static List<Projet> Affiche()
        {
            ProgramMain.bdconx.Open();
            string s = "Select * from Projet";
            SqlCommand cmd = new SqlCommand(s, ProgramMain.bdconx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Projet");
            da.Fill(dt);
            if(dt!=null)
            {
                if(dt.Rows.Count!=0)
                {
                    return (Projet.GetProjet(dt));
                }
            }
            ProgramMain.bdconx.Close();
        }*/
        
        public static void Affiche(int CodeP)// a l'aide de CodeP saisie  par l User 
        {

        }
        public static void Affiche(string NomP)//a l'aide de NomP saisie par l uSER 
        {

        }
    }
}
