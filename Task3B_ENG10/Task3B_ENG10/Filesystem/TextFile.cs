namespace Filesystem
{
    public abstract class TextFile : IFile
    {
        protected string name;
        public string Name => name;

        protected string content;

        public TextFile(string name, string content)
        {
            this.name = name;
            this.content = content;
        }

        public abstract string GetContent();
    }


    public class windowsTF : TextFile
    {
        public windowsTF(string name, string content) : base(name,content)
        {
            this.name = name;
            this.content = content;
        }
        public override string GetContent()
        {
            return "\t"+content;
        }

    }

    public class MacTF : TextFile
    {
        public MacTF(string name, string content) : base(name, content)
        {
            this.name = name;
            this.content = content;
        }
        public override string GetContent()
        {
            return ">" + content;
        }

    }
}

