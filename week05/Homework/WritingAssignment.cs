using System;

// Derived class for Writing assignments
// Inherits from Assignment and adds writing-specific attributes
public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor that accepts all three parameters
    // Calls base class constructor for studentName and topic
    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    // Returns the writing information with title and student name
    public string GetWritingInformation()
    {
        // Uses GetStudentName() method from base class to access private _studentName
        return _title + " by " + GetStudentName();
    }
}