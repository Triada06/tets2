namespace FilesPractisce;

public class Files
{
    
    public async Task WriteToExistingFileAsyn(string path, string content)
    {
        using FileStream fileStream = new (path, FileMode.Create);
        using StreamWriter streamWriter = new (fileStream);
      
        await streamWriter.WriteLineAsync(content); 
    }

    public async Task<string> ReadDataFromExistingFileAsyn(string path)
    {
        using FileStream  filestream = new FileStream(path, FileMode.Open);
        using StreamReader streamReader = new StreamReader(filestream);

        return streamReader.ReadToEnd();
    }

    public async Task WriteToNewFileAsyn(string path, string content)
    {
        using FileStream fileStream = new(path, FileMode.CreateNew);
        using StreamWriter writerr = new StreamWriter(fileStream);

        await writerr.WriteLineAsync(content);
    }

    public void DeleteFileAsyn(string path)
    {
        File.Delete(path);
    }
}