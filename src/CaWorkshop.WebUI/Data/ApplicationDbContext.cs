﻿using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using CaWorkshop.WebUI.Models;

namespace CaWorkshop.WebUI.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    public DbSet<TodoList> TodoLists => Set<TodoList>();

    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {

    }
}
