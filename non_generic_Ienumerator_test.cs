using System.Collections;
using System;

public class Ints : IEnumerable
{

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator) GetEnumerator();
    }

    public IntEnum GetEnumerator()
    {
        return new IntEnum(null);
    }
}

public class IntEnum : IEnumerator
{
    public int[] _ints;

    // Enumerators are positioned before the first element
    // until the first MoveNext() call.
    int position = -1;

    public IntEnum(int[] list)
    {
        _ints = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < _ints.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public int Current
    {
        get
        {
            try
            {
                return _ints[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}

public sealed class Program
{

    public static void Main()
    {
        foreach (var item in new Ints()) {

        }
    }
}
