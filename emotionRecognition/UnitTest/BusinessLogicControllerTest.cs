using BusinessLogic;
using BusinessLogic.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;

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
        public void AddEntity()
        {
            Assert.AreEqual(0, businessLogicController.GetEntities().Count);
            Assert.IsTrue(businessLogicController.AddEntity("Chocolate"));
            Assert.AreEqual(businessLogicController.GetEntities().ElementAt(0).Name, "Chocolate");
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
        public void AddEntityContainedIntoAnotherEntity()
        {
            businessLogicController.AddEntity("Chocolate");
            businessLogicController.AddEntity("cocacola");
            Assert.IsFalse(businessLogicController.AddEntity("coca"));
        }
        
        [TestMethod]
        public void AddAlarmSearchInDays()
        {
            Assert.AreEqual(0, businessLogicController.GetAlarmsChecked().Count);

            businessLogicController.AddAlarm("1", true, 2, false, 3);

            Assert.AreEqual(1, businessLogicController.GetAlarmsChecked().Count);
        }

        [TestMethod]
        public void AddAlarmSearchInHours()
        {
            Assert.AreEqual(0, businessLogicController.GetAlarmsChecked().Count);

            businessLogicController.AddAlarm("1", false, 2, false, 3);

            Assert.AreEqual(1, businessLogicController.GetAlarmsChecked().Count);
        }

        [TestMethod]
        public void GetAlarmsChecked()
        {
            businessLogicController.AddAlarm("Valorant", true, 1, true, 2);
            businessLogicController.AddPhrase("Valorant is good", DateTime.Now);
            businessLogicController.AddPositiveSentiment("Good");
            businessLogicController.AddEntity("Valorant");

            List<TimeLapseAlarm> alarms = businessLogicController.GetAlarmsChecked();

            Assert.AreEqual(true, alarms[0].IsActivated);
        }

        [TestMethod]
        public void AddPhrase()
        {
            Assert.AreEqual(0, businessLogicController.GetPhrases().Count);
            businessLogicController.AddPhrase("test01", new DateTime());
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).Text, "test01");
        }

        [TestMethod]
        public void AnalizePhraseWithoutEntity()
        {
            Assert.AreEqual(0, businessLogicController.GetPhrases().Count);
            Assert.AreEqual(0, businessLogicController.GetEntities().Count);
            Assert.IsTrue(businessLogicController.AddPositiveSentiment("nice"));
            businessLogicController.AddPhrase("The sun is nice", new DateTime());
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).PhraseState, PhraseState.NEUTRAL);
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

            foreach (Phrase e in businessLogicController.GetPhrases())
            {
                Assert.AreEqual("The moon",e.Entity.Name);
                Assert.AreEqual(PhraseState.LOW_POSITIVE, e.PhraseState);
            }
        }

        [TestMethod]
        public void GetPhrasesAfterAddNewPositiveSentiment()
        {
            Assert.AreEqual(businessLogicController.GetPhrases().Count, 0);
            businessLogicController.AddEntity("Titanic");
            businessLogicController.AddPhrase("I love Titanic", new DateTime());
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).Text, "I love Titanic");
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).PhraseState, PhraseState.NEUTRAL);      

            businessLogicController.AddPositiveSentiment("love");
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).PhraseState, PhraseState.LOW_POSITIVE);
        }


        [TestMethod]
        public void AddPositiveSentiment()
        {
            Assert.AreEqual(businessLogicController.GetPositiveSentiments().Count, 0);
            Assert.IsTrue(businessLogicController.AddPositiveSentiment("love"));
            Assert.AreEqual(businessLogicController.GetPositiveSentiments().ElementAt(0).Text, "love");
        }

        [TestMethod]
        public void AddPositiveSentimentConteinedIntoAnother()
        {
            Assert.IsTrue(businessLogicController.AddPositiveSentiment("very nice"));
            Assert.IsTrue(businessLogicController.AddPositiveSentiment("very good"));
            Assert.IsFalse(businessLogicController.AddPositiveSentiment("good"));
            Assert.IsFalse(businessLogicController.AddNegativeSentiment("good"));
        }
       
        [TestMethod]
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
        public void AddNegativeSentiment()
        {
            Assert.AreEqual(businessLogicController.GetNegativeSentiments().Count, 0);
            Assert.IsTrue(businessLogicController.AddNegativeSentiment("odio"));
            Assert.AreEqual(businessLogicController.GetNegativeSentiments().ElementAt(0).Text, "odio");
        }

        [TestMethod]
        public void AddNegativeSentimentConteinedIntoAnother()
        {
            Assert.IsTrue(businessLogicController.AddNegativeSentiment("very bad"));
            Assert.IsFalse(businessLogicController.AddNegativeSentiment("bad"));
            Assert.IsFalse(businessLogicController.AddPositiveSentiment("bad"));
        }

        [TestMethod]
        public void GetPhrasesAfterAddNewNegativeSentiment()
        {
            Assert.AreEqual(businessLogicController.GetPhrases().Count, 0);
            businessLogicController.AddEntity("Titanic");
            businessLogicController.AddPhrase("I hate Titanic", new DateTime());
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).Text, "I hate Titanic");
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).PhraseState, PhraseState.NEUTRAL);

            businessLogicController.AddNegativeSentiment("hate");
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).PhraseState, PhraseState.LOW_NEGATIVE);
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
