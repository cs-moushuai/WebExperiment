using System;
public class Caculator {
    private double[] arr;
    private int len;
    public Caculator() {
        arr = new double[15];
        len = 15;
        for (int i=1; i<=15; i++) {
            arr[i-1] = i;
        }
    }
    public Caculator(double[] _arr, int n) {
        arr = _arr;
        len = n;
    }
    public double GetMax() {
        if (len == 0) {
            Console.Error.WriteLine("长度为0，无最大值");
            return -1;
        }
        double maxx = arr[0];
        for (int i=1; i<len; i++) {
            if (arr[i] > maxx) maxx = arr[i];
        }
        return maxx;
    }
    public double GetMin() {
        if (len == 0) {
            Console.Error.WriteLine("长度为0，无最小值");
            return -1;
        }
        double minn = arr[0];
        for (int i=1; i<len; i++) {
            if (arr[i] < minn) minn = arr[i];
        }
        return minn;
    }
    public double GetAverage() {
        if (len == 0) {
            Console.Error.WriteLine("长度为0，无最平均值");
            return -1;
        }
        double sum = 0;
        for (int i=0; i<len; i++) {
            sum += arr[i];
        }
        return sum / len;
    }
}