using System;

namespace Filesystem
{
    class Program
    {
        static Filesystem BuildFilesystem(/*arguments*/ AbstractFileSystem abstractFileSystem)
        { 

            Filesystem filesystem = abstractFileSystem.Filesystem(); // create filesystem
            Folder f1 = abstractFileSystem.Folder("Home"); 
            Folder f2 = abstractFileSystem.Folder("me");
            Folder f3 = abstractFileSystem.Folder("bin");
            TextFile t1 = abstractFileSystem.TextFile(".hidden","Secreto");
            TextFile t2 = abstractFileSystem.TextFile("beta","Veni\nVidi\nVici");
            TextFile t3 = abstractFileSystem.TextFile("alpha","Cogito\nErgo\nSum");
            filesystem.GetRoot().AddFile(f1);
            f1.AddFile(f2);
            filesystem.GetRoot().AddFile(f3);
            f2.AddFile(t1);
            f2.AddFile(t2);
            f2.AddFile(t3);

            return filesystem;
        }

        static void Main(string[] args)
		{
            var windows = new Windows();
            var mac = new Mac();

            Console.WriteLine("--------------Windows--------------");
            var winRoot = BuildFilesystem(windows);
            Console.WriteLine("Current filesystem: " + winRoot.Name);
            winRoot.GetContent("C:/home/me");
            winRoot.GetContent("C:/home/me/alpha");
            winRoot.GetContent("C:/home/me/beta");

            Console.WriteLine("--------------MacOS--------------");
            var macRoot = BuildFilesystem(mac);
            Console.WriteLine("Current filesystem: " +macRoot.Name);
            macRoot.GetContent("root/home/me");
            macRoot.GetContent("root/home/me/alpha");
            macRoot.GetContent("root/home/me/beta");
        }
	}
}
