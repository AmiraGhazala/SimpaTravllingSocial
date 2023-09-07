namespace SimpaTravllingSocial.BL.Repo
{
    public class PostRepo:IPosts
    {
        #region field
        private readonly ApplicationDbContext db;
        #endregion
        #region constractor
        public PostRepo(ApplicationDbContext db)
        {
            this.db = db;
        }
        #endregion
        #region handel function
        public void CreatePost(Post post)
        {
            try
            {
                post.date = DateTime.Now;
                db.posts.Add(post);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void DeletePost(int postid)
        {
            if (postid != null && postid != 0)
            {
                var post = db.posts.Where(a => a.Id == postid).FirstOrDefault();
                if (post != null)
                {
                    post.IsDeleted = true;
                    db.SaveChanges();
                }
            }
        }

        public List<Post> GetAllPost()
        {
            var post = db.posts.Where(a => a.IsDeleted != true).Include(a => a.User).ToList();
            return post;
        }

        public Post GetPostId(int postid)
        {
            if (postid != null && postid != 0)
            {
                var post = db.posts.Where(a => a.Id == postid).Include(a => a.User).FirstOrDefault();
                return post;
            }
            return null;
        }

        public void UpdatePost(PostVM postvm)
        {
            if (postvm.Id != null && postvm.Id != 0)
            {
                var Old = db.posts.Where(a => a.Id == postvm.Id).FirstOrDefault();
                if (postvm != null)
                {
                    Old.Body = postvm.Body;


                    db.SaveChanges();
                }
            }
        }
        #endregion
    }
}
