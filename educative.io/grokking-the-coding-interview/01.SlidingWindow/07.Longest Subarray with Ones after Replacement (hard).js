const length_of_longest_substring = function(arr, k) {
    var l = 0; 
    var r = 0;
    var result = 0;
    var currentOnesCount = 0;
  
    while (r < arr.length)
    {
      if (arr[r] == 1)
      {
        currentOnesCount += 1;
      }
  
      if ((r - l + 1 - currentOnesCount) > k)
      {
        if (arr[l] == 1)
        {
          currentOnesCount -= 1;
        }
        l += 1;
      }
  
      result = Math.max(result, r - l + 1);
      r += 1;
    }
  
    return result;
  };
  