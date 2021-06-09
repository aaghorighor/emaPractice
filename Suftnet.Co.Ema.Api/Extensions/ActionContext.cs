namespace Suftnet.Co.Ema.Api.Extensions
{  
    using System;

    public static class ActionContext
    {     
        public static DateTime ToDate(this string dateString)
        {
            DateTime dateTime;
            if (DateTime.TryParse(dateString, out dateTime))
            {
                return dateTime;
            }

            return DateTime.UtcNow.Date;
        }

        public static string ToDeliveryDate(this string dateString)
        {         
            if (string.IsNullOrEmpty(dateString))
            {
                return "";
            }

            return dateString;
        }
    }
}
