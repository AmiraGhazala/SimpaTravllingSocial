

namespace SimpaTravllingSocial.PL.Controllers
{
    public class AmiraController : Controller
    {
        #region feild
        private readonly IUserRepo Db;
        #endregion
        #region constructor
        public AmiraController(IUserRepo Db)
        {
            this.Db = Db;
        }
        #endregion
        public IActionResult Index()
        {

            var UserList = Db.GetAllUser();
            return View(UserList);
        }
    }
}
