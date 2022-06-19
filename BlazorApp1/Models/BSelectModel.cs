namespace BlazorApp1.Models
{
    public class BSelectModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string PlaceHolder { get; set; }

        public IEnumerable<BSelectOption> Options { get; set; }
    }
    public class BSelectOption 
    { 
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
