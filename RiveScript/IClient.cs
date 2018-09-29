using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiveScript
{
    public interface IClient
    {
        void set(string name, string value);
        string get(string name);
        void delete(string name);
        IDictionary<string, string> getData { get; }
        bool replaceData(IDictionary<string, string> newData);
        void addInput(string text);
        void addReply(string text);
        string getInput(int index);
        string getReply(int index);

    }
}
