using Domain.Dtos;
using Domain.Entities;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class PostService
    {
        private readonly PostRepository _postRepository;
        public PostService(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        protected bool ValidatePost(PostDto postDto)
        {
            if (postDto == null) { return false; }
            if(string.IsNullOrEmpty(postDto.Description)) { return false; }
            if(string.IsNullOrEmpty(postDto.Picture)) { return false; }
            return true;
        }

        public bool CreatePost(PostDto postDto)
        {
            Post post = new Post();
            if(!ValidatePost(postDto)) { return false; }
            try
            {
                post.Description = postDto.Description;
                post.Picture = postDto.Picture;
                _postRepository.Persist(post);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdatePost(PostDto postDto)
        {

            Post post = new Post();
            if (!ValidatePost(postDto)) { return false; }
            try
            {
                post.Description = postDto.Description;
                post.Picture = postDto.Picture;
                _postRepository.Update(post);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
