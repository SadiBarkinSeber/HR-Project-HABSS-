#region Dependincies
using Azure.Storage.Blobs;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.ExpenseHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.ExpenseHandlers.Write;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using HR_PROJECT.Persistence.Context;
using HR_PROJECT.Persistence.Repositories;
using HR_PROJECT.Persistence.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Read;
using HR_PROJECT.WebAPI.HelperFunctions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
#endregion


var builder = WebApplication.CreateBuilder(args);

#region JWT Configuration
// Configure Jwt
var jwtIssuer = builder.Configuration.GetSection("Jwt:Issuer").Get<string>();
var jwtKey = builder.Configuration.GetSection("Jwt:Key").Get<string>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtIssuer,
            ValidAudience = jwtIssuer,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
        };
    });
#endregion

// Add services to the container.

builder.Services.AddScoped<HRProjectContext>();

builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<HRProjectContext>();

builder.Services.ConfigureApplicationCookie(opts => opts.LoginPath = "/Account/Login");

builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.User.RequireUniqueEmail = true;
});


#region DependencyInjection of Repositories
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IPermissionRepository), typeof(PermissionRepositoty));
builder.Services.AddScoped(typeof(IAdvanceRepository), typeof(AdvanceRepository));
builder.Services.AddScoped(typeof(IExpenseRepository), typeof(ExpenseRepository));
#endregion

#region Dependency Injection of Blob Connection
builder.Services.AddSingleton(x =>
{
    var connectionString = builder.Configuration.GetConnectionString("BlobStorageConnection");

    return new BlobServiceClient(connectionString);
});
#endregion

#region Dependency Injection of Employee Handlers
builder.Services.AddScoped<GetEmployeeByIdQueryHandler>();
builder.Services.AddScoped<GetEmployeeQueryHandler>();
builder.Services.AddScoped<CreateEmployeeCommandHandler>();
builder.Services.AddScoped<UpdateEmployeeCommandHandler>();
builder.Services.AddScoped<RemoveEmployeeCommandHandler>();

#endregion

#region Dependency Injection of Permission Handlers
builder.Services.AddScoped<GetPermissionsByEmployeeIDHandler>();
builder.Services.AddScoped<CreatePermissionCommandHandler>();
builder.Services.AddScoped<RemovePermissionCommandHandler>();
builder.Services.AddScoped<UpdatePermissionCommandHandler>();
builder.Services.AddScoped<GetPermissionQueryHandler>();
#endregion

#region Dependency Injection of Expense Handlers

builder.Services.AddScoped<GetExpenseByIdQueryHandler>();
builder.Services.AddScoped<GetExpenseQueryHandler>();
builder.Services.AddScoped<CreateExpenseCommandHandler>();
builder.Services.AddScoped<UpdateExpenseCommandHandler>();
builder.Services.AddScoped<RemoveExpenseCommandHandler>();
builder.Services.AddScoped<GetExpenseByEmployeeIdQueryHandler>();

#endregion

#region Dependency Injection of Advance Handlers

builder.Services.AddScoped<GetAdvanceByIdQueryHandler>();
builder.Services.AddScoped<GetAdvanceQueryHandler>();
builder.Services.AddScoped<CreateAdvanceCommandHandler>();
builder.Services.AddScoped<UpdateAdvanceCommandHandler>();
builder.Services.AddScoped<RemoveAdvanceCommandHandler>();
builder.Services.AddScoped<GetAdvanceByEmployeeIdQueryHandler>();
#endregion

#region Dependency Injection of Helper Functions

builder.Services.AddScoped<CheckEmployeeWage>();

#endregion

builder.Services.AddControllers(); 

#region CORS Policy

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});



#endregion

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors("AllowAll");


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
