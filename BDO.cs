using System.Net.NetworkInformation;
using System.Speech.Synthesis;

namespace ATM_NI_NATS{



class BDO : Polymerize_Me{
   
        private static Data user = new Data();
        
        public override void Display()
        {   
             SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);
          run.Rate = 1;
          

          do{
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |      1. A C C O U N T                             |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |      2. D E P O S I T  C A S H                    |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |      3. W I T H D R A W  C A S H                  |
                                                                    |                          |                                                   |
                                                                    |  W  H  A  T              |                                                   |
                                                                    |                          |      4. B A N K  T R A N S F E R                  |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |      5. C H A N G E  P I N                        |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |      6. R E T U R N  M E N U                      |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |      ENTER CHOICE:                                |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
            Console.SetCursorPosition(patakilid - 60 , Console.CursorTop -5);
            choice = Console.ReadLine();
            while(!double.TryParse(choice, out input) || input  < 1 || input > 6){
              
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
              Console.Write("Invalid Input!");
              run.Speak("Invalid Input!");
              Display();
              choice = Console.ReadLine();

            }
          }while(false);


          switch(input) {


            case 1: Console.Beep(); Balance(); break; 
            case 2: Console.Beep(); Deposit(); break;
            case 3: Console.Beep(); Withdraw(); break;
            case 4: Console.Beep(); Display2(); break;
            case 5: Console.Beep(); ChangePin(); break;
            case 6: Console.Beep(); ATM menu = new ATM(); menu.Display(); break;
       
            
          }



         
        }


         public override double Balance() {
                   SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);
          run.Rate = 1;
              do{
            format = ATM_NI_NATS.Data.Balance.ToString("F2");
            format2 =ATM_NI_NATS.Data.Savings.ToString("F2");

                Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |         Y O U R  S A V I N G S                    |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |          I S: PHP:  {format2}                       |
                                                                    |                          |               --------------                      |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         Y O U R   C U R R E N T  B A L A N C E    |
                                                                    |                          |                                                   |
                                                                    |                          |           I S: PHP: {format}                       |
                                                                    |                          |                -------------                      |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |  W  H  A  T              |         1. G O  B A C K                           |
                                                                    |                          |                                                   |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |      ENTER CHOICE:                                |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");

                     Console.SetCursorPosition(patakilid - 60 , Console.CursorTop -5);
            choice = Console.ReadLine();
            while(!double.TryParse(choice, out input) || input != 1){
              
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
              Console.Write("Invalid Input!");
              run.Speak("Invalid Input!");
              Balance();
              choice = Console.ReadLine();
            }

            if(input == 1) {
              Console.Beep();
              Display();
            }

               }while(false);

