using System;
using System.IO;

namespace AsyncFileIO
{
    internal class Program
    {
        static void WriteCallback(IAsyncResult ar)
        {
            // End the asynchronous write operation
            FileStream file = (FileStream)ar.AsyncState;
            file.EndWrite(ar);
            Console.WriteLine("File written successfully!");
        }
        static void Main(string[] args)
        {
            string path = "example.txt";
            string content = "Hello, world!";

            // Asynchronously write the content to a file
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true);

            // Returns a byte array containing the encoded representation of the given string.
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);
            file.BeginWrite(buffer, 0, buffer.Length, WriteCallback, file);


            Console.WriteLine("Writing file asynchronously...");
            Console.ReadLine();

        }
    }
}