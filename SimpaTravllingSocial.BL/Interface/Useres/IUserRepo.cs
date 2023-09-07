namespace SimpaTravllingSocial.BL.Interface.Useres
{
    public interface IUserRepo
    {
        List<User> GetAllUser();
        void CreateUser(User user);
        User GetUserId(int userId);
        void DeleteUser(int userId);
        void UpdateUser(UserVM user);
    }
}
