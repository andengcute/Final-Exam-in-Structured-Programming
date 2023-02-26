using System;
using System.Collections.Generic;

namespace Balaba_FinalExam {

 class Program {
	static string search, input, answer;
	static List<string> listGTNumbers = new List<string>();
	static List<string> listSTNumbers = new List<string>();
	static List<string> listDNumbers = new List<string>();
	static List<string> listSNumbers = new List<string>();
	
  static void Main() {
      
    Console.WriteLine("\t\t=====SIM NETWORK IDENTIFIER=====");
    do{
    Console.WriteLine("\nEnter the first 4 number of your cellphone number: (ex. 0906*******)");
    search = Console.ReadLine();
    
    bool isExist = true;
    if (isExist){
        ShowGlobeTmNums();
        ShowSmartTntNums();
        ShowDitoNums();
        ShowSunNums();
        if (listGTNumbers.Contains(search)) {
            Console.WriteLine("\tEntered number " + search + " is Globe/TM.\n");
        }
        else if (listSTNumbers.Contains(search)) {
            Console.WriteLine("\tEntered number " + search + " is Smart/TNT.\n");
        }
        else if (listDNumbers.Contains(search)) {
            Console.WriteLine("\tEntered number " + search + " is DITO.\n");
        }
        else if (listSNumbers.Contains(search)) {
            Console.WriteLine("\tEntered number " + search + " is Sun.\n");
        }
        else {
            Console.WriteLine("\t" + search + " is invalid.");
            ShowMenu();
            input = GetUserInput();
            ShowOtherFeatures();
        }
        
     }
        Console.Write("Do you want to try another number? ");
	    answer = Console.ReadLine();
    }
	  while((answer == "n" || answer == "N" || answer == "no" || answer == "NO" || answer == "nO" || answer == "No") == false);
        
  }
  
  static string GetUserInput(){
      Console.Write("\nEnter your choice: ");
      string choice = Console.ReadLine();
      
      return choice;
      
  }
  
  static void ShowMenu() {
      Console.WriteLine("  -------------------------------------------------------------------");
      Console.WriteLine("\tEnter (1) to Add your number (if not belong)");
      Console.WriteLine("\tEnter (2) to Delete your number(if belong)");
      Console.WriteLine("\tEnter (x) after that type no to exit application. ");
      
  }
  
  static void ShowOtherFeatures(){ 
     string RemaddNum, addNum, delNum;
     if (input == "1"){
         Console.WriteLine("\n\t  Enter (1) to Add in Globe/TM");
         Console.WriteLine("\t  Enter (2) to Add in Smart/TNT");
         Console.WriteLine("\t  Enter (3) to Add in DITO");
         Console.WriteLine("\t  Enter (4) to Add in Sun");
         Console.WriteLine("\t  Enter (x) to Back");
         RemaddNum = GetUserInput();
       
            if (RemaddNum == "1"){
                Console.Write("\nEnter the number you want to add (ex. 0906*******): ");
                addNum = Console.ReadLine();
                listGTNumbers.Add(addNum);
                Console.WriteLine("\nSuccessfully added in Globe/TM!\n");
                
            }
            else if (RemaddNum == "2"){
                Console.Write("\nEnter the number you want to add (ex. 0906*******): ");
                addNum = Console.ReadLine();
                listSTNumbers.Add(addNum);
                Console.WriteLine("\nSuccessfully added in Smart/TNT!\an");
            }
            else if (RemaddNum == "3"){
                Console.Write("\nEnter the number you want to add (ex. 0906*******): ");
                addNum = Console.ReadLine();
                listDNumbers.Add(addNum);
                Console.WriteLine("\nSuccessfully added in DITO!\n");
            }
            else if (RemaddNum == "4"){
                Console.Write("\nEnter the number you want to add (ex. 0906*******): ");
                addNum = Console.ReadLine();
                listSNumbers.Add(addNum);
                Console.WriteLine("\nSuccessfully added in Sun!\n");
            }
            else {
                Console.WriteLine("");
                return;
            }
            
     }
     else if (input == "2"){
         Console.WriteLine("\n\t  Enter (1) to Delete in Globe/TM");
         Console.WriteLine("\t  Enter (2) to Delete in Smart/TNT");
         Console.WriteLine("\t  Enter (3) to Delete in DITO");
         Console.WriteLine("\t  Enter (4) to Delete in Sun");
         Console.WriteLine("\t  Enter (x) to Back");
         RemaddNum = GetUserInput();
       
            if (RemaddNum == "1"){
                Console.Write("\nEnter the number you want to remove: ");
                delNum = Console.ReadLine();
                listGTNumbers.Remove(delNum);
                Console.WriteLine("\nSuccessfully removed in Globe/TM!\n");
                
            }
            else if (RemaddNum == "2"){
                Console.Write("\nEnter the number you want to remove: ");
                delNum = Console.ReadLine();
                listSTNumbers.Remove(delNum);
                Console.WriteLine("\nSuccessfully removed in Smart/TNT!\n");
            }
            else if (RemaddNum == "3"){
                Console.Write("\nEnter the number you want to remove: ");
                delNum = Console.ReadLine();
                listDNumbers.Remove(delNum);
                Console.WriteLine("\nSuccessfully removed in DITO!\n");
            }
            else if (RemaddNum == "4"){
                Console.Write("\nEnter the number you want to remove: ");
                delNum = Console.ReadLine();
                listSNumbers.Remove(delNum);
                Console.WriteLine("\nSuccessfully removed in Sun!\n");
            }
            else {
                Console.WriteLine("");
                return;
            }
     }
     else {
         Console.WriteLine("");
         return;
     }
  }
  
