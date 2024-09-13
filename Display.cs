using System.Speech.Synthesis;
using System.Threading.Channels;


namespace ATM_NI_NATS
{

  class ATM {
    string Invalid = "Invalid Input!";
    public void Display() {

        SpeechSynthesizer run = new SpeechSynthesizer();
        run.SelectVoiceByHints(VoiceGender.Female);
        run.Rate = 1;
      int DisplayNiya = Console.WindowWidth;
      int displayNiya = 60;
      int patakilid = (DisplayNiya - displayNiya);
      string choice;
      int input;

      do{

        Console.Clear();
        Console.ResetColor();
        Console.WriteLine("\n\n");
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.Write(@"
        
                                                                                _______________________________________________________________________
                                                                                |									|
                                                                                |									|
                                                                                |		   	░█▀▀█ ▀▀█▀▀ ▒█▀▄▀█ 				|
                                                                                |			▒█▄▄█ ░▒█░░ ▒█▒█▒█ 				|
                                                                                |			▒█░▒█ ░▒█░░ ▒█░░▒█				|
                                                                                |									|
                                                                                |									|
                                                                                |	___________________________________________			|
                                                                                |	|					  |			|
                                                                                |	|					  |			|
                                                                                |	|     C H O O S E  Y O U R  B A N K       |	 _________	|
                                                                                |	|_________________________________________|  	|	  |	|
                                                                                |	|					  |	|	  | 	|
                                                                                |	|					  |	|	  |	|
                                                                                |	|  1. Banco De Oro (BDO)		  |	|	  |	|
                                                                                |	|					  |	| _______ |	|
                                                                                |	|  2. Metro Bank			  |	|_________|	|
                                                                                |	|					  |			|
                                                                                |	|  3. Philippine National Bank (PNB)	  |			|
                                                                                |	|					  |      [1][2][3]	|
                                                                                |       |  4. Bank of the Philippines (BPI)	  |      [4][5][6]	|
                                                                                |	|					  |      [7][8][9]	|
                                                                                |	|  5. Land Bank of The Philippines 	  |      [ ][0][ ]	|
                                                                                |       |                                         |                     |
                                                                                |       |  6. Exit                                |                     |
                                                                                |	|					  |			|
                                                                                |	|  Choose Option: 			  |			|
                                                                                |	|					  |			|
                                                                                |	|					  |			|
                                                                                |	|					  |			|
                                                                                |	|_________________________________________|		   	|
                                                                                |									|
                                                                                |									|
                                                                                |									|
                                                                                | . ____________________________________________________________________|
                                                                                |									|
                                                                                |									|
                                                                                |	 __________________________________				|
                                                                                |	[				   ]				|
                                                                                |	|				   |				|
                                                                                |	[ _________________________________]				|
                                                                                |									|
                                                                                |____________________________________________________________________ . |
                                                                                |									|
                                                                                |								 	|
                                                                                |_______________________________________________________________________|
        ");


          Console.SetCursorPosition(patakilid -69, Console.CursorTop -20);
           choice = Console.ReadLine();

           while(!int.TryParse(choice, out input) || input < 1 || input > 6) {
        Console.ForegroundColor = ConsoleColor.Red;
        
        Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\tINVALID INPUT!");
        run.Speak("Invalid Input!");
        Display();
    

      }

      switch(input){


      case 1: Console.Clear(); Console.Beep(); BDO atm  = new BDO();  atm.Display(); break;
      case 2: Console.Clear(); Console.Beep(); MB atm1  = new MB();   atm1.Display(); break;
      case 3: Console.Clear(); Console.Beep(); PNB atm2 = new PNB();  atm2.Display();break;
      case 4: Console.Clear(); Console.Beep(); BPI atm3 = new BPI();  atm3.Oras(); break;
      case 5: Console.Clear(); Console.Beep(); LB atm4  = new LB();   atm4.Display(); break;
      case 6: Console.Clear(); Console.Beep(); 

      Console.WriteLine("\n\n");
      Console.Clear();
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write(@"
      
      
                                                                            ████████╗██╗░░██╗░█████╗░███╗░░██╗██╗░░██╗  ██╗░░░██╗░█████╗░██╗░░░██╗██╗
                                                                            ╚══██╔══╝██║░░██║██╔══██╗████╗░██║██║░██╔╝  ╚██╗░██╔╝██╔══██╗██║░░░██║██║
                                                                            ░░░██║░░░███████║███████║██╔██╗██║█████═╝░  ░╚████╔╝░██║░░██║██║░░░██║██║
                                                                            ░░░██║░░░██╔══██║██╔══██║██║╚████║██╔═██╗░  ░░╚██╔╝░░██║░░██║██║░░░██║╚═╝
                                                                            ░░░██║░░░██║░░██║██║░░██║██║░╚███║██║░╚██╗  ░░░██║░░░╚█████╔╝╚██████╔╝██╗
                                                                            ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝  ░░░╚═╝░░░░╚════╝░░╚═════╝░╚═╝

      
      ");
      run.Speak("Thank you!");
      Console.ResetColor();
      Thread.Sleep(1000);
      Console.Write("\n");
      Console.ForegroundColor = ConsoleColor.Red;
      
Console.Write(@"
                                                                                              █▀▀ █▀█ █▀█ █▀▄   █▄▄ █▄█ █▀▀   ▀ ▀▄
                                                                                              █▄█ █▄█ █▄█ █▄▀   █▄█ ░█░ ██▄   ▄ ▄▀
");
run.Speak("Good bye!");
Thread.Sleep(1000);
Console.Beep();
Console.Clear();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("\n\n");
Console.Write(@"



                                                                          ████████╗███████╗██████╗░███╗░░░███╗██╗███╗░░██╗░█████╗░████████╗███████╗██████╗░██╗
                                                                          ╚══██╔══╝██╔════╝██╔══██╗████╗░████║██║████╗░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██║
                                                                          ░░░██║░░░█████╗░░██████╔╝██╔████╔██║██║██╔██╗██║███████║░░░██║░░░█████╗░░██║░░██║██║
                                                                          ░░░██║░░░██╔══╝░░██╔══██╗██║╚██╔╝██║██║██║╚████║██╔══██║░░░██║░░░██╔══╝░░██║░░██║╚═╝
                                                                          ░░░██║░░░███████╗██║░░██║██║░╚═╝░██║██║██║░╚███║██║░░██║░░░██║░░░███████╗██████╔╝██╗
                                                                          ░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═════╝░╚═╝


");

Environment.Exit(0);

break;

      }




      }while(false);
    }


      public void Display1(){
    Console.Clear();
    Thread.Sleep(1000);
    Console.Beep();


                                    Console.Write(@"






                                                                                                I N S E R T I N G   C A R D  ▄             
                                    
                                    
                                    
                                    ");
  Thread.Sleep(1000);
  Display2();
    } 

    public void Display2(){

Console.Clear();


                                            Console.Write(@"






                                                                                                I N S E R T I N G   C A R D  ▄  ▄           
                                                                                            
                                    
                                    
                                    ");
  Thread.Sleep(1000);
  Display3();

    }


    public void Display3(){

Console.Clear();


                                         Console.Write(@"






                                                                                                I N S E R T I N G   C A R D  ▄  ▄  ▄           
                                    
                                    
                                    
                                    ");
  Thread.Sleep(1000);
  Display();

    }
  }
}