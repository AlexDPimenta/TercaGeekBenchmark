namespace Via.TercaGeekBenchmark.Common;

public static class ListUtils
{
    public static int FindOcorrenciesByList(int[] list, int[] listToFind)
    {
        var listStr = String.Join(",", list);

        if (listStr.Contains(String.Join(",", listToFind)))
            return Array.IndexOf(list, listToFind[0]);
        return -1;
    }

    public static int FindOcorrenciesByListSimple(int[] list, int[] listToFind)
    {
        int index = 0;
        int position = -1;

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == listToFind[index])
            {

                if (index + 1 < listToFind.Length)
                {
                    index++;
                }
                else
                {
                    break;
                }
                if (position == -1)
                {
                    position = i;
                }
            }
            else
            {
                position = -1;
            }
        }

        return position;
    }
}
