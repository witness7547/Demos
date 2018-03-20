using System;
using System.Configuration;
using System.IO;
using System.Linq;

namespace DeleteFileFolderTest
{
    class Program
    {
        static uint deletedFoldersCount = 0;        
        static string[] deletedFolders = {"bin", "obj"};

        static void Main(string[] args)
        {
            try
            {
                //show the names which will be deleted
                if (ConfigurationManager.AppSettings["folderNames"] != null)
                {
                    string folderNames = ConfigurationManager.AppSettings["folderNames"];
                    deletedFolders = folderNames.Split(',');                    
                }

                Console.WriteLine("Folders with these names will be deleted:");
                foreach (var item in deletedFolders)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("\r\n");


                //show all folders on current directory
                string[] dirs = Directory.GetDirectories(Directory.GetCurrentDirectory());
                if (dirs.Count() > 0)
                {
                    Console.WriteLine(dirs.Count() + " folders been found in current directory:");
                    foreach (var item in dirs)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("There is no folder on current directory!");
                    Console.ReadKey();
                    return;
                }


                //delete the specified folders
                Console.WriteLine("\r\n");
                Console.WriteLine("Press D to delete the folders or E to exit:");
                bool flag = true;
                while (flag)
                {                    
                    ConsoleKey myKey = Console.ReadKey().Key;
                    switch (myKey)
                    {
                        case ConsoleKey.D:
                            DeleteFolders(dirs, deletedFolders);
                            flag = false;
                            break;

                        case ConsoleKey.E:
                            return;

                        default:
                            break;
                    }
                }


                Console.WriteLine("\r\n");
                Console.WriteLine("Deleted folders count: {0}.", deletedFoldersCount);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }

        //delete specified folders
        private static void DeleteFolders(string[] dirs, string[] deletedFoldersNames)
        {
            if (dirs == null || deletedFoldersNames == null)
            {
                return;
            }

            foreach (var item in dirs)
            {
                bool existed = false;
                foreach (var myFolder in deletedFoldersNames)
                {
                    if (item.EndsWith(myFolder))
                    {
                        existed = true;
                        break;
                    }
                }

                if (existed)
                {
                    Directory.Delete(item, true);
                    deletedFoldersCount++;
                    Console.WriteLine(item + " deleted!");
                }
                else
                {
                    DeleteFolders(Directory.GetDirectories(item), deletedFoldersNames);
                }
            }
        }

    }
}
