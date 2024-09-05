// See https://aka.ms/new-console-template for more information

//string phrase = "Moses";
//Console.WriteLine(("               Hello,               \n    "+phrase+"!").Trim());
//Console.WriteLine(phrase.Replace("Mos","R"));
//Console.Write(phrase.Count());
//Console.Write(phrase);
//Console.WriteLine(" You're The Most Genius Genius I've Ever Met In My Genius Life :3 ");


//Task 1
string firstName = "Micah";
string favMovie = "The Matrix";
Console.WriteLine(("Hello, " +  firstName +"! Your favorite Movie is " + favMovie + ".").ToLower());
favMovie = favMovie.ToUpper();
Console.WriteLine("Does favMovie contains \"THE\"?");
Console.WriteLine(favMovie.Contains("THE"));
Console.WriteLine(favMovie.Replace('A', '@').Replace('E', '3'));

//Task 2
string quote = "To be, or not to be.";
quote = quote.Replace("o", " ").Replace("e"," ");
Console.WriteLine(quote);
for (int i = 0; i < quote.Count(); i++ )
{
    if (Char.IsUpper(quote, i))
    {
        char[] charArray = quote.ToCharArray();
        char c = quote[i];
        charArray[i] = c.ToString().ToLower().ToCharArray()[0];
        quote = new string(charArray);
    }
    else if (Char.IsLower(quote, i))
    {
        char[] charArray = quote.ToCharArray();
        char c = quote[i];
        charArray[i] = c.ToString().ToUpper().ToCharArray()[0];
        quote = new string(charArray);
    }
}

Console.WriteLine(quote);
//Task 3
Console.WriteLine("^..^      /" + "   " + "                                  .-.");
Console.WriteLine("/_/\\_____/" + "   " + "     (___________________________()6 `-,");
Console.WriteLine("   /\\   /\\" + "   " + "     (   ______________________   /''\"`");
Console.WriteLine("  /  \\ /  \\" + "   " + "     //\\\\                      //\\\\");
Console.WriteLine("           " + "   " + "     \"\" \"\"                     \"\" \"\"");