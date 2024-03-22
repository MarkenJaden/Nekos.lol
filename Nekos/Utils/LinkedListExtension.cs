namespace Nekos.Utils;

public static class LinkedListExtension
{
    public static int FindIndex<T>(this LinkedList<T> list, Predicate<T> match)
    {
        var index = 0;
        for (var node = list.First; node != null; node = node.Next, index++)
        {
            if (match(node.Value))
            {
                return index;
            }
        }
        return -1;  // not found
    }
}