

var s1 = new Student();
s1.FullName = "Abdullo";
s1.Age = 24;
s1.Grade = 12;

s1.Study();
System.Console.WriteLine(s1.GetAge());
System.Console.WriteLine(s1.GetGrade());
public class Student
{
    private string fullname;
    private int _age;
    private int _grade;

    public Student(string name, int age)
    {
        fullname = name;
        _age = age;
    }
    public Student(string name, string subject, int grade)
    {
        fullname = name;
        _grade = grade;
    }

    public Student()
    {
    }

    public void Study()
    {
        System.Console.WriteLine($"{fullname} is studying.");
    }
    public void SetGrade(int newGrade)
    {
        _grade = newGrade;
    }
    public int GetGrade()
    {
        return _grade;
    }


    public string Getfullname()
    {
        return fullname;
    }
    public int GetAge()
    {
        return _age;
    }
    public void Setfullname(string name)
    {
        fullname = name;
    }
    public void SetAge(int age)
    {
        _age = age;
    }

    public string FullName
    {
        get { return fullname; }
        set { fullname = value; }
    }
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
    public int Grade
    {
        get { return _grade; }
        set { _grade = value; }
    }

}
