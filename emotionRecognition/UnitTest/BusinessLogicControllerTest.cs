using BusinessLogic;
using BusinessLogic.BD;
using BusinessLogic.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;
using UnitTest;
using BusinessLogic.Entities;

namespace Tests
{
    [TestClass]
    public class BusinessLogicControllerTest : TestUtils
    {
        private BusinessLogicController businessLogicController;

        [TestInitialize]
        public void InitializeTests()
        {
            businessLogicController = new BusinessLogicController(new EFRepository());
        }

        [TestCleanup]
        public void CleanupTests()
        {
            CleanDB();
        }

        [TestMethod]
        public void AddEntity()
        {
            Assert.AreEqual(0, businessLogicController.GetEntities().ToList().Count);
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
            Assert.AreEqual(0, businessLogicController.GetEntities().ToList().Count);
            businessLogicController.AddEntity("test1");
            Assert.AreEqual(1, businessLogicController.GetEntities().ToList().Count);
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
            businessLogicController.AddEntity("1");

            Assert.AreEqual(0, businessLogicController.GetAlarmsChecked().ToList().Count);

            businessLogicController.AddAlarm("1", true, 2, false, 3);

            Assert.AreEqual(1, businessLogicController.GetAlarmsChecked().ToList().Count);
        }

        [TestMethod]
        public void AddAlarmSearchInHours()
        {
            businessLogicController.AddEntity("1");

            Assert.AreEqual(0, businessLogicController.GetAlarmsChecked().ToList().Count);

            businessLogicController.AddAlarm("1", false, 2, false, 3);

            Assert.AreEqual(1, businessLogicController.GetAlarmsChecked().ToList().Count);
        }

        [TestMethod]
        public void GetAlarmsChecked()
        {
            businessLogicController.AddAuthor("test", "s", "t", DateTime.Now);
            businessLogicController.AddEntity("Valorant");
            businessLogicController.AddAlarm("Valorant", true, 1, true, 2);
            businessLogicController.AddPhrase("Valorant is good", DateTime.Now, "test");
            businessLogicController.AddPositiveSentiment("Good");

            IEnumerable<TimeLapseAlarm> alarms = businessLogicController.GetAlarmsChecked();

            Assert.AreEqual(true, alarms.ToList()[0].IsActivated);
        }

