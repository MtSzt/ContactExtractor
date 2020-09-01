using Caliburn.Micro;
using ContactExtractor.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using ContactExtractor.Data;
using ContactExtractor.Models.InnerDataModels;
using ContactExtractor.Helpers;
using System.Threading;

namespace ContactExtractor.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        #region GLOBAL VARIABLES

        LinkHelper linkHelper = new LinkHelper();

        WebAccess webContent = new WebAccess();

        private CityModel _selectedCities;

        private ProfessionModel _selectedProfession;

        private WebModel _selectedWeb;

        private NumbersModel _selectedNumber;

        private WebSiteModel _selectedCredentialsFromWeb;
        public CityModel SelectedCities
        {
            get { return _selectedCities; }
            set
            {
                _selectedCities = value;
                NotifyOfPropertyChange(() => SelectedCities);
            }
        }

        public ProfessionModel SelectedProfession
        {
            get { return _selectedProfession; }
            set
            {
                _selectedProfession = value;
                NotifyOfPropertyChange(() => SelectedProfession);
            }
        }

        public WebModel SelectedWeb
        {
            get { return _selectedWeb; }
            set
            {
                _selectedWeb = value;
                NotifyOfPropertyChange(() => SelectedWeb);
            }
        }

        public NumbersModel SelectedNumber
        {
            get { return _selectedNumber; }
            set
            {
                _selectedNumber = value;
                NotifyOfPropertyChange(() => SelectedNumber);
            }
        }

        public WebSiteModel SelectedCredentialsFromWeb
        {
            get { return _selectedCredentialsFromWeb; }
            set
            {
                _selectedCredentialsFromWeb = value;
                NotifyOfPropertyChange(() => SelectedCredentialsFromWeb);
            }
        }

        public BindableCollection<CityModel> Cities { get; set; }

        public BindableCollection<ProfessionModel> Professions { get; set; }

        public BindableCollection<WebModel> Websites { get; set; }

        public BindableCollection<NumbersModel> Numbers { get; set; }

        public BindableCollection<WebSiteModel> ExtractedContent { get; set; }

        #endregion

        public ShellViewModel()
        {
            DataAccess da = new DataAccess();
            Cities = new BindableCollection<CityModel>(da.GetCityModelList());
            Professions = new BindableCollection<ProfessionModel>(da.GetProfessionModelList());
            Websites = new BindableCollection<WebModel>(da.GetWebistesModelList());
            Numbers = new BindableCollection<NumbersModel>(da.GetNumberModelList());
            ExtractedContent = new BindableCollection<WebSiteModel> { };
            SelectedCredentialsFromWeb = new WebSiteModel { };
        }

        #region ---UpperMenu---
        public void MenuJobEdit()
        {
            Process.Start("notepad.exe", _fileWithJobs);
        }

        public void MenuRegionEdit()
        {
            Process.Start("notepad.exe", _fileWithCities);
        }

        public void MenuNumberEdit()
        {
            Process.Start("notepad.exe", _convertedNumbers);
        }

        #endregion

        #region ---MenuButtons---

        public void GetSelectedContact(WebSiteModel model) 
        {
            SelectedCredentialsFromWeb = model;        
        }

        public void LeadGenerateButton()
        {
            string selectedCity;
            string selectedProfession;
            string selectedWebsite;
            string selectedNumber;
            try
            {
                selectedCity = SelectedCities.City;
            }
            catch
            {
                MessageBox.Show("Proszę wybrać miasto", "info");
                return;
            }

            try
            {
                selectedProfession = SelectedProfession.Profession;
            }
            catch
            {
                MessageBox.Show("Proszę wybrać zawód", "info");
                return;
            }
            try
            {
                selectedWebsite = SelectedWeb.Web;
            }
            catch
            {
                MessageBox.Show("Proszę wybrać stronę", "info");
                return;
            }

            try
            {
                selectedNumber = SelectedNumber.Number;
            }
            catch
            {
                selectedNumber = string.Empty;
            }
         
            string link = linkHelper.CreateLink(selectedWebsite, selectedCity, selectedProfession, selectedNumber);
            ExtractedContent.Clear();
            ExtractedContent.AddRange(webContent.GetListOfWebsiteModels(link));
            
            if (!ExtractedContent.Any())
                MessageBox.Show("No contacts for above criteria", "LOADING FAILED");

            ActivateItem(new ContactViewModel(ExtractedContent));
        }
        #endregion

        private readonly string _fileWithCities = Environment.CurrentDirectory + ".\\Data\\cities.txt";
        private readonly string _fileWithJobs = Environment.CurrentDirectory + ".\\Data\\professions.txt";
        private readonly string _convertedNumbers = Environment.CurrentDirectory + ".\\Data\\convertedNumbers.txt";
    }
}
