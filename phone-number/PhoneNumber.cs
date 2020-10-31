using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string cleanPhoneNum =  Regex.Replace(phoneNumber, "[^0-9]", "");
        switch (cleanPhoneNum.Length) {
            case 10:
                if(cleanPhoneNum[0] <= '1' || cleanPhoneNum[3] <= '1')
                    throw new ArgumentException();
                break;
            case 11:
                if(cleanPhoneNum[0] != '1')
                    throw new ArgumentException();
                if(cleanPhoneNum[1] <= '1' || cleanPhoneNum[4] <= '1')
                    throw new ArgumentException();
                cleanPhoneNum = cleanPhoneNum.Substring(1, 10);
                break;
            default: 
                throw new ArgumentException();
        }
        return cleanPhoneNum;
    }
}