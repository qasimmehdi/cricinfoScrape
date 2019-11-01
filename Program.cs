using System;
using PuppeteerSharp;
using System.Threading.Tasks;
using System.Windows;
namespace Dice
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string skill = "java";
            string location = "nj";
            // Download the Chromium revision if it does not already exist
            var options = new LaunchOptions{Headless=true, ExecutablePath = "C:\\Users\\Compro\\Documents\\Dice\\Dice\\.local-chromium\\Win64-686378\\chrome-win\\chrome.exe"};
            //Console.WriteLine("Downloading chromium");
            //var executablePath = new BrowserFetcher.GetExecutablePath(BrowserFetcher.DefaultRevision);
            using (var browser = await Puppeteer.LaunchAsync(options))
            using (var page = await browser.NewPageAsync())
            {
                Console.WriteLine("0");
                await page.GoToAsync("https://www.dice.com/employer/login?redirectUri=/employer/talent/search;q=java;location=nj;page=1;pageSize=20;sortBy=relevance;sortByDirection=desc;excludeRecruiters=true;distance=50;distanceUoM=miles;lastActive=90;profileSource=resumes",1500000000);
                Console.WriteLine("Logging in");
                await page.TypeAsync("#username","imran@prosistech.com");
                await page.TypeAsync("#password","Prosis2019");
                await page.ClickAsync(".sign-in-btn");
                Console.WriteLine("3");
                string ab = ".search-result";
                try{
                await page.WaitForSelectorAsync(ab);
                }catch{}
                
                string content = await page.GetContentAsync();
                Console.WriteLine("4");
                var jsSelectAllAnchors = @"Array.from(document.querySelectorAll('.view-link')).map(a => a.href);";
                var urls = await page.EvaluateExpressionAsync<string[]>(jsSelectAllAnchors);
                System.IO.File.WriteAllText(@"C:\\Users\\Compro\\Documents\\Dice\\Dice\\page1.txt",content);
                

                //search for persons
                /*string url = "https://www.dice.com/employer/talent/search;q="+skill+";location="+location+";page=1;pageSize=20;sortBy=relevance;sortByDirection=desc;excludeRecruiters=true;distance=50;distanceUoM=miles;lastActive=90;profileSource=resumes";
                await page.GoToAsync(url,WaitUntilNavigation.Networkidle0);
                
                content = await page.GetContentAsync();
                System.IO.File.WriteAllText(@"C:\\Users\\Compro\\Documents\\Dice\\Dice\\page2.txt",content);
                /*var jsSelectAllAnchors = @"Array.from(document.querySelectorAll('a')).map(a => a.href);";
                var urls = await page.EvaluateExpressionAsync<string[]>(jsSelectAllAnchors);
                foreach (string url in urls)
                {
                    Console.WriteLine($"Url: {url}");
                }
            }
            //Console.WriteLine("Hello World!");*/
            }
        }
        
    }
}
