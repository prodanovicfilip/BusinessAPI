using System;
using System.Collections.Generic;

namespace BusinessAPI.Entities;

public partial class Client
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;
}
