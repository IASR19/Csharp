using System;

class MainClass {
  public static void Main () {
    string   Nome, Idade, Altura;
           
            int idade;
            float altura;
           
            Console.Write("Qual é seu nome? ");
            Nome = Console.ReadLine();
           
            Console.Write("Qual é sua idade? ");
            Idade = Console.ReadLine();

            Console.Write("Qual é sua altura? ");
            Altura = Console.ReadLine();
           
            idade = Int32.Parse (Idade);
            altura = float.Parse(Altura);

            Console.WriteLine ("\nNome: " + Nome + '\n' + "Idade: " + idade + " anos \n" + "Altura: " + altura + "m");
  }
}
