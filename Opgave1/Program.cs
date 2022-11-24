using Opgave1.Classes;
using Opgave1.Code.Enums;

Teacher Niels = new Teacher("IT", "Niels", "Olesen", "02-02-1971");
Teacher Peter = new("IT", "Peter", "Lindenskov", "01-01-1970");

Course clientSide = new(CourseEnum.ClientsideProgrammering.ToString(), Peter);
Course studieteknik = new(CourseEnum.Studieteknik.ToString(), Niels);
Course grundlæggendeProgrammering = new(CourseEnum.GrundlæggendeProgrammering.ToString(), Niels);
Course oop = new(CourseEnum.OOP.ToString(), Niels);
Course databaseProgrammering = new Course(CourseEnum.DatabaseProgrammering.ToString(), Niels);
Course computerTeknologi = new Course(CourseEnum.Computerteknologi.ToString(), Niels);
Course netværk = new Course(CourseEnum.Netværk.ToString(), Niels);


bool _keepRunning = true;


Enrollment _enrollmentList = new();
_enrollmentList.EnrollList = new List<Enrollment>() { };


while (_keepRunning)
{
        Console.WriteLine("Indtast Elevens studieID");
        int.TryParse(Console.ReadLine(), out int _studieID);
        Console.WriteLine("Indtast Elevens fornavn: ");
        string? _firstName = Console.ReadLine();
        Console.WriteLine("Indtast Elevens efternavn: ");
        string? _lastName = Console.ReadLine();
        Console.WriteLine("Indtast Elevens fødselsdato (dd-mm-yyyy)");
        string? _dateOfBirth = Console.ReadLine();


        Student student = new(_studieID, _firstName, _lastName, _dateOfBirth);


        Console.WriteLine("\nTilmeld elev til fag: \n-------------------------------------");
        foreach (CourseEnum coursesEnum in Enum.GetValues(typeof(CourseEnum)))
        {
            Console.WriteLine(coursesEnum);
        }
        Console.WriteLine("-------------------------------------");
        string? _pickCourse = Console.ReadLine().ToUpper();

        if (_pickCourse == CourseEnum.GrundlæggendeProgrammering.ToString().ToUpper())
        {
            _enrollmentList.EnrollList.Add(new Enrollment(student, clientSide));
        }
        else if (_pickCourse == CourseEnum.Studieteknik.ToString().ToUpper())
        {
            _enrollmentList.EnrollList.Add(new Enrollment(student, studieteknik));
        }
        else if (_pickCourse == CourseEnum.GrundlæggendeProgrammering.ToString().ToUpper())
        {
            _enrollmentList.EnrollList.Add(new Enrollment(student, grundlæggendeProgrammering));
        }
        else if (_pickCourse == CourseEnum.OOP.ToString().ToUpper())
        {
            _enrollmentList.EnrollList.Add(new Enrollment(student, oop));
        }
        else if (_pickCourse == CourseEnum.Netværk.ToString().ToUpper())
        {
            _enrollmentList.EnrollList.Add(new Enrollment(student, netværk));
        }
        else if (_pickCourse == CourseEnum.ClientsideProgrammering.ToString().ToUpper())
        {
            _enrollmentList.EnrollList.Add(new Enrollment(student, clientSide));
        }
        else if (_pickCourse == CourseEnum.DatabaseProgrammering.ToString().ToUpper())
        {
            _enrollmentList.EnrollList.Add(new Enrollment(student, databaseProgrammering));
        }
        else if (_pickCourse == CourseEnum.Computerteknologi.ToString().ToUpper())
        {
            _enrollmentList.EnrollList.Add(new Enrollment(student, computerTeknologi));
        }

        else Console.WriteLine("Ugyldigt input");

        Console.WriteLine("\n");

        foreach (var item in _enrollmentList.EnrollList)
        {
            Console.WriteLine($"{item._studentInfo._firstName} {item._studentInfo._lastName}, fag: {item._courseInfo._courseName}, lærer: {item._courseInfo._teacherInfo._firstName} {item._courseInfo._teacherInfo._lastName}");
        }

        Console.WriteLine("\n\nTast\n1: For at tilmelde en elev\nQ: For at afslutte");
        char c = Console.ReadKey().KeyChar;

        if (c == 'q' || c == 'Q')
        {
            _keepRunning = false;
        }
        Console.Clear();


    }