using ForeverLand.ADO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaADOMysql
{
    [TestClass]
    public class TestCreacionBD
    {
        public static MySqlADO Ado { get; set; }

        [ClassInitialize]

        public static void SetUpClase(TestContext context)
        {

            //Ado = new MySqlADO();
            Ado = FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "root");
            Ado.Database.EnsureDeleted();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Ado.Database.EnsureCreated();

        }
        
    }
}
