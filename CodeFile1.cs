internal class Student
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        students.Add(new Student("Jimmy", 13));
        students.Add(new Student("Hannah Banana", 21));
        students.Add(new Student("Justin", 30));
        students.Add(new Student("Sarah", 53));
        students.Add(new Student("Hannibal", 15));
        students.Add(new Student("Phillip", 16));
        students.Add(new Student("Maria", 63));
        students.Add(new Student("Abe", 33));
        students.Add(new Student("Curtis", 10));
    }
}
