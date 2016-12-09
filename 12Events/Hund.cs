using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _12Events
{
    class Hund 
    {

        public event EventHandler<MyEventArgs> PropertyChanged;
        private int age;

        public int Age
        {
            get { return age; }
            set {
                OnPropertyChanged();
                age = value; }
        }

        
        private string name;

        [Required]
        [StringLength(50, ErrorMessage ="Forkert streng")]
        //[Display(Name = "navn", ResourceType = typeof()]
        public string Name
        {
            get { return name; }
            set {
                OnPropertyChanged();
                name = value; }
        }

        private void OnPropertyChanged([CallerMemberName]string name = null) {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new MyEventArgs() { PropName = name });
            }
        }
    }
}
