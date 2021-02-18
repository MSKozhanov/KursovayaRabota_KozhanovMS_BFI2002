using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static public void AddResult(string key, string value)
        {
            dic[key] = value;
        }
        static public string getResult(string key)
        {
            if (dic.ContainsKey(key))
                return dic[key];
            else return "";
        }
        static private Dictionary<string, string> dic = new Dictionary<string, string>();
    }
}
