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
        private readonly DBContext _dbContext = new DBContext();
        public AutherHelperService()
        {

        }

        public Author GetAuthor(int id) => _dbContext.Authors.Find(id);

        public List<Author> GetAuthors()
        {
            return _dbContext.Authors.ToList();
        }

        public List<Author> GetAuthors(string job, string search)
        {
            if (string.IsNullOrEmpty(job) && string.IsNullOrEmpty(search))
                return GetAuthors();

            var data = _dbContext.Authors as IQueryable<Author>;

            if (!string.IsNullOrEmpty(job))
            {
                job = job.Trim();
                data = data.Where(record => record.JobRole == job);

            }

            if (!string.IsNullOrEmpty(search))
            {
                search = search.Trim();
                data = data.Where(record => 
                    record.FullName.Contains(search) || record.City.Contains(search));
            }

            return data.ToList();

        }

        public Author AddAuthor(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();

            return _dbContext.Authors.Find(author.Id);
        }
    }
}
