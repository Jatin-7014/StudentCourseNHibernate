using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using StudentCourseApp.Models;

namespace StudentCourseApp.Mappings
{
    public class StudentsMap:ClassMap<Student>
    {
        public StudentsMap()
        {
            Table("Studets");
            Id(s => s.Id).GeneratedBy.Identity();
            Map(s => s.Name);
            Map(s=>s.Age);
            Map(s=>s.Email);
            HasOne(s => s.Course).Cascade.All().PropertyRef(s => s.Student).Constrained();
        }
    }
}