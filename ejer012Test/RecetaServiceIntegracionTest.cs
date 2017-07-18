using ejer012;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer012Test
{
    [TestClass]
    public class RecetaServiceIntegracionTest
    {
        [TestMethod]
        public void TestCreate()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();

            IRecetaService sut = container.Resolve<IRecetaService>();

            Receta receta = new Receta();
            receta.Nombre = "Arroz negro";
            receta.Peso = 100;

            Receta resultado = sut.Create(receta);

            Assert.AreEqual(2 * 100.0, resultado.Peso);

        }
    }
}
