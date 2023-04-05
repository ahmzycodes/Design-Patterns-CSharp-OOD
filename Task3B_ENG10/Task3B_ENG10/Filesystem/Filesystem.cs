using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Filesystem
{
    public abstract class Filesystem
    {
        protected Folder root;
        public abstract string Name { get; }

        public Folder GetRoot() => root;

        public Filesystem(Folder root)
        {
            this.root = root;
        }

        public abstract void GetContent(string path);
    }


    public class windowsFS : Filesystem
    {

        public windowsFS(Folder root) : base(root)
        {
            this.root = root;
        }

        public override string Name { get { return "NTFS"; } }


        public override void GetContent(string path)
        {
            
        }

    }

    public class macFS : Filesystem
    {
        public macFS(Folder root) : base(root)
        {
            this.root = root;
        }
        public override string Name { get { return "APFS"; } }
        public override void GetContent(string path)
        {
            
        }

    }
}

