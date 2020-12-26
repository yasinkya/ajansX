using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ajans_X.database
{
    class DB_Connection
    {
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataReader dataR;

        public DB_Connection()
        {
            Connect();
        }

        public void Connect()
        {
            connect = new SqlConnection("server=KAYA; Initial Catalog=AjansCs;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection = connect;
        }

        //şifre kontrolü ve kimin giriş yaptı?
        public int PassCheck(string username, string userpass)
        {
            connect.Open();
            cmd.CommandText = "SELECT * FROM kullanicilar WHERE username = '" + username + "' and pass = '" + userpass + "'";
            dataR = cmd.ExecuteReader();

            if (dataR.Read())
            {
                connect.Close(); //çalışmazsa
                return Convert.ToInt32(dataR[2].ToString());
            }
            else
            {
                connect.Close();
                return -1;
            }
        }

        //oyuncuları listeleme
        public List<classes.Actress> ActressesList()
        {
            try
            {
                List<classes.Actress> actresses = new List<classes.Actress>();

                cmd.CommandText = "select * From oyuncu";
                cmd.CommandType = CommandType.Text;
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    classes.Actress data = new classes.Actress();
                    data.Id = Convert.ToInt32(reader[0].ToString());
                    data.Name = reader[1].ToString();
                    data.Surname = reader[2].ToString();
                    data.Salary = Convert.ToInt64(reader[3].ToString());
                    data.Role = reader[4].ToString();
                    data.Status = Convert.ToBoolean(reader[5].ToString());

                    actresses.Add(data);
                }

                return actresses;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        //ofis calisanları listeleme
        public List<classes.OfficeWorker> OfficersList()
        {
            try
            {
                List<classes.OfficeWorker> officer = new List<classes.OfficeWorker>();

                cmd.CommandText = "select * From calisan";
                cmd.CommandType = CommandType.Text;
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    classes.OfficeWorker data = new classes.OfficeWorker();
                    data.Id = Convert.ToInt32(reader[0].ToString());
                    data.Name = reader[1].ToString();
                    data.Surname = reader[2].ToString();
                    data.Salary = Convert.ToInt64(reader[3].ToString());
                    data.Role = reader[4].ToString();
                    data.Status = Convert.ToBoolean(reader[5].ToString());

                    officer.Add(data);
                }

                return officer;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        //işleri listeleme
        public List<classes.Projects> ProjectsList()
        {
            
            try
            {
                List<classes.Projects> projects = new List<classes.Projects>();
                cmd.CommandText = "select * From calisan";
                cmd.CommandType = CommandType.Text;
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    classes.Projects data = new classes.Projects();
                    data.Id = Convert.ToInt32(reader[0].ToString());
                    data.PrjName = reader[1].ToString();
                    data.Start = Convert.ToDateTime(reader[2].ToString());
                    data.Finish = Convert.ToDateTime(reader[3].ToString());
                    data.Price = Convert.ToInt64(reader[4].ToString());
                    data.ActWorker = Convert.ToInt32( reader[5].ToString());
                    data.OfficeWorker = Convert.ToInt32(reader[6].ToString());
                    data.Company = Convert.ToInt32(reader[7].ToString());

                    projects.Add(data);
                }

                return projects;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        //firma listele
        public List<classes.Company> CompaniesList()
        {
            try
            {
                List<classes.Company> companies = new List<classes.Company>();
                cmd.CommandText = "select * From calisan";
                cmd.CommandType = CommandType.Text;
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    classes.Company data = new classes.Company();
                    data.C_Id = Convert.ToInt32(reader[0].ToString());
                    data.Name = reader[1].ToString();
                    data.Adress = reader[2].ToString();
                    data.Contracts = Convert.ToInt32(reader[3].ToString());
                    

                    companies.Add(data);
                }

                return companies;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
    }
}
