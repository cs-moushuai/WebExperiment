// 圆形基类
public class Circle: Shape {
    private double radius;
    public Circle(double _radius) {
        radius = _radius;
    }
    public override double GetArea() {
        return Math.PI * radius * radius;
    }

}