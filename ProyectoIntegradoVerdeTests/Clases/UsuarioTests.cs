using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoIntegradoVerde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVerde.Tests
{
    [TestClass()]
    public class UsuarioTests
    {
        [TestMethod()]
        public void compNifTest()
        {
            string[] nif = new string[] { "12345678Z","00000000T","11223344B" };

            foreach (string i in nif)
            {
                Assert.AreEqual(true, Usuario.compNif(i));
            }
            
        }
    }
}