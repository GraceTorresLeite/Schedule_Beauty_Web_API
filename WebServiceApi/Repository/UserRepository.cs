using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using WebServiceApi.Data.VO;
using WebServiceApi.Models;
using WebServiceApi.Models.Bd;

namespace WebServiceApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ContextSql _context;

        public UserRepository(ContextSql context)
        {
            _context = context;
        }

        public User ValidateCredenctials(UserVO user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());
            return _context.Users.FirstOrDefault(u => (u.UserName == user.UserName) && (u.Password == pass));

        }

        public User RefreshUserInfo(User user)
        {
            if (!_context.Users.Any(u => u.Id.Equals(user.Id))) return null;

            var result = _context.Users.SingleOrDefault(p => p.Id.Equals(user.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
           // else
           // {
                return result;
          //  }
        }
        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }

        public User ValidateCredenctials(string username)
        {
            return _context.Users.SingleOrDefault(u => (u.UserName == username));
        }

        public bool RevokeToken(string username)
        {
            var user = _context.Users.SingleOrDefault(u => (u.UserName == username));
            if (user is null) return false;
            user.RefreshToken = null;
            _context.SaveChanges();
            return true;
        }
    }
}
