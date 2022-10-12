using AulaEF_CF.Context;
using AulaEF_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEF_CF {
    internal class Program {
        static void Main(string[] args) {

            using (var context = new PersonContext()) {

                #region Insere Dados
                ////  context.Persons.Add(new Person() { Name="Julio", Phone = "123" });
                //Person person = new Person();
                //person.Name = "barotox";
                //person.Phone = "258";
                //person.Mobile = "007";
                //person.Email = "nois@";
                //context.Persons.Add(person);
                //context.SaveChanges();
                #endregion

                #region Lista Todos
                //var persons = new PersonContext().Persons.ToList();
                //foreach (var item in persons) {
                //    Console.WriteLine(item.ToString());

                //}
                //Console.ReadKey();
                #endregion

                #region Listar Unico
                //Console.Write("\nNome: ");
                //string n = Console.ReadLine();
                //Person find = new PersonContext().Persons.FirstOrDefault(c => c.Name == n);
                ////Person find1 = new PersonContext().Persons.Find(3);
                //if (find != null) {
                //    find.Name = "show";//Altera o nome do produto
                //    context.SaveChanges();
                //    Console.WriteLine(find.ToString());
                //}
                #endregion

                #region Remove
                //context.Entry(find).State= EntityState.Deleted;
                //context.Persons.Remove(find);
                //context.SaveChanges();
                #endregion

                #region Update
                Console.Write("\nNome: ");
                string n = Console.ReadLine();
                Person find = new PersonContext().Persons.FirstOrDefault(c => c.Name == n);
                if (find != null) {
                    context.Entry(find).State = EntityState.Modified;
                    //context.Persons.AddOrUpdate(find);
                    find.Name = "Maicon";//Altera o nome do produto
                    context.SaveChanges();
                    Console.WriteLine(find.ToString());
                }

                #endregion
            }


            Console.ReadKey();

        }
    }
}
