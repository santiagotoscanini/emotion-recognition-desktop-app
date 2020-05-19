using System;
using System.Collections.Generic;
using BusinessLogic.Enums;

namespace BusinessLogic
{
    public class TimeLapseAlarm
    {
        public Entity Entity { get; }
        public TimeSearchMethodType TimeSearchMethodType { get; }
        public uint QuantityOfTimeToSearchBack { get; }
        public AlarmPosibleState AlarmPosibleState { get; }
        public uint QuantityOfSentimentsNeeded { get; }
        public bool IsActivated { get; private set; }

        public TimeLapseAlarm(Entity Entity, TimeSearchMethodType TimeSearchMethodType, uint QuantityOfTimeToSearchBack, AlarmPosibleState AlarmPosibleState, uint QuantityOfSentimentsNeeded)
        {
            if(QuantityOfTimeToSearchBack == 0 ) {
                throw new ArgumentException("Cannot create an alarm with quantity of time to search back equals to zero", "QuantityOfTimeToSearchBack");
            }
            if(QuantityOfSentimentsNeeded == 0) {
                throw new ArgumentException("Cannot create an alarm with quantity of sentiments needed equals to zero", "QuantityOfSentimentsNeeded");
            }

            this.Entity = Entity ?? throw new ArgumentNullException("Cannot create an alarm with null entity", "QuantityOfSentimentsNeeded");
            this.TimeSearchMethodType = TimeSearchMethodType;
            this.QuantityOfTimeToSearchBack = QuantityOfTimeToSearchBack;
            this.AlarmPosibleState = AlarmPosibleState;
            this.QuantityOfSentimentsNeeded = QuantityOfSentimentsNeeded;
            IsActivated = false;
        }

        public bool CheckIfAlarmIsActivated(List<Phrase> allPhrases)
        {
            DateTime beginDateToSearch = GetBeginDateToSearch();
            List<Phrase> phrasesToBeChecked = FilterPhrasesToBeChecked(allPhrases, beginDateToSearch);
            uint alarmCounter = GetNumberOfPhrases(phrasesToBeChecked);
            IsActivated = alarmCounter >= QuantityOfSentimentsNeeded;
            return IsActivated;
        }

        private DateTime GetBeginDateToSearch()
        {
            DateTime today = DateTime.Now;
            DateTime beginDateToSearch = new DateTime();

            if (TimeSearchMethodType.Equals(TimeSearchMethodType.DAYS))
            {
                beginDateToSearch = today.AddDays(-QuantityOfTimeToSearchBack);
            }
            else if (TimeSearchMethodType.Equals(TimeSearchMethodType.HOURS))
            {
                beginDateToSearch = today.AddHours(-QuantityOfTimeToSearchBack);
            }

            return beginDateToSearch;
        }

        private List<Phrase> FilterPhrasesToBeChecked(List<Phrase> allPhrases, DateTime beginDateToSearch)
        {
            return allPhrases.FindAll(phrase =>
                        phrase.Entity != null &&
                        phrase.Entity.Equals(Entity) &&
                        phrase.CreationDate.Ticks >= beginDateToSearch.Ticks &&
                        phrase.CreationDate.Ticks <= DateTime.Now.Ticks
                    );
        }
        
        private uint GetNumberOfPhrases(List<Phrase> phrasesToBeChecked)
        {
            uint alarmCounter = 0;

            foreach (Phrase phrase in phrasesToBeChecked)
            {
                if ((AlarmPosibleState.Equals(AlarmPosibleState.POSITIVE) && phrase.PhraseState > 0) ||
                    (AlarmPosibleState.Equals(AlarmPosibleState.NEGATIVE) && phrase.PhraseState < 0))
                {
                    alarmCounter++;
                }
            }
            return alarmCounter;
        }
    }
}
