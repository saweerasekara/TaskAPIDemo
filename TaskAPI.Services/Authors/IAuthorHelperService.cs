using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public interface IAuthorHelperService
    {
        List<Author> GetAuthors();

        Author GetAuthor(int id);

        List<Author> GetAuthors(string job, string search);
    }
}
