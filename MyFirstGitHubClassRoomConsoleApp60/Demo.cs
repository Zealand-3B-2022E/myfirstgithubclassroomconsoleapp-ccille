using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class Demo
    {
        private int _id;
        private string _name;
        private string _phone;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public Demo():this(0, "", "")
        {
        }

        public Demo(int id, string name, string phone)
        {
            _id = id;
            _name = name;
            _phone = phone;
        }

        public override string ToString()
        {
            return $"Id = {_id}, Name = {_name}, Phone = {_phone}";
        }


    }
}
