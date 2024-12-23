﻿using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICommentService
    {
        Task<List<Comment>> GetAll();
        Task<Comment> GetById(int id);
        Task Create(Comment model);
        Task Update(Comment model);
        Task Delete(int id);
    }
}