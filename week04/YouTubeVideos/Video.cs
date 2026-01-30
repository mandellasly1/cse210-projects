using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    public string Title => _title;
    public string Author => _author;
    public int LengthSeconds => _lengthSeconds;
    
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"  Comment by {comment.CommenterName}: {comment.Text}");
        }
        Console.WriteLine();
    }
}