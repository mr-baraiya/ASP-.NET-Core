namespace ConsoleDemoApp
{
    public class Student
    {
        public int Rno { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public int Sem { get; set; }
        public double CPI { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Rno: {Rno}, Name: {Name}, Branch: {Branch}, Sem: {Sem}, CPI: {CPI}, Age: {Age}";
        }
    }

    public class Course
    {
        public int Rno { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public override string ToString()
        {
            return $"Rno: {Rno}, Course: {CourseName}, Credits: {Credits}";
        }
    }

    class Program
    {
        static List<Student> GetStudents()
        {
            // Note: Using traditional List<Student> for compatibility. For C# 12, can use: [new Student { ... }, ...] 
            return new List<Student>
            {
                new Student { Rno=101, Name="Ramesh", Branch="CE", Sem=3, CPI=9.2, Age=23 },
                new Student { Rno=102, Name="Mahesh", Branch="EC", Sem=3, CPI=8.8, Age=21 },
                new Student { Rno=103, Name="Suresh", Branch="ME", Sem=4, CPI=7.5, Age=22 },
                new Student { Rno=104, Name="Amit", Branch="EE", Sem=4, CPI=8.6, Age=20 },
                new Student { Rno=105, Name="Anita", Branch="CE", Sem=4, CPI=8.0, Age=22 },
                new Student { Rno=106, Name="Reeta", Branch="ME", Sem=3, CPI=7.35, Age=21 },
                new Student { Rno=107, Name="Rohit", Branch="EE", Sem=4, CPI=9.45, Age=24 },
                new Student { Rno=108, Name="Chetan", Branch="CE", Sem=3, CPI=8.6, Age=26 },
                new Student { Rno=109, Name="Rakesh", Branch="CE", Sem=4, CPI=9.10, Age=24 },
                new Student { Rno=110, Name="Alice", Branch="CSE", Sem=4, CPI=8.5, Age=20 },
                new Student { Rno=111, Name="Jay", Branch="CE", Sem=5, CPI=6.5, Age=21 },
                new Student { Rno=112, Name="Vijay", Branch="ME", Sem=4, CPI=5.5, Age=22 },
                new Student { Rno=113, Name="Rajvi", Branch="CSE", Sem=5, CPI=5.5, Age=19 },
                new Student { Rno=114, Name="Viru", Branch="ME", Sem=4, CPI=8.5, Age=24 },
                new Student { Rno=115, Name="Amee", Branch="ME", Sem=5, CPI=8.5, Age=24 }
            };
        }

        static List<Course> GetCourses()
        {
            return new List<Course>
            {
                new Course { Rno=101, CourseName="Data Structures", Credits=4 },
                new Course { Rno=101, CourseName="Algorithms", Credits=3 },
                new Course { Rno=102, CourseName="Circuit Design", Credits=4 },
                new Course { Rno=103, CourseName="Mechanics", Credits=3 },
                new Course { Rno=104, CourseName="Electronics", Credits=4 },
                new Course { Rno=105, CourseName="Database Systems", Credits=3 },
                new Course { Rno=106, CourseName="Thermodynamics", Credits=3 },
                new Course { Rno=107, CourseName="Power Systems", Credits=4 },
                new Course { Rno=108, CourseName="Operating Systems", Credits=4 },
                new Course { Rno=109, CourseName="Software Engineering", Credits=3 },
                new Course { Rno=110, CourseName="AI", Credits=4 },
                new Course { Rno=111, CourseName="Networking", Credits=3 },
                new Course { Rno=112, CourseName="Fluid Mechanics", Credits=3 },
                new Course { Rno=113, CourseName="Machine Learning", Credits=4 },
                new Course { Rno=114, CourseName="Robotics", Credits=3 }
            };
        }

        static void Main(string[] args)
        {
            var students = GetStudents();
            var courses = GetCourses();
            var studentsByBranch = students.GroupBy(s => s.Branch);

            Console.WriteLine("35. Flatten All Students from Grouped Data:");
            var allStudents = studentsByBranch.SelectMany(g => g);
            Console.WriteLine(string.Join(", ", allStudents.Select(s => $"{s.Name} ({s.Branch})")));
        }
    }
}


//List<Student> GetAllStudents()
//{
//    List<Student> students = new List<Student>();

//    students.Add(new Student
//    {
//        RNo = 1,
//        Name = "Alice",
//        Age = 20,
//        Branch = "CSE",
//        CPI = 8.5,
//        Sem = 4
//    });
//    students.Add(new Student
//    {
//        RNo = 2,
//        Name = "Jay",
//        Age = 21,
//        Branch = "CE",
//        CPI = 6.5,
//        Sem = 5
//    });
//    students.Add(new Student
//    {
//        RNo = 3,
//        Name = "Vijay",
//        Age = 22,
//        Branch = "ME",
//        CPI = 5.5,
//        Sem = 4
//    });
//    students.Add(new Student
//    {
//        RNo = 4,
//        Name = "Rajvi",
//        Age = 19,
//        Branch = "CSE",
//        CPI = 5.5,
//        Sem = 5
//    });
//    students.Add(new Student
//    {
//        RNo = 5,
//        Name = "Viru",
//        Age = 24,
//        Branch = "ME",
//        CPI = 7.5,
//        Sem = 4
//    });
//    students.Add(new Student
//    {
//        RNo = 5,
//        Name = "Amee",
//        Age = 24,
//        Branch = "ME",
//        CPI = 8.5,
//        Sem = 5
//    });

//    return students;
//}

//void PrintStudents(IEnumerable<Student> students)
//{
//    foreach (var stu in students)
//    {
//        Console.WriteLine($"RNo: {stu.RNo}, Name: {stu.Name}, Age: {stu.Age}, Branch: {stu.Branch}, CPI: {stu.CPI}");
//    }
//}

//var students = GetAllStudents();

// LINQ Method Syntax Examples 

// 1. Get Students with CPI greater than 8  
//var greaterThan8 = students.
//    Where(s => s.CPI > 8).
//    ToList();
//PrintStudents(greaterThan8);

// 2. Get Students with Semester less than 5  
//var semLessThan5 = students.
//    Where(s => s.Sem > 5).
//    ToList();
//PrintStudents(semLessThan5);

// 3. Get Students with CPI between 7 and 8 
//var betweenand = students.
//    Where(s => s.CPI > 7 && s.CPI < 8)
//    .ToList();
//PrintStudents(betweenand);

// 4. Get Students with CPI greater than 8 and Sem is 3 
//var greaterThan8AndSem3 = students
//                            .Where(s => s.CPI > 8 && s.Sem == 3)
//                            .ToList();

//PrintStudents(greaterThan8AndSem3);

// 5. Get Students whose name starts with 'R' 
//var startsWithR = students
//    .Where(s => s.Name.StartsWith("R"))
//    .ToList();
//PrintStudents(startsWithR);

// 6. Get Students whose name starts with 'R' and Sem is 3 
//var startsWithRAndSem3 = students
//                            .Where(s => s.Name.StartsWith("R") && s.Sem == 3)
//                            .ToList();
//PrintStudents(startsWithRAndSem3);

// 7. Get Students whose name ends with 'h' 
//var endsWithH = students
//                        .Where(s => s.Name.EndsWith("h"))
//                        .ToList();
//PrintStudents(endsWithH);

// 8. Get Students whose name contains 'e' 
//var containsE = students
//                    .Where(s => s.Name.Contains("e"))
//                    .ToList();
//PrintStudents(containsE);

// 9. Get Students whose name contains 'e' and Sem is 3 
//var containsEAndSem3 = students
//                            .Where(s => s.Name.Contains("e") && s.Sem == 3)
//                            .ToList();
//PrintStudents(containsEAndSem3);

// 10. Get Students whose name contains 'e' and Sem is 3 But Only Display RNo, Name, Branch, Sem 
//var containsEAndSem3Display = students 
//                                    .Where(s => s.Name.Contains("e") && s.Sem == 3) 
//                                    .Select(s => new
//                                                 {
//                                                     s.RNo,
//                                                     s.Name,
//                                                     s.Branch,
//                                                     s.Sem
//                                                 }) 
//                                    .ToList();
//foreach (var stu in containsEAndSem3Display)
//{
//    Console.WriteLine($"RNo: {stu.RNo}, Name: {stu.Name}, Branch: {stu.Branch}");
//}

// 11. Get Minimum CPI from the list of students 
//var minimumCPI = students
//                      .Min(s => s.CPI);

// 12. Get Maximum CPI from the list of students 
//var maximumCPI = students
//                      .Max(s => s.CPI);


//// 13. Get Average CPI from the list of students 
//var averageCPI = students
//                      .Average(s => s.CPI);

//// 14. Get Total CPI from the list of students 
//var totalCPI = students
//                      .Sum(s => s.CPI);

// 15. Get Students with CPI greater than 8 and Sem is 3, ordered by Rno then Name 
//var greaterThan8AndSem3Ordered = students
//                                      .Where(s => s.CPI > 8 && s.Sem == 3)
//                                      .OrderBy(s => s.RNo)
//                                      .ThenBy(s => s.Name)
//                                      .ToList();

// 16. Get Students with CPI greater than 8 and Sem is 3, ordered by Name 
//var greaterThan8AndSem3OrderedByName = students
//                                            .Where(s => s.CPI > 8 && s.Sem == 3)
//                                            .OrderBy(s => s.Name)
//                                            .ToList();

// 17. Get Summary of Students with CPI greater than 8 and Sem is 3(Display Rno, Name, Branch, CPI) 
//var greaterThan8AndSem3Summary = students 
//                                        .Where(s => s.CPI > 8 && s.Sem == 3) 
//                                        .Select(s => new
//                                                     {
//                                                         s.RNo,
//                                                         s.Name,
//                                                         s.Branch,
//                                                         s.CPI
//                                                     }) 
//                                        .ToList();

// 18. Get Students with CPI greater than 8 and Sem is 3, ordered by Rno, then by Name 
//var greaterThan8AndSem3OrderedByRno = students
//                                          .Where(s => s.CPI > 8 && s.Sem == 3)
//                                          .OrderBy(s => s.RNo)
//                                          .ThenBy(s => s.Name)
//                                          .ToList();

// 20. Get First Student with CPI greater than 8 
//var firstStudentWithCPIGreaterThan8 = students
//                                          .Where(s => s.CPI > 8)
//                                          .FirstOrDefault();

// 21. Get Last Student with CPI greater than 8 
//var lastStudentWithCPIGreaterThan8 = students
//                                          .Where(s => s.CPI > 8)
//                                          .LastOrDefault();

// 22. Group by Branch and Sem 
//var groupedByBranchAndSem = students
//                                .GroupBy(s => new { s.Branch, s.Sem })
//                                .Select(g => new
//                                {
//                                    Branch = g.Key.Branch,
//                                    Sem = g.Key.Sem,
//                                    Students = g.ToList()
//                                })
//                                .ToList();

// 23. Take first 3 students from the list 
//var firstThreeStudents = students
//                            .Take(3)
//                            .ToList();

// 24. Skip first 3 students and take next 3 students 
//var skipFirstThreeTakeNextThree = students
//                                        .Skip(3)
//                                        .Take(3)
//                                        .ToList();