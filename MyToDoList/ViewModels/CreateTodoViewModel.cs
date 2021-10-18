using System.ComponentModel.DataAnnotations;

namespace MyToDoList.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
