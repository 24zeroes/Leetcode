const search_min_diff_element = function(arr, key) {
    let l = 0,
        r = arr.length - 1,
        mid = -1;
    while (l <= r)
    {
      mid = l + Math.floor((r - l) / 2);
      if (arr[mid] === key)
      {
        return arr[mid];
      }
      if (arr[mid] > key)
      {
        r = mid - 1;
      }
      else
      {
        l = mid + 1;
      }
    }
    if (arr[l] - key < arr[r] - key)
    {
      return arr[l];
    }
    return arr[r];
  };
  
  
  console.log(search_min_diff_element([4, 6, 10], 7))
  console.log(search_min_diff_element([4, 6, 10], 4))
  console.log(search_min_diff_element([1, 3, 8, 10, 15], 12))
  console.log(search_min_diff_element([4, 6, 10], 17))
  