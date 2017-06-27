using System.Collections.Generic;
using System;

class Program
{

    static IEnumerable<int> fn()
    {
        yield return 1;
        yield return 2;
    }

    static void Main()
    {
        fn().GetEnumerator().MoveNext();
    }
}
