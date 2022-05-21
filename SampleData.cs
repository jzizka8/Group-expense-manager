using Project.BusinessLayer;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class SampleData
    {
        private static List<string> usernames = new List<string>(){
                "Alice",
                "Bob",
                "Cyril",
                "Dan",
                "Eugen",
                "Frank",
                "Hans",
                "Ivan",
                "Josef"
        };
        private UserManager userManager;
        private GroupManager groupManager;
        public SampleData()
        {
            userManager = new UserManager();
            groupManager = new GroupManager();
        }
        public async Task AddSampleData()
        {
            List<Task> tasks = new()
            {
                AddSampleUsers(),
                //AddSampleGroups()
            };
            await Task.WhenAll(tasks);
            

        }
        public async Task AddSampleGroups()
        {
            List<Task> tasks = new();
            Random random = new Random();
            foreach (var username in usernames)
            {

                User user = await userManager.GetUserAsync(username);

                tasks.Add(groupManager.CreateGroup($"{username}'s group", user));


                int count = random.Next() % (usernames.Count - 3);
                string members = string.Join(" ", username.OrderBy(x => random.Next()).Take(count));
                
                //tasks.Add(groupManager.AddGroupMembers(group, members));

            }
            await Task.WhenAll(tasks);
        }
        public async Task AddSampleUsers()
        {
            List<Task> tasks = new();
            foreach(var username in usernames)
            {
                string password = username.ToLower();
                tasks.Add(userManager.RegisterUserAsync(username, password));
            }
            await Task.WhenAll(tasks);
        }
    }
}
