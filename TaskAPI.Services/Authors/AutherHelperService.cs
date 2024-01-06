using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Data;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public class AutherHelperService : IAuthorHelperService
    {
        private readonly TodoDBContext _todoDBContext = new TodoDBContext();
        public AutherHelperService()
        {
            
        }

        public Author GetAuthor(int id) => _todoDBContext.Authors.Find(id);

        public List<Author> GetAuthors()
        {
            return _todoDBContext.Authors.ToList();
        }
    }
}
