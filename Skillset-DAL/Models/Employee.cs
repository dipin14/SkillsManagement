﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillset_DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int DesignationId { get; set; }
        public virtual Designation Designations { get; set; }
        public int QualificationId { get; set; }
        public virtual Qualification Qualifications { get; set; }
        public int Experience { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ManagerCode { get; set; }
        public virtual Employee Manager { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public double MobileNumber { get; set; }
        public string Gender { get; set; }

    }
}
