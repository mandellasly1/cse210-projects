using System;

// Derived class for Math assignments
// Inherits from Assignment and adds math-specific attributes
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor that accepts all four parameters
    // Calls base class constructor for studentName and topic
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Returns the homework list with section and problems
    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}