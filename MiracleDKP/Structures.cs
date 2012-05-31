using System;
using System.Collections.Generic;
using System.Text;

namespace MiracleDKP
{
    public struct CharAttrib
    {
        int _id;
        string _name;

        public CharAttrib(int _id, string _name)
        {
            this._id = _id;
            this._name = _name;
        }

        public int ID { get { return _id; } private set { this._id = value; } }
        public string Name { get { return _name; } private set { this._name = value; } }
    }
}
