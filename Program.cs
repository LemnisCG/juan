// int largo = 15;
LineaHorizontal(100, 4, 2);
LineaHorizontal(100, 4, 10);
LineaHorizontal(50, 53, 25);
LineaHorizontal(100, 4, 41);


LineaVertical(40, 4, 2);
LineaVertical(40, 103, 2);
LineaVertical(32, 53, 10);

MaquinaDeEscribir("B i e n v e n i d o  a  B a n c o   J a v i  C o i n s".ToUpper(),28, 6,30);
MaquinaDeEscribir("M E N U", 25, 15,15);
MaquinaDeEscribir("1.Deposito ", 10, 19,15);
MaquinaDeEscribir("2.Retiro ", 10, 22,15);
MaquinaDeEscribir("3.Consultar Saldo ", 10, 25,15);
MaquinaDeEscribir("4.Mostrar informacion de la cuenta ", 10, 28,15);
MaquinaDeEscribir("5.Salir ", 10, 31,15);

MaquinaDeEscribir("CARGANDO", 73, 18, 15);
MaquinaDeEscribir("...", 81, 18, 200);
MaquinaDeEscribir("   ", 81, 18, 0);
MaquinaDeEscribir("...", 81, 18, 200);
MaquinaDeEscribir("   ", 81, 18, 0);
MaquinaDeEscribir("...", 81, 18, 200);
MaquinaDeEscribir("   ", 81, 18, 0);
MaquinaDeEscribir("...", 81, 18, 200);
MaquinaDeEscribir("   ", 81, 18, 0);
MaquinaDeEscribir("           ", 73, 18, 0);
MaquinaDeEscribir("DATOS DE LA CUENTA", 70, 12,15);
MaquinaDeEscribir("NOMBRE: Cristobal ", 60, 14,15);
MaquinaDeEscribir("APELLIDO: Storme", 60, 16,15);
MaquinaDeEscribir("RUT: 18.392.855 - 4", 60, 18,15);
MaquinaDeEscribir("DIRECCION: Parque Central 6868 ", 60, 20,15);
MaquinaDeEscribir("SALDO: $2000 ", 60, 22,15);

MaquinaDeEscribir("........................................",60,32,60);
MaquinaDeEscribir("                                        ",60,32,0);
MaquinaDeEscribir("             CARGANDO                   ",60,32,60);
MaquinaDeEscribir("                                        ",60,32,0);
MaquinaDeEscribir("........................................",60,32,60);
MaquinaDeEscribir("                                        ",60,32,0);


MaquinaDeEscribir("RESULTADO DE LA OPERACION ", 65, 27,15);
MaquinaDeEscribir("Se ha realizado con exito desposito :  ", 60, 29,15);
MaquinaDeEscribir("Se ha abonado : $30000  ", 60, 31,15);
MaquinaDeEscribir("Cuenta numero: " + Convert.ToString(NumeroAleatorio(1000000,9000000)), 60, 33,15);
MaquinaDeEscribir("Numero de Operacion: " + Convert.ToString(NumeroAleatorio(1000000, 9000000)), 60, 35,15);


void MaquinaDeEscribir(string texto, int x, int y, int velocidad)
{
    for (int i = 0; i < texto.Length; i++)
    {
        EscribirEn(Convert.ToString(texto[i]), x+i, y);
        Thread.Sleep(velocidad);
    }
    
}

int NumeroAleatorio(int a, int b)
{
    Random random = new Random();
    return random.Next(a, b+1);
}




Console.SetCursorPosition(0, 45);
void LineaHorizontal(int largo, int x , int y)
{
    for (int i = 0; i < largo; i++)
    {
        EscribirEn("*", i+x,y);

    }
}
void LineaVertical(int largo, int x, int y)
{
    for (int i = 0; i < largo; i++)
    {
        EscribirEn("*",x,i+y);
    }
}

void EscribirEn (string caracter, int x , int y)
{
    Console.SetCursorPosition(x,y);
    Console.Write(caracter);
}