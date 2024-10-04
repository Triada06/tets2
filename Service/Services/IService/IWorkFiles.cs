namespace Service.Services.IService;

public interface IWorkFiles
{
    public Task WriteToExistingFileAsyn(string path, string content);
    public Task<string> ReadDataFromExistingFileAsyn(string path);
    public Task WriteToNewFileAsyn(string path, string content);
    public void DeleteFileAsyn(string path);
}