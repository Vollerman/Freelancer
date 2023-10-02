namespace FreelancerProject.Constants
{
    public static class FileLocations
    {
        public static string ProjectFolder => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
    }
}