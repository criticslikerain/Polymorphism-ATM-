using System.Speech.Synthesis;

namespace ATM_NI_NATS{



  class PNB : Polymerize_Me{


      private static Data user = new Data();

         public override void Display()
        {
            string madapaka;
                 SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
    tries = 0;

    
    bool authenticated = false;

    do
    {

        

        if(user.Newpin3.Length >= 6){
        Authenticate:
        Console.Clear();
        Console.ResetColor();
             Console.ForegroundColor = ConsoleColor.Black;
             Console.WriteLine($"{ATM_NI_NATS.Data.Balance3}");
               Console.Write($@"




                                                                                                                                                                
                                                                                                                                                            █▀█ █▄░█ █▄▄
                                                                                                                                                            █▀▀ █░▀█ █▄█



                                                                                                                                                              ___________
                                                                                             P l e a s e  P r o t e c t  y o u r  P i n                      |           |
                                                                                                      a s  y o u  k e y  i n.                                | [1][2][3] |       
                                                                                                                                                             | [4][5][6] | 
                                                                                                                                                             | [7][8][9] |     
                                                                                                _________________________________                            | [ ][0][ ] |   
                                                                                               |                                 |                           |___________| 
                                                                                               |                                 |                                (_)
                                                                                               |_________________________________|                                | | 
                                                                                                                                                                 _| |_ __
                                                                                                                                                                (()()()())
                                                                                                                                                                (        |
                                                                                                                                                                (        |
                                                                                                                                                                 \      /
                                                                                                                                                                  |     |                                         
            ");
               run.Speak("Enter Pin code");
        Console.SetCursorPosition(patakilid - 72, Console.CursorTop -9);
        madapaka = Tago2();

        if (madapaka == user.Newpin3)
        {
             authenticated = true;
               Transaction();
        }
        else
        {
            tries++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");
            if (tries >= 3)
            {
                Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t Maximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                ATM menu = new ATM();menu.Display();
                
            }
        }
        }


        if(user.Newpin3.Length == 0){

            Authenticate2:
            Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Black;
         Console.WriteLine($"{ATM_NI_NATS.Data.Balance3}");
            Console.Write($@"




                                                                                                                                                                
                                                                                                                                                            █▀█ █▄░█ █▄▄
                                                                                                                                                            █▀▀ █░▀█ █▄█



                                                                                                                                                              ___________
                                                                                             P l e a s e  P r o t e c t  y o u r  P i n                      |           |
                                                                                                      a s  y o u  k e y  i n.                                | [1][2][3] |       
                                                                                                                                                             | [4][5][6] | 
                                                                                                                                                             | [7][8][9] |     
                                                                                                _________________________________                            | [ ][0][ ] |   
                                                                                               |                                 |                           |___________| 
                                                                                               |                                 |                                (_)
                                                                                               |_________________________________|                                | | 
                                                                                                                                                                 _| |_ __
                                                                                                                                                                (()()()())
                                                                                                                                                                (        |
                                                                                                                                                                (        |
                                                                                                                                                                 \      /
                                                                                                                                                                  |     |                                         
            ");
               run.Speak("Enter Pin code");
        Console.SetCursorPosition(patakilid - 72, Console.CursorTop - 8);
        madapaka =  Tago2();

         if (madapaka == user.Pin3)
        {
             authenticated = true;
          Transaction();
        }
        else
        {
            tries++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");

            if (tries >= 3)
            {
                Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t Maximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                ATM menu = new ATM();menu.Display();
                
            }
        }
        }


    } while (!authenticated);


 

        }

        public override double Transaction()
        {

        
                          SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
    tries = 0;
    
    do{
             Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(@"
                                                                                                                    P L E A S E  P R E S S  T H E  P R O P E R  K E Y

                                                                                                                  F O R  Y O U R  D E S I R E D  T R A N S A C T I O N
            


                                                                                                1. A C C O U N T                                                   2. W I T H D R A W  C A S H

                                                                                                
                                                                                                
                                                                                                3. T R A N S F E R S                                               4. F A S T  C A S H


                                                                                                
                                                                                                5. C H A N G E  P I N                                              6. D E P O S I T  


                                                                                                                           7. R E T U R N  D I S P L A Y



                                                                                                                                C H O I C E : 
            
            ");
                   Console.SetCursorPosition(patakilid - 33, Console.CursorTop - 2);        
                   choice = Console.ReadLine();

                   while(!double.TryParse(choice, out input)|| input < 1 || input > 7) {

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write("\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t Invalid input!");
                    run.Speak("invalid input!");
                    Transaction(); 
                   }


                   switch(input) {

                    
                    case 1: Console.Beep(); Balance(); break;
                    case 2: Console.Beep(); Withdraw(); break;
                    case 3: Console.Beep(); Display2(); break;
                    case 4: Console.Beep(); FastCash(); break;
                    case 5: Console.Beep(); ChangePin(); break;
                    case 6: Console.Beep(); Deposit(); break;
                    case 7: Console.Beep(); ATM menu = new ATM(); menu.Display(); break;
                        
                   }                                                                                


             }while(false);

            return base.Transaction();
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

             if(user.Newpin3.Length >= 1){


               Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Black;
             Console.Write($@"
                                                                     ________________________________________________________________________________________
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |                                                                         
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                E N T E R  P I N  C O D E                    |
                                                                    |                          |                                                             |
                                                                    |                          |                  T O  C H A N G E  P I N :                  |
                                                                    |   E v e r y  S t e p     |                                                             |
                                                                    |                          |                                                             |
                                                                    |      T o g e t h e r!    |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |            P I N:                                           |
                                                                    |       P    N    B        |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |                                                                                                                              
                                                                    |__________________________|_____________________________________________________________|                                                  
            ");
               run.Speak("Enter New Pin");
        Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 7);
        newpin = Tago2();

         if(newpin.Length <=5 || newpin.Length >=7){
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tPin should only be 6 digits only!");
          run.Speak("Pin should only be six digits only!");
          ChangePin();
        }

          
        if(newpin == user.Newpin3){

             Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\tPin cannot be the same from previous pin!");
          run.Speak("Pin cannot be the same from previous pin!");
          ChangePin();

        }

                 

          sakto = true;
                Console.Clear();
                 Console.Write($@"
                                                                     ________________________________________________________________________________________
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |                                                                         
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |         E N T E R  C O N F I R M A T I O N                  |
                                                                    |                          |                                                             |
                                                                    |                          |                      P I N :                                |
                                                                    |   E v e r y  S t e p     |                                                             |
                                                                    |                          |                                                             |
                                                                    |      T o g e t h e r!    |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |            P I N:                                           |
                                                                    |       P    N    B        |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |                                                                                                                              
                                                                    |__________________________|_____________________________________________________________|                                                  
            ");
               run.Speak("Enter New Pin");
            Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 7);
            confirmpin = Tago2();

            if(newpin == confirmpin){
                Console.ForegroundColor = ConsoleColor.Green;
                user.Newpin3 =  newpin;
                Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tPin code Changed!");
                run.Speak("Pin Code Changed!, going back to menu");
                Display();
            }


            if(newpin != confirmpin){

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t Incorrect Confirmation Pin!");
            run.Speak("Incorrect Confirmation Pin!");
            ChangePin();
            }

        


        else{

            tries++;   
             Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");
        

          if (tries >= 3)
            {
                Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\t\t Maximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                Display();
                
            }

        }


         }

         if(user.Newpin3.Length == 0){       

        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($@"
                                                                     ________________________________________________________________________________________
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |                                                                         
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                E N T E R  P I N  C O D E                    |
                                                                    |                          |                                                             |
                                                                    |                          |                  T O  C H A N G E  P I N :                  |
                                                                    |   E v e r y  S t e p     |                                                             |
                                                                    |                          |                                                             |
                                                                    |      T o g e t h e r!    |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |            P I N:                                           |
                                                                    |       P    N    B        |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |                                                                                                                              
                                                                    |__________________________|_____________________________________________________________|                                                  
            ");
               run.Speak("Enter New Pin");
        Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 7);
        newpin = Tago2();

        if(newpin.Length <=5 || newpin.Length >=7){
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tPin should only be 6 digits only!");
          run.Speak("Pin should only be six digits only!");
          ChangePin();
        }

        
        if(newpin == user.Pin3){

             Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tPin cannot be the same from previous pin!");
          run.Speak("Pin cannot be the same from previous pin!");
          ChangePin();

        }


        

          sakto = true;
          Console.Clear();
                Console.Write($@"
                                                                     ________________________________________________________________________________________
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |                                                                         
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |         E N T E R  C O N F I R M A T I O N                  |
                                                                    |                          |                                                             |
                                                                    |                          |                      P I N :                                |
                                                                    |   E v e r y  S t e p     |                                                             |
                                                                    |                          |                                                             |
                                                                    |      T o g e t h e r!    |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |            P I N:                                           |
                                                                    |       P    N    B        |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |                                                                                                                              
                                                                    |__________________________|_____________________________________________________________|                                                  
            ");
            run.Speak("Enter Confirmation Pin: ");

            Console.SetCursorPosition(patakilid - 60, Console.CursorTop - 7);
            confirmpin = Tago2();

            if(newpin == confirmpin) {
                Console.ForegroundColor = ConsoleColor.Green;
                user.Newpin3 =  newpin;
                Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tPin code Changed!");
                
                run.Speak("Pin Code Changed!, going back to menu");
                Display();
            }


            if(newpin != confirmpin){

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t Incorrect Confirmation Pin!");
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
             
            }

        }

         }





        

              }while(!sakto);      

            return user.Newpin3;
        }


        public override double Deposit()
        {


                  SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);
          run.Rate = 1;
                do{
                  Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |             E N T E R  A M O U N T  T O           |
                                                                    |                          |                                                   |
                                                                    |                          |                  D E P O S I T.                   |
                                                                    |                          |                                                   |
                                                                    |                          |           I n s e r t  c a s h  b i l l s         |
                                                                    |                          |                                                   |
                                                                    |                          |                (100, 200, 500, 1000)              |
                                                                    |     E v e r y  S t e p   |                        O N L Y                    |
                                                                    |                          |                                                   |
                                                                    |       T o g e t h e r!   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |        P   N   B         |      ENTER BILL:                                  |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |__________________________|___________________________________________________|                                                  
            ");
                      Console.SetCursorPosition(patakilid - 61 , Console.CursorTop -5 );
              run.Speak("Enter amount to deposit");
              choice = Console.ReadLine();

                while(!double.TryParse(choice, out input) || input < 1 ){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Please enter a valid amount!");
                    run.Speak("Please enter a valid amount!");
                    Deposit();
                    Console.ResetColor();
                     
                  }

                        if(input != 100 && input != 200 && input != 500 && input != 1000){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Entered bills should only be 100,200,500,1000");
                    run.Speak("Please enter a valid amount!");
                    Deposit();
                    Console.ResetColor();
                  }


               


                     ATM_NI_NATS.Data.Balance3 += input;

                      Console.Write("\n\n\n\n\t\t\t\t\t\t\t\t");
                  yorno:
                  Console.Write(" Do you want a receipt or not? (Y or N): ");
                  input2 = Console.ReadLine();

                  if(input2 == "Y" || input2 == "y") {
                   format1 = input.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance3.ToString("F2");
                          receipt:
                          Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     _____________________________________________________________________________
                                                                    |                                                                             |             _________________________________________________
                                                                    |                                                                             |            |                                                 |
                                                                    |                                                                             |            |    NAME: {user.Firstname} {user.Lastname}                     |
                                                                    |                              R E C E I P T                                  |            |                                                 |
                                                                    |                                                                             |            |    DEPOSITED AMOUNT: PHP: {format1}                |
                                                                    |                             P R I N T E D !                                 |            |                                                 |
                                                                    |                                                                             |            |    UPDATED BALANCE:  PHP: {format2}               |
                                                                    |                                                                             |            |                                                 |
                                                                    |                                                                             |            |                                                 |
                                                                    |                                                                             |            |        THANK YOU FOR USING OUR SERVICE!         |
                                                                    |                                                                             |            |                                                 |
                                                                    |                              1. G O  B A C K                                |            |                                                 |
                                                                    |                                                                             |            |_________________________________________________|  
                                                                    |                                                                             |           
                                                                    |                                                                             |            
                                                                    |                                                                             |
                                                                    |                      ENTER CHOICE:                                          |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |_____________________________________________________________________________|                                                  
            ");

                     Console.SetCursorPosition(patakilid - 70 , Console.CursorTop -5);
                    choice = Console.ReadLine();
                     while(!double.TryParse(choice, out input) || input != 1){
              
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
              Console.Write("Invalid Input!");
              run.Speak("Invalid Input!");
              goto receipt;
           
            }


            if(input == 1) {

              Console.Beep();
             Transaction();
            }

                  }



                  if(input2 == "N" || input2 == "n"){

                    Transaction();
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
                double amount;
                
             SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);
          run.Rate = 1;

                   Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |                                                                 
                                                                    |                                                                             |
                                                                    |                          E N T E R  A M O U N T  T O                        |
                                                                    |                                                                             |
                                                                    |                               W I T H D R A W :                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                            ______________________                           |
                                                                    |                           | P H P:               |                          |
                                                                    |                           |______________________|                          |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |_____________________________________________________________________________|                                                  
            ");
            Console.SetCursorPosition(patakilid - 71 , Console.CursorTop -13 );
              run.Speak("Enter amount to withdraw");
              choice = Console.ReadLine();

             while(!double.TryParse(choice, out amount)|| amount < 1){
                      Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Please enter a valid amount!");
                    run.Speak("Please enter a valid amount!");
                    Withdraw();
                    Console.ResetColor();
                    choice = Console.ReadLine();


                  
              }

               if(ATM_NI_NATS.Data.Balance3< amount) {
                  Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Insufficient amount to Withdraw!");
                    run.Speak("Insuficcient amount to withdraw!");
                    Withdraw();
                    Console.ResetColor();
              }


              if(ATM_NI_NATS.Data.Balance3 > amount){


                ATM_NI_NATS.Data.Balance3 -= amount;
                 string withdrawformat = amount.ToString("F2");
                  string withdrawformat1 = ATM_NI_NATS.Data.Balance3.ToString("F2");



                Console.Write("\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t");
                balikresibo:
                 Console.Write(" Do you want a receipt or not? (Y or N): ");
                  Console.SetCursorPosition(patakilid - 38 , Console.CursorTop -0);
                  input2 = Console.ReadLine();




                 if(input2 == "Y" || input2 == "y") {

                        PrintReceipt(amount);

                 }


                 if(input2 == "n" || input2 == "N"){


                    Transaction();
                 }
                 else{

                      goto balikresibo;
                 }


              }






            return base.Withdraw();
        }




        public override double Balance() {
                   SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);
          run.Rate = 1;
              do{
            format = ATM_NI_NATS.Data.Balance3.ToString("F2");
            format2 = ATM_NI_NATS.Data.Savings3.ToString("F2");

                Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
                                                                     ______________________________________________________________________________
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |         Y O U R   B A L A N C E                   |
                                                                    |                          |                                                   |
                                                                    |                          |           I S: PHP: {format}                       |
                                                                    |                          |                -------------                      |
                                                                    |                          |                                                   |
                                                                    |                          |         Y O U R  S A V I N G S                    |
                                                                    |                          |                                                   |
                                                                    |                          |           I S: PHP: {format2}                       |
                                                                    |                          |                                                   |
                                                                    |     E v e r y  S t e p   |                                                   |
                                                                    |                          |         1. G O  B A C K                           |
                                                                    |       T o g e t h e r!   |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |                          |                                                   |
                                                                    |        P   N   B         |      ENTER CHOICE:                                |
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

            }

            if(input == 1) {
              Console.Beep();
              Transaction();
            }

               }while(false);

            return base.Balance();

             
          }


       public override double FastCash()
{
    SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;

    while (true)
    {
        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($@"
                                                                      
                                                                                                █▀▀ ▄▀█ █▀ ▀█▀   █▀▀ ▄▀█ █▀ █░█
                                                                                                █▀░ █▀█ ▄█ ░█░   █▄▄ █▀█ ▄█ █▀█          


                                                                                                                                                             
                                                                                   1.) PHP. 100                               2.) PHP. 300                       
                                                                                                                                                                 
                                                                                                                                                                 
                                                                                                                                                                                              
                                                                                   3.) PHP. 500                              4.) PHP. 1000                     
                                                                                                                                                                
                                                                                                                                                                
                                                                                                                                                     
                                                                                                     ENTER CHOICE:                                          
                                                                                                                                                     
                                                         
        ");
        Console.SetCursorPosition(patakilid - 61 , Console.CursorTop - 3);
        string fastcashInput = Console.ReadLine();

        if (int.TryParse(fastcashInput, out int choice) && choice >= 1 && choice <= 4)
        {
            switch (choice)
            {
                case 1:
                    return FastCashOption(100);
                case 2:
                    return FastCashOption(300);
                case 3:
                    return FastCashOption(500);
                case 4:
                    return FastCashOption(1000);
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\tInvalid choice, please try again.");
                    run.Speak("Invalid choice, please try again.");
                    break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\tInvalid input, please try again.");
            run.Speak("Invalid input, please try again.");
        }
    }
}




  private double FastCashOption(double amount)
{

    SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;

    if (ATM_NI_NATS.Data.Balance3 < amount)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\tInsufficient balance!");
        run.Speak("Insufficient balance!");
        return base.FastCash1();
    }

   
    ATM_NI_NATS.Data.Balance3 -= amount;

    while (true)
    {
        Console.Write("\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t Do you want a receipt? (Y or N): ");
        string receiptChoice = Console.ReadLine().Trim();

        if (receiptChoice.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            PrintReceipt(amount);
            break;
        }
        else if (receiptChoice.Equals("N", StringComparison.OrdinalIgnoreCase))
        {
            Transaction();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t Invalid input. Please enter 'Y' or 'N'.");
            run.Speak("Invalid input. Please enter 'Y' or 'N'.");
            FastCashOption(amount);
        }
    }

    return base.FastCash1();
}


public void PrintReceipt(double amount)
{   
     SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
    balik:
    string formattedamount = amount.ToString("F2");
    string formatBalance = ATM_NI_NATS.Data.Balance3.ToString("F2");

    Console.Clear();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($@"   
                                                                             _____________________________________________________________________________
                                                                            |                                                                             |             _________________________________________________
                                                                            |                                                                             |            |                                                 |
                                                                            |                                                                             |            |    NAME: {user.Firstname} {user.Lastname}                     |
                                                                            |                              R E C E I P T                                  |            |                                                 |
                                                                            |                                                                             |            |    WITHDRAWNED AMOUNT: PHP: {formattedamount}                 |
                                                                            |                             P R I N T E D !                                 |            |                                                 |
                                                                            |                                                                             |            |    UPDATED BALANCE:  PHP: {formatBalance}               |
                                                                            |                                                                             |            |                                                 |
                                                                            |                                                                             |            |                                                 |
                                                                            |                                                                             |            |        THANK YOU FOR USING OUR SERVICE!         |
                                                                            |                                                                             |            |                                                 |
                                                                            |                              1. G O  B A C K                                |            |                                                 |
                                                                            |                                                                             |            |_________________________________________________|
                                                                            |                                                                             |           
                                                                            |                                                                             |            
                                                                            |                                                                             |
                                                                            |                      ENTER CHOICE:                                          |
                                                                            |                                                                             |
                                                                            |                                                                             |
                                                                            |                                                                             |
                                                                            |                                                                             |
                                                                            |                                                                             |
                                                                            |_____________________________________________________________________________|
    ");

    Console.SetCursorPosition(patakilid - 63 , Console.CursorTop - 7);
    string printChoice = Console.ReadLine().Trim();

    if (printChoice == "1")
    {
        Console.Beep();
        Transaction();
    }

      else{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tInvalid Input!");
        run.Speak("invalid input");
        goto balik;
      }  
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
                                                                |       ▄█    |  █▄▄ █▀▄ █▀█  |                              ▀█    |   █▀▄▀█  █▄▄   |       |
                                                                |       ░█ ▄  |  █▄█ █▄▀ █▄█  |                              █▄ ▄  |   █░▀░█  █▄█   |       |
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


                if(ATM_NI_NATS.Data.Balance3< kwarta){

                    Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\t Not enough Balance for your Metro bank account");
                  run.Speak("Not enough Balance for your Metro Bank account"); 
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
                string accnum = Tago2();


                if(accnum != user.Accnum){
                     Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Account Number!");
                  run.Speak("Invalid Account Number!"); 
                  goto accnum;


                }


                  ATM_NI_NATS.Data.Balance3-= kwarta;
                  ATM_NI_NATS.Data.Balance3 -= 15;
                  ATM_NI_NATS.Data.Balance2 += kwarta;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tDo you want a receipt or not? (Y or N): ");


                  string receipt = Console.ReadLine();
                   if(receipt == "Y" || receipt == "y") {
                  format1 = kwarta.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance3.ToString("F2");
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
                        Transaction();
                      }
                   }
                    if(receipt == "N" || receipt == "n"){

                    Transaction();
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


                if(ATM_NI_NATS.Data.Balance3< kwarta){

                    Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\t Not enough Balance for your Metro bank account");
                  run.Speak("Not enough Balance for your Metro Bank account"); 
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
                string accnum = Tago2();


                if(accnum != user.Accnum){
                     Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Account Number!");
                  run.Speak("Invalid Account Number!"); 
                  goto accnum;


                }


                  ATM_NI_NATS.Data.Balance3-= kwarta;
                  ATM_NI_NATS.Data.Balance3 -= 15;
                  ATM_NI_NATS.Data.Balance2 += kwarta;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tDo you want a receipt or not? (Y or N): ");


                  string receipt = Console.ReadLine();
                   if(receipt == "Y" || receipt == "y") {
                  format1 = kwarta.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance3.ToString("F2");
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
                        Transaction();
                      }
                   }
                    if(receipt == "N" || receipt == "n"){

                    Transaction();
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


                if(ATM_NI_NATS.Data.Balance3< kwarta){

                    Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\t Not enough Balance for your Metro bank account");
                  run.Speak("Not enough Balance for your Metro Bank account"); 
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
                string accnum = Tago2();


                if(accnum != user.Accnum){
                     Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Account Number!");
                  run.Speak("Invalid Account Number!"); 
                  goto accnum;


                }


                  ATM_NI_NATS.Data.Balance3-= kwarta;
                  ATM_NI_NATS.Data.Balance3 -= 15;
                  ATM_NI_NATS.Data.Balance4 += kwarta;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tDo you want a receipt or not? (Y or N): ");


                  string receipt = Console.ReadLine();
                   if(receipt == "Y" || receipt == "y") {
                  format1 = kwarta.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance3.ToString("F2");
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
                        Transaction();
                      }
                   }
                    if(receipt == "N" || receipt == "n"){

                    Transaction();
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


                if(ATM_NI_NATS.Data.Balance3< kwarta){

                    Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\t Not enough Balance for your Metro bank account");
                  run.Speak("Not enough Balance for your Metro Bank account"); 
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
                string accnum = Tago2();


                if(accnum != user.Accnum){
                     Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Account Number!");
                  run.Speak("Invalid Account Number!"); 
                  goto accnum;


                }


                  ATM_NI_NATS.Data.Balance3-= kwarta;
                  ATM_NI_NATS.Data.Balance3 -= 15;
                  ATM_NI_NATS.Data.Balance5 += kwarta;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tDo you want a receipt or not? (Y or N): ");


                  string receipt = Console.ReadLine();
                   if(receipt == "Y" || receipt == "y") {
                  format1 = kwarta.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance3.ToString("F2");
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
                        Transaction();
                      }
                   }
                    if(receipt == "N" || receipt == "n"){

                    Transaction();
                  }  



              
                   
                  }while(false);
            base.Amount4();

        }








        public override string Tago2()
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
            Console.Write("x  ");
            pin += keyInfo.KeyChar;
        }
    } while (keyInfo.Key != ConsoleKey.Enter);

    Console.WriteLine();

            return pin;
        }
  }
}