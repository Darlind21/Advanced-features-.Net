using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_excercises
{
    internal class BankAccount
    {
        public string AccountHolder {  get; set; }
        public decimal Balance { get; private set; } = 0;
        // me private set do t thot 
        //qe vlera e balances mund t vendoset vtm nga metodat qe jan brenda per brenda klases 
        //ose duke vendosur vleren ne konstruktor dhe menyr tjtr eshte ajo me siper me =

        public void Withdraw(decimal amount)
        {
            try
            {
                if (amount > 0 && amount < Balance)
                {
                    Balance = Balance - amount;
                    Console.WriteLine("Ju keni terhequr :" + amount + "leke");
                    Console.WriteLine("Balanca e mbetur eshte :" + Balance + "leke");
                }
                else
                {
                    throw new Exception("Shuma qe doni te terhiqni duhet te jete me e madhe se zero dhe me e vogel se balanca e llogarise");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount > 0)
                {
                    Balance = Balance + amount;
                    Console.WriteLine("Ju keni depozituar :" + amount + "leke");
                    Console.WriteLine("Balanca e re eshte :" + Balance + "leke");
                }
                else
                {
                    throw new Exception("Shuma qe doni te depozitoni duhet te jete me e madhe se zero");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetBankAccountInfo()
        {
            Console.WriteLine("Emri i llogarise eshte: " + AccountHolder);
            Console.WriteLine("Balanca e llogarise eshte: " +Balance);
        }
    }
}
