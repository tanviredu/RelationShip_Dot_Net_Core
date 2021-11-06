using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SamuraiApp.Data;
using SamuraiApp.Domain;


namespace SamuraiApp.Service
{
    public class InteractionBasic : IInteractionBasic
    {
        private static SamuraiContext _context;
        public InteractionBasic()
        {
            _context = new SamuraiContext();
        }

        public void AddSamurais(params string[] names)
        {

            foreach (string name in names)
            {
                _context.Samurais.Add(new Samurai { Name = name });
            }
            _context.SaveChanges();
        }


        // add various item
        public void AddVariousTypes()
        {

            _context.AddRange(new Samurai { Name = "Shimeda" },
                              new Samurai { Name = "Okomoto" },
                              new Battle { Name = "Battle of Avengers" },
                              new Battle { Name = "Battle of the Neshahino" });
            _context.SaveChanges();
        }




        public void GetSamurais()
        {

            var samurais = _context.Samurais.ToList();
            Console.WriteLine($"Samurai count is {samurais.Count}");

        }


        public void QueryFilters()
        {
            var name = "Shimeda";
            //var samurais = _context.Samurais.Where(s => s.Name == name).ToList();
            // filtr with Like
            var samurais = _context.Samurais.Where(s => EF.Functions.Like(s.Name, "S%")).ToList();

        }

        public void QueryAggrates()
        {

            var name = "Shimeda";
            var samurai = _context.Samurais.Where(s => s.Name == name).FirstOrDefault();
            Console.WriteLine(samurai.Name);
        }

        public void RetrieveAndUpdateSamurai()
        {
            var samurai = _context.Samurais.FirstOrDefault();
            samurai.Name = "Hawkeye";
            _context.SaveChanges();

        }

        public void DeleteData()
        {
            // first fetch the object
            // then delete
            var samurai = _context.Samurais.Find(2);
            _context.Samurais.Remove(samurai);
            _context.SaveChanges();


        }

        public void InsertNewSamuraiWithQuote() {

            var samurai = new Samurai
            {
                Name = "Kambei Shimeda",
                Quotes = new List<Quote>
                {
                    new Quote { Text = "I have Come to save You"}

                }
            };

            _context.Samurais.Add(samurai);
            _context.SaveChanges();
        }

        public void AddQuotewithExistingSamurai()
        {

            var samurai = _context.Samurais.FirstOrDefault();
            samurai.Quotes = new List<Quote>();
            samurai.Quotes.Add(new Quote { Text = "I have Come to save You" });
            _context.Samurais.Update(samurai);
            _context.SaveChanges();

        }

        public void EgarLoadingsamuraiWithQuotes()
        {
            var samuraiWithQuotes = _context.Samurais.Include(s => s.Quotes).ToList();
            foreach (var samurai in samuraiWithQuotes) {
                Console.WriteLine(samurai.Name);
                foreach (var quotes in samurai.Quotes) {
                    Console.WriteLine(quotes.Text);
                }
            }
        
        }

        public void QueryProjection() {

            var projection = _context.Samurais.Select
                (s => new { s.Id, s.Name, HappyQuotes = s.Quotes }).ToList();
            Console.WriteLine();
        }

        public void FilterwithRelatedData() {

            // filter based on the include data/subquery
            var samurais = _context.Samurais.Where(s => s.Quotes.Any(
                q => q.Text.Contains("save"))).ToList();
            Console.WriteLine();
        }


        public void AddingSamuraiWithExistingBattle() 
        {
            var battle = _context.Battles.FirstOrDefault();
            battle.Samurais.Add(new Samurai { Name = "Takeda Shingen" });
            _context.SaveChanges();
            
        }

        public void ReturnBattleWithSamurai()
        {
            var battle = _context.Battles.Include(b => b.Samurais).FirstOrDefault();
            Console.WriteLine();
        
        }

        public void ReturnAllbattleWithSamurai()
        {
            var battles = _context.Battles.Include(s => s.Samurais).ToList();
            Console.WriteLine();
            
        }

        public void ReturnAllSamuraiWithBattle() {

            var samurais = _context.Samurais.Include(s => s.Battles).ToList();
            Console.WriteLine();
        }

        public void RemoveSamuraiFromBattle()
        {
        }
    }
}
