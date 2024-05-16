﻿namespace CourseProvider.Infrastructure.Models;

public class CourseUpdateRequest
{
    public string Id { get; set; } = null!;
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
    public virtual List<AuthorUpdateRequest>? Authors { get; set; }
    public virtual PricesUpdateRequest? Prices { get; set; }
    public virtual ContentUpdateRequest? Content { get; set; }
}

public class AuthorUpdateRequest
{
    public string? Name { get; set; }
}

public class PricesUpdateRequest
{
    public string? Currency { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}
public class ContentUpdateRequest
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailItemUpdateEntity>? ProgramDetails { get; set; }
}

public class ProgramDetailItemUpdateEntity
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
