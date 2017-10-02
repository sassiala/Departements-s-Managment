using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient ;
namespace Program
{
    

    public class ProgramMain
    {

        static public SqlConnection bdconx;
        //methode connection 
        static public SqlConnection DataConx()
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=PC-ALA\SQLEXPRESS;
                                                    Initial Catalog=DataBase;
                                                    Integrated Security=True");
            return cnx;

        }
        static void Main(string[] args)
        {
            bdconx = DataConx();
        }
    }
}
