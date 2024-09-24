Using System;

class Mat
{
    delegate int Op(int n1, int n2);

    public static int soma(int n1, int n2){
        return n1 + n2;
    }

    public static int dobro(int n){
        return n*2;
    }

    public static int mult(int n1, int n2){
        return (n1 * n2);
    }
}

class Delegates
{
    static void Main(string[] args){
        Op d1 = new Op(soma);
    }
}