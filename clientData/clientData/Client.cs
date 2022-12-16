using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientData
{
    public class Client
    {
        private string name;
        public string Name
        {
            get { return name; }
            set {
                if (!char.IsUpper(value[0]))
                    throw new System.Exception("Name must start with uppercase letter");
                else
                    name = value; 
            }
                
        }
        
        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                if (!char.IsUpper(value[0]))
                    throw new System.Exception("Surname must start with uppercase letter");
                else
                    surname = value;
            }

        }
        
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (!(value >= 100 && value <= 210))
                    throw new System.Exception("Height must be within 100-210 range");
                else
                    height = value;
            }

        }
    }
}
