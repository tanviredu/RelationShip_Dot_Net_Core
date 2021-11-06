namespace SamuraiApp.Domain
{
    public class Quote
    {
    
        public int Id { get; set; }
        public string Text { get; set; }

        // reverse relationship
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
    }


}
