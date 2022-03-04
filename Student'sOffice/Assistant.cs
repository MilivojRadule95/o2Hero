using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOffice
{
    class Assistant
    {
        private string _assistantName;

        public Assistant(string name)
        {
            _assistantName = name;
        }

        public string GetAssistantName()
        {
            return _assistantName;
        }
    }
}
