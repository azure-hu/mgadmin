using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMiracle
{
    public class Character
    {
        string _name;
        CharClass _class;
        CharRole _role_main;
        CharRole _role_alt;
        CharProfession _prof_main;
        CharProfession _prof_alt;
        Boolean _is_main;
        Int32 _keycode;
        Int32 _main_id;
        Int32 _points;
        GuildRank _rank;
        DateTime _join_date;
        DateTime _left_date;
    }
}
