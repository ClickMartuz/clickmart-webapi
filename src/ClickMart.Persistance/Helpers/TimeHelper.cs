using ClickMart.Domain.Constants;

namespace ClickMart.Persistance.Common.Helpers;

public class TimeHelper
{
    public static DateTime GetDateTime()
    {
        var dtTime = DateTime.Now;
        dtTime.AddHours(TimeConstants.UTC);
        return dtTime;
    }
}
