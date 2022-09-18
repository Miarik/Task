 int[] SwapNumbers(int num)
    {}
        char[]arr = num.ToString().ToCharArray();
        int temp = arr[arr.Length-1];
        arr[arr.Length-1] = arr[arr.Length-2];
        arr[0] = temp;
    }