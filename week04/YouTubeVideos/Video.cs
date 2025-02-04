using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // Duration in seconds
    public List<Comment> Comments { get; set; }

    // Constructor to initialize the Video object
    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        Comments = new List<Comment>();
    }

    // Method to return the number of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}