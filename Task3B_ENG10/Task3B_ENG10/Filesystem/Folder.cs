using System;
using System.Collections.Generic;
using System.Linq;

namespace Filesystem
{
    public abstract class Folder : IFile
    {
        protected List<IFile> files = new List<IFile>();
        public List<IFile> Files => files;
        protected string name;
        public string Name => name;

        public Folder(string name)
        {
            this.name = name;
        }

        public abstract void AddFile(IFile file);
    }

    public class windowsFolder : Folder 
    {
        public windowsFolder(string name) : base(name)
        {
            this.name = name;
        }
        public override void AddFile(IFile file)
        {
            if (files.Contains(file))
            {
                Console.WriteLine("File {" + file.Name + "}");
            }
            else
            {
                files.Add(file);
            }
        }

    }


    public class macFolder : Folder
    {
        public macFolder(string name) : base(name)
        {
            this.name = name;
        }
        public override void AddFile(IFile file)
        {
            if (files.Contains(file))
            {
                for (int i = 0; i < files.Count; i++)
                {
                    if (files.ElementAt(i) == file)
                    {
                        files.Insert(i, file);
                    }
                }
            }
            else
            {
                files.Add(file);
            }
        }
    }
}
