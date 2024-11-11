//if (6>=3){
//Console.WriteLine("Hello, World!");  
//}

//Console.ReadLine();


// Console.WriteLine("skriv in ditt användarnamn och lösenord");


// string användarnamn = Console.ReadLine();
// string lösenord = Console.ReadLine();

// if (användarnamn != "kalleanka" && lösenord != "12345"){
//     Console.WriteLine("nej");
// }
// else{
//     Console.WriteLine("Välkommen");
// }
// Console.ReadLine();



// for (int i = 0; i<32 ; i++){
//   Console.WriteLine("Hello World");
// }

// Console.ReadLine();

// Console.WriteLine("Skriv in lösenordet");
// string lösenord = Console.ReadLine();

// while (lösenord != "lösenord"){
//   lösenord = Console.ReadLine();
// }

// for (int i = 0; i<5; i++){
//   Console.WriteLine("Skriv ett nummer");
//   string nummret = Console.ReadLine();
//   int siffra;
//   int.TryParse(nummret, out siffra);

//   if (siffra>=5){
//     Console.WriteLine("Större en fem");
//   }
// }


bool success = false;

while (!success){
  Console.WriteLine("skriv in något som kan konverteras till en string");

  string detduskriver = Console.ReadLine();
  int sddd;

  success = int.TryParse(detduskriver, out sddd);
}