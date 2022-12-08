using System;
using System.Collections.Generic;

namespace CustomersTest.Models;

public partial class InfCustomer
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Company { get; set; }

    public string? Phone { get; set; }

    public string? Type { get; set; }
}
