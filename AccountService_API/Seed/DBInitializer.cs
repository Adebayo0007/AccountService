using AccountService_API.Common;
using AccountService_API.Entities;
using Microsoft.AspNetCore.Identity;

namespace AccountService_API.Seed
{
    public class DBInitializer
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public DBInitializer(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedInitialData()
        {
            //SEED CHAIRMAN
            if (!await _roleManager.RoleExistsAsync(RoleConstant.Chairman))
            {
                var chairmanRole = new Role { Name = RoleConstant.Chairman, Description = "In charge everything" };
                await _roleManager.CreateAsync(chairmanRole);

                if (await _userManager.FindByEmailAsync("chairman@gmail.com") == null)
                {
                    var chairman = new User
                    {
                        UserName = "Chirman",
                        Email = "chairman@gmail.com",
                        FirstName = "Mr",
                        LastName = "Chairman",
                        RoleId = chairmanRole.Id,
                        PhoneNumber = "08083456477",
                        PhoneNumberConfirmed = true,
                        EmailConfirmed = true,
                        DateCreated = DateTime.Now,
                        DateOfBirth = DateTime.Now.AddYears(-20),
                        Gender = "Male"
                    };

                    var result = await _userManager.CreateAsync(chairman, "Chairman123!");

                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(chairman, RoleConstant.Chairman);
                    }
                    else
                    {
                        // Handle errors if user creation fails
                        Console.WriteLine($"Seeding user failed and these are the errors {result.Errors}");
                    }
                }

                //SEED ADMIN
                if (!await _roleManager.RoleExistsAsync(RoleConstant.Administrator))
                {
                    var adminRole = new Role { Name = RoleConstant.Administrator, Description = "In charge of taking inventor" };
                    await _roleManager.CreateAsync(adminRole);

                    if (await _userManager.FindByEmailAsync("admin@gmail.com") == null)
                    {
                        var adminUser = new User
                        {
                            UserName = "Admininstrator",
                            Email = "admin@gmail.com",
                            FirstName = "Mrs",
                            LastName = "Admin",
                            RoleId = adminRole.Id,
                            DateCreated = DateTime.Now,
                            PhoneNumber = "07033245590",
                            PhoneNumberConfirmed = true,
                            EmailConfirmed = true,
                            DateOfBirth = DateTime.Now,
                            Gender = "Female",
                            // add other properties as needed
                        };

                        var result = await _userManager.CreateAsync(adminUser, "Admin123!");

                        if (result.Succeeded)
                        {
                            await _userManager.AddToRoleAsync(adminUser, RoleConstant.Administrator);
                        }
                        else
                        {
                            // Handle errors if user creation fails
                            Console.WriteLine("Seeding user failed");
                        }
                    }
                }


            }
        }
    }
}
