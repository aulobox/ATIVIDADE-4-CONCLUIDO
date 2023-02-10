using System;

class Program {
  public static void Main (string[] args) {
    
String convert1, convert2;
    Double  SalarioPorhora, HorasTrabalhadas, HorasExtras, Salario;
    

Console.Write("Digite as horas trabalhadas do Funcionario : ");
   convert1 =Console.ReadLine();
  HorasTrabalhadas=Double.Parse(convert1);

    Console.Write("Digite o salario do Funcionario Hora do mesmo : ");
    convert2=Console.ReadLine();
   SalarioPorhora=Double.Parse(convert2);

    if ( HorasTrabalhadas > 160)
    {
      HorasExtras = SalarioPorhora * HorasTrabalhadas * 1.5;
      Console.Write("O salario Total no final do mês é : " + HorasExtras);
      }
    else
    {
      Salario = (HorasTrabalhadas * SalarioPorhora);
      Console.Write("O salario total é : " + Salario); 
      }
  }
}