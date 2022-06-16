using Microsoft.EntityFrameworkCore;
using Project.Models;
using Regex = System.Text.RegularExpressions;

namespace Project.BusinessLayer
{
    public class GroupManager
    {
        private static readonly int MIN_GROUPNAME_LENGTH = 3;
        // alpha numeric string with min length of 3
        private static readonly Regex.Regex groupNameRegex = new($"^[' 0-9a-zA-Z]{{{MIN_GROUPNAME_LENGTH},}}$");
        public async Task CreateGroup(string groupName, User groupAdmin)
        {
            groupName = groupName.Trim();
            if (!groupNameRegex.IsMatch(groupName))
            {
                throw new ArgumentException($"Group name has to contain atleast {MIN_GROUPNAME_LENGTH} characters" +
                    " and can only contain alphanumeric characters");
            }

            using var db = await Task.Run(() => new DataContext());

            var admin = await db.Users.FindAsync(groupAdmin.Id);
            Group group = new Group(groupName, admin);
            db.Groups.Add(group);


            /*admin.ManagedGroups.Add(group);
            admin.Groups.Add(group);
            
            */
            db.Update(admin);

            await db.SaveChangesAsync();
        }
        public async Task AddGroupMembers(Group group, string usernames)
        {
            var usernamesSplit = usernames.Split(" ");

            using var db = await Task.Run(() => new DataContext());


            var trackedGroup = await db.Groups.FindAsync(group.Id);

            var users = db.Users.Where(u => usernamesSplit.Contains(u.Username)).ToList();

            foreach (var user in users)
            {
                trackedGroup.Members.Add(user);
            }

            db.Update(trackedGroup);

            await db.SaveChangesAsync();

            if (users.Count != usernamesSplit.Length)
            {
                throw new ArgumentException("Some of the entered username don't exist");
            }
        }

        public async Task<List<Group>> GetGroupsAsync(User member)
        {
            using var db = await Task.Run(() => new DataContext());
            User user = await db.Users.FindAsync(member.Id);
            return user.Groups.ToList();
        }

        public async Task<Group> GetGroupEagerAsync(Group group)
        {
            using var db = await Task.Run(() => new DataContext());
            return await db.Groups
                .Include(g => g.Admin)
                .Include(g => g.Members)
                .Include(g => g.Expenses)
                    .ThenInclude(e => e.Payer)
                .Include(g => g.Expenses)
                    .ThenInclude(e => e.Consumers)
                .FirstOrDefaultAsync(g => g.Equals(group));
        }
    }

}
