
using ClickMart.Persistance.Dtos.Notifications;

namespace ClickMart.Service.Interfaces.Notifcations;

public interface ISmsSender
{
    public Task<bool> SendAsync(SmsMessage smsMessage);
}
