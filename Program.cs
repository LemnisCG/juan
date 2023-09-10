// este son los numero de notas que tienen cada estudiantes
int numeroDeNotas = 5;
// Crear las notas de los estudiantes con matris
int[] juanScores = new int[] {100,90,40,80,100};
int[] luzScores = new int[] {100,90,90,80,100};
int[] aylenScores = new int[] {100,90,80,80,90};
int[] nancyScores = new int[] {100,90,100,100,100};

//crear nombre a los estudiantes con matris
string[] nombreEstudiantes = new string[] {"Juan","Luz","Aylen","Nancy"};
//Recorrer los nombre uno por uno
foreach (string recorrerNombre in nombreEstudiantes)
{
    if (recorrerNombre == "Juan")
    {
        //SUMAR LAS NOTAS DEL ESTUDIANTES JUAN y dividirlos para sacar el promedio
        int sum = 0;
        decimal juanScore;

        foreach (int sumarNotas in juanScores)
        {   
            sum += sumarNotas;
        }

        juanScore = (decimal)sum / (decimal)numeroDeNotas;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine($"{recorrerNombre}:\t\t" + juanScore + "\tA-");

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
        if (recorrerNombre == "Nancy")
    {
        //SUMAR LAS NOTAS DEL ESTUDIANTES JUAN y dividirlos para sacar el promedio
        int sum = 0;
        decimal nancyScore;

        foreach (int sumarNotas in nancyScores)
        {   
            sum += sumarNotas;
        }

        nancyScore = (decimal)sum / (decimal)numeroDeNotas;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine($"{recorrerNombre}:\t\t" + nancyScore + "\tA-");

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
        if (recorrerNombre == "Luz")
    {
        //SUMAR LAS NOTAS DEL ESTUDIANTES JUAN y dividirlos para sacar el promedio
        int sum = 0;
        decimal luzScore;

        foreach (int sumarNotas in luzScores)
        {   
            sum += sumarNotas;
        }

        luzScore = (decimal)sum / (decimal)numeroDeNotas;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine($"{recorrerNombre}:\t\t" + luzScore + "\tA-");

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
        if (recorrerNombre == "Aylen")
    {
        //SUMAR LAS NOTAS DEL ESTUDIANTES JUAN y dividirlos para sacar el promedio
        int sum = 0;
        decimal aylenScore;

        foreach (int sumarNotas in aylenScores)
        {   
            sum += sumarNotas;
        }

        aylenScore = (decimal)sum / (decimal)numeroDeNotas;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine($"{recorrerNombre}:\t\t" + aylenScore + "\tA-");

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}







