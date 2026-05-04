using Practice._3;

Console.OutputEncoding = System.Text.Encoding.UTF8;

BankCard card1 = new BankCard("1234-5678", "Дарія", 5000);
Console.WriteLine(card1);

BankCard card2 = new BankCard("1111-2222", "Дмитро");
Console.WriteLine(card2);

Console.WriteLine($"Кількість карток: {BankCard.GetCount()}");

card1.SetLimit(8000);
Console.WriteLine($"Новий ліміт: {card1.Limit}");

card1.SetLimit(-100);

Console.WriteLine($"Операція 3000 грн дозволена? {card1.IsOperationAllowed(3000)}");
Console.WriteLine($"Операція 10000 грн дозволена? {card1.IsOperationAllowed(10000)}");