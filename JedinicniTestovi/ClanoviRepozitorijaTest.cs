using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryIS;

namespace JedinicniTestovi
{
    /// <summary>
    /// Summary description for ClanoviRepozitorijaTest
    /// </summary>
    [TestClass]
    public class ClanoviRepozitorijaTest
    {
        public ClanoviRepozitorijaTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GenerirajKorisnickoIme_PredugoImeIPrezime_Vraca8Znakova()
        {
            //
            // TODO: Add test logic here
            //
            // Arrange
            ClanoviRepozitorij clanoviRepozitorijaTest = new ClanoviRepozitorij();
            Clan clan = new Clan("Petar", "Preradovic");

            // Act
            string korIme = clanoviRepozitorijaTest.GenerirajKorisnickoIme(clan);

            // Assert
            Assert.IsTrue(korIme.Length == 8);
        }

        [TestMethod]
        public void GenerirajKorisnickoIme_PrekratkoImeIPrezime_Vraca6Znakova()
        {
            // Arrange
            ClanoviRepozitorij clanoviRepozitorij = new ClanoviRepozitorij();
            Clan clan = new Clan("Petar", "Kos");

            // Act
            string korIme = clanoviRepozitorij.GenerirajKorisnickoIme(clan);

            // Assert
            Assert.IsTrue(korIme.Length == 6);
        }

        [TestMethod]
        public void GenerirajKorisnickoIme_ImeIPrezimeValjaneDuljine_VracaIspravnoKorIme()
        {
            //Arrange 
            ClanoviRepozitorij repozitorij = new ClanoviRepozitorij(); 
            Clan clan = new Clan("Petar", "Klaric");

            //Act
            string korIme = repozitorij.GenerirajKorisnickoIme(clan);

            // Assert
            Assert.AreEqual("pklaric", korIme);
        }

        [TestMethod]
        public void GenerirajKorisnickoIme_ImeIPrezimePrazno_VracaNull()
        {
            //Arrange 
            ClanoviRepozitorij repozitorij = new ClanoviRepozitorij();
            Clan clan = new Clan("", "");

            //Act
            string korIme = repozitorij.GenerirajKorisnickoIme(clan);

            // Assert
            Assert.IsTrue(korIme == "");
        }

        [TestMethod]
        public void GenerirajKorisnickoIme_ClanJednakNull_VracaArgumentNullException()
        {
            //Arrange 
            ClanoviRepozitorij repozitorij = new ClanoviRepozitorij();
            Clan clan = null;

            //Act&Assert
            Assert.ThrowsException<ArgumentNullException>(() => repozitorij.GenerirajKorisnickoIme(clan));
        }
    }
}
