
namespace SimpaTravllingSocial.DAL.Entites
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Max length 30")]
        public string FName { get; set; }
        public string? LName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        //navigation property
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
