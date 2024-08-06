using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IdentityServer4.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer();
