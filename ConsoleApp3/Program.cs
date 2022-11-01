string?[,] docentes = new string[2, 4];

for (int i = 0; i < docentes.GetLength(0); i++)
{
    Console.WriteLine("\nDocente {0}: \n", i + 1);

    Console.WriteLine("Nombre del docente: ");
    docentes[i, 0] = "Nombre: " + Console.ReadLine();

    Console.WriteLine("Direccion del docente: ");
    docentes[i, 1] = "Direccion: " + Console.ReadLine();

    Console.WriteLine("Cantidad de hijos: ");
    if (int.TryParse(Console.ReadLine(), out int hijos))
    {
        docentes[i, 3] = "Salario: ";
        switch (hijos)
        {
            case 0:
                {
                    docentes[i, 3] += "12825";
                    break;
                }
            case 1:
                {
                    docentes[i, 3] += (12825 + (12825 / 100 * 8)).ToString();
                    break;
                }
            case 2:
                {
                    docentes[i, 3] += (12825 + (12825 / 100 * 8) + (12825 / 100 * 5)).ToString();
                    break;
                }
            case 3:
                {
                    docentes[i, 3] += (12825 + (12825 / 100 * 8) + (12825 / 100 * 5) + (12825 / 100 * 2)).ToString();
                    break;
                }
            default:
                {
                    docentes[i, 3] += (12825 + (12825 / 100 * 8) + (12825 / 100 * 5) + (12825 / 100 * 2)).ToString();
                    break;
                }
        }
        docentes[i, 2] = "Hijos: " + hijos;
    }
}
for (int i = 0; i < docentes.GetLength(0); i++)
{
    Console.WriteLine("\n Docente {0}:\n", (i + 1));
    for (int j = 0; j < docentes.GetLength(1); j++)
    {
        Console.WriteLine(docentes[i, j]);
    }
}

Console.ReadKey();