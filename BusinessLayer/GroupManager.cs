using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regex = System.Text.RegularExpressions;

namespace Project.BusinessLayer
{
    public class GroupManager
    {
        private static readonly int MIN_GROUPNAME_LENGTH = 3;
        // alpha numeric string with min length of 3
        private static readonly Regex.Regex groupNameRegex = new($"[0-9a-zA-Z]{{{MIN_GROUPNAME_LENGTH},}}");
        public async Task CreateGroup(string groupName, User groupAdmin)
        {
            if (!groupNameRegex.IsMatch(groupName))
            {
                throw new ArgumentException($"Group name has to contain atleast {MIN_GROUPNAME_LENGTH} characters" +
                    " and can only contain alphanumeric characters");
            }

            using var db = await Task.Run(() => new DataContext());

            var admin = await db.Users.FindAsync(groupAdmin.Id);
            Group group = new Group(groupName, admin);
            db.Groups.Add(group);


            admin.ManagedGroups.Add(group);
            admin.Groups.Add(group);
            db.Update(admin);

            await db.SaveChangesAsync();
        }

        public async Task<List<Group>> GetGroupsAsync(User member)
        {
            using var db = await Task.Run(() => new DataContext());
            User user = await db.Users.FindAsync(member.Id);
            return user.Groups.ToList();
        }

        public async Task<List<User>> GetGroupMembersAsync(Group group){
            using var db = await Task.Run(() => new DataContext());
            Group trackedGroup = await db.Groups.FindAsync(group.Id);
            
            return trackedGroup.Members.ToList();
        }
    }

}
