using Domain.Dtos;
using Domain.Entities;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CommentService
    {
        private readonly CommentRepository _commentRepository;
        public CommentService(CommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        protected bool ValidateComment(CommentDto commentDto)
        {
            if (commentDto == null) { return false; }
            if(string.IsNullOrEmpty(commentDto.Body)) { return false; }
            return true;
        }

        public bool CreateComment(CommentDto commentDto)
        {
            Comment comment = new Comment();
            if(!ValidateComment(commentDto)) { return false; }
            try
            {
                comment.Body = commentDto.Body;
                _commentRepository.Persist(comment);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateComment(CommentDto commentDto)
        {
            Comment comment = new Comment();
            if (!ValidateComment(commentDto)) { return false; }
            try
            {
                comment.Body = commentDto.Body;
                _commentRepository.Update(comment);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
