using DevZone_Assignment.src;

var t1 = new Teacher();
t1.Name = "salem";
t1.Age = 26;
t1.Subject = "heko";

var t2 = new Teacher();
t2.Name = "ali";
t2.Age = 41;
t2.Subject = "heko";

var s1 = new Student();
s1.Name = "yasser";
s1.Age = 23;
s1.Grade = 100;


var s2 = new Student();
s2.Name = "mohamed";
s2.Age = 26;
s2.Grade = 77;

var m = new SchoolManager();

m.AddStudent(s1);
m.AddStudent(s2);
m.AddTeacher(t1);
m.AddTeacher(t2);

m.DeleteTeacher(2);
m.UpdateStudent(1, new Student { Name = "ahmed", Grade = 99 });

Console.WriteLine("View Teacher 1: ");
Console.WriteLine(m.ViewTeacher(1) + "\n");
Console.WriteLine(m.ViewAll());
