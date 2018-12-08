using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCamilla.Classes
{
    public class Log
    {
        private int id;
        private string description;
        private DateTime date;
        private string type;



        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Log(string description, DateTime date, string type)
        {
            this.Description = description;
            this.Date = date;
            this.Type = type;
        }

        public Log()
        {
            
        }

        public Log(int id, string description, DateTime date, string type)
        {
            this.Id = id;
            this.Description = description;
            this.Date = date;
            this.Type = type;
        }

        public static void SalvarLog(string description, DateTime date, string type)
        {
            string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            //Conectar
            sqlConnect.Open();
            string sql = "INSERT INTO LOG (DESCRIPTION, DATE, TYPE) VALUES (@description, @date, @type)";
            //string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (" 
            //    + this.tbxName.Text + "," + this.cbxActive.Checked + ")";

            SqlCommand cmd = new SqlCommand(sql, sqlConnect);

            cmd.Parameters.Add(new SqlParameter("@description", description));
            cmd.Parameters.Add(new SqlParameter("@date", date));
            cmd.Parameters.Add(new SqlParameter("@type", type));
            cmd.ExecuteNonQuery();

        }
    }
}
