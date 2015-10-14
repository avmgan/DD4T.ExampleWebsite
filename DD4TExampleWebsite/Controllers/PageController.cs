using DD4T.ContentModel.Contracts.Configuration;
using DD4T.ContentModel.Contracts.Logging;
using DD4T.ContentModel.Factories;
using DD4T.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DD4TExampleWebsite.Controllers
{
    public class PageController : TridionControllerBase
    {

        public PageController(IPageFactory pageFactor, 
                                IComponentPresentationFactory componentPresentationFactory, 
                                ILogger logger, 
                                IDD4TConfiguration configuration) :
            base(pageFactor, componentPresentationFactory, logger, configuration)
        {

        }
        public override ActionResult Page(string url)
        {
            return base.Page(url);
        }
    }
}