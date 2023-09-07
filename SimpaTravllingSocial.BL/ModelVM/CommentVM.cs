namespace SimpaTravllingSocial.BL.ModelVM
{
    public class CommentVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Min lenghth 2")]
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime date { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
