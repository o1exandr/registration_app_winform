using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registration_app_winform.Model
{
    public class UserItemModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Sex { get; set; }
        public int Age { get; set; }
    }
    public class UserAddModel
    {
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Secondname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Sex { get; set; }
        public string DateBirth { get; set; }
        public string Password { get; set; }
    }
}
