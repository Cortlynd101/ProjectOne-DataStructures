using System;

public class Student : Person
{
    public Student(string name, string id, decimal credits, decimal gPA)
    {
        Name = name;
        ID = id;
        Credits = credits;
        GPA = gPA;
    }
    public string ID { get; set; }
    public decimal Credits { get; set; }
    public decimal GPA { get; set; }
}