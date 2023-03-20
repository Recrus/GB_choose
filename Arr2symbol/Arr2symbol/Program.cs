string[] items = {"1", "22", "33", "444", "-a"};

void Main(string[] arr)
{
        //first solution
        string[] res = { };
        for (int i = 0; i < arr.Length; i++)
        {
                if (arr[i].Length == 2)
                {
                        res = res.Append(arr[i]).ToArray();
                }
        }
        Console.WriteLine("[{0}]", string.Join(", ", res));
        
        //second solution
        // arr = arr.Where(val => val.Length == 2).ToArray();
        // Console.WriteLine("[{0}]", string.Join(", ", arr));
};

Main(items);