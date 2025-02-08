public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor to initialize WritingAssignment
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get the writing information
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
