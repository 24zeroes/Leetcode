const length_of_longest_substring = function(str, k) {
  var l = 0;
  var r = 0;
  var tempK = k;
  var letter = str[l];
  var result = -Infinity;

  while (r < str.length)
  {
    console.log(l + " " + r );
    if (str[r] == letter)
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
        while(str[l] == letter)
        {
          l += 1;
        }
        r = l;
        tempK = k;
        letter = str[r];
      }
    }
  }
  return result;
};
