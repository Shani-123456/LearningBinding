using System;
using Microsoft.Maui.Controls;
using LearningBinding.models;

namespace LearningBinding
{
    public partial class MainPage : ContentPage
    {
       
        Student student1;
        Student student2;

        private Student _displayedStudent;
        public Student DisplayedStudent
        {
            get { return _displayedStudent; }
            set
            {
                _displayedStudent = value;
                OnPropertyChanged();    
            }
        }

        public MainPage()
        {
            InitializeComponent();

            student1 = new Student();
            student1.FirstName = "יוחננן";
            student1.LastName = "המושלם";
            student1.ImageName = "workyohanan.jpg";
            student1.BirthDate = new DateTime(1948, 7, 6);

            student2 = new Student();
            student2.FirstName = "אבי";
            student2.LastName = "רון";
            student2.ImageName = "bobiabanai.jpg";
            student2.BirthDate = new DateTime(1967, 5, 10);

            DisplayedStudent = student1;

            this.BindingContext = this;
        }

        private void OnChangeStudentClicked(object sender, EventArgs e)
        {
            if (DisplayedStudent == student1)
            {
                DisplayedStudent = student2;
            }
            else
            {
                DisplayedStudent = student1;
            }
        }
    }
}