namespace SamuraiApp.Service
{
    public interface IInteractionBasic
    {
        void AddSamurais(params string[] names);
        void AddVariousTypes();
        void DeleteData();
        void GetSamurais();
        void QueryAggrates();
        void QueryFilters();
        void RetrieveAndUpdateSamurai();
    }
}