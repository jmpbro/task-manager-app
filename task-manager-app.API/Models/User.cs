namespace task_manager_app.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }  // Nullable if Name can be null
        public string? Email { get; set; }  // Nullable if Email can be null
    }
}

