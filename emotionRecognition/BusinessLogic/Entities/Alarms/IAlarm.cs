using System;
using System.Collections.Generic;

namespace BusinessLogic.Entities
{
    public interface IAlarm
    { 
        bool CheckIfAlarmIsActivated(IEnumerable<Phrase> allPhrases);

    }
}