  static void ShowGlobeTmNums(){
     listGTNumbers.Add("0917"); listGTNumbers.Add("0925"); listGTNumbers.Add("0817");
     listGTNumbers.Add("0905"); listGTNumbers.Add("0906"); listGTNumbers.Add("0915");
     listGTNumbers.Add("0916"); listGTNumbers.Add("0926"); listGTNumbers.Add("0927");
     listGTNumbers.Add("0935"); listGTNumbers.Add("0936"); listGTNumbers.Add("0937");
     listGTNumbers.Add("0945"); listGTNumbers.Add("0953"); listGTNumbers.Add("0954");
     listGTNumbers.Add("0955"); listGTNumbers.Add("0956"); listGTNumbers.Add("0965");
     listGTNumbers.Add("0966"); listGTNumbers.Add("0967"); listGTNumbers.Add("0975");
     listGTNumbers.Add("0976"); listGTNumbers.Add("0977"); listGTNumbers.Add("0978");
     listGTNumbers.Add("0979"); listGTNumbers.Add("0994"); listGTNumbers.Add("0995");
     listGTNumbers.Add("0996"); listGTNumbers.Add("0997");
    
  }
  
  static void ShowSmartTntNums(){
      listSTNumbers.Add("0907"); listSTNumbers.Add("0813"); listSTNumbers.Add("0908");
      listSTNumbers.Add("0909"); listSTNumbers.Add("0910"); listSTNumbers.Add("0911");
      listSTNumbers.Add("0912"); listSTNumbers.Add("0913"); listSTNumbers.Add("0914");
      listSTNumbers.Add("0918"); listSTNumbers.Add("0919"); listSTNumbers.Add("0920");
      listSTNumbers.Add("0921"); listSTNumbers.Add("0928"); listSTNumbers.Add("0929");
      listSTNumbers.Add("0930"); listSTNumbers.Add("0938"); listSTNumbers.Add("0939");
      listSTNumbers.Add("0946"); listSTNumbers.Add("0947"); listSTNumbers.Add("0948");
      listSTNumbers.Add("0949"); listSTNumbers.Add("0950"); listSTNumbers.Add("0951");
      listSTNumbers.Add("0961"); listSTNumbers.Add("0963"); listSTNumbers.Add("0968");
      listSTNumbers.Add("0970"); listSTNumbers.Add("0981"); listSTNumbers.Add("0989");
      listSTNumbers.Add("0998"); listSTNumbers.Add("0999");

  }
  
  static void ShowDitoNums(){
      listDNumbers.Add("0991"); listDNumbers.Add("0992"); listDNumbers.Add("0993");
      listDNumbers.Add("0994"); listDNumbers.Add("0895"); listDNumbers.Add("0896");
      listDNumbers.Add("0897"); listDNumbers.Add("0898");
      
  }
  
  static void ShowSunNums(){
      listSNumbers.Add("0922"); listSNumbers.Add("0923"); listSNumbers.Add("0924");
      listSNumbers.Add("0925"); listSNumbers.Add("0931"); listSNumbers.Add("0932");
      listSNumbers.Add("0933"); listSNumbers.Add("0934"); listSNumbers.Add("0940");
      listSNumbers.Add("0941"); listSNumbers.Add("0942"); listSNumbers.Add("0943");
      listSNumbers.Add("0944"); listSNumbers.Add("0973"); listSNumbers.Add("0974");
     
  }
  
 }
}

