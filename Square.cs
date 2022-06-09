// 正方形基类
public class Square: Shape {
    private double side;
    public Square(int _side) {
        side = _side;
    }
    public override double GetArea() {
        return side * side;
    }
}