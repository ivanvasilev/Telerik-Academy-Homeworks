// Problem 4. Download file
// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
// Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        try
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
            Console.WriteLine("You can find the downloaded image in 'bin' directory of the project.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}