            return base.Balance();

             
          }




        public override double Deposit() {
              do{
                SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);
          run.Rate = 1;

                Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         E N T E R  A M O U N T  T O               |
                                                                    |                          |                                                   |
                                                                    |                          |                D E P O S I T :                    |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |           ______________________                  |
                                                                    |  W  H  A  T              |          | P H P:               |                 |
                                                                    |                          |          |______________________|                 |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
            Console.SetCursorPosition(patakilid - 61 , Console.CursorTop -16 );
              run.Speak("Enter amount to deposit");
              choice = Console.ReadLine();
              

                  while(!double.TryParse(choice, out input) || input < 1 ){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Please enter a valid amount!");
                    run.Speak("Please enter a valid amount!");
                    Deposit();
                    Console.ResetColor();
                    choice = Console.ReadLine();
                  }

                  ATM_NI_NATS.Data.Balance += input;

                  Console.Write("\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t");
                  yorno:
                  Console.Write(" Do you want a receipt or not? (Y or N): ");
                  input2 = Console.ReadLine();

                  if(input2 == "Y" || input2 == "y") {
                   format1 = input.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance.ToString("F2");
                          receipt:
                          Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |             _________________________________________________
                                                                    |                          |                                                   |            |                                                 |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |            |             ATM TRANSACTION RECORD              |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |            |                                                 |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |            |                                                 |
                                                                    |                          |                                                   |            |    DATE: {Date.ToShortDateString()}                               |
                                                                    |                          |                                                   |            |                                                 |
                                                                    |                          |                                                   |            |    NAME: {user.Firstname} {user.Lastname}                     |
                                                                    |                          |                R E C E I P T                      |            |                                                 |
                                                                    |                          |                                                   |            |    DEPOSITED AMOUNT: PHP: {format1}                |
                                                                    |                          |                P R I N T E D !                    |            |                                                 |
                                                                    |                          |                                                   |            |    UPDATED BALANCE:  PHP: {format2}               |
                                                                    |                          |                                                   |            |                                                 |
                                                                    |                          |                                                   |            |                                                 |
                                                                    |                          |                                                   |            |        THANK YOU FOR USING OUR SERVICE!         |
                                                                    |                          |                                                   |            |                                                 |
                                                                    |  W  H  A  T              |         1. G O  B A C K                           |            |                                                 |
                                                                    |                          |                                                   |            |_________________________________________________|  
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |           
                                                                    |                          |                                                   |            
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Selece select your    |                                                   |
                                                                    |    desired transaction   |      ENTER CHOICE:                                |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");

                     Console.SetCursorPosition(patakilid - 60 , Console.CursorTop -5);
                    choice = Console.ReadLine();
                     while(!double.TryParse(choice, out input) || input != 1){
              
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
              Console.Write("Invalid Input!");
              run.Speak("Invalid Input!");
              goto receipt;
              choice = Console.ReadLine();
            }


            if(input == 1) {
              Console.Beep();
              Display();
            }

                  }



                  if(input2 == "N" || input2 == "n"){

                    Display();
                  }


                else{
                    Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
              run.Speak("Invalid Input!");
              goto yorno;
                  
                }


              }while(false);

            return base.Deposit();
        }


        public override double Withdraw()
        {


             SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);
          run.Rate = 1;
          bool pass = false;
            do{
                Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         E N T E R  A M O U N T  T O               |
                                                                    |                          |                                                   |
                                                                    |                          |                W I T H D R A W :                  |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |           ______________________                  |
                                                                    |  W  H  A  T              |          | P H P:               |                 |
                                                                    |                          |          |______________________|                 |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
                Console.SetCursorPosition(patakilid - 61 , Console.CursorTop -16 );
              run.Speak("Enter amount to withdraw");
              choice = Console.ReadLine();

              while(!double.TryParse(choice, out input)|| input < 1){
                      Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Please enter a valid amount!");
                    run.Speak("Please enter a valid amount!");
                    Withdraw();
                    Console.ResetColor();
                    choice = Console.ReadLine();
                  
              }


              if(ATM_NI_NATS.Data.Balance < input) {
                  Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Insufficient amount to Withdraw!");
                    run.Speak("Insuficcient amount to withdraw!");
                    Withdraw();
                    Console.ResetColor();
              }


              if(ATM_NI_NATS.Data.Balance > input) {
                

                 Authenticate();
              
                  ATM_NI_NATS.Data.Balance -= input;
                  format1 = input.ToString("F2");
                  format2 = ATM_NI_NATS.Data.Balance.ToString("F2");
                  
               


              Console.Write("\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t");
               
                  Console.Write(" Do you want a receipt or not? (Y or N): ");
                
                    Console.SetCursorPosition(patakilid - 38 , Console.CursorTop -0);
                    yorno1:
                  input2 = Console.ReadLine();

                  if(input2 == "Y" || input2 == "y") {
                   format1 = input.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance.ToString("F2");
                          receipt1:
                          Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |             ________________________________________________
                                                                    |                          |                                                   |            |                                                |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |            |             ATM TRANSACTION RECEIPT            |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |            |                                                |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |            |                                                |
                                                                    |                          |                                                   |            |    DATE: {Date.ToShortDateString()}                             |
                                                                    |                          |                                                   |            |                                                |
                                                                    |                          |                                                   |            |    NAME: {user.Firstname} {user.Lastname}                    |
                                                                    |                          |                R E C E I P T                      |            |                                                |
                                                                    |                          |                                                   |            |    WITHDRAWED AMOUNT: PHP: {format1}              |
                                                                    |                          |                P R I N T E D !                    |            |                                                |
                                                                    |                          |                                                   |            |    UPDATED BALANCE:  PHP: {format2}              |
                                                                    |                          |                                                   |            |                                                |
                                                                    |                          |                                                   |            |                                                |
                                                                    |                          |                                                   |            |        THANK YOU FOR USING OUR SERVICE!        |
                                                                    |                          |                                                   |            |                                                |
                                                                    |  W  H  A  T              |         1. G O  B A C K                           |            |                                                |
                                                                    |                          |                                                   |            |________________________________________________|  
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |           
                                                                    |                          |                                                   |            
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |      ENTER CHOICE:                                |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");

                     Console.SetCursorPosition(patakilid - 60 , Console.CursorTop -5);
                    choice = Console.ReadLine();
                     while(!double.TryParse(choice, out input) || input != 1){
              
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
              Console.Write("Invalid Input!");
              run.Speak("Invalid Input!");
              goto receipt1;
              choice = Console.ReadLine();
            }


            if(input == 1) {
              Console.Beep();
              Display();
            }

                  }



                  if(input2 == "N" || input2 == "n"){

                    Display();
                  }


                else{
              run.Speak("Invalid Input!");
                Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         E N T E R  P I N  C O D E                 |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |           ______________________                  |
                                                                    |  W  H  A  T              |          | P I N: ******        |                 |
                                                                    |                          |          |______________________|                 |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          | Do you want a receipt or not? (Y or N):           |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
            Console.SetCursorPosition(patakilid - 38 , Console.CursorTop -0);
              goto yorno1;
                  
                }
              
                
              



              
              }

        }while(false);
            return base.Withdraw();
        }



       public override string Authenticate()
{
    SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
    tries = 0;

    string pin;
    bool authenticated = false;
  
    do
    {

        

        if(user.Newpin.Length >= 6){
          
        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         E N T E R  P I N  C O D E                 |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |           ______________________                  |
                                                                    |  W  H  A  T              |          | P I N:               |                 |
                                                                    |                          |          |______________________|                 |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
               run.Speak("Enter Pin code");
        Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 16);
        pin = Tago();

        if (pin == user.Newpin)
        {
            authenticated = true;
        }
        else
        {
            tries++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");

            if (tries >= 3)
            {
                Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\t\t Maximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                Display();
                return null;
            }
        }
        }


        if(user.Newpin.Length == 0){


            Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |            E N T E R  P I N  C O D E              |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |           ______________________                  |
                                                                    |  W  H  A  T              |          | P I N:               |                 |
                                                                    |                          |          |______________________|                 |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
               run.Speak("Enter Pin code");
        Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 16);
        pin = Tago();

        if (pin == user.Pin)
        {
            authenticated = true;
        }
        else
        {
            tries++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");

            if (tries >= 3)
            {
                Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\t\t Maximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                Display();
                return null;
            }
        }
        }


    } while (!authenticated);
            
            return base.Authenticate();
        }






        public override string ChangePin()
        {
              do{
           SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
    
    
            
            string newpin;
            string confirmpin;

              Thread.Sleep(1000);

             if(user.Newpin.Length >= 1){


               Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         E N T E R  P I N  C O D E  T O            |
                                                                    |                          |                                                   |
                                                                    |                          |              C H A N G E   P I N :                |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |           ______________________                  |
                                                                    |  W  H  A  T              |          | P I N:               |                 |
                                                                    |                          |          |______________________|                 |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
               run.Speak("Enter New Pin");
        Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 16);
        newpin = Tago();

         if(newpin.Length <=5 || newpin.Length >=7){
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tPin should only be 6 digits only!");
          run.Speak("Pin should only be six digits only!");
          ChangePin();
        }

          
        if(newpin == user.Newpin){

             Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tPin cannot be the same from previous pin!");
          run.Speak("Pin cannot be the same from previous pin!");
          ChangePin();

        }

                 

          sakto = true;
                Console.Clear();
                Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         E N T E R  C O N F I R M A T I O N        |
                                                                    |                          |                                                   |
                                                                    |                          |                     P I N :                       |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |           ______________________                  |
                                                                    |  W  H  A  T              |          | P I N:               |                 |
                                                                    |                          |          |______________________|                 |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
            run.Speak("Enter Confirmation Pin: ");
            Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 16);
            confirmpin = Tago();

            if(newpin == confirmpin){
                Console.ForegroundColor = ConsoleColor.Green;
                user.Newpin =  newpin;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tPin code Changed!");
                run.Speak("Pin Code Changed!, going back to menu");
                Display();
            }


            if(newpin != confirmpin){

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t Incorrect Confirmation Pin!");
            run.Speak("Incorrect Confirmation Pin!");
            ChangePin();
            }

        


        else{

            tries++;   
             Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");
        

          if (tries >= 3)
            {
                Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\t\t Maximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                Display();
                return null;
            }

        }


         }

         if(user.Newpin.Length == 0){       

        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         E N T E R  P I N  C O D E  T O            |
                                                                    |                          |                                                   |
                                                                    |                          |              C H A N G E   P I N :                |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |           ______________________                  |
                                                                    |  W  H  A  T              |          | P I N:               |                 |
                                                                    |                          |          |______________________|                 |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
               run.Speak("Enter New Pin");
        Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 16);
        newpin = Tago();

        if(newpin.Length <=5 || newpin.Length >=7){
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tPin should only be 6 digits only!");
          run.Speak("Pin should only be six digits only!");
          ChangePin();
        }

        
        if(newpin == user.Pin){

             Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tPin cannot be the same from previous pin!");
          run.Speak("Pin cannot be the same from previous pin!");
          ChangePin();

        }


        

          sakto = true;
          Console.Clear();
           Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |                                                                 
                                                                    |     ░█▀▀█ ░█▀▀▄ ░█▀▀▀█   |                                                   |
                                                                    |     ░█▀▀▄ ░█─░█ ░█──░█   |                                                   |
                                                                    |     ░█▄▄█ ░█▄▄▀ ░█▄▄▄█   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         E N T E R  C O N F I R M A T I O N        |
                                                                    |                          |                                                   |
                                                                    |                          |                     P I N :                       |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |           ______________________                  |
                                                                    |  W  H  A  T              |          | P I N:               |                 |
                                                                    |                          |          |______________________|                 |
                                                                    |  W  O  U  L  D   Y  O  U |                                                   |
                                                                    |                          |                                                   |
                                                                    |   L  I  K  E   T  O      |                                                   |
                                                                    |                          |                                                   |
                                                                    |       D  O ?             |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |    Please select your    |                                                   |
                                                                    |    desired transaction   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
            run.Speak("Enter Confirmation Pin: ");
            Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 16);
            confirmpin = Tago();

            if(newpin == confirmpin){
                Console.ForegroundColor = ConsoleColor.Green;
                user.Newpin =  newpin;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tPin code Changed!");
                
                run.Speak("Pin Code Changed!, going back to menu");
                Display();
            }


            if(newpin != confirmpin){

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t Incorrect Confirmation Pin!");
            run.Speak("Incorrect Confirmation Pin!");
            ChangePin();
            }
          
        


        else{
            tries++;
             Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");

        

          if (tries >= 3)
            {
                Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\t\t Maximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                Display();
                return null;
            }

        }

         }





        

              }while(!sakto);      

            return user.Newpin;
        }



    
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


            base.Display2();
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
                  ATM_NI_NATS.Data.Balance -= 15;
                  ATM_NI_NATS.Data.Balance2 += kwarta;
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
                                                                                |     TRANSACTION FEE: PHP: 15                   |
                                                                                |                                                |                                                                            
                                                                                |        THANK YOU FOR USING OUR SERVICE!        |
                                                                                |                                                |
                                                                                |                                                |
                                                                                |________________________________________________|

                                                                         
                                                                                1.) G O  B A C K
                                                                          
                                                                                C H O I C E : 
                                                                          
                
              ");
                  Console.SetCursorPosition(patakilid - 81 , Console.CursorTop -3);
              string goback = Console.ReadLine();
              int convert;
              while(!int.TryParse(goback, out convert) || convert < 1 || convert > 1){
                           Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Input! ");
                  run.Speak("Invalid input!");
                  goto invalid;
                  
                   }


                      if(convert == 1) {

                        Console.Beep();
                        Display();
                      }
                   }
                    if(receipt == "N" || receipt == "n"){

                    Display();
                  }  



              
                   
                  }while(false);



            base.Amount();
        }


        public override void Amount2()
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
                  ATM_NI_NATS.Data.Balance -= 15;
                  ATM_NI_NATS.Data.Balance3 += kwarta;
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
                                                                                |     TRANSACTION FEE: PHP: 15                   |
                                                                                |                                                |                                                                            
                                                                                |        THANK YOU FOR USING OUR SERVICE!        |
                                                                                |                                                |
                                                                                |                                                |
                                                                                |________________________________________________|

                                                                         
                                                                                1.) G O  B A C K
                                                                          
                                                                                C H O I C E : 
                                                                          
                
              ");
                  Console.SetCursorPosition(patakilid - 81 , Console.CursorTop -3);
              string goback = Console.ReadLine();
              int convert;
              while(!int.TryParse(goback, out convert) || convert < 1 || convert > 1){
                           Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Input! ");
                  run.Speak("Invalid input!");
                  goto invalid;
                  
                   }


                      if(convert == 1) {

                        Console.Beep();
                        Display();
                      }
                   }
                    if(receipt == "N" || receipt == "n"){

                    Display();
                  }  



              
                   
                  }while(false);

          
            base.Amount2();
        }



        public override void Amount3()
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
                  ATM_NI_NATS.Data.Balance -= 15;
                  ATM_NI_NATS.Data.Balance4 += kwarta;
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
                                                                                |     TRANSACTION FEE: PHP: 15                   |
                                                                                |                                                |                                                                            
                                                                                |        THANK YOU FOR USING OUR SERVICE!        |
                                                                                |                                                |
                                                                                |                                                |
                                                                                |________________________________________________|

                                                                         
                                                                                1.) G O  B A C K
                                                                          
                                                                                C H O I C E : 
                                                                          
                
              ");
                  Console.SetCursorPosition(patakilid - 81 , Console.CursorTop -3);
              string goback = Console.ReadLine();
              int convert;
              while(!int.TryParse(goback, out convert) || convert < 1 || convert > 1){
                           Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Input! ");
                  run.Speak("Invalid input!");
                  goto invalid;
                  
                   }


                      if(convert == 1) {

                        Console.Beep();
                        Display();
                      }
                   }
                    if(receipt == "N" || receipt == "n"){

                    Display();
                  }  



              
                   
                  }while(false);
            base.Amount3();
        }


        public override void Amount4()
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
                  ATM_NI_NATS.Data.Balance -= 15;
                  ATM_NI_NATS.Data.Balance5 += kwarta;
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
                                                                                |     TRANSACTION FEE: PHP: 15                   |
                                                                                |                                                |                                                                            
                                                                                |        THANK YOU FOR USING OUR SERVICE!        |
                                                                                |                                                |
                                                                                |                                                |
                                                                                |________________________________________________|

                                                                         
                                                                                1.) G O  B A C K
                                                                          
                                                                                C H O I C E : 
                                                                          
                
              ");
                  Console.SetCursorPosition(patakilid - 81 , Console.CursorTop -3);
              string goback = Console.ReadLine();
              int convert;
              while(!int.TryParse(goback, out convert) || convert < 1 || convert > 1){
                           Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Input! ");
                  run.Speak("Invalid input!");
                  goto invalid;
                  
                   }


                      if(convert == 1) {

                        Console.Beep();
                        Display();
                      }
                   }
                    if(receipt == "N" || receipt == "n"){

                    Display();
                  }  



              
                   
                  }while(false);
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