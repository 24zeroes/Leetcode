class ArrayReader {

    constructor(arr) {
      this.arr = arr;
    }
  
    get(index) {
      if (index >= this.arr.length)
        return Number.MAX_SAFE_INTEGER;
      return this.arr[index]
    }
  };
  
  
  const search_in_infinite_array = function(reader, key) {
    let l = 0,
        r = l + 1,
        newStart;
    while (reader.get(r) < key)
    {
      newStart = r + 1;
      r = (r - l + 1) * 2;
      l = newStart;
    }
    
    return binary_search(l, r, key, reader);
  };
  
  function binary_search(l, r, target, reader)
  {
    let mid = - 1;
    while (l <= r)
    {
      mid = l + Math.floor((r - l) / 2);
      midValue = reader.get(mid);
  
      if (midValue === target)
      {
        return mid;
      } 
  
      if (midValue > target)
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
  
  var reader = new ArrayReader([4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30]);
  console.log(search_in_infinite_array(reader, 16))
  console.log(search_in_infinite_array(reader, 11))
  reader = new ArrayReader([1, 3, 8, 10, 15])
  console.log(search_in_infinite_array(reader, 15))
  console.log(search_in_infinite_array(reader, 200))
  