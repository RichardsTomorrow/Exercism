using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
       string justNumbers = string.Join("", Regex.Split(phoneNumber, @"[^0-9]+"));
       
        if (justNumbers[0]== '1') //gets rid of country code
        {
            justNumbers = justNumbers.Remove(0,1);
        }
        if(justNumbers.Length != 10)// tests length of phone number, the length tests can be grouped together
        {
            if( justNumbers.Length < 10)// tests to see if the number is too short
            {
                throw new ArgumentException("There weren't enough numbers here to make a phone number.");
            }
            else if (justNumbers.Length > 10) // tests to see if the number is too long
            {
                throw new ArgumentException("There weren't enough numbers here to make a phone number.");
            }
        }
        if(justNumbers[0] == '0' || justNumbers[0] == '1') // tests area code, code tests could be combined but this gives better feed back
        {
            throw new ArgumentException("That number had an invalid area code.");
        }
        if (justNumbers[3] == '0' || justNumbers[3] == '1')// tests exchange code
        {
            throw new ArgumentException("That number had an invalid exchange code.");
        }

        return justNumbers;
    }
         
}