﻿using Microsoft.EntityFrameworkCore;
using TesteTecnico.Entity;
using TesteTecnico.Service;

namespace TesteTecnico.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
    }
}
