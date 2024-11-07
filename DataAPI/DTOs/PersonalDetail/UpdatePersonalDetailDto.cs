﻿using System.ComponentModel.DataAnnotations;

namespace DataAPI.DTOs.PersonalDetail;

public class UpdatePersonalDetailDto
{

    [Required]
    public string About { get; set; } = string.Empty;

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Surname { get; set; } = string.Empty;

    [Required]
    public DateTime BirthDate { get; set; }
}
