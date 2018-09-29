using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiveScriptSample
{
    public class MyObjectHandler:RiveScript.IObjectHandler
    {
        public bool onLoad(string name, string[] code)
        {
            return true;
        }

        public string onCall(string name, RiveScript.RiveScript rs, string[] args)
        {
            switch (name)
            {
                case "showmessage":
                    MessageBox.Show(string.Join(" ", args));
                    break;
            }
            return string.Empty;
        }
    }
}
