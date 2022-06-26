namespace DocumentManagerUI.Pages
{
    public partial class FileListResponse
    {
        public string File { get; }
        public string Name { get; }

        public FileListResponse(string file, string name)
        {
            File = file;
            Name = name;
        }
    }
}
