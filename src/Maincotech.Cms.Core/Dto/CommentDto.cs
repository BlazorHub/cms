﻿using System;

namespace Maincotech.Cms.Dto
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public string Content { get; set; }
        public Guid? ReplyTo { get; set; }
        public string Author { get; set; }
    }
}