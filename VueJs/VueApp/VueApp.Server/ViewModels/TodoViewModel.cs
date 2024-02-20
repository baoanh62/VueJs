namespace VueApp.Server.ViewModels
{
    public class TodoViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool Start { get; set; }
        public bool IsDeleted { get; set; }
    }
}
