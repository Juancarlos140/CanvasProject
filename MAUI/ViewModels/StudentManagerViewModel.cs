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
    internal class StudentManagerViewModel : INotifyPropertyChanged {
        private PersonService studentSvc;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Person> Students {
            get {
                return new ObservableCollection<Person>(studentSvc.Persons);
            }
        }

        public Person SelectedStudent {
            get; set;
        }

        public void AddStudent() {
            studentSvc.Add(new Person { Name = "New Student" });
            NotifyPropertyChanged(nameof(Students));
        }

        public void RemoveStudent() {
            studentSvc.Remove(SelectedStudent);
            RefreshView();
        }

        public StudentManagerViewModel() {
            studentSvc = PersonService.Current;
        }

        public void RefreshView() {
            NotifyPropertyChanged(nameof(Students));
        }

    }
}