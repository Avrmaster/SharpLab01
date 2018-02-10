using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab01
{
    class BirthdayModel
    {
        private DateTime _birthday;
        public bool Valid { get; private set; }
        public string Age { get; private set; }
        public string WestZodiac { get; private set; }
        public string ChineseZodiac { get; private set; }

        public BirthdayModel()
        {
            _birthday = DateTime.Today;
        }

        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                _birthday = value;
                var today = DateTime.Today;
                var dyears = (today.Year - value.Year) - (today.DayOfYear >= _birthday.DayOfYear? 0 : 1);
                var deltaDateTime = today - value;
                
                Valid = deltaDateTime.Days >= 0 && dyears <= 135;
                if (Valid)
                {
                    Age = dyears > 0? dyears+" year(s)" : deltaDateTime.Days+ " day(s)";
                    WestZodiac = "Some west2";
                    ChineseZodiac = ChineseZodiaсs[(_birthday.Year + 8) % 12];
                }
                else
                {
                    Age = WestZodiac = ChineseZodiac = "";
                }
            }
        }

        public bool IsBirthday
        {
            get
            {
                var today = DateTime.Today;
                return today.Month == _birthday.Month && today.Day == _birthday.Day;
            }
        }

        private static readonly string[] ChineseZodiaсs = {
            "Rat",
            "Ox",
            "Tiger",
            "Rabbit",
            "Dragon",
            "Snake",
            "Horse",
            "Goat",
            "Monkey",
            "Rooster",
            "Dog",
            "Pig"
        };
    }
}
