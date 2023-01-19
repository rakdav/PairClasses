using PairClasses;

Complex complex1 = new Complex(9, 3);
Complex complex2 = new Complex(4, -4);
Complex complex3= (Complex)complex1.Add(complex2);
Console.WriteLine(complex3.ToString());
Complex complex4 = (Complex)complex1.Sub(complex2);
Console.WriteLine(complex4.ToString());
Complex complex5 = (Complex)complex1.Mult(complex2);
Console.WriteLine(complex5.ToString());
Complex complex6 = (Complex)complex1.Div(complex2);
Console.WriteLine(complex6.ToString());
Console.WriteLine(complex1.Equ(complex2));
Complex complex7 = (Complex)complex1.Conj(); 
Console.WriteLine(complex7.ToString());