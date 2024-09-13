using System.Speech.Synthesis;

namespace ATM_NI_NATS{



  class BankTransferPNB:Polymerize_Me{
        private static Data user = new Data();
        public override void Display()  {


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


                    }while(false);


            base.Display();
        }

    }
}