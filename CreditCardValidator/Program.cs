using System;
using System.Collections.Generic;

namespace CreditCardValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in credit card information to check validity");
						List<long> creditCard = new List<long>();
						string cardString = Console.ReadLine();
						long cardNumber;
						
						bool numberCheck = Int64.TryParse(cardString, out cardNumber);
						if (numberCheck==false){
							Console.WriteLine("Not a valid card");
							return;
						}
						
						int lastCheck = 0;
						long lastNumber = 0;
						while (cardNumber>0){
							if (lastCheck==0){
								lastCheck++;
								lastNumber=cardNumber%10;
								cardNumber=cardNumber/10;
							}
							else{
							creditCard.Add(cardNumber%10);
							cardNumber=cardNumber/10;
							}
						}
						
						long cardTotal=0;
						for(int i=1; i<=creditCard.Count; i++){
							if (i%2 == 1){
								creditCard[i-1]= creditCard[i-1]*2;
							}
							if (creditCard[i-1]>9){
								creditCard[i-1]=creditCard[i-1]-9;
							}
							cardTotal+= creditCard[i-1];
						}
						
						cardTotal=cardTotal%10;
						if (cardTotal+lastNumber==10){
							Console.WriteLine("That is a valid card!");
						}
						else{
							Console.WriteLine("Not a valid card");
						}
						
        }
    }
}
