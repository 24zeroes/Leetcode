namespace QSort;

public static class QSort
{
    public static void Sort(int[] arr, int left, int right)
    {
        if (left >= right)
            return;
        int pivot = Partition(arr, left, right);
        Sort(arr, left, pivot - 1);
        Sort(arr, pivot + 1, right);
    }

    public static int Partition(int[] arr, int left, int right)
    {
        var pivot = arr[right];
        var i = left - 1;
        for (var j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        i++;
        (arr[right], arr[i]) = (arr[i], arr[right]);
        return i;
    }
}