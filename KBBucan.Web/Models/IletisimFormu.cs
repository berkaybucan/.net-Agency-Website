using System;
using System.Collections.Generic;

namespace KBBucan.Web.Models;

public partial class IletisimFormu
{
    public int MesajId { get; set; }

    public string? AdSoyad { get; set; }

    public string? MailAdres { get; set; }

    public string? TelefonNumarasi { get; set; }

    public string? Konu { get; set; }

    public string? Mesaj { get; set; }

    public string? ProjeButcesi { get; set; }
}