        [TestMethod]
        public void AddPhrase()
        {
            businessLogicController.AddAuthor("test", "s", "t", DateTime.Now);
            Assert.AreEqual(0, businessLogicController.GetPhrases().ToList().Count);
            businessLogicController.AddPhrase("test01", DateTime.Now, "test");
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).Text, "test01");
        }

        [TestMethod]
        public void GetPhrases()
        {
            businessLogicController.AddAuthor("test", "s", "t", DateTime.Now);
            Assert.AreEqual(0, businessLogicController.GetPhrases().ToList().Count);
            businessLogicController.AddPhrase("test1", DateTime.Now, "test");
            Assert.AreEqual(1, businessLogicController.GetPhrases().ToList().Count);
        }

        [TestMethod]
        public void GetPhrasesReAnalize()
        {
            businessLogicController.AddAuthor("test", "s", "t", DateTime.Now);
            businessLogicController.AddPhrase("The moon is great", DateTime.Now, "test");
            foreach (Phrase phrase in businessLogicController.GetPhrases())
            {
                Assert.IsNull(phrase.Entity);
                Assert.AreEqual(PhraseState.NEUTRAL, phrase.PhraseState);
            }

            businessLogicController.AddEntity("The moon");
            businessLogicController.AddPositiveSentiment("great");

            foreach (Phrase phrase in businessLogicController.GetPhrases())
            {
                Assert.AreEqual("The moon", phrase.Entity.Name);
                Assert.AreEqual(PhraseState.LOW_POSITIVE, phrase.PhraseState);
            }
        }

        [TestMethod]
        public void GetPhrasesAfterAddNewPositiveSentiment()
        {
            businessLogicController.AddAuthor("test", "s", "t", DateTime.Now);
            Assert.AreEqual(businessLogicController.GetPhrases().ToList().Count, 0);
            businessLogicController.AddEntity("Titanic");
            businessLogicController.AddPhrase("I love Titanic", DateTime.Now, "test");
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).Text, "I love Titanic");
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).PhraseState, PhraseState.NEUTRAL);

            businessLogicController.AddPositiveSentiment("love");
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).PhraseState, PhraseState.LOW_POSITIVE);
        }


        [TestMethod]
        public void AddPositiveSentiment()
        {
            Assert.AreEqual(businessLogicController.GetPositiveSentiments().ToList().Count, 0);
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
            Assert.AreEqual(0, businessLogicController.GetPositiveSentiments().ToList().Count);
            businessLogicController.AddPositiveSentiment("test3");
            Assert.AreEqual(1, businessLogicController.GetPositiveSentiments().ToList().Count);
        }

        [TestMethod]
        public void DeletePositiveSentiment()
        {
            businessLogicController.AddPositiveSentiment("test4");
            businessLogicController.DeletePositiveSentiment("test4");
            Assert.AreEqual(0, businessLogicController.GetPositiveSentiments().ToList().Count);
        }

        [TestMethod]
        public void AddNegativeSentiment()
        {
            Assert.AreEqual(businessLogicController.GetNegativeSentiments().ToList().Count, 0);
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
            businessLogicController.AddAuthor("test", "s", "t", DateTime.Now);
            Assert.AreEqual(businessLogicController.GetPhrases().ToList().Count, 0);
            businessLogicController.AddEntity("Titanic");
            businessLogicController.AddPhrase("I hate Titanic", DateTime.Today, "test");
            Assert.AreEqual(businessLogicController.GetPhrases().ElementAt(0).Text, "I hate Titanic");
            Assert.AreEqual(PhraseState.NEUTRAL, businessLogicController.GetPhrases().ElementAt(0).PhraseState);

            businessLogicController.AddNegativeSentiment("hate");
            Assert.AreEqual(PhraseState.LOW_NEGATIVE, businessLogicController.GetPhrases().ElementAt(0).PhraseState);
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
            Assert.AreEqual(0, businessLogicController.GetNegativeSentiments().ToList().Count);
            businessLogicController.AddNegativeSentiment("test6");
            Assert.AreEqual(1, businessLogicController.GetNegativeSentiments().ToList().Count);
        }

        [TestMethod]
        public void DeleteNegativeSentiment()
        {
            businessLogicController.AddNegativeSentiment("test7");
            businessLogicController.DeleteNegativeSentiment("test7");
            Assert.AreEqual(0, businessLogicController.GetNegativeSentiments().ToList().Count);
        }

        [TestMethod]
        public void AddAuthor()
        {
            Assert.AreEqual(0, businessLogicController.GetAuthors().ToList().Count);
            bool wasAdded = businessLogicController.AddAuthor("stos", "Elsa", "Pallito", DateTime.Now);
            Assert.AreEqual(true, wasAdded);
            Assert.AreEqual(1, businessLogicController.GetAuthors().ToList().Count);
        }

        [TestMethod]
        public void AnalyzeAuthor()
        {
            Assert.AreEqual(0, businessLogicController.GetAuthors().ToList().Count);
            bool wasAdded = businessLogicController.AddAuthor("stos", "Elsa", "Pallito", DateTime.Now);
            Assert.AreEqual(true, wasAdded);

            businessLogicController.AnalyzeAuthors();

            Author authorSaved = businessLogicController.GetAuthorByUsername("stos");
            Assert.AreEqual(0, authorSaved.NumberOfPhrases);
            Assert.AreEqual(0, authorSaved.NumberOfPositivePhrases);
            Assert.AreEqual(0, authorSaved.NumberOfNegativePhrases);
            Assert.AreEqual(0, authorSaved.NumberOfDistinctEntitiesMentioned);
            Assert.AreEqual(0, authorSaved.NumberOfDaysFromFirstPublication);

            businessLogicController.AddPhrase("Muy rica la mostaza", DateTime.Now, "stos");
            businessLogicController.AddEntity("mostaza");
            businessLogicController.AddPositiveSentiment("RicA");
            
            businessLogicController.AnalyzePhrases();
            businessLogicController.AnalyzeAuthors();

            Author authorSavedAfterAnalyze = businessLogicController.GetAuthors().ToList().First();
            Assert.AreEqual(1, authorSavedAfterAnalyze.NumberOfPhrases);
            Assert.AreEqual(1, authorSavedAfterAnalyze.NumberOfPositivePhrases);
            Assert.AreEqual(0, authorSavedAfterAnalyze.NumberOfNegativePhrases);
            Assert.AreEqual(1, authorSavedAfterAnalyze.NumberOfDistinctEntitiesMentioned);
        }
    }
}
