using Web01.Models;

namespace Web01.Services
{
    public class RepositoryOfProject
    {

        public List<ClassProject> GetProjects()
        {




            return new List<ClassProject>() {             
            
            
            new ClassProject{
                Title = "Asp.net",
                Description = "WEB realized en ASP.NET core",
                Link ="http://amazon.com",
                ImageURL = "fa-bomb"
            },
            
            new ClassProject
            {
                Title = "Java Project",
                Description = "WEB realized with JAVA",
                Link = "http://amazon.com",
                ImageURL = "fa-book"
            },
            new ClassProject
            {
                Title = "HTML y CSS",
                Description = "WEB realized With HTML y CSS",
                Link = "http://amazon.com",
                ImageURL = "fa-archive"
            },
             new ClassProject
            {
                Title = "REACT",
                Description = "WEB realized With REACT",
                Link = "http://amazon.com",
                ImageURL = "fa-cubes"
            }

            };
        }





    }
}
