﻿namespace DataAPI.DTOs.BlogPost;

public class CreateBlogPostDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content{ get; set; }
    public DateTime PublishDate { get; set; }
    public int AuthorId { get; set; }
}