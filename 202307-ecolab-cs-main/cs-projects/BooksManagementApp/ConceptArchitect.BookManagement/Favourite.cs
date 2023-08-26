using ConceptArchitect.Utils;
using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace ConceptArchitect.BookManagement
{
    public class Favourite
    {
       
            public int Id { get; set; }



            [Email]
            [ExistingUser]
            public string UserEmail { get; set; }



            [ExistingBook]
            public string BookId { get; set; }



            public string Status { get; set; } = "Reading";
        }      
    
}
