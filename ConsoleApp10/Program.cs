Console.WriteLine("¿Hotel de tres estrellas o cinco estrellas?:");
string hotel = Console.ReadLine();

Console.WriteLine("¿Cuántos días desea quedarse?:");
int dias = int.Parse(Console.ReadLine());

switch (hotel)
{
    case "tres estrellas":
    case "3":
        switch (dias)
        {
            case <= 5:
                double precio = dias * 100 + dias * 7;
                Console.WriteLine("El precio, incluyendo el desayuno, de su estadía en el hotel es de " + precio + " soles");
                break;
            case <= 10:
                precio = dias * 85 + dias * 7;
                Console.WriteLine("El precio, incluyendo el desayuno, de su estadía en el hotel es de " + precio + " soles");
                break;
            case >= 11:
                precio = dias * 70 + dias * 7;
                Console.WriteLine("El precio, incluyendo el desayuno, de su estadía en el hotel es de " + precio + " soles");
                break;
        }
        break;
    case "cinco estrellas":
    case "5":
        switch (dias)
        {
            case <= 5:
                double precio = dias * 300 + dias * 7;
                Console.WriteLine("El precio, incluyendo el desayuno, de su estadía en el hotel es de " + precio + " soles");
                break;
            case <= 10:
                precio = dias * 270 + dias * 7;
                Console.WriteLine("El precio, incluyendo el desayuno, de su estadía en el hotel es de " + precio + " soles");
                break;
            case >= 11:
                precio = dias * 250 + dias * 7;
                Console.WriteLine("El precio, incluyendo el desayuno, de su estadía en el hotel es de " + precio + " soles");
                break;
        }
        break;
}
