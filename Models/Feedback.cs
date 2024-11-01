namespace ApiAuth.Models;

public class Feedback
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Detail { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime? Updated { get; set; }

    public string UserId { get; set; }
    public ApplicationUser? User { get; set; }
}

public class FeedbackModel
{
    public string Title { get; set; }
    public string Detail { get; set; }
}