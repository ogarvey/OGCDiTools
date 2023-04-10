using System;
using System.Collections.Generic;

namespace Desktop.Models;

public partial class DataFile
{
    public long Id { get; set; }

    public long? PlanetId { get; set; }

    public string Name { get; set; } = null!;

    public string? SpriteData { get; set; }

    public long? DyuvOffset { get; set; }

    public long? TextOffset { get; set; }

    public long? HasScreen { get; set; }

    public long? HasDyuv { get; set; }

    public long? HasText { get; set; }

    public long? HasSprites { get; set; }

    public virtual Planet? Planet { get; set; }
}
