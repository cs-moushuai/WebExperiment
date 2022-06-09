public class StackTp
{
    int maxSize=1000;
    int top=0;
    int[] stkList;
    public StackTp() {
        stkList = new int[maxSize];
    }
    public StackTp(int maxSize) {
        this.maxSize = maxSize;
        stkList = new int[maxSize];
    }
    public bool IsEmpty() {
        return top == 0;
    }
    public bool IsFull() {
        return top == maxSize;
    }
    public bool Push(int x) {
        if (IsFull()) {
            Console.Error.WriteLine("Can't push because stack is full");
            return false;
        }
        stkList[top++] = x;
        return true;
    }
    public int Pop() {
        if (IsEmpty()) {
            Console.Error.WriteLine("Can't pop because stack is empty");
            return 0;
        }
        return stkList[--top];
    }
    public int Top() {
        if (IsEmpty()) {
            Console.Error.WriteLine("The stack is empty");
            return 0;
        }
        return stkList[top-1];
    }
    
}