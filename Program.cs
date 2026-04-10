using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//declaração de variáveis
int a, b, total;
//atribuição de valores
a = 20;
b = 10;
/*concatenação de valores a serem exibidos na tela calculo da operação sendo realizado entre parênteses*/
Console.WriteLine(a + " + " + b + "=" + (a + b));
//resultado do cálculo da operação sendo atribuído em uma variável
total = a - b;
Console.WriteLine(a + " - " + b + " = " + total);
Console.WriteLine(a + "*" + b + " = " + (a * b));
Console.WriteLine(a + "/" + b + " = " + (a / b));
Console.WriteLine(a + "%" + b + " = " + (a % b));
Console.ReadKey();//Ins