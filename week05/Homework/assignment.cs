using System;

// Base class for all assignments
// Contains common attributes and behaviors shared by all assignment types
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor that accepts student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Returns a summary with student name and topic
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    // Public getter method to allow derived classes to access student name
    // This is needed because _studentName is private
    public string GetStudentName()
    {
        return _studentName;
    }
}