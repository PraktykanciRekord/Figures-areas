﻿
using MyApplication;

public class PolaFigurTests
{
    [Fact]
    public void PolaObwodyFigurTests()
    {
        

        SquareArea sq = new SquareArea();
        Assert.Equal(4, SquareArea.SquareA(2));
        Assert.Equal(8, SquareArea.SquareP(2));

        Recttangle rc = new Recttangle();
        Assert.Equal(4, Recttangle.recArea(2, 2));
        Assert.Equal(8, Recttangle.rePem(2, 2));

        Rhombus rh = new Rhombus();
        Assert.Equal(12 ,Rhombus.RhoArea(4, 6));
        Assert.Equal(16, Rhombus.rhomPer(4));

        Trapeze tr = new Trapeze();
        Assert.Equal(28, Trapeze.TrAr(8, 6, 4));
        Assert.Equal(22, Trapeze.TrPe(8, 6, 4, 4));

        Triangle tria = new Triangle();
        Assert.Equal(12, Triangle.TriAr(4, 6));
        Assert.Equal(18, Triangle.TriPer(4, 6, 8));

        Circle cr = new Circle();
        Assert.Equal(157.91367041742973, Circle.CirAr(4));
        Assert.Equal(50.26548245743669, Circle.CirPer(8));
    }
}