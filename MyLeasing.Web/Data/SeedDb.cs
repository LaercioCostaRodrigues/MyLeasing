﻿using System;
using System.Linq;
using System.Threading.Tasks;
using MyLeasing.Web.Data;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private Random _random;

        public SeedDb(DataContext context)
        {
            _context = context;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Owners.Any())
            {
                AddOwners("Anders", "Hejlsberg", "Copenhage, Dinamarca");
                AddOwners("Dennis", "Ritchie", "Bronxville, Nova York, EUA");
                AddOwners("Bjarne", "Stroustrup", "Arhus, Dinamarca");
                AddOwners("Brian", "Kernighan", "Toronto, Canadá");
                AddOwners("Kenneth", "Thompson", "Nova Orleans, Luisiana, EUA");
                AddOwners("Linus", "Torvalds", "Helsinque, Finlândia");
                AddOwners("James", "Gosling", "Calgary, Canadá");
                AddOwners("Richard", "Matthew Stallman", "Nova Iorque, Nova York, EUA");
                AddOwners("Bill", "Joy", "Farmington Hills, Michigan, EUA");
                AddOwners("Grace", "Hopper", "Nova Iorque, Nova York, EUA");
                await _context.SaveChangesAsync();
            }
        }

        private void AddOwners(string first, string last, string address)
        {
            _context.Owners.Add(new Owner
            { 
                Document = _random.Next(99999999).ToString(),
                FirstName = first,
                LastName = last,
                FixedPhone = _random.Next(99999999).ToString(),
                CellPhone = _random.Next(99999999).ToString(),
                Address = address
            });
        }
    }
}
