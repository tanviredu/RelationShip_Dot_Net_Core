using System;
using SamuraiApp.Service;
namespace SamuraiApp
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var cr = new InteractionBasic();
            //cr.AddSamurais("ruhul", "tanvir", "tonmoy");
            //cr.GetSamurais();
            //cr.AddVariousTypes();
            //cr.GetSamurais();
            //cr.QueryFilters();
            //cr.QueryAggrates();
            //cr.RetrieveAndUpdateSamurai();
            //cr.DeleteData();
            //cr.InsertNewSamuraiWithQuote();
            //cr.AddQuotewithExistingSamurai();
            //cr.EgarLoadingsamuraiWithQuotes();
            //cr.QueryProjection();
            //cr.FilterwithRelatedData();
            //cr.AddingSamuraiWithExistingBattle();
            //cr.ReturnBattleWithSamurai();
            //cr.ReturnAllbattleWithSamurai();
            //cr.ReturnAllSamuraiWithBattle();
            cr.RemoveSamuraiFromBattle();
        }

        
    }
}
