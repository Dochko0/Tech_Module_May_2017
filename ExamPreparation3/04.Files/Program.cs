using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



    class File
    {
        public string Root { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
    }






    class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> allFiles = ReadFiles();

            var query = Regex.Split(Console.ReadLine(), @"\s+in\s+");

            var extQuery = query[0];
            var rootQuery = query[1];


            var resultFiles = allFiles.
                Where(f => f.Root == rootQuery).
                Where(f => f.Extension == extQuery).
                OrderByDescending(f => f.Size).
                ThenBy(f => f.FileName);


            if (resultFiles.Any())
            {
                foreach (var f in resultFiles)
                {
                    Console.WriteLine($"{f.FileName} - {f.Size} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }



        }

        private static List<dynamic> ReadFiles()
        {
            var n = int.Parse(Console.ReadLine());
            var allFiles = new List<dynamic>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                //var tokens = inputLine.Split(';');
                //var size = int.Parse(tokens.Last());
                //var pathPlusFilename = 


                //tokens = inputLine.Split('\\');
                //var root = int.Parse(tokens.First());
                ExtractRoot(inputLine, out int mostLefrSlashIndex, out string root);

                var mostRightSlashIndex = inputLine.LastIndexOf(@";");
                ExtractSize(inputLine, mostLefrSlashIndex, mostRightSlashIndex, out long size, out string pathPlusName);

                var ext = ExtractExtension(pathPlusName);
                var fileName = ExtractFileName(pathPlusName);



                var match = allFiles.FirstOrDefault(f => f.FileName == fileName && f.Root == root);
                if (match != null)
                {
                    match.Size = size;
                }
                else
                {
                    var file = new File()
                    {
                        Root = root,
                        FileName = fileName,
                        Extension = ext,
                        Size = size
                    };
                    allFiles.Add(file);
                }
                //if (allFiles.Count(f => f.FileName == fileName) == 0)
                //{
                //}
                //Console.WriteLine(root + " " + size + " " + pathPlusName + " " + ext + " " + fileName);
                //Console.WriteLine(root + " " + size + " " + ext + " " + fileName);
            }

            return allFiles;
        }

        private static void ExtractSize(string inputLine, int mostLefrSlashIndex, int mostRightSlashIndex, out long size, out string pathPlusName)
        {
            size = 0;
            if (mostLefrSlashIndex >= 0)
            {
                size = long.Parse(inputLine.Substring(mostRightSlashIndex + 1));
            }
            pathPlusName = inputLine.Substring(0, mostRightSlashIndex);
        }


        private static void ExtractRoot(string inputLine, out int mostLefrSlashIndex, out string root)
        {
            mostLefrSlashIndex = inputLine.IndexOf(@"\");
            root = "";
            if (mostLefrSlashIndex >= 0)
            {
                root = inputLine.Substring(0, mostLefrSlashIndex);
            }
        }


        static string ExtractExtension(string pathPlusName)
        {
            var mostRightDotIndex = pathPlusName.LastIndexOf(@".");
            string ext = "";
            if (mostRightDotIndex >= 0)
            {
                ext = pathPlusName.Substring(mostRightDotIndex + 1);
            }
            return ext;
        }

        static string ExtractFileName(string pathPlusName)
        {
            var mostRightSlashIndex = pathPlusName.LastIndexOf(@"\");
            string fileName = "";
            if (mostRightSlashIndex >= 0)
            {
                fileName = pathPlusName.Substring(mostRightSlashIndex + 1);
            }
            return fileName;
        }
    }

