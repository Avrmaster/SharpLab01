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
        public string WestZodiak { get; private set; }
        public string ChinaZodiak { get; private set; }

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
                var age = today.Year - value.Year;
                Valid = (today - value).Days >= 0 && age <= 135;
                if (Valid)
                {
                    Age = age > 1? "2" : "0";
                    WestZodiak = "Some west2";
                    ChinaZodiak = "Some china3";
                }
                else
                {
                    Age = WestZodiak = ChinaZodiak = "";
                }
            }
        }

    }
}
