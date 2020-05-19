using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactExtractor.Models;
using ContactExtractor.Models.InnerDataModels;

namespace ContactExtractor.Data
{
    public class DataAccess
    {
        private readonly string _fileWithCities = ".\\Data\\cities.txt";
        private readonly string _fileWithJobs = ".\\Data\\professions.txt";

        public List<CityModel> GetCityModelList()
        {
            List<CityModel> outputCity = new List<CityModel>();
            List<string> listOfCities = GetCities(_fileWithCities);
            foreach (string city in listOfCities)
            {
                outputCity.Add(GetCityCandidates(city));
            }

            return outputCity;
        }

        private static CityModel GetCityCandidates(string city)
        {
            CityModel outputCityCandidates = new CityModel();
            outputCityCandidates.City = city;

            return outputCityCandidates;
        }

        private static List<string> GetCities(string fileWithCities)
        {
            string[] blockWithCityNames = File.ReadAllLines(fileWithCities);
            List<string> cityCandidates = new List<string>(blockWithCityNames);

            return cityCandidates;
        }


        public List<ProfessionModel> GetProfessionModelList()
        {
            List<ProfessionModel> outputPro = new List<ProfessionModel>();
            List<string> listOfProfessions = GetProfessions(_fileWithJobs);
            foreach (string prof in listOfProfessions)
            {
                outputPro.Add(GetProfessionCandidates(prof));
            }

            return outputPro;
        }

        private static ProfessionModel GetProfessionCandidates(string profession)
        {
            ProfessionModel outputProfessionCandidates = new ProfessionModel();
            outputProfessionCandidates.Profession = profession;

            return outputProfessionCandidates;
        }

        private static List<string> GetProfessions(string fileWithJobs)
        {
            string[] blockWithJobNames = File.ReadAllLines(fileWithJobs);
            List<string> jobCandidates = new List<string>(blockWithJobNames);

            return jobCandidates;
        }


        public IEnumerable<WebModel> GetWebistesModelList()
        {
            List<WebModel> outputWeb = new List<WebModel>();
            List<string> listOfWebsites = GetWebsites();
            foreach (string web in listOfWebsites)
            {
                outputWeb.Add(GetWebsitesCandidates(web));
            }

            return outputWeb;
        }

        private static WebModel GetWebsitesCandidates(string website)
        {
            WebModel outputWebsiteCandidates = new WebModel();
            outputWebsiteCandidates.Web = website;

            return outputWebsiteCandidates;
        }

        private static List<string> GetWebsites()
        {
            List<string> websiteCandidates = new List<string>() { "pkt", "panoramafirm" };
            return websiteCandidates;
        }

        public List<NumbersModel> GetNumberModelList()
        {
            List<NumbersModel> outputNumber = new List<NumbersModel>();
            List<string> listOfNumbers = GetNumbers();
            foreach (string number in listOfNumbers)
            {
                outputNumber.Add(GetNumberCandidate(number));
            }

            return outputNumber;
        }


        private static List<string> GetNumbers()
        {
            List<string> numberCandidate = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"};
            return numberCandidate;
        }

        private static NumbersModel GetNumberCandidate(string number)
        {
           NumbersModel numModel = new NumbersModel();
           numModel.Number = number;

           return numModel;
        }
    }


}
