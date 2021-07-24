const find_range = function(arr, key) {
    let result = [-1, -1];
    result[0] = binary_search(arr, key, false);
    if (result[0] !== -1)
    {
      result[1] = binary_search(arr, key, true)
    }
    return result;
  };
  
  function binary_search(arr, key, findMax)
  {
    let l = 0,
        r = arr.length - 1,
        keyIndex = -1;
  
    while (l <= r)
    {
      let mid = l + Math.floor((r - l) / 2);
      if (arr[mid] > key)
      {
        r = mid - 1;
      }
      else if (arr[mid] < key)
      {
        l = mid + 1;
      }
      else
      {
        keyIndex = mid;
        if (findMax)
        {
          l = mid + 1;
        }
        else
        {
          r = mid - 1;
        }
      }
    }
    return keyIndex;
  }
  
  
  console.log(find_range([4, 6, 6, 6, 9], 6))
  console.log(find_range([1, 3, 8, 10, 15], 10))
  console.log(find_range([1, 3, 8, 10, 15], 12))
  