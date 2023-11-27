using BibliotecaNewSysacad;
namespace NewSysacad_Test
{
    [TestClass]

    public class ObtenerEstudiante
    {
        [TestMethod]

        public void ObtenerEstudianteLegajo0()
        {
            //ARANGE
            int legajo = 0;

            //ACT
            Estudiante est = NewSysacad.ObtenerEstudiante(legajo);

            //ASSERT
            Assert.IsNotNull(est);
            Assert.AreEqual(est.Legajo, new Estudiante().Legajo);

        }
        [TestMethod]
        public void ObtenerEstudianteLegajoInexistente()
        {
            //ARANGE
            int legajo = 2;

            //ACT
            Estudiante est = NewSysacad.ObtenerEstudiante(legajo);

            //ASSERT
            Assert.IsNotNull(est);
            Assert.AreEqual(est.Legajo, new Estudiante().Legajo);
        }

        [TestMethod]
        public void ObtenerEstudianteCorrecto()
        {
            //ARANGE
            int legajo = 100;

            //ACT
            Estudiante est = NewSysacad.ObtenerEstudiante(legajo);

            //ASSERT
            Assert.IsNotNull(est);
            Assert.AreNotEqual(est, new Estudiante());

        }
    }

    [TestClass]

    public class loggearEstudiante
    {
        [TestMethod]

        public void LoggearEstudianteCorrectamente()
        {
            //ARANGE
            string pass = "1234";
            string username = "ezef";

            //ACT
            bool resultado = NewSysacad.LoginEstudiante(username, pass);

            //ASSERT
            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado);


        }
        [TestMethod]
        public void LoggearEstudianteIncorrecto()
        {
            //ARANGE
            string pass = "$13$Ro2zeHisBsVSbnybMw9WU.BMtekwc6wLIEqBYBc7LQBAiZsWE5VlW";
            string username = "nuevoEst";

            //ACT
            bool resultado = NewSysacad.LoginEstudiante(username, pass);

            //ASSERT
            Assert.IsNotNull(resultado);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void LoggearPasswordVacio()
        {
            //ARANGE
            string pass = "";
            string username = "est";

            //ACT
            bool resultado = NewSysacad.LoginEstudiante(username, pass);

            //ASSERT
            Assert.IsNotNull(resultado);
            Assert.IsFalse(resultado);

        }
    }

    [TestClass]

    public class NombreDelUsuario
    {
        [TestMethod]

        public void ValidarNombreCorrectamete()
        {
            //ARANGE
            string nombre = "Ezequiel";

            //ACT
            bool resultado = Validaciones.ValidarNombre(nombre);

            //ASSERT
            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado);


        }
        [TestMethod]
        public void NoValidarNombreVacio()
        {
            //ARANGE
            string nombre = "";

            //ACT
            bool resultado = Validaciones.ValidarNombre(nombre);

            //ASSERT
            Assert.IsNotNull(resultado);
            Assert.IsFalse(resultado);
        }
        
        [TestMethod]
        public void NoValidarNombreConNumero()
        {
            //ARANGE
            string nombre = "asda33";

            //ACT
            bool resultado = Validaciones.ValidarNombre(nombre);

            //ASSERT
            Assert.IsNotNull(resultado);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ValidarNombreConEspacio()
        {
            //ARANGE
            string nombre = "Ezequiel Manuel";

            //ACT
            bool resultado = Validaciones.ValidarNombre(nombre);

            //ASSERT
            Assert.IsNotNull(resultado);
            Assert.IsFalse(resultado);
        }

    }
}