namespace SimpaTravllingSocial.BL.Interface.Posts
{
    public interface IPosts
    {
        List<Post> GetAllPost();
        void CreatePost(Post user);
        Post GetPostId(int PostId);
        void DeletePost(int PostId);
        void UpdatePost(PostVM postVm);
    }
}
