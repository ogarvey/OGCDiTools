using System;
using System.Collections.Generic;

namespace Desktop.Models;

public partial class Planet
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DataFile> DataFiles { get; } = new List<DataFile>();
}
