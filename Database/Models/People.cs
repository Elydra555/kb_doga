using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class People : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string age;
        public string Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged(); }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged(); }
        }

        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; OnPropertyChanged(); }
        }

        private string hobby;

        public People(string line)
        {
        }

        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; OnPropertyChanged(); }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
