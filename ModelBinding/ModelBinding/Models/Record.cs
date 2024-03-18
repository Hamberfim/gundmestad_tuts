namespace ModelBinding.Models
{
    public class Record
    {
        // if you make a parameterized constructor, you need to make a default constructor

        // Auto-implemented properties with get and set blocks
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
