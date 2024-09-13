

using System.Speech.Synthesis;


using System.Speech.Synthesis;

namespace ATM_NI_NATS{



  class BankTransferBDO:Polymerize_Me{

              private static Data user = new Data();
          
        public override void Display2()  {


                               SpeechSynthesizer run = new SpeechSynthesizer();
                             run.SelectVoiceByHints(VoiceGender.Female);
                             run.Rate = 1;
                    do{
                        Console.Clear();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;


                                  Console.Write(@"
                                                                 ___________________________________________________________________________________________
                                                                |                                                                                           |
                                                                |                                                                                           |                                                                                                                                     
                                                                |              _______________                                      ________________        |
                                                                |             |               |                                    |                |       |
                                                                |       ▄█    |  █▀▄▀█  █▄▄   |                              ▀█    |  █▀█ █▄░█ █▄▄  |       |
                                                                |       ░█ ▄  |  █░▀░█  █▄█   |                              █▄ ▄  |  █▀▀ █░▀█ █▄█  |       |
                                                                |             |_______________|                                    |________________|       |                                   
                                                                |                                                                                           |
                                                                |                                                                                           |
                                                                |                                                                                           |
                                                                |                                                                                           |
                                                                |             ________________                                      ______________          |
                                                                |            |                |                                    |              |         |
                                                                |      ▀█    |   █▄▄ █▀█ █    |                              █░█   |   █░░  █▄▄   |         |
                                                                |       ▄█ ▄ |   █▄█ █▀▀ █    |                              ▀▀█ ▄ |   █▄▄  █▄█   |         |
                                                                |            |________________|                                    |______________|         |
                                                                |                                                                                           |       
                                                                |                                                                                           |
                                                                |                                                                                           |
                                                                |                                                                                           |
                                                                |                                                                                           |
                                                                |                                                                                           |
                                                                |    -Please select your-                                                                   |
                                                                |    desired transaction              ENTER CHOICE:                                         |
                                                                |   ---------------------           ------------------                                      |
                                                                |                                                                                           |
                                                                |                                                                                           |
                                                                |___________________________________________________________________________________________|                                                  
            ");

            run.Speak("Select a bank to transfer");
               Console.SetCursorPosition(patakilid - 60 , Console.CursorTop -5);
            choice = Console.ReadLine();
            while(!double.TryParse(choice, out input) || input  < 1 || input > 4){
              
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
              Console.Write("Invalid Input!");
              run.Speak("Invalid Input!");
              Display();
              choice = Console.ReadLine();
            }


      
                  switch(input){


                    case 1: Amount(); break;
                    case 2: Amount2(); break;
                    case 3: Amount3(); break;
                    case 4: Amount4(); break;
                    
                  }

        




                    }while(false);


            base.Display();
        }

        public override void Amount()
        {
                    SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);
          run.Rate = 1;
          

                  do{
                    Console.Clear();
                    Console.ResetColor();
                     Console.Write(@"
                                                                                              E N T E R   A M O U N T
              
                                                                                          P H P :   
                                                                                          -----------------------------



                                                                          A C C O U N T  N U M B E R : 
              
                                                                          
              
              ");      
              Console.SetCursorPosition(patakilid - 77 , Console.CursorTop -9);      
                string amount = Console.ReadLine();
                
                double kwarta;
                while(!double.TryParse(amount, out kwarta) || kwarta < 1){
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\t Invalid input of amount!");
                  run.Speak("Invalid input of amount!"); 
                  Amount();
                }


                if(ATM_NI_NATS.Data.Balance < kwarta){

                    Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\t Not enough Balance for your BDO account");
                  run.Speak("Not enough Balance for your BDO account"); 
                  Amount();



                }

                        accnum:
                       Console.Clear();
                  Console.ResetColor();
                  Console.Write($@"
                                                                                              E N T E R   A M O U N T
              
                                                                                          P H P : {amount} 
                                                                                          -----------------------------



                                                                          A C C O U N T  N U M B E R : 
              
                                                                          
              
              ");      
                  Console.SetCursorPosition(patakilid - 72 , Console.CursorTop -4);
                  run.Speak("Enter users account number");      
                string accnum = Tago();


                if(accnum != user.Accnum){
                     Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Account Number!");
                  run.Speak("Invalid Account Number!"); 
                  goto accnum;


                }


                  ATM_NI_NATS.Data.Balance -= kwarta;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tDo you want a receipt or not? (Y or N): ");
                  string receipt = Console.ReadLine();
                   if(receipt == "Y" || receipt == "y") {
                  format1 = kwarta.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance.ToString("F2");
                   invalid:
                   Console.Clear();
                  Console.ResetColor();
                  

                   Console.Write($@"
                                                                                 ________________________________________________
                                                                                |                                                |
                                                                                |              ATM TRANSACTION RECEIPT           |       
                                                                                |                                                |
                                                                                |    DATE: {Date.ToShortDateString()}                             |                                                                    
                                                                                |                                                |                                                       
                                                                                |    NAME: {user.Firstname} {user.Lastname}                    |
                                                                                |                                                |
                                                                                |    TRANSFERRED AMOUNT: PHP: {format1}             |
                                                                                |                                                |
                                                                                |    UPDATED BALANCE:  PHP: {format2}              |
                                                                                |                                                |
                                                                                |                                                |
                                                                                |        THANK YOU FOR USING OUR SERVICE!        |
                                                                                |                                                |
                                                                                |                                                |
                                                                                |________________________________________________|

                                                                         
                                                                                1.) G O  B A C K
                                                                          
                                                                                C H O I C E : 
                                                                          
              
              ");
             Console.SetCursorPosition(patakilid - 81 , Console.CursorTop -1);
              string goback = Console.ReadLine();
              int convert;
              while(!int.TryParse(goback, out convert) || convert < 1 || convert > 1){
                           Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Input! ");
                  run.Speak("Invalid input!");
                  goto invalid;
                  
                   }

                   }
                    if(receipt == "N" || receipt == "n"){

                    BDO balik = new BDO(); balik.Display();
                  }  


              
                   
                  }while(false);



            base.Amount();
        }


        public override void Amount2()
        {
            base.Amount2();
        }



        public override void Amount3()
        {
            base.Amount3();
        }


        public override void Amount4()
        {
            base.Amount4();
        }



              public override string Tago()
{
      string pin = "";

    ConsoleKeyInfo keyInfo;
    do
    {
        keyInfo = Console.ReadKey(true);

        if (keyInfo.Key == ConsoleKey.Backspace && pin.Length > 0)
        {
            pin = pin.Substring(0, pin.Length - 1);
            Console.Write("\b \b");
        }
        else if (keyInfo.Key != ConsoleKey.Enter && !char.IsControl(keyInfo.KeyChar))
        {
            Console.Write("*");
            pin += keyInfo.KeyChar;
        }
    } while (keyInfo.Key != ConsoleKey.Enter);

    Console.WriteLine();

            return pin;
        }

    }           
            
}