const find_max_in_bitonic_array = function(arr) {
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
  
    return arr[l];
  };
  
  
  console.log(find_max_in_bitonic_array([1, 3, 8, 12, 4, 2]))
  console.log(find_max_in_bitonic_array([3, 8, 3, 1]))
  console.log(find_max_in_bitonic_array([1, 3, 8, 12]))
  console.log(find_max_in_bitonic_array([10, 9, 8]))
  