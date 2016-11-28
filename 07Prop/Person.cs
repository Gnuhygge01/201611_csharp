using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Prop
{

    class Dyr {
        // nej....
        //public int AntalBen;

        private string id;

        public string Id
        {
            get { return id; }
            set {
                id = value;
            }
        }
        //public string Id { get; set; }

        private string navn;

        public string Navn
        {
            get
            {
                return navn;

            }
            set
            {
                navn = value;
            }
        }

    }

    class Bil
    {
        private string model;

       public string Model
        {
            get {

                return model.ToUpper();

            }
            set {
                if (value.Length < 2)
                    throw new ApplicationException("Forkert model");

                model = value;

            }
        }




        public string Get_Model() {
            return this.model.ToUpper();
        }

        public void Set_Model(string value) {
            if (value.Length < 2)
                throw new ApplicationException("Forkert model");
            this.model = value;
        }
    }
}
