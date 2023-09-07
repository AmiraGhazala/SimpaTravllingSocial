
namespace SimpaTravllingSocial.DAL.Entites
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Min lenghth 2")]
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime date { get; set; }
        //Navigation property
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
