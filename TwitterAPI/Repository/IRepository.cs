﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TwitterAPI.Models;

namespace TwitterAPI.Database
{
    public interface IRepository
    {
        Task<IEnumerable<Post>> GetAllPosts();
        //IEnumerable<String> GetAllPosts();
        Post GetPostByName(string name);
        bool SavePost(Post blogPost);

    }
}
