using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class UnsafeTypeCust
    {
        public static DateTime DbDateToDateTimeCust(object dbDate)
        {
            DateTime outDateTimeValue = dbDate!= System.DBNull.Value?(DateTime)dbDate:DateTime.Now;
            return outDateTimeValue;
        }
        public static string DbDateToStringCust(object dbDate)
        {
            if (!DBNull.Value.Equals(dbDate))
                return dbDate.ToString();
            else
                return String.Empty;
        }
        public static long ToJavaScriptMilliseconds(DateTime dt)
        {
            long DatetimeMinTimeTicks =(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).Ticks;
            return (long)((dt.ToUniversalTime().Ticks - DatetimeMinTimeTicks) / 10000);
        }
    }
}
