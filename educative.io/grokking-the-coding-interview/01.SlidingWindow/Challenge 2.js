const find_string_anagrams = function(str, pattern) {
    result_indexes = [];
    let l = 0,
        r = 0,
        matched = 0,
        map = {};
  
    for(let i = 0; i < pattern.length; i++)
    {
      let ch = pattern[i];
      if (!(ch in map))
      {
        map[ch] = 0;
      }
      map[ch] += 1;
    }
  
    while(r < str.length)
    {
      let rightChar = str[r]
      if (rightChar in map)
      {
        map[rightChar] -= 1;
        if (map[rightChar] == 0)
        {
          matched += 1;
          
        }
      }
  
      if (r - l + 1 >= pattern.length)
      {
        
        if (matched == pattern.length)
        {
          result_indexes.push(l);
        }
  
        let leftChar = str[l];
        if (leftChar in map)
        {
          map[leftChar] += 1;
  
          if (map[leftChar] != 0)
          {
            matched -= 1;
          }
        }
  
        l += 1;
      } 
  
      r += 1;
    }
  
    return result_indexes;
  };
  