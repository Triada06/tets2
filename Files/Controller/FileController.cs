using Service.Services;
using Service.Services.IService;

namespace Files.Controller;

public class FileController
{
    private IWorkFiles _workFiles;

    public FileController()
    {
        _workFiles = new WorkFiles();
    }

    public async Task WriteToExistingFileAsyn()
    {
        string path = "C:\\Users\\nizam\\Documents\\C#\\Files\\Service\\test2.txt";

        Console.WriteLine("Enter text: ");
        
        string text =  Console.ReadLine();
        
        await _workFiles.WriteToExistingFileAsyn(path, text);

        Console.WriteLine("Dopustim isldei");
    }


    public async Task ReadDataFromExistingFileAsyn()
    {
        string path = "C:\\Users\\nizam\\Documents\\C#\\Files\\Service\\test2.txt";

        var data = await _workFiles.ReadDataFromExistingFileAsyn(path);

        Console.WriteLine(data);
    }

    public async Task WriteToNewFileAsyn()
    {
        string path = "C:\\Users\\nizam\\Documents\\C#\\Files\\Service\\test1.txt";


        Console.WriteLine("Enter text: ");

        string text = Console.ReadLine();

         await _workFiles.WriteToNewFileAsyn(path, text);

        Console.WriteLine("File has been created and updated");
    }

    public void Delete()
    {
        string path = "C:\\Users\\nizam\\Documents\\C#\\Files\\Service\\test1.txt";

        if (path.Length != 0)
        {
            _workFiles.DeleteFileAsyn(path);
            Console.WriteLine("File has been deleted");
            return;

        }
        Console.WriteLine("Incorrect path");
    }
}