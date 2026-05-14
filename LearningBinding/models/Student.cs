using System;

namespace LearningBinding.models
{
    public class Student : ObservableObject
    {
        private string firstnam;
        public string FirstName
        {
            get { return firstnam; }
            set
            {
                firstnam = value;
                OnPropertyChanged(); 
            }
        }

        private string lastnname;
        public string LastName
        {
            get { return lastnname; }
            set
            {
                lastnname = value;
                OnPropertyChanged();
            }
        }

        private string iimageName;
        public string ImageName
        {
            get { return iimageName; }
            set
            {
                iimageName = value;
                OnPropertyChanged();
            }
        }

        private DateTime birthdate;
        public DateTime BirthDate
        {
            get { return birthdate; }
            set
            {
                birthdate = value;
                OnPropertyChanged();
            }
        }
    }
}