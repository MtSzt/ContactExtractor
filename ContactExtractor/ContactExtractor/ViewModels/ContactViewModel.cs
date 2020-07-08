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
        public BindableCollection<WebSiteModel> ExtractedContent { get; set; }

        public ContactViewModel(BindableCollection<WebSiteModel> WebCredentialModel)
        {
            ExtractedContent = WebCredentialModel;
        }
    }
}
