
namespace SimpaTravllingSocial.DAL.Entites
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Min lenghth 2")]
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime date { get; set; }

        //        //navigation property
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
