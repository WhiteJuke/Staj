namespace UtilityLibraries;
public class StringLibrary
{
    public bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return false;
        }
        return char.IsUpper(str[0]);
    }
}
