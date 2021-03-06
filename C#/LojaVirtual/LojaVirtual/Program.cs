﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.Entities;
using Microsoft.Data.Entity;

namespace LojaVirtual {
    class Program {
        static void Main(string[] args) {
            //string conn = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbLojaVirtual.mdf;Integrated Security=True;Connect Timeout=30"; //String de conexão
            //IDbConnection con = new SqlConnection(conn);
            //IDbCommand com = con.CreateCommand();
            //com.CommandText = "select * from tbCliente";
            //IDataReader read = com.ExecuteReader();
            //while (read.Read()) {
            //    int Id = Convert.ToInt32(read["Id"]);
            //    string Name = Convert.ToString(read["Name"]);
            //}

            UserDAO dao = new UserDAO();

            //ADD
            //User Client = new User() { Name = "Malu", Pass = "123" };
            //dao.Add(Client);
            //Console.WriteLine( Properties.Resources.Saved );

            //FIND
            //User Client = dao.FindId(5);
            //Console.WriteLine( Client.Name );

            //REMOVE
            //User Client = dao.FindId(2);
            //dao.Remove(Client);
            //Console.WriteLine( Properties.Resources.Removed );

            //UPDATE
            //User Client = dao.FindId(4);
            //Client.Pass = "noob";
            //dao.Update();
            //Console.WriteLine(Properties.Resources.Updated);

            //NEW CONTEXTS - Category and Product
            //EntitiesContext context = new EntitiesContext();
            //Category cat = new Category() { Name = "Informática" };
            //context.Categories.Add(cat);
            //context.SaveChanges();
            //Product prod = new Product() { Name = "Notebook Tijolo", Price = 20, Category = cat };
            //context.Products.Add(prod);
            //context.SaveChanges();
            //Console.WriteLine( Properties.Resources.Register );

            //Add only the Prod with an existing Category by they ID
            //EntitiesContext context = new EntitiesContext();
            //Product prod = new Product() { Name = "HD Externo 4TB USB 3.0", Price = 550, CategoryId = 1 };
            //context.Products.Add(prod);
            //context.SaveChanges();
            //Console.WriteLine(Properties.Resources.Register);

            //Search for a product or category (Prod this case) by they Id
            //EntitiesContext context = new EntitiesContext();
            //Product p = context.Products.FirstOrDefault(product => product.Id == 1);
            //Console.WriteLine(p.Name);

            //Search for a product and his category, show on the console the category only, by they Id
            //EntitiesContext context = new EntitiesContext();
            //Product p = context.Products.Include(product => product.Category).FirstOrDefault(product => product.Id == 1);
            //Console.WriteLine(p.Category.Name);

            //List of products in an category
            //EntitiesContext context = new EntitiesContext();
            //var category = context.Categories.Include(c => c.Products).FirstOrDefault(c => c.Id == 1);
            //foreach (var p in category.Products) {
            //    Console.WriteLine(p.Name);
            //}

            //Avaliative Activity
            //EntitiesContext context = new EntitiesContext();
            //Category cat = new Category() { Name = "Papelaria" };
            //context.Categories.Add(cat);
            //context.SaveChanges();
            //Product prod = new Product() { Name = "Lapis de Cor 60 cores", Price = 64, Category = cat };
            //context.Products.Add(prod);
            //context.SaveChanges();
            //prod = new Product() { Name = "Caneta Hidrográfica", Price = 24, Category = cat };
            //context.Products.Add(prod);
            //context.SaveChanges();
            //prod = new Product() { Name = "Cola Bastão", Price = 14, Category = cat };
            //context.Products.Add(prod);
            //context.SaveChanges();
            //prod = new Product() { Name = "Lapiseira 0.7mm", Price = 7, Category = cat };
            //context.Products.Add(prod);
            //context.SavesChanges();
            //prod = new Product() { Name = "Papel Sulfite A4", Price = 23, Category = cat };
            //context.Products.Add(prod);
            //context.SaveChanges();
            //Console.WriteLine(Properties.Resources.Register);

            //Using LINQ
            //EntitiesContext context = new EntitiesContext();
            //var search = from p in context.Products select p;
            //foreach (var prod in search) {
            //    Console.WriteLine(prod.Name);
            //}

            //The(funcking) same thing
            //EntitiesContext context = new EntitiesContext();
            //var search = from p in context.Products select p;
            //IList<Product> res = search.ToList();
            //foreach (var prod in res) {
            //    Console.WriteLine(prod.Name);
            //}

            //EntitiesContext context = new EntitiesContext();
            //var search = from p in context.Products orderby p.Name select p;
            //IList<Product> res = search.ToList();
            //foreach (var prod in res) {
            //    Console.WriteLine(prod.Name);
            //}

            //EntitiesContext context = new EntitiesContext();
            //var search = from p in context.Products where (p.Price > 30) select p;
            //IList<Product> res = search.ToList();
            //foreach (var prod in res) {
            //    Console.WriteLine(prod.Name);
            //}

            //EntitiesContext context = new EntitiesContext();
            //var search = from p in context.Products where (p.Price > 30) select p;
            //IList<Product> res = search.ToList();
            //foreach (var prod in res) {
            //    Console.WriteLine(prod.Name + "\t\t" + prod.Price);
            //}

            //EntitiesContext context = new EntitiesContext();
            //decimal pMin = 20;
            //var search = from p in context.Products where (p.Price > pMin) select p;
            //IList<Product> res = search.ToList();
            //foreach (var prod in res) {
            //    Console.WriteLine(prod.Name + "\t\tR$ " + prod.Price);
            //}

            //EntitiesContext context = new EntitiesContext();
            //var search = from p in context.Products where (p.Category.Name == "Papelaria") select p;
            //foreach (var prod in search) {
            //    Console.WriteLine(prod.Name + "\t\tR$ " + prod.Price);
            //}

            //EntitiesContext context = new EntitiesContext();
            //decimal pMin = 20;
            //var search = from p in context.Products where ((p.Category.Name == "Papelaria") && (p.Price > pMin)) select p;
            //foreach (var prod in search) {
            //    Console.WriteLine(prod.Name + "\t\tR$ " + prod.Price);
            //}

            //Start the ProdDAO
            EntitiesContext context = new EntitiesContext();
            ProdDAO pdao = new ProdDAO(context);

            //var res = pdao.SearchNPC(null, 0, null);
            //foreach (var prod in res) {
            //    Console.WriteLine(prod.Name);
            //}

            //var res = pdao.SearchNPC("Cola Bastão", 0, null);
            //foreach (var prod in res) {
            //    Console.WriteLine(prod.Name);
            //}

            //var res = pdao.SearchNPC(null, 24, null);
            //foreach (var prod in res) {
            //    Console.WriteLine(prod.Name);
            //}

            //var res = pdao.SearchNPC("Cola Bastão", 0, null);
            //foreach (var prod in res) {
            //    Console.WriteLine(prod.Name);
            //}

            UserDAO udao = new UserDAO();
            User users = udao.FindId(3);

            Sale s = new Sale() {
                Client = users
            };

            Product p1 = context.Products.FirstOrDefault(prod => prod.Id == 1);
            Product p2 = context.Products.FirstOrDefault(prod => prod.Id == 2);

            //ProdSale ps1 = new ProdSale() {
            //    Sales = s,
            //    ProdID = p1.Id,
            //    Products = p1
            //};

            ProdSale ps2 = new ProdSale() {
                Sales = s,
                ProdID = p2.Id,
                Products = p2
            };

            //context.Sales.Add(s);
            //context.ProdSales.Add(ps1);
            context.ProdSales.Add(ps2);

            context.SaveChanges();

            Console.WriteLine("Foi!");

            Console.ReadLine();
        }
    }
}
