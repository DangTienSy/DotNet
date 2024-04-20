﻿using DotNet.Dtos.Comment;
using DotNet.Models;

namespace DotNet.Mappers
{
    public static class CommentMappers
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto()
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreateOn = commentModel.CreateOn,
                StockId = commentModel.StockId,
            };
        }

        public static Comment ToCommentFromCreate(this CreateCommentDto commentDto,int stockId)
        {
            return new Comment
            {               
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId,
            };
        }
    }
}