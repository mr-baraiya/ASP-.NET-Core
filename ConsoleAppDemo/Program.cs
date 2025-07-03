using ConsoleAppDemo;

List<Student> GetAllStudents()
{
    List<Student> students = new List<Student>();
    students.Add(new Student
    {
        Rno = 1,
        Name = "Alice",
        Age = 20,
        Branch = "CSE",
        CPI = 8.5,
        Sem = 3
    });

    students.Add(new Student
    {
        Rno = 2,
        Name = "Jay",
        Age = 21,
        Branch = "CE",
        CPI = 9.5,
        Sem = 3
    });

    students.Add(new Student
    {
        Rno = 3,
        Name = "Vijay",
        Age = 22,
        Branch = "ME",
        CPI = 5.5,
        Sem = 5
    });

    students.Add(new Student
    {
        Rno = 4,
        Name = "Raj",
        Age = 19,
        Branch = "CSE",
        CPI = 5.5,
        Sem = 6
    });

    students.Add(new Student
    {
        Rno = 5,
        Name = "Viru",
        Age = 24,
        Branch = "ME",
        CPI = 8.5,
        Sem = 7 
    });

    students.Add(new Student
    {
        Rno = 6,
        Name = "Viraj",
        Age = 24,
        Branch = "ME",
        CPI = 8.5,
        Sem = 2
    });

    return students;
}

var students = GetAllStudents();

//foreach (var stu in students)
//{
//    Console.WriteLine($"RNO:{stu.Rno}, Name:{stu.Name}, Age:{stu.Age}, Branch:{stu.Branch}, CPI:{stu.CPI}, Sem:{stu.Sem}");
//}


// 1. Select * From Students Where CPI > 8

//var greaterThan8 = students.Where(s => s.CPI > 8).ToList();

//foreach (var stu in greaterThan8)
//{
//    Console.WriteLine($"RNO:{stu.Rno}, Name:{stu.Name}, Age:{stu.Age}, Branch:{stu.Branch}, CPI:{stu.CPI}, Sem:{stu.Sem}");
//}

// 2. Select * From Students Where CPI < 8

//var lessThan8 = students.Where(s => s.CPI < 8).ToList();

//foreach (var stu in lessThan8)
//{
//    Console.WriteLine($"RNO:{stu.Rno}, Name:{stu.Name}, Age:{stu.Age}, Branch:{stu.Branch}, CPI:{stu.CPI}, Sem:{stu.Sem}");
//}

// 3. Select * From Students Where CPI => 7 and CPI <= 8

//var bw7and8 = students.Where(s => s.CPI >= 7 && s.CPI <= 8).ToList();

//foreach (var stu in bw7and8)
//{
//    Console.WriteLine($"RNO:{stu.Rno}, Name:{stu.Name}, Age:{stu.Age}, Branch:{stu.Branch}, CPI:{stu.CPI}, Sem:{stu.Sem}");
//}

// 4. Select * From Students Where Sem = 3 and CPI > 8
//var data = students.Where(s => s.Sem == 3 && s.CPI > 8).ToList();

//foreach (var stu in data)
//{
//    Console.WriteLine($"RNO:{stu.Rno}, Name:{stu.Name}, Age:{stu.Age}, Branch:{stu.Branch}, CPI:{stu.CPI}, Sem:{stu.Sem}");
//}

// 5.Get Students Whose name starts with 'R'

//var data = students.Where(s => s.Name.StartsWith("R")).ToList();

//foreach (var stu in data)
//{
//    Console.WriteLine($"RNO:{stu.Rno}, Name:{stu.Name}, Age:{stu.Age}, Branch:{stu.Branch}, CPI:{stu.CPI}, Sem:{stu.Sem}");
//}


// 6.Get Students Whose name ends with 'h'

//var data = students.Where(s => s.Name.EndsWith("h")).ToList();

//foreach (var stu in data)
//{
//    Console.WriteLine($"RNO:{stu.Rno}, Name:{stu.Name}, Age:{stu.Age}, Branch:{stu.Branch}, CPI:{stu.CPI}, Sem:{stu.Sem}");
//}

// 6.Get Students Whose name contains 'e'

//var data = students.Where(s => s.Name.Contains("e")).ToList();

//foreach (var stu in data)
//{
//    Console.WriteLine($"RNO:{stu.Rno}, Name:{stu.Name}, Age:{stu.Age}, Branch:{stu.Branch}, CPI:{stu.CPI}, Sem:{stu.Sem}");
//}


// 7.Get Students Whose name contains 'e' and sem is 3

//var data = students.Where(s => s.Name.Contains("e") && s.Sem == 3).ToList();

//foreach (var stu in data)
//{
//    Console.WriteLine($"RNO:{stu.Rno}, Name:{stu.Name}, Age:{stu.Age}, Branch:{stu.Branch}, CPI:{stu.CPI}, Sem:{stu.Sem}");
//}

// 8. Get Students Whose name contains 'e' and sem is 3 but only display Rno, Name, Branch, Sem

//var data = students
//    .Where(s => s.Name.Contains("e") && s.Sem == 3)
//    .OrderBy(s => s.Rno)
//    .ToList();

//foreach (var stu in data)
//{
//    Console.WriteLine($"RNO: {stu.Rno}, Name: {stu.Name}, Branch: {stu.Branch}, Sem: {stu.Sem}");
//}

//var data = students
//    .Where(s => s.Name.Contains("e") && s.Sem == 3)
//    .OrderBy(s => s.Rno)
//    .Select(s => new { s.Rno, s.Name, s.Branch, s.Sem })
//    .ToList();

//foreach (var stu in data)
//{
//    Console.WriteLine($"RNO: {stu.Rno}, Name: {stu.Name}, Branch: {stu.Branch}, Sem: {stu.Sem}");
//}

//// 9. Get Minimum CPI from the list of students
//var minCPI = students.Min(s => s.CPI);
//Console.WriteLine($"Minimum CPI: {minCPI}");

//// 10. Get Maximum CPI from the list of students
//var maxCPI = students.Max(s => s.CPI);
//Console.WriteLine($"Maximum CPI: {maxCPI}");

//// 11. Get Average CPI from the list of students
//var avgCPI = students.Average(s => s.CPI);
//Console.WriteLine($"Average CPI: {avgCPI}");

//// 12. Get Total CPI from the list of students
//var totalCPI = students.Sum(s => s.CPI);
//Console.WriteLine($"Total CPI: {totalCPI}");

// 13. get students 
//selct * from LOC_City
//order by 2;

//selct* from LOC_City
//order by CityName;

// 14. get first Student with cpi greter than 8
//var data = students.Where(s => s.CPI > 8).FirstOrDefault();


// 15. get last Student with cpi greter than 8
//var data = students.Where(s => s.CPI > 8).LastOrDefault();



// 16. Take first 3 students
//var data = students.Take(3);

//foreach (var stu in data)
//{
//    Console.WriteLine($"RNO: {stu.Rno}, Name: {stu.Name}, Branch: {stu.Branch}, Sem: {stu.Sem}");
//}

// 17. skip first 3 students and take next 3 students
//var data = students.Skip(3).Take(3);

//foreach (var stu in data)
//{
//    Console.WriteLine($"RNO: {stu.Rno}, Name: {stu.Name}, Branch: {stu.Branch}, Sem: {stu.Sem}");
//}

//18.Group by Branch and Sem
var data = students
            .GroupBy(s => new { s.Branch, s.Sem})
            .Select(g => new
            {
                Branch = g.Key.Branch,
                Sem = g.Key.Sem,
                Students = g.ToList()
            })
            .ToList();