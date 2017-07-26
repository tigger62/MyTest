//MyDerived.cs
public class MyDerived:MyBase {
    // public string Meth1(){
        // return "MyDerived";
    // }    

    public static void Main(){
        MyDerived mD = new MyDerived();
        MyBase mB = (MyBase) mD;

        System.Console.WriteLine(mD.Meth1());
        System.Console.WriteLine(mB.Meth1());
    }
}