using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebAPI_test.Models.Abstract;
using WebAPI_test.Models.Concrete;

namespace WebAPI_test.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType != null)
                return (IController)ninjectKernel.Get(controllerType);
            else
                return null;
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<ICommentRepository>().To<CommentRepository>();
        }
    }
}