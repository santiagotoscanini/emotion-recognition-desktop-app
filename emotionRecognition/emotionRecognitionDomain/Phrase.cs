using System;

namespace BussinessLogic
{
    public class Phrase
    {
        public string Text { get; }
        public bool Analized { get; private set; }
        private Entity Entity { get; set; }
        private PhraseState State { get; set; }
        private DateTime Date { get; set; }

        public Entity getEntityValue()
        {
            if (Analized)
            {
                return Entity;
            }
            else
            {
                throw new InvalidOperationException("Phrase was not analized");
            }
        }
        public PhraseState getPhraseState()
        {
            if (Analized)
            {
                return State;
            }
            else
            {
                throw new InvalidOperationException("Phrase was not analized");
            }
        }

        public Phrase(string Text)
        {
            this.Text = Text;
            Entity = new Entity();
            Analized = false;
            State = PhraseState.NEUTRAL;
            Date = new DateTime();
        }
         
        public void SetAnalisisResult(Entity Entity, PhraseState State)
        {
            if (Analized)
            {
                throw new InvalidOperationException("Phrase was analized already");
            }
            else
            {
                Analized = true;
                this.Entity = Entity;
                this.State = State;
            }
        }
    }
}
