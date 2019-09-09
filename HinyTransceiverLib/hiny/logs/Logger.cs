using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;
using System.Timers;
using Newtonsoft.Json;


namespace WCOLORLESS.Hiny
{
    public class Logger
    {
        private static Logger _Instance;


        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if(_Instance == null)
            {
                _Instance = new Logger();
            }
            return _Instance;
        }

        private ObservableCollection<LogItem> logItems = new ObservableCollection<LogItem>();


        public ObservableCollection<LogItem> Items
        {
            get { return logItems; }
            set
            {
                logItems = value;
            }
        }

        public void AddItem(string Message)
        {
            if (string.IsNullOrEmpty(Message)) return;
            var item = new LogItem() {DateTime = DateTime.Now, Message = Message };
            
        }

        public void SaveLogsInCSV(string Path)
        {
            if (File.Exists(Path))
            {
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < logItems.Count; i++)
                {
                    sb.Append(logItems[i].DateTime.ToString() + "," + logItems[i].Message + "\n");
                }
                using (FileStream fs = new FileStream(Path, FileMode.Create, FileAccess.Write))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(sb.ToString());
                    sw.Close();
                    fs.Close();
                }
            }
        }

    }
}
