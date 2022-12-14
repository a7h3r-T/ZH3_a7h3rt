using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Time
{
    public byte TimeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; } = new List<Lesson>();
}
