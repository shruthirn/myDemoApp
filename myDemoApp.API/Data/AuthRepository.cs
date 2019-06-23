using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myDemoApp.API.Models;

namespace myDemoApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<User> Login(string username, string password)
        {
            var user =await _context.Users.FirstOrDefaultAsync(x => x.Username == username);
            if (user == null)
            return null;

            if(!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
             return null;

            return user;
        
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512( passwordSalt))
            {

                var ComputedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                for (var i = 0; i < ComputedHash.Length; i++){
                    
                    if(ComputedHash[i] != passwordHash[i]) return false;

                }
            }
            return true;

        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash,passwordSalt;
            createPasswordHash(password, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash; // user is from models 
            user.PasswordSalt = passwordSalt;

//to add into database
            await _context.Users.AddAsync(user); //Users is the table name in DB
            await _context.SaveChangesAsync();

            return user;
        }
// out --> hold the reference of the variable after the execution the new values will be stored into the variables
                private void createPasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //any thing inside using statement will be disposed immideately after fininshing execution
            using(var hmac = new System.Security.Cryptography.HMACSHA512()){

                //hmacsha512 method consists of values for key to unlock the hash and hash
                passwordSalt = hmac.Key;
                //comuteHash method needs byte array as input hence using System.Text.Encoding.UTF8.GetBytes() to convert the password string into byte array
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string username)
        {
            if(await _context.Users.AnyAsync( x => x.Username == username))
                 return true;

            return false;
        }
    }
}