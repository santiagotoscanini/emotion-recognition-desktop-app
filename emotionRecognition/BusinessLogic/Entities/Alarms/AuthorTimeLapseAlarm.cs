using BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace BusinessLogic.Entities
{
    public class AuthorTimeLapseAlarm : IAlarm
    {
        public HashSet<Author> ActivatingAuthors { get; set; }
        public int Id { get; set; }
        public TimeSearchMethodType TimeSearchMethodType { get; set; }
        public uint QuantityOfTimeToSearchBack { get; set; }
        public AlarmPosibleState AlarmPosibleState { get; set; }
        public uint QuantityOfSentimentsNeeded { get; set; }
        public bool IsActivated { get; set; }

        public AuthorTimeLapseAlarm() { }

        public AuthorTimeLapseAlarm(TimeSearchMethodType timeSearchMethodType, uint quantityOfTimeToSearchBack, AlarmPosibleState alarmPosibleState, uint quantityOfSentimentsNeeded)
        {
            if (quantityOfTimeToSearchBack == 0)
            {
                throw new ArgumentException("Cannot create an alarm with quantity of time to search back equals to zero", "quantityOfTimeToSearchBack");
            }
            if (quantityOfSentimentsNeeded == 0)
            {
                throw new ArgumentException("Cannot create an alarm with quantity of sentiments needed equals to zero", "quantityOfSentimentsNeeded");
            }

            TimeSearchMethodType = timeSearchMethodType;
            QuantityOfTimeToSearchBack = quantityOfTimeToSearchBack;
            AlarmPosibleState = alarmPosibleState;
            QuantityOfSentimentsNeeded = quantityOfSentimentsNeeded;
            IsActivated = false;
            ActivatingAuthors = new HashSet<Author>();
        }

        public bool CheckIfAlarmIsActivated(IEnumerable<Phrase> allPhrases)
        {
            DateTime beginDateToSearch = GetBeginDateToSearch();
            List<Phrase> phrasesToBeChecked = FilterPhrasesToBeChecked(allPhrases, beginDateToSearch);
            uint alarmCounter = GetNumberOfPhrases(phrasesToBeChecked);
            IsActivated = alarmCounter >= QuantityOfSentimentsNeeded;
            SetActivatingAuthors(phrasesToBeChecked);
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

        private List<Phrase> FilterPhrasesToBeChecked(IEnumerable<Phrase> allPhrases, DateTime beginDateToSearch)
        {
            List<Phrase> phrases = allPhrases.ToList();
            return phrases.FindAll(phrase =>
                        phrase.CreationDate.Ticks >= beginDateToSearch.Ticks &&
                        phrase.CreationDate.Ticks <= DateTime.Now.Ticks
                    );
        }

        private uint GetNumberOfPhrases(List<Phrase> phrasesToBeChecked)
        {
            uint alarmCounter = 0;

            foreach (Phrase phrase in phrasesToBeChecked)
            {
                bool positive = AlarmPosibleState.Equals(AlarmPosibleState.POSITIVE) && phrase.PhraseState > 0;
                bool negative = AlarmPosibleState.Equals(AlarmPosibleState.NEGATIVE) && phrase.PhraseState < 0;
                if (positive || negative) alarmCounter++;
            }

            return alarmCounter;
        }

        private void SetActivatingAuthors(List<Phrase> ActivatingPhrases)
        {
            ActivatingAuthors.Clear();
            if (IsActivated)
            {
                foreach(Phrase phrase in ActivatingPhrases)
                {
                    ActivatingAuthors.Add(phrase.Author);
                }
            }
        }
    }
}
