using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static BussinessLogic.Module;

namespace BussinessLogic
{
    public class Phrase
    {
        public string Text { get; }
        public bool Analized { get; private set; }
        private Entity Entity { get; set; }
        private PhraseState State { get; set; }
        public Entity getEntityValue()
        {
            if (this.Analized)
            {
                return this.Entity;
            }
            else
            {
                throw new InvalidOperationException("Phrase was not analized");
            }
        }
        public PhraseState getPhraseState()
        {
            if (this.Analized)
            {
                return this.State;
            }
            else
            {
                throw new InvalidOperationException("Phrase was not analized");
            }
        }

        public Phrase(string Text)
        {
            this.Text = Text;
            this.Entity = new Entity();
            this.Analized = false;
            this.State = PhraseState.NEUTRAL;
        }
        public void SetAnalisisResult(Entity Entity, PhraseState State)
        {
            if (this.Analized)
            {
                throw new InvalidOperationException("Phrase was analized already");
            }
            else
            {
                this.Analized = true;
                this.Entity = Entity;
                this.State = State;
            }
        }
    }
}
