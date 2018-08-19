using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace GetWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDQ60801/IDQ60801.94183.axf", @"C:\GetWeather\Coen Airport\Coen Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDQ60801/IDQ60801.94260.axf", "C:\\GetWeather\\Burketown Airport\\Burketown Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94216.axf", "C:\\GetWeather\\Kununurra Airport\\Kununurra Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.95214.axf", "C:\\GetWeather\\Wyndham Airport\\Wyndham Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94317.axf", "C:\\GetWeather\\Newman Airport\\Newman Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.95305.axf", "C:\\GetWeather\\Onslow Airport\\Onslow Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94308.axf", "C:\\GetWeather\\Roebourne Airport\\Roebourne Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.99217.axf", "C:\\GetWeather\\Solomon Airport\\Solomon Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94429.axf", "C:\\GetWeather\\Mount Magnet Airport\\Mount Magnet Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.95402.axf", "C:\\GetWeather\\Shark Bay Airport\\Shark Bay Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94450.axf", "C:\\GetWeather\\Leonora Airport\\Leonora Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94610.axf", "C:\\GetWeather\\Perth Airport\\Perth Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.95611.axf", "C:\\GetWeather\\Busselton Airport\\Busselton Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94802.axf", "C:\\GetWeather\\Albany Airport\\Albany Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.95638.axf", "C:\\GetWeather\\Esperance Airport\\Esperance Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.95634.axf", "C:\\GetWeather\\Southern Cross Airport\\Southern Cross Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.95625.axf", "C:\\GetWeather\\Cunderdin Airport\\Cunderdin Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94417.axf", "C:\\GetWeather\\Morawa Airport\\Morawa Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94403.axf", "C:\\GetWeather\\Geraldton Airport\\Geraldton Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.95642.axf", "C:\\GetWeather\\Norseman Airport\\Norseman Airport.csv");
            webClient.DownloadFile("http://www.bom.gov.au/fwo/IDW60801/IDW60801.95439.axf", "C:\\GetWeather\\Wiluna Airport\\Wiluna Airport.csv");

        }        
    }
}
