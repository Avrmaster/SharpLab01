using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using LeskivSharp01.Annotations;

namespace LeskivSharp01
{
    internal class BirthdayViewModel:INotifyPropertyChanged
    {
        private readonly BirthdayModel _birthdayModel=new BirthdayModel();

        public DateTime BirthDate
        {
            get
            {
                return _birthdayModel.Birthday;
            }
            set
            {
                _birthdayModel.Birthday = value;
                if (!_birthdayModel.Valid)
                {
                    MessageBox.Show("You entered invalid date!", "DatePickerError", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
                else
                {
                    if (_birthdayModel.IsBirthday)
                    {
                        MessageBox.Show("Happy birthday, bro/sister!!! <3");
                    }
                }
                OnPropertyChanged();
                OnPropertyChanged(nameof(Age));
                OnPropertyChanged(nameof(ChineseZodiac));
                OnPropertyChanged(nameof(WestZodiac));
            }
        }

        public string Age
        {
            get
            {
                return $"Your age:{Environment.NewLine}{_birthdayModel.Age}";
            }
        }

        public string WestZodiac
        {
            get
            {
                return $"Western zodiac:{Environment.NewLine}{_birthdayModel.WestZodiac}";
            }
        }

        public string ChineseZodiac
        {
            get
            {
                return $"Chinise zodiac:{Environment.NewLine}{_birthdayModel.ChineseZodiac}";
            }
        }

        internal BirthdayViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
