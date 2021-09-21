using System.Text;
using System.Windows.Forms;

namespace tickethelper.Service
{
    class IpcPackage
    {
        public IpcPackage(string name)
        {
            Name = name;
        }
        private string Name { get; }
        private readonly StringBuilder _data = new StringBuilder();

        public static IpcPackage Create(string name)
        {
            return new IpcPackage(name);
        }

        public void AddData(string dataType, string data)
        {
            _data.AppendFormat("{0}{1}{0}", dataType, data);
        }

        public void Send()
        {
            var package = string.Format("{0}{1}{0}", Name, _data.Replace("\r\n", ""));
            Clipboard.SetText(package);
        }
    }
}
