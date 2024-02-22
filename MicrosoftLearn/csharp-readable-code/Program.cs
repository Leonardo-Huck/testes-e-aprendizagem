/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/


/*
  O código a seguir cria cinco OrderIDs aleatórios
  para testar o processo de detecção de fraude. IDs do pedido
  consistem em uma letra de A a E e três
  digite o número. Ex. A123.
*/

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// Exemplos de como os espaçoes em branco são ignorados pelo compilador:

Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Exemplo 2:
string firstWord = "Hello"; string lastWord = "Example 2"; Console.WriteLine(firstWord + " " + lastWord + "!");