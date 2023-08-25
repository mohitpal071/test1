using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class User
    {



        [Key]
        public string username { get; set; }

        
       
        public string name { get; set; }

        
        public string password { get; set; }
    }
}
