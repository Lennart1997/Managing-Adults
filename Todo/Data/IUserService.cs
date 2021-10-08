using ToDo.Models;

namespace ToDo.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}