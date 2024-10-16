using System;
using System.Collections.Generic;

namespace DE15.Models;

public partial class TLoaiSach
{
    public string MaLoai { get; set; } = null!;

    public string? TenLoai { get; set; }

    public virtual ICollection<TSach> TSaches { get; set; } = new List<TSach>();
}
