using System;
// class for a Video 
// track the title, author, and length (in seconds) 
// Each video also has responsibility to store a list of comments
// have a method to return the number of comments. 
// A comment should be defined by the Comment class which has the responsibility for 
// tracking both the name of the person who made the comment and the text of the comment.

// program that creates 3-4 videos, sets the appropriate values, and for each one add a 
// list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

// Then, have your program iterate through the list of videos and for 
// each one, display the title, author, length, number of comments (from the method) 
// and then list out all of the comments for that video. Repeat this display for 
// each video in the list.

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();
        List<(string title, string author, int length)> videoInfo = new();
        (string, string, int) v1Info = ("DIY Magic Mirror", "Evil Queen", 230);
        videoInfo.Add(v1Info);

        Video video1 = new("DIY Magic Mirror", "Evil Queen", 230);
        videos.Add(video1);

        Video video2 = new("Sports Talk", "Bob", 450);
        videos.Add(video2);

        Video video3 = new("Quiet Cats", "Elvira", 210);
        videos.Add(video3);

        Video video4 = new("Haunted House", "Dr. Evil", 502);
        videos.Add(video4);

        video1.AddComment("dSmallz", "I think it's amazing that you can create a magic mirror!");
        video1.AddComment("house", "Fake News! Not a real magic mirror");
        video1.AddComment("dSmallz", "I think it's amazing that you can create a magic mirror!");
        
        video2.AddComment("Bo", "Not sure how people can stand to listen to this.");
        video2.AddComment("LionZZ", "Great season. Sad it ended this way.");
        video2.AddComment("Starz", "Didn't make it in the end!");
        
        video3.AddComment("Mr. Smith", "Didn't know this was even possible!");
        video3.AddComment("JohnsBaby", "Fake News! Not a real magic mirror");
        video3.AddComment("Dingo", "Love the cats! Keep 'em coming!");
        
        video4.AddComment("BSimpson", "Did I do that?");
        video4.AddComment("bing0", "Not real! I could see the wires!");
        video4.AddComment("D_B_S", "This house is right around the corner from me!");

        // foreach (var item in videoInfo)
        // {
        //     videos.Add(item.title, item.author, item.length);
        // }

        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}