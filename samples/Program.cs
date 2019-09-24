using System;
using System.IO;
using System.Text;

namespace Samples
{
    static class Program
    {
        static void Main(string[] args)
        {
            var someText = "This is some dummy text";
            var compressed = LZMA.Engine.Compress(Encoding.UTF8.GetBytes(someText));
            var decompressed = Encoding.UTF8.GetString(LZMA.Engine.Decompress(compressed));
            Console.WriteLine(decompressed);

            var longText = File.ReadAllText("lorem.txt");
            compressed = LZMA.Engine.Compress(Encoding.UTF8.GetBytes(longText));
            decompressed = Encoding.UTF8.GetString(LZMA.Engine.Decompress(compressed));
            Console.WriteLine($"Not compressed length: {longText.Length}");
            Console.WriteLine($"Compressed length: {compressed.Length}");
            Console.WriteLine($"Decompressed length: {decompressed.Length}");
        }
    }
}
