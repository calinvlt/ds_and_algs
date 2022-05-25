var h = new Heaps.Heap<int>();
h.Insert(3);
h.Insert(1);
h.Insert(2);
h.Insert(4);
h.Insert(9);
h.Insert(7);
h.Insert(8);
// System.Console.WriteLine(h.Delete());
// System.Console.WriteLine(h.Delete());
// System.Console.WriteLine(h.Delete());
// System.Console.WriteLine(h.Delete());
// System.Console.WriteLine(h.Delete());
// System.Console.WriteLine(h.Delete());
// System.Console.WriteLine(h.Delete());


static int PercentageLetter(string s, char letter)
{
  int letterCount = 0;
  foreach (var l in s.ToCharArray())
  {
    if (l == letter) letterCount++;
  }

  decimal result = (decimal)letterCount / (decimal)s.ToCharArray().Length;

  return (int)Math.Floor(result * 100);

}

PercentageLetter("foobar", 'o');



