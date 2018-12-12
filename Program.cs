using System;

namespace CopyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello World!");    
        string sourceFile = @"D:\Develop\DevelopSoft\DevelopNetCore\CopyFiles\TestFiles\TestFrom.txt";
        string destinationFile = @"D:\Develop\DevelopSoft\DevelopNetCore\CopyFiles\TestFiles\TestFrom2.txt";

        // To move a file or folder to a new location:
        //System.IO.File.Move(sourceFile, destinationFile);
        System.IO.File.Copy(sourceFile, destinationFile);

        // To move an entire directory. To programmatically modify or combine
        // path strings, use the System.IO.Path class.
        //System.IO.Directory.Move(@"C:\Users\Public\public\test\", @"C:\Users\Public\private");
            
            

        }
    }
}
