﻿using System.Xml.Linq;

namespace Core.Entities;

public class AboutMe : BaseEntity
{
    public string Introduction { get; set; } = "Intro";
    public string ImageUrl1 { get; set; }
    public string ImageUrl2 { get; set; }
}
