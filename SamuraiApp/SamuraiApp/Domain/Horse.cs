namespace SamuraiApp.Domain
{
    public class Horse
    {
        /*Horse cant exists without SAmurai*/
        public int Id { get; set; }
        public string Name { get; set; }
        public int SamuraiID { get; set; }
    }


}
