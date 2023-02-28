using System.Data.Entity;
using MySql.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Rest_API.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Rest_API.Data;

[DbConfigurationType(typeof(MySqlEFConfiguration))]
public class RestApiDbContext: DbContext
{
    public RestApiDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public Microsoft.EntityFrameworkCore.DbSet<Employee> Employees { get; set; }
}