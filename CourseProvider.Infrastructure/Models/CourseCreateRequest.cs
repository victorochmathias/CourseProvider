﻿using CourseProvider.Infrastructure.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace CourseProvider.Infrastructure.Models;

public class CourseCreateRequest
{
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public bool IsBestseller { get; set; }
    public bool IsDigital { get; set; }
    public string[]? Categories { get; set; }
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public decimal StarRating { get; set; }
    public string? Reviews { get; set; }
    public string? LikesInProcent { get; set; }
    public string? Likes { get; set; }
    public string? Hours { get; set; }
    public virtual List<AuthorCreateRequest>? Authors { get; set; }
    public virtual PricesCreateRequest? Prices { get; set; }
    public virtual ContentCreateRequest? Content { get; set; }
}

public class AuthorCreateRequest
{
    public string? Name { get; set; }
}

public class PricesCreateRequest
{
    public string? Currency { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}
public class ContentCreateRequest
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailItemCreateEntity>? ProgramDetails { get; set; }
}

public class ProgramDetailItemCreateEntity
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
