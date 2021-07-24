const search_ceiling_of_a_number = function(arr, key) {
    let l = 0,
        r = arr.length - 1;
    
    if (key > arr[r]) { // if the 'key' is bigger than the biggest element
      return -1;
    }
  
    while (l <= r)
    {
      let mid = l + Math.floor((r - l) / 2);
  
      if (arr[mid] === key)
        return mid;
  
      if (arr[mid] > key)
      {
        r = mid - 1;
      }
      else
      {
        l = mid + 1;
      }
    }
    return l;
  };
  
  
  console.log(search_ceiling_of_a_number([4, 6, 10], 6))
  console.log(search_ceiling_of_a_number([1, 3, 8, 10, 15], 12))
  console.log(search_ceiling_of_a_number([4, 6, 10], 17))
  console.log(search_ceiling_of_a_number([4, 6, 10], -1))
  