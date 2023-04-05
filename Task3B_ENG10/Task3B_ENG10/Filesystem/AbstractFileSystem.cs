using System;
using System.Collections.Generic;
using System.Text;

namespace Filesystem
{
    public abstract class AbstractFileSystem
    {
        public abstract TextFile TextFile(string name, string content);
        public abstract Folder Folder(string name);
        public abstract Filesystem Filesystem(Folder root);
    }

    public class Windows : AbstractFileSystem
    {
        public override TextFile TextFile(string name, string content)
        {
            return new windowsTF(name, content);
        }

        public override Folder Folder(string name)
        {
            return new windowsFolder(name);
        }

        public override Filesystem Filesystem(Folder root)
        {
            return new windowsFS(root);
        }
    }

    public class Mac : AbstractFileSystem
    {
        public override TextFile TextFile(string name, string content)
        {
            return new MacTF(name,content);
        }

        public override Folder Folder(string name)
        {
            return new macFolder(name);
        }

        public override Filesystem Filesystem(Folder root)
        {
            return new macFS(root);
        }
    }
}
