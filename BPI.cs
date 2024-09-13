using System.Speech.Synthesis;


namespace ATM_NI_NATS{



  class BPI : Polymerize_Me{
   private static Data user = new Data();
 string greet = "";
            string greet2= "";


        public override string Oras()
        {


                  DateTime time = DateTime.Now;

 

              int currentHour = time.Hour;

        if (currentHour >= 1 && currentHour < 12)
        {   
            greet = "G O O D  M O R N I N G !";
            greet2= "goodmorning!";
            Display();
           

        }
        else if (currentHour >= 12 && currentHour < 17)
        {
            greet = "G O O D  A F T E R N O O N !";
            greet2= "good afternoon!";
            Display();

        }
        else if (currentHour >= 17 && currentHour < 24)
        {
           greet = "G O O D  E V E N I N G !";
           greet2= "good evening!";
           Display();
       
        }


            return base.Oras();
        }

        public override void Display()
        {
        

            bool authenticated = false;
          string bpipass;

                    SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
    tries = 0;





do{
        
        if(user.Newpin4.Length >= 6){
        Authenticate:
        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($@"

_______________________________________________________________________________________________________________

         █▄▄ █▀█ █
         █▄█ █▀▀ █                                     {greet}

_______________________________________________________________________________________________________________
        
        
        
         ____________________________________________
        |                                            |
        |                                            |
        |                                            |
        |            E N T E R  Y O U R              |
        |                                            |
        |                 P  I  N                    |
        |                                            |
        |                                            |
        |                                            |
        |                                            |
        |       _______________________________      |
        |      |                               |     |
        |      |_______________________________|     |
        |                                            |
        |                                            |
        |                                            |
        |____________________________________________|
        
        ");
           
     
           run.Speak($"{greet2},Enter Pin code");
         Console.SetCursorPosition(patakilid - 150, Console.CursorTop - 7);
        bpipass = Tago2();
  if (bpipass == user.Newpin4)
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


        if(user.Newpin4.Length == 0){

            Authenticate2:
            Console.Clear();
        Console.ResetColor();
       Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write($@"

_______________________________________________________________________________________________________________

         █▄▄ █▀█ █
         █▄█ █▀▀ █                                     {greet}

_______________________________________________________________________________________________________________
        
        
        
         ____________________________________________
        |                                            |
        |                                            |
        |                                            |
        |            E N T E R  Y O U R              |
        |                                            |
        |                 P  I  N                    |
        |                                            |
        |                                            |
        |                                            |
        |                                            |
        |       _______________________________      |
        |      |                               |     |
        |      |_______________________________|     |
        |                                            |
        |                                            |
        |                                            |
        |____________________________________________|
        
        ");
           run.Speak($"{greet2},Enter Pin code");
        Console.SetCursorPosition(patakilid - 150, Console.CursorTop - 7);
        bpipass =  Tago2();

         if (bpipass == user.Pin4)
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
    tries = 0;
  do{
         Console.Clear();
        Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write($@"

_______________________________________________________________________________________________________________

         █▄▄ █▀█ █
         █▄█ █▀▀ █                                     {greet}

_______________________________________________________________________________________________________________
        
        
        


      1. A C C O U N T                                                      2. P I N  S E R V I C E S





      3. W I T H D R A W                                                    4. F A S T  C A S H




                                        5. R E T U R N  M E N U 




                                         S E L E C T : 


______________________________________________________________________________________________________________











        
        ");
        run.Speak("Select a transaction");
        Console.SetCursorPosition(patakilid - 121, Console.CursorTop - 16);
        choice = Console.ReadLine();
        while(!double.TryParse(choice, out input) || input < 1 || input > 5 ) {

          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("\n\n\t\t\t\tInvalid input!");
          run.Speak("Invalid input");
          Transaction();
        }

        switch(input){


          case 1: Console.Beep(); Balance(); break;
          case 2: Console.Beep(); ChangePin(); break;
          case 3: Console.Beep(); Withdraw(); break;
          case 4: Console.Beep(); FastCash(); break;
          case 5: Console.Beep(); ATM menu = new ATM(); menu.Display(); break;
        }


  }while(false);
            return base.Transaction();
        }

        


        public override double Balance()
        {
              do{
                          SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
        format = ATM_NI_NATS.Data.Balance4.ToString("F2");
        format2 = ATM_NI_NATS.Data.Savings2.ToString("F2");
                Console.Clear();
                Console.ResetColor();
               Console.Write($@"

_______________________________________________________________________________________________________________

         █▄▄ █▀█ █
         █▄█ █▀▀ █                                     {greet}

_______________________________________________________________________________________________________________
        
        
        


                                        Y O U R  C U R R E N T  B A L A N C E : 


                                              C u r r e n t  b a l a n c e
                                                      {format}
                                                -----------------------


                                                Y O U R  S A V I NG S : 
                                                      {format2}                                      
                                                -----------------------

                                  D O  Y O U  W A N T  A N O T H E R  T R A N S A C T I O N ?



                                       1. Y E S                              2. N O



                                                     C H O I C E : 


______________________________________________________________________________________________________________


        
        ");
        Console.SetCursorPosition(patakilid - 108, Console.CursorTop - 7);
        choice = Console.ReadLine();
        while(!double.TryParse(choice, out input) || input < 1 || input > 2) {

          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("Invalid Input!");
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

        public override string ChangePin()
        {


               do{
           SpeechSynthesizer run = new SpeechSynthesizer();
    run.SelectVoiceByHints(VoiceGender.Female);
    run.Rate = 1;
    
    
            
            string newpin;
            string confirmpin;

              Thread.Sleep(1000);

             if(user.Newpin4.Length >= 1){


               Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
_______________________________________________________________________________________________________________

         █▄▄ █▀█ █
         █▄█ █▀▀ █                                     {greet}

_______________________________________________________________________________________________________________

 ______________________________________________________________________________
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |                                                                 
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |         E N T E R  P I N  C O D E  T O            |
|                          |                                                   |
|                          |              C H A N G E   P I N :                |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |           ___________________________             |
|                          |          | P I N:                    |            |
|                          |          |___________________________|            |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |                                                                                                                              
|__________________________|___________________________________________________|                                                  
            ");
               run.Speak("Enter New Pin");
        Console.SetCursorPosition(patakilid - 127, Console.CursorTop - 6);
        newpin = Tago2();

         if(newpin.Length <=5 || newpin.Length >=7){
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\tPin should only be 6 digits only!");
          run.Speak("Pin should only be six digits only!");
          ChangePin();
        }

          
        if(newpin == user.Newpin4){

             Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\tPin cannot be the same from previous pin!");
          run.Speak("Pin cannot be the same from previous pin!");
          ChangePin();

        }

                 

          sakto = true;
                Console.Clear();
                                    
                      Console.Write($@"
_______________________________________________________________________________________________________________

         █▄▄ █▀█ █
         █▄█ █▀▀ █                                     {greet}

_______________________________________________________________________________________________________________

 ______________________________________________________________________________
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |                                                                 
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |         E N T E R  C O N F I R M A T I O N        |
|                          |                                                   |
|                          |                       P I N :                     |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |           ___________________________             |
|                          |          | P I N:                    |            |
|                          |          |___________________________|            |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |                                                                                                                              
|__________________________|___________________________________________________|                                                  
            ");
               run.Speak("Enter New Pin");
            Console.SetCursorPosition(patakilid - 127, Console.CursorTop - 6);
            confirmpin = Tago2();

            if(newpin == confirmpin){
                Console.ForegroundColor = ConsoleColor.Green;
                user.Newpin4 =  newpin;
                Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\t\t Pin code Changed!");
                run.Speak("Pin Code Changed!, going back to menu");
               Display();
            }


            if(newpin != confirmpin){

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\t\t\tIncorrect Confirmation Pin!");
            run.Speak("Incorrect Confirmation Pin!");
            ChangePin();
            }

        


        else{

            tries++;   
             Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");
        

          if (tries >= 3)
            {
                Console.WriteLine("\n\t\t\t\t Maximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                Transaction();
                
            }

        }


         }

         if(user.Newpin4.Length == 0){       

        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($@"
_______________________________________________________________________________________________________________

         █▄▄ █▀█ █
         █▄█ █▀▀ █                                     {greet}

_______________________________________________________________________________________________________________

 ______________________________________________________________________________
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |                                                                 
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |         E N T E R  P I N  C O D E  T O            |
|                          |                                                   |
|                          |              C H A N G E   P I N :                |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |           ___________________________             |
|                          |          | P I N:                    |            |
|                          |          |___________________________|            |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |                                                                                                                              
|__________________________|___________________________________________________|                                                  
            ");
               run.Speak("Enter New Pin");
        Console.SetCursorPosition(patakilid - 127, Console.CursorTop - 6);
        newpin = Tago2();

        if(newpin.Length <=5 || newpin.Length >=7){
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\t\t\tPin should only be 6 digits only!");
          run.Speak("Pin should only be six digits only!");
          ChangePin();
        }

        
        if(newpin == user.Pin4){

             Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\n\n\n\t\t\tPin cannot be the same from previous pin!");
          run.Speak("Pin cannot be the same from previous pin!");
          ChangePin();

        }


        

          sakto = true;
          Console.Clear();

                      Console.Write($@"
_______________________________________________________________________________________________________________

         █▄▄ █▀█ █
         █▄█ █▀▀ █                                     {greet}

_______________________________________________________________________________________________________________

 ______________________________________________________________________________
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |                                                                 
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |         E N T E R  C O N F I R M A T I O N        |
|                          |                                                   |
|                          |                       P I N :                     |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |
|                          |           ___________________________             |
|                          |          | P I N:                    |            |
|                          |          |___________________________|            |
|                          |                                                   |
|                          |                                                   |
|                          |                                                   |                                                                                                                              
|__________________________|___________________________________________________|                                                  
            ");
            run.Speak("Enter Confirmation Pin: ");
            Console.SetCursorPosition(patakilid - 127, Console.CursorTop - 6);
            confirmpin = Tago2();

            if(newpin == confirmpin){
                Console.ForegroundColor = ConsoleColor.Green;
                user.Newpin4 =  newpin;
                Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t Pin code Changed!");
                
                run.Speak("Pin Code Changed!, going back to menu");
              Display();
            }


            if(newpin != confirmpin){

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\t\t\t Incorrect Confirmation Pin!");
            run.Speak("Incorrect Confirmation Pin!");
            ChangePin();
            }
          
        


        else{
            tries++;
             Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\tIncorrect Pin!");
            run.Speak("Incorrect Pin!");

        

          if (tries >= 3)
            {
                Console.WriteLine("\n\n\n\n\t\t\tMaximum number of tries reached!");
                run.Speak("Maximum number of tries reached, going to menu!");
                   Transaction();
             
            }

        }

         }





        

              }while(!sakto);      

            return user.Newpin4;
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

                                                       _______________________________________________________________________________________________________________

                                                                       █▄▄ █▀█ █
                                                                       █▄█ █▀▀ █                           {greet}

                                                       _______________________________________________________________________________________________________________

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

               if(ATM_NI_NATS.Data.Balance4< amount) {
                  Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.Write("Insufficient amount to Withdraw!");
                    run.Speak("Insuficcient amount to withdraw!");
                    Withdraw();
                    Console.ResetColor();
              }


              if(ATM_NI_NATS.Data.Balance4 > amount){


                ATM_NI_NATS.Data.Balance4 -= amount;
                 string withdrawformat = amount.ToString("F2");
                  string withdrawformat1 = ATM_NI_NATS.Data.Balance4.ToString("F2");



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
                                                       _______________________________________________________________________________________________________________

                                                                       █▄▄ █▀█ █
                                                                       █▄█ █▀▀ █                           {greet}

                                                       _______________________________________________________________________________________________________________

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

    if (ATM_NI_NATS.Data.Balance4 < amount)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\tInsufficient balance!");
        run.Speak("Insufficient balance!");
        return base.FastCash1();
    }

   
    ATM_NI_NATS.Data.Balance4 -= amount;

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
    string formatBalance = ATM_NI_NATS.Data.Balance4.ToString("F2");

    Console.Clear();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($@"

                                                       _______________________________________________________________________________________________________________

                                                                       █▄▄ █▀█ █
                                                                       █▄█ █▀▀ █                           {greet}

                                                       _______________________________________________________________________________________________________________

    
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
            Console.Write(". ");
            pin += keyInfo.KeyChar;
        }
    } while (keyInfo.Key != ConsoleKey.Enter);

    Console.WriteLine();

            return pin;
        }
    }
}