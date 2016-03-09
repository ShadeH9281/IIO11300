using System;
using System.Collections.Generic;
using System.Data; //ADO perusluokat
using System.Data.SqlClient; //SQL servua varten
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H7ADOConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //1 Luodaan yhteys
                string connStr = GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    //avataan
                    conn.Open();
                    //2 tehdään SQl kysely
                    string sql = "SELECT asioid, lastname, firstname FROM Presences";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //3 käsitellään tulos (Datareader-olio)
                    SqlDataReader rdr = cmd.ExecuteReader();
                    //käydään reader olio
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            Console.WriteLine("Läsnäolosi {0} {1} {2}",
                                rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));
                        }
                        Console.WriteLine("Tiedot haettu onnistuneesti");
                    }
                    rdr.Close();
                    conn.Close();
                    Console.WriteLine("Yhteys suljettu onnistuneesti");
                }
               
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }


        private static string GetConnectionString()
        {
            return H7ADOConsoleDemo.Properties.Settings.Default.Tietokanta;
        }

    }

}
