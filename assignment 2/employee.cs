using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
    

{
    enum employee_job
    {
        guest, Developer, secretary ,DBA
    }

    enum gender:byte
    {
        male=0,female=1,m=0,f=1
    }

    internal class employee
    {
        private int id;
        private string name;
        employee_job sercuity_level ;
        private int salary;
        private int haringdate;
        gender gender;
       
       public int getid() {  return id; }
        public string getName() { return name; }
        public employee_job getemployee_job() {return sercuity_level;}
        public int getSalary() { return salary; }
        public gender getGender() { return gender;}
        public int getharingdate() {  return haringdate;}
        
        public void setid(int id) {  this.id = id; }
        public void setname(string name) { this.name = name; }
        public void setsercuity_level(employee_job sercuity_level) {this.sercuity_level = sercuity_level;}
        public void setsalary(int salary) { this.salary = salary;}
        public void setgender(gender gender) { this.gender = gender;}
        public void setharingdate(int haringdate) {  this.haringdate = haringdate;}

        public override string ToString()
        {
            return $"{salary}";
        }



    }
    internal class hiring_date
    {
        int month;
        int year;
         int day;



    }


}
