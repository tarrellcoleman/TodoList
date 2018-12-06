using Nancy;

namespace todolist
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ => View["index"];
        }
    }
}