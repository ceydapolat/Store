﻿namespace Entities;

public record UserDtoForUpdate : UserDto
{
    public HashSet<string> UserRoles { get; set; } = new HashSet<string>();
}
