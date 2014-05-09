using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;


namespace Guadi.Web.Tool.Helper.Ioc
{
    public class MefDependencySolver:IDependencyResolver
    {
        private readonly ComposablePartCatalog _catalog;

        private const string MefContainerKey = "MefContainerKey";

        public MefDependencySolver(ComposablePartCatalog catalog)
        {
            _catalog = catalog;
        }

        public CompositionContainer Container
        {
            get
            {
                if (!HttpContext.Current.Items.Contains((MefContainerKey)))
                {
                    HttpContext.Current.Items.Add(MefContainerKey,new );
                }
            }
        }


    }

}
