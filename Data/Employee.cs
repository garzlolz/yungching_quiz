﻿using System;
using System.Collections.Generic;

namespace yungching_quiz.Data;

public partial class Employee
{
    public string EmpId { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string? Minit { get; set; }

    public string Lname { get; set; } = null!;

    public short JobId { get; set; }

    public byte? JobLvl { get; set; }

    public string PubId { get; set; } = null!;

    public DateTime HireDate { get; set; }
}
