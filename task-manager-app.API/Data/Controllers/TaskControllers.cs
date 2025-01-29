using task_manager_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task = task_manager_app.Models.Task;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TaskController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<Task>> CreateTask([FromBody] Task task)
    {
        // You can associate the task with a user here
        var user = await _context.Users.FindAsync(task.UserId);
        if (user == null)
        {
            return NotFound("User not found");
        }

        // Example: Create the task and associate it with the user
        task.User = user;
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
    }

    private object GetTask()
    {
        throw new NotImplementedException();
    }
}
