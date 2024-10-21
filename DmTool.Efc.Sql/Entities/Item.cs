﻿using System.Runtime.CompilerServices;

namespace DmTool.Efc.Sql.Entities;

public class Item : BaseEntity
{
    public ICollection<string>? ItemOutcomes { get; set; }
    public int CharacterId { get; set; }
}