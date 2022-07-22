using System.Security.Cryptography;
using System.Text.Json;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedUsers(DataContext Context)
        {
            if (await Context.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData);

            foreach (var user in users)
            {
                user.Profession = (Profession)Context.Character.FirstOrDefault(x=>x.ID==user.ProfessionId);
                using var hmac = new HMACSHA512();
                user.UserName = user.UserName.ToLower();
                user.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("Password"));
                user.PasswordSalt = hmac.Key;

                Context.Users.Add(user);
            }
            await Context.SaveChangesAsync();
        }
        public static async Task SeedIcons(DataContext Context)
        {
            if (await Context.Icon.AnyAsync()) return;

            var IconData = await System.IO.File.ReadAllTextAsync("Data/IconSeedData.json");
            var Icons = JsonSerializer.Deserialize<List<Icon>>(IconData);
            foreach (var icon in Icons)
            {
                Context.Icon.Add(icon);
            }
            await Context.SaveChangesAsync();
        }
        public static async Task SeedCharacters(DataContext Context)
        {
            if (await Context.Character.AnyAsync()) return;

            var CharacterData = await System.IO.File.ReadAllTextAsync("Data/CharacterSeedData.json");
            var Characters = JsonSerializer.Deserialize<List<Character>>(CharacterData);
            foreach (var Char in Characters)
            {
                Context.Character.Add(Char);
            }
            await Context.SaveChangesAsync();
        }
    }
}