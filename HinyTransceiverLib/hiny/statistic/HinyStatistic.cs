using System;
using System.Collections.Generic;
using System.Text;

namespace WCOLORLESS.Hiny
{
    public enum HinyStatisticType
    {
        Empty,
        Read,
        Write
    }


    public class HinyCommonStatistic
    {

        private static HinyCommonStatistic _Instance;

        private long _ReadByte;
        private long _WriteByte;
        private long _Operations;

        private HinyCommonStatistic()
        {

        }

        public static HinyCommonStatistic GetInstance()
        {
            if(_Instance == null)
            {
                _Instance = new HinyCommonStatistic();
            }
            return _Instance;
        }



        public long ReadByte
        {
            get { return _ReadByte; }
        }

        public long WriteByte
        {
            get { return _WriteByte; }
        }

        public long Operations
        {
            get { return _Operations; }
        }

        public void Action(HinyStatisticType statisticType, long bytes)
        {
            if(statisticType == HinyStatisticType.Read)
            {
                _Operations++;
                _ReadByte += bytes;
            }
            else if(statisticType == HinyStatisticType.Write)
            {
                _Operations++;
                _WriteByte += bytes;
            }
        }

    }
}
