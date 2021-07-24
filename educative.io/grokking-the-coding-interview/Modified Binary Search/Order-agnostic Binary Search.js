const binary_search = function(arr, key) {
    let l = 0,
        r = arr.length - 1,
        isAsc = arr[l] < arr[r];
    while(l <= r)
    {
      let mid = l + (r - l)/2;
      
      if (arr[mid] === key)
      {
        return mid;
      } 
  
      if (shouldChangeRightPointer(isAsc, arr, mid, key))
      {
        r = mid - 1;
      }
      else
      {
        l = mid + 1;
      }
      
    }
    return -1;
  };
  
  function shouldChangeRightPointer(isAscOrder, arr, mid, target)
  {
    if (isAscOrder)
    {
      return arr[mid] > target;
    }
  
    return arr[mid] < target;
  }
  
  console.log(binary_search([4, 6, 10], 10))
  console.log(binary_search([1, 2, 3, 4, 5, 6, 7], 5))
  console.log(binary_search([10, 6, 4], 10))
  console.log(binary_search([10, 6, 4], 4))
  