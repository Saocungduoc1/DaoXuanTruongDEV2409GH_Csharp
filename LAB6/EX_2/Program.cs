using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo một hashtable lưu danh sách các ngày trong tuần với key từ 1-8
        Hashtable weekDays = new Hashtable
        {
            { 1, "Monday" },
            { 2, "Tuesday" },
            { 3, "Wednesday" },
            { 4, "Thursday" },
            { 5, "Friday" },
            { 6, "Saturday" },
            { 7, "Sunday" }
        };

        // Tìm ngày Tuesday, in ra thông báo nếu tìm thấy hoặc không
        Console.WriteLine("Checking for 'Tuesday':");
        if (weekDays.ContainsValue("Tuesday"))
        {
            Console.WriteLine("Tuesday is found in the hashtable.");
        }
        else
        {
            Console.WriteLine("Tuesday is not found in the hashtable.");
        }

        // In ra các ngày trong tuần bao gồm cả key và value
        Console.WriteLine("\nDays of the week:");
        foreach (DictionaryEntry entry in weekDays)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
