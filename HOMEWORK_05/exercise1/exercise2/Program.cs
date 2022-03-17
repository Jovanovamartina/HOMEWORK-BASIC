using System;
public class funcexer2
{
    DateTime dateOfBirth = new DateTime(2000, 4, 18);
    DateTime currentDate = DateTime.Now;

    int ageInYears = 0;
    int ageInMonths = 0;
    int ageInDays = 0;

    ageInDays = currentDate.Day - dateOfBirth.Day;
ageInMonths = currentDate.Month - dateOfBirth.Month;
ageInYears = currentDate.Year - dateOfBirth.Year;

if (ageInDays< 0)
{
    ageInDays += DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
    ageInMonths = ageInMonths--;

    if (ageInMonths< 0)
    {
        ageInMonths += 12;
        ageInYears--;
    }
}

if (ageInMonths < 0)
{
    ageInMonths += 12;
    ageInYears--;
}

Console.WriteLine("{0}, {1}, {2}", ageInYears, ageInMonths, ageInDays);
