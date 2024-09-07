using System;
namespace WeatherApplication.Business.BaseMessages
{
    public static class UIMessage
    {
        public const string ADD_MESSAGE = "Əlavə Edildi";
        public const string UPDATE_MESSAGE = "Məlumat Yeniləndi";
        public const string DELETED_MESSAGE = "Məlumat Silindi";
        public const string DELETED_MESSAGES = "Məlumat Birdəfəlik Silindi";

        public static string GetRequiredMessage(string propName)
        {
            return $"{propName} boş ola bilməz!";
        }

        public static string GetMinLengthMessage(int length, string propName)
        {
            return $"{propName} {length} simvoldan aşağı ola bilməz!";
        }

        public static string GetMaxLengthMessage(int length, string propName)
        {
            return $"{propName} {length} simvoldan yuxarı ola bilməz!";
        }
    }
}

