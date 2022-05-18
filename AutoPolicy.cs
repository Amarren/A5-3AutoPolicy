using System;

namespace AutoPolicy
{
    class AutoPolicy
    {
        public int AccountNumber { get; set; } //policy account number
        public string MakeAndModel { get; set; } //car that policy applies to
        public string State { get; set; } //two-letter state abbreviation

        bool noFaultState;

        //Constructor
        public AutoPolicy(int accountNumber, string makeAndModel, string state)
        {
            AccountNumber = accountNumber;
            MakeAndModel = makeAndModel;
            State = state;

        }

        //returns whether the state has no-fault insurance
        public bool IsNoFaultState
        {
            get
            {

                if ((State == "CT") || (State == "MA") || (State == "ME") || (State == "NH") || (State == "NJ") || (State == "NY") || (State == "PA") || (State == "VT"))
                {
                    noFaultState = true;
                    return noFaultState;
                }

                else
                {
                    Console.WriteLine("ERROR: Not Acceptable State");
                    noFaultState = false;
                    return noFaultState;


                }
            }
        }
    }
}
