using MyPortfolio.Context;
using System;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MyPortfolio
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer() => container.Value;

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<PortfolioContext, PortfolioContext>();
        }
    }
}