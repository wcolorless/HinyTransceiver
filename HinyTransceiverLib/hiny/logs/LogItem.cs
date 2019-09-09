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
    public class LogItem
    {
        private string _Message;
        private DateTime _DateTime;

        public string Message
        {
            get { return _Message; }
            set
            {
                _Message = value;
            }
        }


        public DateTime DateTime
        {
            get { return _DateTime; }
            set
            {
                _DateTime = value;
            }
        }


       
    }
}
