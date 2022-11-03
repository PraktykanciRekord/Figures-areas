
static void squareArea()
{
    int a;
    int pole;
    Console.WriteLine("Wprowadź długość boku ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Pole tego kwadratu to: ");
    pole = (a * 2);
    Console.WriteLine(pole);
}

static void rectangleArea()
{
    int b;
    int a;
    int pole;
    Console.WriteLine("Wprowadź długość boku a: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź długość boku b: ");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("pole tego prostokątu to: ");
    pole = (a + b);
    Console.WriteLine(pole);
}

static void triangleArea()
{
    int a;
    int h;
    int pole;

    Console.WriteLine("Wprowadź długość odcinka a ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Wprowadź długość wysokości h ");
    h = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("pole tego trójkąta to: ");
    pole = ((a * h) / 2);
    Console.WriteLine(pole);
}

static void circleArea()
{
    float r;
    double pole;

    Console.WriteLine("Wprowadź długość promienia r ");
    r = float.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("pole tego koła to: ");
    pole = (Math.Pow((Math.PI * r), 2));
    Console.WriteLine(pole);
}

static void trapezeArea()
{
    int a;
    int b;
    int h;
    int pole;

    Console.WriteLine("Wprowadź długość boku a ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Wprowadź długość boku b ");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Wprowadź długość wysokości h ");
    h = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("pole tego trapecu to: ");
    pole = ((a + b) * h / 2);
    Console.WriteLine(pole);
}

static void rhombusArea()
{
    int e;
    int f;
    int pole;

    Console.WriteLine("Wprowadź długość przeciwległej e ");
    e = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Wprowadź długość przeciwległej f ");
    f = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("pole tego rombu to: ");
    pole = (e * f / 2);
    Console.WriteLine(pole);
}

squareArea();
//rectangleArea();
//triangleArea();
//circleArea();
//trapezeArea();
//rhombusArea();

