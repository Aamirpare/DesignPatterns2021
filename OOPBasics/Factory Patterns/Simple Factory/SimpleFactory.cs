namespace OOPBasics.Factory
{
    public enum StudentType 
    { 
        Visiting, Serious    
    }
    public abstract class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public abstract Student CreateStudent();
    }
    public class Visiting : Student
    {
        //public override Student CreateStudent()
        //{
        //    return new Visiting();
        //}
    }
    public class Serious : Student
    {
        public string Email { get; set; }

        //public override Student CreateStudent()
        //{
        //    return new Serious();
        //}
    }



    ///Simple Factory
    public static class StudentFactory
    {
        public static Student Create(StudentType type)
        {
            if(type == StudentType.Visiting)
            {
                return new Visiting();
            }
            if(type == StudentType.Serious)
            {
                return new Serious();
            }
            return null;
        }
    }
}
