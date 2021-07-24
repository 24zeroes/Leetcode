const search_bitonic_array = function(arr, key) {
    let peek = find_peek(arr);
    let ascResult = binary_search(arr, key, 0, peek, true);
    let descResult = binary_search(arr, key, peek, arr.length - 1, false);
  
    if (ascResult !== -1)
    {
      return ascResult;
    }
  
    if (descResult !== -1)
    {
      return descResult;
    }
  
    return -1;
  };
  
  function find_peek(arr)
  {
    let l = 0,
        r = arr.length - 1,
        mid = -1;
    while (l < r)
    {
      mid = l + Math.floor((r - l) / 2);
      if (arr[mid] > arr[mid + 1])
      {
        r = mid;
      }
      else
      {
        l = mid + 1;
      }
    }
    return l;
  }
  
  function binary_search(arr, key, left, right, isAsc)
  {
    let l = left,
        r = right,
        mid = -1;
    while (l <= r)
    {
      mid = l + Math.floor((r - l) / 2);
      if (arr[mid] === key)
      {
        return mid;
      }
  
      if (shouldChangeRightPointer(arr, isAsc, mid, key))
      {
        r = mid - 1;
      }
      else
      {
        l = mid + 1;
      }
    }
    return -1;
  }
  
  function shouldChangeRightPointer(arr, isAsc, mid, key)
  {
    if (isAsc)
    {
      return arr[mid] > key;
    }
    else
    {
      return arr[mid] < key;
    }
  }
  
  console.log(search_bitonic_array([1, 3, 8, 4, 3], 4))
  console.log(search_bitonic_array([3, 8, 3, 1], 8))
  console.log(search_bitonic_array([1, 3, 8, 12], 12))
  console.log(search_bitonic_array([10, 9, 8], 10))
  