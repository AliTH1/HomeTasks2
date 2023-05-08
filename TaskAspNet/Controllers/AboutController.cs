namespace TaskAspNet.Controllers
{
    public class AboutController
    {
        public string Index()
        {
            return "About Index";
        }

        public string Detail(int id)
        {
            return $"About Detail {id}";
        }
    }
}
