namespace ATM_NI_NATS{


  class Data{

    private string accnum;
    private string firstname;
    private string lastname;
      private string pin;
    private string pin2;
    private string pin3;
    private string pin4;
    private string pin5;
    private string newpin = "";
    private string newpin2 = "";
    private string newpin3 = "";
    private string newpin4 = "";
    private string newpin5 = "";
    private double balance = 5000.00;
    private double withdraw;




    public string Accnum
    {
      get {return accnum = "123456789012";}
      set {accnum = value;}

    }

    public string Firstname
    {
      get {return firstname = "Nathaniel";}
      set {firstname = value;}
    }

    public string Lastname
    {

      get {return lastname = "Inocando"; }
    }

    public string Pin
    {

      get {return pin = "123456";}
      set {pin = value;}
    }
    public string Pin2
    {

      get {return pin2 = "123456";}
      set {pin2 = value;}
    }

        public string Pin3
    {

      get {return pin3 = "123456";}
      set {pin3 = value;}
    }

       public string Pin4
    {

      get {return pin4 = "123456";}
      set {pin4 = value;}
    }

         public string Pin5
    {

      get {return pin5 = "123456";}
      set {pin5 = value;}
    }


  

public static double Balance {get; set;} = 5000.00;
public static double Balance2 {get; set;} = 5000.00;
public static double Balance3 {get; set;} = 5000.00;
public static double Balance4 {get; set;} = 5000.00;
public static double Balance5 {get; set;} = 5000.00;


public static double Savings {get; set;} = 3000.00;
public static double Savings2 {get; set;} = 3000.00;
public static double Savings3 {get; set;} = 3000.00;
public static double Savings4 {get; set;} = 3000.00;
public static double Savings5 {get; set;} = 3000.00;

    public double Withdraw
    {

      get {return withdraw;}
      set {withdraw = value;}

    }


    public string Newpin
    {

      get{return newpin;}
      set{newpin = value;}
    }

      public string Newpin2
    {

      get{return newpin2;}
      set{newpin2 = value;}
    }

      public string Newpin3
    {

      get{return newpin3;}
      set{newpin3 = value;}
    }

         public string Newpin4
    {

      get{return newpin4;}
      set{newpin4 = value;}
    }

             public string Newpin5
    {

      get{return newpin5;}
      set{newpin5 = value;}
    }





    


  }
}