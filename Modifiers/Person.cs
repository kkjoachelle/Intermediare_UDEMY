using System;

namespace Modifiers
{
    public class Person
    {
         private DateTime _DateNais;

        public  void SetDateNais(DateTime value)
        {
            this._DateNais = value;
        }
        public DateTime GetDateNais()
        {
            return _DateNais;
        }

    }
}
