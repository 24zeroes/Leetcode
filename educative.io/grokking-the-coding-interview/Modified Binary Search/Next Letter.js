const search_next_letter = function(letters, key) {
    let l = 0,
        r = letters.length - 1;
    
    if (key > letters[r] || key < letters[l])
      return letters[0];
  
    while (l <= r)
    {
      let mid = l + Math.floor((r - l) / 2);
  
      if (letters[mid] > key)
      {
        r = mid - 1;
      }
      else
      {
        l = mid + 1;
      }
    }
  
    return letters[l % letters.length];
  };
  
  
  console.log(search_next_letter(['a', 'c', 'f', 'h'], 'f'))
  console.log(search_next_letter(['a', 'c', 'f', 'h'], 'b'))
  console.log(search_next_letter(['a', 'c', 'f', 'h'], 'm'))
  