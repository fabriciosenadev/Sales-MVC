using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); // associação associação para muitos vendedores

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final)); // soma todas as vendas do departamento reaproveitndo o metodo dos sellers
        }
    }
}
