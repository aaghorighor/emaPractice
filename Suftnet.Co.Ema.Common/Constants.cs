namespace Suftnet.Co.Ema.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class ValidationError
    {
        public const string PASSWORD_OR_USERNAME = "Invalid username or password.";
        public const string USER_NOT_FOUND = "application user id not found";
        public const string PASSWORD_RESET = "Error while generating password reset token, please try later";
        public const string EMAIL_FOUND = "A match found for your Email address, please try another email";      
    }

    public static class JwtClaimIdentifiers
    {
        public const string USER_ID = "UserId", PHONE_NUMBER = "PhoneNumber", USER_NAME = "UserName", FIRST_NAME ="FirstName", LAST_NAME ="LastName",  FULL_NAME ="FullName";
    }

    public static class UserType
    {
        public const string PATIENT = "Patient", PROVIDER = "Provider", SECRETARY = "Secretary", PHARMACY = "Pharmacy", ACCOUNTANT = "Accountant", ADMINISTRATOR = "Administrator";
    }

    public static class Constants
    {
        public const string DefaultPassword = "Vx!1234567";      
    }

    public static class DateTimeFormat
    {
        public static string FormatDate = "dddd, dd MMMM yyyy";
        public static string FormatDateTime = "dddd, dd MMMM yyyy";
    }  

    public static class ePaymentStatus
    {
        public const string Paid = "115924fb-79f9-4e0c-ab5f-d4e1dfc1c893";
        public const string Pending = "ed9eb336-d246-4747-adb1-42fd95d98e4c";     
    }

    public enum EmailSendingType
    {
        To,
        CC,
        BCC,
        ReplyTo,
    }
}
