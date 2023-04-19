internal static class ProgramHelpers
{

    public static int BinarySearchWithIfState(int[] arr, int itemToFind, int left, int right)
    {
        if (left <= right)
        {
            int middle = (left + right) / 2;

            if (itemToFind == arr[middle])
            {
                return middle;
            }
            else
            {
                if (itemToFind < arr[middle])
                {
                    return BinarySearchWithIfState(arr, itemToFind, left, middle - 1);
                }
                else if (itemToFind > arr[middle])
                {
                    return BinarySearchWithIfState(arr, itemToFind, middle + 1, right);
                }
            }
        }
        return -1;
    }
}