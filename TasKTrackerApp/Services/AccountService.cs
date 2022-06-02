using TasKTrackerApp.Models;
using TasKTrackerApp.ViewModels.Account;

namespace TasKTrackerApp.Services
{
    public class AccountService
    {
        public static string RegisterLocalUser(RegisterViewModel registeredUser)
        {
            using (var dbContext = new TaskTrackerContext())
            {
                User localUser = new User
                {
                    FirstName = registeredUser.FirstName,
                    LastName = registeredUser.LastName,
                    Email = registeredUser.Email,
                    PhoneNumber = registeredUser.PhoneNumber,
                    Gender = registeredUser.Gender, 
                    BirthDate = registeredUser.BirthDate,
                    City = registeredUser.City,
                    State = registeredUser.State,
                    ZipCode = registeredUser.ZipCode,

                };

                dbContext.Users.Add(localUser);
                dbContext.SaveChanges();

                string userAccountId = localUser.UserAccountId.ToString();
                return userAccountId;

            }
        }

        // If we want the user to be able to edit some of their registered data

    }
}
