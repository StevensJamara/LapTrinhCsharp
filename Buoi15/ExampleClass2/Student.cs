public class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public float Score { get; set; }
    public Student() { }
    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Score = 0.0f; // Default score
    }
}
