const length_of_longest_substring = function(str, k) {
    var l = 0;
    var r = 0;
    var lastCharacter = str[l];
    var tempK = k;
    var result = -Infinity;
  
    while (r < str.length)
    {
      if (lastCharacter == str[r])
      {
        result = Math.max(result, r - l + 1);
        r += 1;
      }
      else
      {
        if (tempK > 0)
        {
          result = Math.max(result, r - l + 1);
          tempK -= 1;
          r += 1;
        }
        else
        {
          l = r;
          r = r + 1;
          tempK = k;
          lastCharacter = str[l];
        }
      }
    }
  
    return result;
  };
  