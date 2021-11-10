using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;


namespace MultivalueDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unitycontainer = new UnityContainer();
            unitycontainer.RegisterType<IMultivalueDictionary<string, string>, MultivalueDictionary<string, string>>(new ContainerControlledLifetimeManager() { });
            unitycontainer.Resolve<ConsoleApplication>().Run(); ;
        }
    }
}
