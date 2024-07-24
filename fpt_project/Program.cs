using System;
using fpt_project;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext()) 
        {
            context.Database.EnsureCreated();

            var grd1 = new Grade() { GradeName = "1st Grade" };
            var std1 = new Student() { FirstName = "Yash", LastName = "Malhotra", Grade = grd1 };

            context.Students.Add(std1);

            context.SaveChanges();

            foreach (var s in context.Students)
            {
                Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}");
            }
        }
    }
}
