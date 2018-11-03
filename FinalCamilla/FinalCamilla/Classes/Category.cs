using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCamilla.Classes
{
    public class Category
    {
        private int id;
        private string name;
        private bool active;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }

        public Category(string name, bool active)
        {
            this.Name = name;
            this.Active = active;
        }

        public Category()
        {
            
        }

        public Category(int id, string name, bool active)
        {
            this.Id = id;
            this.Name = name;
            this.Active = active;
        }
    }
}
