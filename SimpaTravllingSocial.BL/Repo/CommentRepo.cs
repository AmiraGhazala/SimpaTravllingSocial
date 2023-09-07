namespace SimpaTravllingSocial.BL.Repo
{
    public class CommentRepo : ICommentRepo
    {
        #region field
        private readonly ApplicationDbContext db;
        #endregion
        #region constractor
        public CommentRepo(ApplicationDbContext db)
        {
            this.db = db;
        }
        #endregion
        #region handel function
        public void CreateComment(Comment comment)
        {
            try
            {
                comment.date = DateTime.Now;
                db.comments.Add(comment);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void DeleteComment(int CommentId)
        {
            if (CommentId != null && CommentId != 0)
            {
                var comment = db.posts.Where(a => a.Id == CommentId).FirstOrDefault();
                if (comment != null)
                {
                    comment.IsDeleted = true;
                    db.SaveChanges();
                }
            }
        }

        public List<Comment> GetAllComment()
        {
            var comment = db.comments.Where(a => a.IsDeleted != true).Include(a => a.User).ToList();
            return comment;
        }

        public Comment GetcommentId(int CommentId)
        {
            if (CommentId != null && CommentId != 0)
            {
                var comment = db.comments.Where(a => a.Id == CommentId).Include(a => a.User).FirstOrDefault();
                return comment;
            }
            return null;
        }

        public void Updatecomment(CommentVM commentVm)
        {
            if (commentVm.Id != null && commentVm.Id != 0)
            {
                var Old = db.comments.Where(a => a.Id == commentVm.Id).FirstOrDefault();
                if (commentVm != null)
                {
                    Old.Body = commentVm.Body;


                    db.SaveChanges();
                }
            }
        }
        #endregion

    }
}
