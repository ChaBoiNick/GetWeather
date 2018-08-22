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
        static void Main()
        {
            Airports Coen = new Airports
            {
                Name = "Coen Airport",
                Url = "http://www.bom.gov.au/fwo/IDQ60801/IDQ60801.94183.axf"
            };

            Airports Burketown = new Airports
            {
                Name = "Burketown Airport",
                Url = "http://www.bom.gov.au/fwo/IDQ60801/IDQ60801.94260.axf"
            };

            Airports Kununurra = new Airports
            {
                Name = "Kununurra Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94216.axf"
            };

            Airports Wyndham = new Airports
            {
                Name = "Wyndham Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95214.axf"
            };

            Airports Newman = new Airports
            {
                Name = "Newman Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94317.axf"
            };

            Airports Onslow = new Airports
            {
                Name = "Onslow Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95305.axf"
            };

            Airports Roebourne = new Airports
            {
                Name = "Roebourne Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94308.axf"
            };

            Airports Soloman = new Airports
            {
                Name = "Soloman Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.99217.axf"
            };

            Airports MtMagnet= new Airports
            {
                Name = "Mount Magnet Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94429.axf"
            };

            Airports SharkBay = new Airports
            {
                Name = "Shark Bay Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95402.axf"
            };

            Airports Leonora = new Airports
            {
                Name = "Leonora Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94450.axf"
            };

            Airports Perth = new Airports
            {
                Name = "Perth Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94610.axf"
            };

            Airports Busselton = new Airports
            {
                Name = "Busselton Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95611.axf"
            };

            Airports Albany = new Airports
            {
                Name = "Albany Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94802.axf"
            };

            Airports Esperance = new Airports
            {
                Name = "Esperance Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95638.axf"
            };

            Airports SouthernCross = new Airports
            {
                Name = "Southern Cross Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95634.axf"
            };

            Airports Cunderdin = new Airports
            {
                Name = "Cunderdin Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95625.axf"
            };

            Airports Morawa = new Airports
            {
                Name = "Morawa Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94417.axf"
            };

            Airports Geraldton = new Airports
            {
                Name = "Geraldton Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94403.axf"
            };

            Airports Norseman = new Airports
            {
                Name = "Norseman Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95642.axf"
            };

            Airports Wiluna = new Airports
            {
                Name = "Wiluna Airport",
                Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95439.axf"
            };

        }        
    }
}
