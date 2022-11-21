
using MyApplication;

public class PolaFigurTests
{


    [Theory]
    [InlineData(2, 4)]
    [InlineData(4, 16)]
    [InlineData(5, 25)]
    [InlineData(3, 9)]
    public void PoleKWadratu(double value1, double expected)
    {
        SquareArea u = new SquareArea();

        var result = SquareArea.SquareA(value1);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(2, 8)]
    [InlineData(4, 16)]
    [InlineData(3, 12)]
    [InlineData(1, 4)]
    public void ObwodKwadratu(double v1, double expected)
    {
        SquareArea uu = new SquareArea();

        var result = SquareArea.SquareP(v1);
        Assert.Equal(expected, result);
    }

    [Theory] 
    [InlineData(2, 8, 16)]
    [InlineData(4, 5, 20)]
    [InlineData(2, 1, 2)]
    [InlineData(1, 4, 4)]
    public void PoleProstokata(double v1, double v2, double expected)
    {
        Recttangle aa = new Recttangle();

        var result = Recttangle.recArea(v1, v2);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 8, 20)]
    [InlineData(4, 2, 12)]
    [InlineData(3, 2, 10)]
    [InlineData(15, 20, 69)] //70
    public void ObwodProstokatu(double v1, double v2, double expected)
    {
        Recttangle c = new Recttangle();

        var result = Recttangle.rePem(v1, v2);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 8, 8)]
    [InlineData(4, 2, 4)]
    [InlineData(3, 2, 3)]
    [InlineData(15, 20, 150)]
    public void PoleRombu(double v1, double v2, double expected)
    {
        Rhombus o = new Rhombus();

        var result = Rhombus.RhoArea(v1, v2);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 8)]
    [InlineData(4, 16)]
    [InlineData(3, 11)]//12
    [InlineData(5, 20)]
    public void ObwodRombu(double v1, double expected)
    {
        Rhombus a = new Rhombus();

        var result = Rhombus.rhomPer(v1);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 8, 2, 10)]
    [InlineData(4, 16, 2, 20)]
    [InlineData(3, 11, 6, 42)]
    [InlineData(5, 20, 1, 12.5)]
    public void PoleTrapezu(double v1, double v2, double h, double expected)
    {
        Trapeze t = new Trapeze();
        var result = Trapeze.TrAr(v1, v2, h);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 8, 2, 10, 22)]
    [InlineData(4, 16, 2, 20, 42)]
    [InlineData(3, 11, 6, 13, 33)]
    [InlineData(5, 20, 1, 14, 40)]
    public void ObwodTrapezu(double v1, double v2, double v3, double v4, double expected)
    {
        Trapeze r = new Trapeze();
        var result = Trapeze.TrPe(v1, v2, v3, v4);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 8, 8)]
    [InlineData(4, 16, 32)]
    [InlineData(3, 12, 18)]
    [InlineData(5, 20, 50)]
    public void PoleTrojkata(double v1, double h, double expected)
    {
        Triangle tr = new Triangle();

        var result = Triangle.TriAr(v1, h);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 8, 8, 18)]
    [InlineData(4, 16, 16, 36)]
    [InlineData(3, 12, 11, 26)]
    [InlineData(5, 20, 5, 30)]
    public void ObwodTrojkata(double v1, double v2, double v3, double expected)
    {
        Triangle tri = new Triangle();

        var result = Triangle.TriPer(v1, v2, v3);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 39.47841760435743)]
    [InlineData(4, 157.91367041742973)]
    [InlineData(3, 88.82643960980423)]
    [InlineData(5, 246.74011002723395)]
    public void poleKola(double r, double expected)
    {
        Circle cr = new Circle();
        var result = Circle.CirAr(r);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 12.566370614359172)]
    [InlineData(4, 25.132741228718345)]
    [InlineData(3, 18.84955592153876)]
    [InlineData(5, 31.41592653589793)]
    public void obwodKola(double r, double expected)
    {
        Circle cr = new Circle();
        var result = Circle.CirPer(r);
        Assert.Equal(expected, result);
    }
}
