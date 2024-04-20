using Canvas.Models;
using Canvas.Services;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.Canvas.ViewModels 
{
    internal class CourseManagerViewModel : INotifyPropertyChanged {
        private CourseService courseSvc;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Course> Courses {
            get {
                return new ObservableCollection<Course>(courseSvc.Courses);
            }
        }

        public Course SelectedCourse {
            get; set;
        }

        public void AddCourse() {
            courseSvc.Add(new Course { Name = "New Course" });
            NotifyPropertyChanged(nameof(Courses));
        }

        public void RemoveCourse() {
            courseSvc.Remove(SelectedCourse);
            RefreshView();
        }

        public CourseManagerViewModel() {
            courseSvc = CourseService.Current;
        }

        public void RefreshView() {
            NotifyPropertyChanged(nameof(Courses));
        }

    }
}