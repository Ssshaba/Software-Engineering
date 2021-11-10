using System;
class HelloWorld {
  static void Main() {
    var n = Convert.ToInt32((Console.ReadLine()));
    var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
    int summa=0;
    for (int i = 1; i<n-1; i++) {
        if (array[i-1]%2==0 && array[i+1]%2==0) {
            summa+=1;
        }
    }
    Console.WriteLine(summa);
  }
}
