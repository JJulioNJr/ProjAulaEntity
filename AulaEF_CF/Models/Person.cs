using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEF_CF.Models {
    internal class Person{

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }
        public string Mobile { get; set; }
        public override string ToString() {
            return "\nID:" +this.Id+
                   "\nName:" +this.Name+
                   "\nPhone:" +this.Phone+
                   "\nMobile:" +this.Mobile+
                   "\nEmail:" +this.Email;
        }

    }
}
