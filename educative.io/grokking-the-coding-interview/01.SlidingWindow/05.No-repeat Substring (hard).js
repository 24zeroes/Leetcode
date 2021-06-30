const non_repeat_substring = function(str) {
    var l = 0;
    var r = 0;
    var result = -Infinity;
  
    var map = new Map();
  
    while(r < str.length)
    {
      if (!map.get(str[r]))
      {
        map.set(str[r], 0);
      }
      if (map.get(str[r]) > 0)
      {
        l = r;
        map.clear();
      }
      else
      {
        map.set(str[r], map.get(str[r]) + 1);
        result = Math.max(result, r - l + 1);
        r += 1;
      }
    }
  
    return result;
  };
  