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

        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                _birthday = value;
                var today = DateTime.Today;
                Valid = (today - value).Days >= 0 && (today.Year - value.Year) <= 135;
            }
        }

    }
}
