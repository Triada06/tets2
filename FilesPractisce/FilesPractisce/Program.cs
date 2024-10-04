using FilesPractisce;

Files files = new Files();

string path = "C:\\Users\\nizam\\Documents\\C#\\Files\\Service\\test3.txt";

await files.WriteToExistingFileAsyn(path, Console.ReadLine());


var data = await files.ReadDataFromExistingFileAsyn(path);
Console.WriteLine(data);


await files.WriteToNewFileAsyn("C:\\Users\\nizam\\Documents\\C#\\Files\\Service\\test4.txt", Console.ReadLine());

//files.DeleteFileAsyn("C:\\Users\\nizam\\Documents\\C#\\Files\\Service\\test4.txt");
