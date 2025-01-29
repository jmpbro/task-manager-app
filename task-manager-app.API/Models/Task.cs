namespace task_manager_app.Models
{
    public class Task 
{
    public int Id { get; set; }
    public string? Title { get; set; }  // Nullable if Title can be null
    public string? Description { get; set; }  // Nullable if Description can be null
    public string? Status { get; set; }  // Nullable if Status can be null
    public DateTime? DueDate { get; set; }  // Nullable DateTime if it can be null
    public int UserId { get; set; }
    public User? User { get; set; }  // Nullable reference type for User // reference to User
}

}


