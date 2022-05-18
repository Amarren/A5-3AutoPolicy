using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPolicy
{
    class AutoPolicyTest
    {
        static void Main()
        {
            //create two AutoPPolicy Objects
            AutoPolicy policy1 = new AutoPolicy(11111111, "Toyota Camry", "UT");
            AutoPolicy policy2 = new AutoPolicy(22222222, "Ford Fusion", "MA");



            //display wether each policy is in a no-fault state
            PolicyInNoFaultState(policy1);
            PolicyInNoFaultState(policy2);
        }

        //method that displays whether an AutoPolicy
        //is in a state with no-fault auto insurance
        public static void PolicyInNoFaultState(AutoPolicy policy)
        {
            Console.WriteLine("The auto Policy:");
            Console.Write($"Account #: {policy.AccountNumber}; ");
            Console.WriteLine($"Car: {policy.MakeAndModel};");
            Console.Write($"State {policy.State}; ");
            Console.Write($"({(policy.IsNoFaultState ? "is" : "is not")})");
            Console.WriteLine(" a no-fault State\n");
        }
    }
}
