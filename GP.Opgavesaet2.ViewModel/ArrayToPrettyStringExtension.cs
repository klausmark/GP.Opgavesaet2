namespace GP.Opgavesaet2.ViewModel
{
    public static class ArrayToPrettyStringExtension
    {
        public static string ToPrettyString<T>(this T[] array)
        {
            var s = $"{typeof(T).Name}[{array.Length}] {{ ";
            for (var i = 0; i < array.Length; i++)
            {
                s += array[i].ToString();
                if (i < array.Length - 1) s += ", ";
            }
            return s + " }";
        }
    }
}