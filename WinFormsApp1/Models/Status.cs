using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Status
{
    public byte StatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();
}
