using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine(GetDisplay());
    }

    public string GetDisplay()
    {
        string result = $"{_title} by {_author} ({_length}s)\n";
        result += $"Comments: {GetCommentCount()}\n";

        foreach (Comment c in _comments)
        {
            result += $"{c.GetName()}: {c.GetText()}\n";
        }

        return result;
    }
}