using BusinessLogic;
using BusinessLogic.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Tests
{
    [TestClass]
    public class BusinessLogicControllerTest
    {
        private BusinessLogicController businessLogicController;

        [TestInitialize]
        public void initializeTests()
        {
            businessLogicController = new BusinessLogicController(new Repository());
        }

        [TestMethod]
        public void ValidateAddingDuplicatedEntities()
        {
            Assert.IsTrue(businessLogicController.AddEntity("test"));
            Assert.IsFalse(businessLogicController.AddEntity("test"));
        }

        [TestMethod]
        public void GetEntities()
        {
            Assert.AreEqual(0, businessLogicController.GetEntities().Count);
            businessLogicController.AddEntity("test1");
            Assert.AreEqual(1, businessLogicController.GetEntities().Count);
        }
        
        [TestMethod]
        public void AddAlarm()
        {
            Assert.AreEqual(0, businessLogicController.GetAlarmsChecked().Count);

            businessLogicController.AddAlarm("1", true, 2, false, 3);

            Assert.AreEqual(1, businessLogicController.GetAlarmsChecked().Count);
        }

        [TestMethod]
        public void GetAlarmsChecked()
        {
            businessLogicController.AddAlarm("Valorant", true, 1, true, 1);
            businessLogicController.AddPhrase("Valorant is good", DateTime.Now);
            businessLogicController.AddPositiveSentiment("Good");
            businessLogicController.AddEntity("Valorant");

            businessLogicController.AnalizePhrases();

            List<TimeLapseAlarm> alarms = businessLogicController.GetAlarmsChecked();

            Assert.AreEqual(true, alarms[0].IsActivated);
        }

        [TestMethod]
        public void GetPhrases()
        {
            Assert.AreEqual(0, businessLogicController.GetPhrases().Count);
            businessLogicController.AddPhrase("test1", new DateTime());
            Assert.AreEqual(1, businessLogicController.GetPhrases().Count);
        }

        [TestMethod]
        public void GetPhrasesReAnalize()
        {
            businessLogicController.AddPhrase("The moon is great", new DateTime());
            foreach(Phrase e in businessLogicController.GetPhrases())
            {
                Assert.IsNull(e.Entity);
                Assert.AreEqual(PhraseState.NEUTRAL, e.PhraseState);
            }

            businessLogicController.AddEntity("The moon");
            businessLogicController.AddPositiveSentiment("great");
            businessLogicController.AnalizePhrases();

            foreach (Phrase e in businessLogicController.GetPhrases())
            {
                Assert.AreEqual("The moon",e.Entity.Name);
                Assert.AreEqual(PhraseState.LOW_POSITIVE, e.PhraseState);
            }
        }

        public void ValidateAddingDulpicatedPositiveSentiment()
        {
            Assert.IsTrue(businessLogicController.AddPositiveSentiment("test2"));
            Assert.IsFalse(businessLogicController.AddPositiveSentiment("test2"));
        }

        [TestMethod]
        public void GetPositiveSentiments()
        {
            Assert.AreEqual(0, businessLogicController.GetPositiveSentiments().Count);
            businessLogicController.AddPositiveSentiment("test3");
            Assert.AreEqual(1, businessLogicController.GetPositiveSentiments().Count);
        }

        [TestMethod]
        public void DeletePositiveSentiment()
        {
            businessLogicController.AddPositiveSentiment("test4");
            businessLogicController.DeletePositiveSentiment("test4");
            Assert.AreEqual(0, businessLogicController.GetPositiveSentiments().Count);
        }

        [TestMethod]
        public void ValidateAddingDulpicatedNegativeSentiment()
        {
            Assert.IsTrue(businessLogicController.AddNegativeSentiment("test5"));
            Assert.IsFalse(businessLogicController.AddNegativeSentiment("test5"));
        }

        [TestMethod]
        public void GetNegativentiments()
        {
            Assert.AreEqual(0, businessLogicController.GetNegativeSentiments().Count);
            businessLogicController.AddNegativeSentiment("test6");
            Assert.AreEqual(1, businessLogicController.GetNegativeSentiments().Count);
        }

        [TestMethod]
        public void DeleteNegativeSentiment()
        {
            businessLogicController.AddNegativeSentiment("test7");
            businessLogicController.DeleteNegativeSentiment("test7");
            Assert.AreEqual(0, businessLogicController.GetNegativeSentiments().Count);
        }
    }
}
