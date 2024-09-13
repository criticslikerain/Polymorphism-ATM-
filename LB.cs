using System.Speech.Synthesis;
namespace ATM_NI_NATS{



  class LB :Polymerize_Me{

         private static Data user = new Data();
    
        public override void Display()
        {

          string lbpin;
      bool authenticated = false;
                   SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
    tries = 0;


do{
       Authenticate:
        Console.Clear();
        Console.ResetColor();
             Console.ForegroundColor = ConsoleColor.Green;
             if(user.Newpin5.Length >= 6){
       Console.Write(@"
       
       






                                                                                                       P L E A S E  E N T E R  P I N  T O  C O N T I N U E 
       
       
       
       
       ");         
                                       
         run.Speak("Enter Pin code");
         
        Console.SetCursorPosition(patakilid - 69, Console.CursorTop -3);
        lbpin = Tago2();
        
        if (lbpin == user.Newpin5)
        {
               Transaction();
        }
        else
        {
            tries++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");
            if (tries >= 3)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t Maximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                Display();
                
            }
        }
        }


        if(user.Newpin5.Length == 0){

            Authenticate2:
            Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@"
       
       

                                                                                           P L E A S E  E N T E R  P I N  T O  C O N T I N U E 
       
       
       
       
       ");                                         
               run.Speak("Enter Pin code");
       
        Console.SetCursorPosition(patakilid - 69, Console.CursorTop -3);
       lbpin = Tago2();

         if (lbpin == user.Pin5)
        {
          Transaction();
        }
        else
        {
            tries++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");

            if (tries >= 3)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t Maximum number of tries reached!");
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
                     

                        do{


                        Console.Clear();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write(@"
                        
                        
                        
                        
                                                                                            ＰＬＥＡＳＥ ＰＲＥＳＳ ＴＨＥ ＰＲＯＰＥＲ ＫＥＹ 
                                                                                          ＦＯＲ ＹＯＵＲ ＤＥＳＩＲＥＤ ＴＲＡＮＳＡＣＴＩＯＮ    
                        
                        
                        

                                                                1. A C C O U N T                                                    2. W I T H D R A W  C A S H                             
                                                                _________________________________                                   ____________________________





                                                                3. T R A N S F E R                                                  4. F A S T  C A S H 
                                                                __________________________________                                  ____________________________




                                                                5. C H A N G E  P I N                                               6. D E P O S I T
                                                                __________________________________                                  ____________________________




                                                                                                    7. R E T U R N  M E N U 
                                                                                                    ________________________ 





                                                                                                    E N T E R  C H O I C E : 

                        
                        
                        ");
                                        run.Speak("Enter choice of option");
                                      Console.SetCursorPosition(patakilid -51 , Console.CursorTop -4);
                                      choice = Console.ReadLine();

                                      while(!double.TryParse(choice, out input) || input < 1 || input > 7){

                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("\n\n\n\t\t\t\t\t\t\tInvalid Input!");
                                        run.Speak("Invalid input!");
                                        Transaction();
                                      }


                                      switch(input) {


                                        case 1: Console.Beep();  Balance(); break;
                                        case 2: Console.Beep();  Withdraw(); break;
                                        case 3: Console.Beep();  Display2() ; break;
                                        case 4: Console.Beep();  FastCash(); break;
                                        case 5: Console.Beep();  ChangePin(); break;
                                        case 6: Console.Beep();  Deposit(); break;
                                        case 7: Console.Beep();  ATM menu = new ATM(); menu.Display(); break;
                                      }





                        }while(false);
            return base.Transaction();
        }

        public override double Balance()
        {

              SpeechSynthesizer run = new SpeechSynthesizer();
                         run.SelectVoiceByHints(VoiceGender.Female);
                        run.Rate = 1;

            do{
                    Console.Clear();
                    Console.ResetColor();
                    Console.ForegroundColor= ConsoleColor.Green;
                           format = ATM_NI_NATS.Data.Balance5.ToString("F2");
                           format2 = ATM_NI_NATS.Data.Savings5.ToString("F2");
                    Console.Write($@"
                    
                    
                    
                                                                                                            
                                                                                            Y O U R  C U R R E N T  B A L A N C E : 

                                              
                                                                                                C u r r e n t  b a l a n c e
                                                                                                          {format}
                                                                                                    -----------------------


                                                                                                        S A V I N G S 
                                                                                                          {format2}
                                                                                                    -----------------------

                                                                                D O  Y O U  W A N T  A N O T H E R  T R A N S A C T I O N ?



                                                                                                                              1. Y E S                             
                                       
                                                                                                                              2. N O


                                                                                                            C H O I C E : 

                    
                    
                    

                    ");

                    Console.SetCursorPosition(patakilid - 54, Console.CursorTop - 6);
                    choice = Console.ReadLine();

                      while(!double.TryParse(choice, out input) || input < 1 || input > 2) {

          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\tInvalid Input!");
          run.Speak("invalid input!");
          Balance();


        }

        switch(input) {


          case 1: Console.Beep(); Thread.Sleep(1000); run.Speak("Please wait.."); Display(); break;
          case 2: Console.Beep(); Thread.Sleep(1000); run.Speak("Returning to menu..");  ATM menu = new ATM(); menu.Display(); break;
        }


            }while(false);
            return base.Balance();
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

               if(ATM_NI_NATS.Data.Balance5< amount) {
                  Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Insufficient amount to Withdraw!");
                    run.Speak("Insuficcient amount to withdraw!");
                    Withdraw();
                    Console.ResetColor();
              }


              if(ATM_NI_NATS.Data.Balance5 > amount){


                ATM_NI_NATS.Data.Balance5 -= amount;
                 string withdrawformat = amount.ToString("F2");
                  string withdrawformat1 = ATM_NI_NATS.Data.Balance5.ToString("F2");



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
                                                                    |                                                                             |
                                                                    |                                                                             |
                                                                    |                                                                             |                                                                 
                                                                    |                                                                             |
                                                                    |                          E N T E R  A M O U N T  T O                        |
                                                                    |                                                                             |
                                                                    |                               D E P O S I T :                               |
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
              run.Speak("Enter amount to deposit");
              choice = Console.ReadLine();
              

                  while(!double.TryParse(choice, out input) || input < 1 ){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Please enter a valid amount!");
                    run.Speak("Please enter a valid amount!");
                    Deposit();
                    Console.ResetColor();
                  }

                  ATM_NI_NATS.Data.Balance5  += input;

                  Console.Write("\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t");
                  yorno:
                  Console.Write("\n\n\t Do you want a receipt or not? (Y or N): ");
                  input2 = Console.ReadLine();

                  if(input2 == "Y" || input2 == "y") {
                   format1 = input.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance5.ToString("F2");
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


        public override string ChangePin()
        {
              do{
           SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
    
    
            
            string newpin;
            string confirmpin;

              Thread.Sleep(1000);

             if(user.Newpin5.Length >= 1){


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
                                                                    |   W E  H E L P           |                                                             |
                                                                    |                          |                                                             |
                                                                    |      Y O U  G RO W       |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |            P I N:                                           |
                                                                    |                          |                                                             |
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

          
        if(newpin == user.Newpin5){

             Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\tPin cannot be the same from previous pin!");
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
                                                                    |  W E  H E L P            |                                                             |
                                                                    |                          |                                                             |
                                                                    |      Y O U  G R O W      |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |            P I N:                                           |
                                                                    |                          |                                                             |
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
                user.Newpin5 =  newpin;
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

         if(user.Newpin5.Length == 0){       

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
                                                                    |   W E  H E L P           |                                                             |
                                                                    |                          |                                                             |
                                                                    |      Y O U  G RO W       |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |            P I N:                                           |
                                                                    |                          |                                                             |
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

        
        if(newpin == user.Pin5){

             Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tPin cannot be the same from previous pin!");
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
                                                                    |  W E  H E L P            |                                                             |
                                                                    |                          |                                                             |
                                                                    |      Y O U  G R O W      |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |                                                             |
                                                                    |                          |            P I N:                                           |
                                                                    |                          |                                                             |
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
                user.Newpin5 =  newpin;
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

            return user.Newpin5;
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
                                                                |      ▀█    |   █▄▄ █▀█ █    |                              █░█   | █▀█ █▄░█ █▄▄ |         |
                                                                |       ▄█ ▄ |   █▄█ █▀▀ █    |                              ▀▀█ ▄ | █▀▀ █░▀█ █▄█ |         |
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
                                                                         _____________________________________________________________________________
                                                                        |                                                                             |             
                                                                        |                                                                             |           
                                                                        |                                                                             |           
                                                                        |                                  F A S T                                    |            
                                                                        |                                                                             |          
                                                                        |                                  C A S H !                                  |           
                                                                        |                                                                             |            
                                                                        |                                                                             |        
                                                                        |         1.) PHP. 100                               2.) PHP. 300             |          
                                                                        |                                                                             |            
                                                                        |                                                                             |            
                                                                        |                                                                             |                                         
                                                                        |         3.) PHP. 500                              4.) PHP. 1000             |        
                                                                        |                                                                             |           
                                                                        |                                                                             |            
                                                                        |                                                                             |
                                                                        |                      ENTER CHOICE:                                          |
                                                                        |                                                                             |
                                                                        |                                                                             |
                                                                        |                                                                             |
                                                                        |                                                                             |
                                                                        |                                                                             |
                                                                        |                                                                             |
                                                                        |                                                                             |
                                                                        |_____________________________________________________________________________|
        ");
        Console.SetCursorPosition(patakilid - 66 , Console.CursorTop - 9);
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

    if (ATM_NI_NATS.Data.Balance5 < amount)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\tInsufficient balance!");
        run.Speak("Insufficient balance!");
        return base.FastCash1();
    }

   
    ATM_NI_NATS.Data.Balance5 -= amount;

    while (true)
    {
        Console.Write("\n\t\t\t\t\t\t\t\t\t\t\t Do you want a receipt? (Y or N): ");
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
    string formatBalance = ATM_NI_NATS.Data.Balance5.ToString("F2");

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


                if(ATM_NI_NATS.Data.Balance5< kwarta){

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


                  ATM_NI_NATS.Data.Balance5-= kwarta;
                  ATM_NI_NATS.Data.Balance5 -= 15;
                  ATM_NI_NATS.Data.Balance += kwarta;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tDo you want a receipt or not? (Y or N): ");


                  string receipt = Console.ReadLine();
                   if(receipt == "Y" || receipt == "y") {
                  format1 = kwarta.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance5.ToString("F2");
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


                if(ATM_NI_NATS.Data.Balance5< kwarta){

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


                  ATM_NI_NATS.Data.Balance5-= kwarta;
                  ATM_NI_NATS.Data.Balance5 -= 15;
                  ATM_NI_NATS.Data.Balance2 += kwarta;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tDo you want a receipt or not? (Y or N): ");


                  string receipt = Console.ReadLine();
                   if(receipt == "Y" || receipt == "y") {
                  format1 = kwarta.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance5.ToString("F2");
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


                if(ATM_NI_NATS.Data.Balance5< kwarta){

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


                  ATM_NI_NATS.Data.Balance5-= kwarta;
                  ATM_NI_NATS.Data.Balance5 -= 15;
                  ATM_NI_NATS.Data.Balance4 += kwarta;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tDo you want a receipt or not? (Y or N): ");


                  string receipt = Console.ReadLine();
                   if(receipt == "Y" || receipt == "y") {
                  format1 = kwarta.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance5.ToString("F2");
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


                if(ATM_NI_NATS.Data.Balance5< kwarta){

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


                  ATM_NI_NATS.Data.Balance5-= kwarta;
                  ATM_NI_NATS.Data.Balance5 -= 15;
                  ATM_NI_NATS.Data.Balance3 += kwarta;
                  Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t\tDo you want a receipt or not? (Y or N): ");


                  string receipt = Console.ReadLine();
                   if(receipt == "Y" || receipt == "y") {
                  format1 = kwarta.ToString("F2");
                   format2 = ATM_NI_NATS.Data.Balance5.ToString("F2");
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
            Console.Write("x ");
            pin += keyInfo.KeyChar;
        }
    } while (keyInfo.Key != ConsoleKey.Enter);

    Console.WriteLine();

            return pin;
        }
  }
}