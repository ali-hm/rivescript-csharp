using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiveScript.lang;

namespace RiveScriptSample
{
    public partial class Form1 : Form
    {
        private RiveScript.RiveScript rs;
        public Form1()
        {
            InitializeComponent();
            InitializeEngine();
        }

        public void InitializeEngine(string[] code=null)
        {
            rs = new RiveScript.RiveScript(debug: true,utf8:true);
            //rs.setHandler("csharp", new CSharp());
            rs.setHandler("aliscript",new MyObjectHandler());
            //Stram bais variables for teste suite
            rs.stream(new[] { "// Bot Variables",
                              "! var name     = RiveScript Test Bot",
                              "! var age      = 9000",
                              "! var gender   = androgynous",
                              "! var location = Cyberspace",
                              "! var phone    = 555-1234",
                              "! var email    = test@mydomain.com",
                              "// Substitutions",
                              "! sub +         = plus",
                              "! sub -         = minus",
                              "! sub /         = divided",
                              "! sub *         = times",
                              "! sub i'm       = i am",
                              "! sub i'd       = i would",
                              "! sub i've      = i have",
                              "! sub i'll      = i will",
                              "! sub don't     = do not",
                              "! sub isn't     = is not",
                              "! sub you'd     = you would",
                              "! sub you're    = you are",
                              "! sub you've    = you have",
                              "! sub you'll    = you will",
                              "! sub he'd      = he would",
                              "! sub he's      = he is",
                              "! sub he'll     = he will",
                              "! sub she'd     = she would",
                              "! sub she's     = she is",
                              "! sub she'll    = she will",
                              "! sub they'd    = they would",
                              "! sub they're   = they are",
                              "! sub they've   = they have",
                              "! sub they'll   = they will",
                              "! sub we'd      = we would",
                              "! sub we're     = we are",
                              "! sub we've     = we have",
                              "! sub we'll     = we will",
                              "! sub whats     = what is",
                              "! sub what's    = what is",
                              "! sub what're   = what are",
                              "! sub what've   = what have",
                              "! sub what'll   = what will",
                              "! sub can't     = can not",
                              "! sub whos      = who is",
                              "! sub who's     = who is",
                              "! sub who'd     = who would",
                              "! sub who'll    = who will",
                              "! sub don't     = do not",
                              "! sub didn't    = did not",
                              "! sub it's      = it is",
                              "! sub could've  = could have",
                              "! sub couldn't  = could not",
                              "! sub should've = should have",
                              "! sub shouldn't = should not",
                              "! sub would've  = would have",
                              "! sub wouldn't  = would not",
                              "! sub when's    = when is",
                              "! sub when're   = when are",
                              "! sub when'd    = when did",
                              "! sub y         = why",
                              "! sub u         = you",
                              "! sub ur        = your",
                              "! sub r         = are",
                              "! sub im        = i am",
                              "! sub wat       = what",
                              "! sub wats      = what is",
                              "! sub ohh       = oh",
                              "! sub becuse    = because",
                              "! sub becasue   = because",
                              "! sub becuase   = because",
                              "! sub practise  = practice",
                              "! sub its a     = it is a",
                              "! sub fav       = favorite",
                              "! sub fave      = favorite",
                              "! sub iam       = i am",
                              "! sub realy     = really",
                              "! sub iamusing  = i am using",
                              "! sub amleaving = am leaving",
                              "! sub yuo       = you",
                              "! sub youre     = you are",
                              "! sub didnt     = did not",
                              "! sub ain't     = is not",
                              "! sub aint      = is not",
                              "! sub wanna     = want to",
                              "! sub brb       = be right back",
                              "! sub bbl       = be back later",
                              "! sub gtg       = got to go",
                              "! sub g2g       = got to go",
                              "",
                              "// Person substitutions",
                              "! person i am    = you are",
                              "! person you are = I am",
                              "! person i'm     = you're",
                              "! person you're  = I'm",
                              "! person my      = your",
                              "! person your    = my",
                              "! person you     = I",
                              "! person i       = you",
                              "",
                              "// Arrays",
                              "! array colors = red green blue cyan yellow magenta white orange brown black",
                              "  ^ gray grey fuchsia maroon burgundy lime navy aqua gold silver copper bronze",
                              "  ^ light red|light green|light blue|light cyan|light yellow|light magenta",
                              "! array be     = is are was were",
                              ""});




            rs.setDebug(true);
            if(code!=null && code.Any()) rs.stream(code);
            rs.sortReplies();
        }

        private void btnStreamCode_Click(object sender, EventArgs e)
        {
            InitializeEngine(txtCode.Lines);
            var erro = rs.error();
            rs.dumpSorted();
            //CSharp ss = new CSharp();
            //ss.onLoad("showmessage", new[] { "reference System.Windows.Forms.dll;", "System.Windows.Forms.MessageBox.Show(\"Test Message\");","return \"\";"});
            //ss.onCall("showmessage", rs, new string[] {""});

        }

        private void btnGetReply_Click(object sender, EventArgs e)
        {
            txtChatArea.AppendText($"{rs.reply("Test User", txtUserMessage.Text)}\r\n");
        }
    }
}
