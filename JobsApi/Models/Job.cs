﻿using System;
using System.Collections.Generic;

namespace JobsApi.Models;

public partial class Job
{
    public int Id { get; set; }

    public string JobName { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Qualification { get; set; } = null!;

    public string Salary { get; set; } = null!;

    public string Location { get; set; } = null!;
}