using System;
using System.Collections.Generic;
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

    }
}
