
namespace SimpaTravllingSocial.BL.Interface.Comments
{
    public interface ICommentRepo
    {
        List<Comment> GetAllComment();
        void CreateComment(Comment comment);
        Comment GetcommentId(int CommentId);
        void DeleteComment(int CommentId);
        void Updatecomment(CommentVM commentVm);
    }
}
