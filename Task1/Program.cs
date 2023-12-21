

var teach = new Teacher();
teach.FullName = "Shahrom";
teach.Subject = "mathematics";
teach.Experience = 20;

System.Console.WriteLine(teach.Teach());
System.Console.WriteLine(teach.Teach1());


public class Teacher
{
    private string fullName;
    private string _subject;
    private int _experience;

    public Teacher()
    {

    }

    public Teacher(string name, string subject)
    {
        fullName = name;
        _subject = subject;
    }

    public Teacher(string name, string subject, int experience)
    {
        fullName = name;
        _subject = subject;
        _experience = experience;
    }

    public string Teach()
    {
        return $"{fullName} is teaching {_subject}.";
    }
    public string Teach1()
    {
        return $"She study {_experience} years.";
    }   

    public void SetExperience(int years)
    {
        _experience = years;
    }

    public int GetExperience()
    {
        return _experience;
    }

    public string GetFullName()
    {
        return fullName;
    }

    public string GetSubject()
    {
        return _subject;
    }

    public void SetFullName(string name)
    {
        fullName = name;
    }

    public void SetSubject(string subject)
    {
        _subject = subject;
    }

    public int Experience
    {
        get { return _experience; }
        set { _experience = value; }
    }

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }

    public string Subject
    {
        get { return _subject; }
        set { _subject = value; }
    }
}