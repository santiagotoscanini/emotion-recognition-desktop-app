using BussinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class PhraseTest
    {
        private Phrase phrase;

        [TestInitialize]
        public void SetUp()
        {
            phrase = new Phrase("The sun is great");
        }

        [TestCleanup]
        public void CleanUp()
        {
            phrase = null;
        }

        [TestMethod]
        public void CreatePhrase()
        {
            Assert.AreEqual("The sun is great", phrase.Text);
        }

        [TestMethod]
        public void SetAnalysisValuesEntitySentiment()
        {
            Entity entity = new Entity("The sun");

            phrase.SetAnalisisResult(entity, PhraseState.HIGH_POSITVE);

            Assert.IsTrue(phrase.Analized);
            Assert.AreEqual("The sun", phrase.getEntityValue().Name);
            Assert.AreEqual(PhraseState.HIGH_POSITVE, phrase.getPhraseState());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SetAnalysisValuesEntitySentimentSecondTime()
        {
            Entity entity = new Entity("The sun");

            phrase.SetAnalisisResult(entity, PhraseState.HIGH_POSITVE);
            phrase.SetAnalisisResult(entity, PhraseState.NEUTRAL);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetSentimentFromEntityNotAnalize()
        {
            _ = phrase.getPhraseState();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetEntityFromEntityNotAnalize()
        {
            _ = phrase.getEntityValue();
        }
    }
}
