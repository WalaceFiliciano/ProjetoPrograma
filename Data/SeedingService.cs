using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any()||
               _context.Sellers.Any() ||
               _context.SalesRecords.Any())
            {
                return; // O banco de dados foi Populado
            }

            Department d1 = new Department(1, "Financeiro");
            Department d2 = new Department(2, "Contas a Pagar");
            Department d3 = new Department(3, "Estoque");
            Department d4 = new Department(4, "Contas a Receber");
            Department d5 = new Department(5, "Faturamento");
            Department d6 = new Department(6, "Utilitarios");
            Department d7 = new Department(7, "Vendedores");


            Seller s1 = new Seller(1, "Helder", "helder@gmail.com", new DateTime(1982, 5, 22), 1500.0, d7);
            Seller s2 = new Seller(2, "Tainara", "tainarinha@gmail.com", new DateTime(1989, 9, 9), 1500.0, d1);
            Seller s3 = new Seller(3, "Mateus", "mateus@gmail.com", new DateTime(1990, 12, 26), 1500.0, d3);
            Seller s4 = new Seller(4, "Karine", "karine@gmail.com", new DateTime(1987, 7, 20), 1800.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Faturado, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 10, 12), 1200.0, SalesStatus.Pendente, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 08, 06), 1400.0, SalesStatus.Cancelado, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2017, 05, 10), 1350.0, SalesStatus.Faturado, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 06, 1), 12.0, SalesStatus.Faturado, s2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2015, 07, 2), 152.0, SalesStatus.Pendente, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2016, 03, 03), 170.0, SalesStatus.Faturado, s4);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2014, 11, 04), 176.0, SalesStatus.Faturado, s4);

            _context.Department.AddRange(d1, d2, d3, d4, d5, d6, d7);

            _context.Sellers.AddRange(s1, s2, s3, s4);

            _context.SalesRecords.AddRange(r1, r2, r3, r4, r5, r6, r7, r8);

            _context.SaveChanges();
        }
    }
}
