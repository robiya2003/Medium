using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class UserModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Salt {  get; set; }
        public string photopath {  get; set; }
        public string Bio {  get; set; }
        public int FollowersCount {  get; set; }
        public bool IsDelete {  get; set; }
    }
}
