using System;
using System.Collections.Generic;
using System.Text;

namespace MiracleDKP
{
    public class Info
    {
        private string created_by;
        private string post_date;
        private string posted_info;

        public Info(string _user, string _date, string _info)
        {
            created_by = _user;
            post_date = _date;
            posted_info = _info;
        }

        public override string ToString()
        {
            string _return = "Közzétette: " + created_by + "\nDátum: " + post_date + "\n\n";
            _return += posted_info;
            _return += "\n --- \n";
            return _return;
        }
    }
}
