using Caliburn.Micro;
using ContactExtractor.Data;
using ContactExtractor.Models;
using ContactExtractor.Models.InnerDataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactExtractor.ViewModels
{
    public class ContactViewModel : Screen
    {
        private WebSiteModel _fromWeb;
        public BindableCollection<WebSiteModel> ExtractedContent { get; set; }

        public WebSiteModel FromWeb
        {
            get 
            {
                new ShellViewModel().GetSelectedContact(_fromWeb);
                return _fromWeb;
            }
            set
            {
                _fromWeb = value;
                NotifyOfPropertyChange(() => FromWeb);
            }
        }

        public ContactViewModel(BindableCollection<WebSiteModel> WebCredentialModel)
        {
            ExtractedContent = WebCredentialModel;
            FromWeb = new WebSiteModel { };
        }

        


    }
}
