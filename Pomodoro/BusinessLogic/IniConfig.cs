using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class IniConfig
    {
        #region Constructors

        public IniConfig()
        {

        }

        public IniConfig(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            InitFromLines(lines);
        }

        public IniConfig(IEnumerable<string> lines)
        {
            InitFromLines(lines);
        }

        private void InitFromLines(IEnumerable<string> lines)
        {
            foreach (var line in lines)
                ProcessIniLine(line);
        }

        #endregion

        #region Public Members

        public string this[string name]
        {
            get
            {
                string value;
                return _dict.TryGetValue(name, out value) ? value : string.Empty;
            }
            set
            {
                if (ForbidNewKeys && !_dict.ContainsKey(name))
                    throw new Exception("New keys are forbidden");
                _dict[name] = value;
            }
        }

        public int Count
        {
            get { return _dict.Count; }
        }

        public bool ForbidNewKeys { get; set; }

        public List<string> GetIniLines()
        {
            return _dict.Select(r => r.Key + '=' + r.Value).ToList();
        }

        public void Save(string fileName)
        {
            File.WriteAllLines(fileName, GetIniLines());
        }

        #endregion

        #region Private Members

        private Dictionary<string, string> _dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private void ProcessIniLine(string line)
        {
            var index = line.IndexOf('=');
            if (index < 0) return;
            var key = line.Substring(0, index).Trim();
            var value = line.Substring(index + 1).Trim();
            _dict[key] = value;
        }

        #endregion
    }
}
