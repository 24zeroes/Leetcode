const find_substring = function(str, pattern) {
    let result = "",
        l= 0,
        r = 0,
        map = {},
        matched = 0;

    for(let i = 0; i < pattern.length; i++)
    {
        let ch = pattern[i];
        if (!(ch in map))
        {
            map[ch] = 0;
        }
        map[ch] += 1;
    }

    while (r < str.length)
    {
        let rightChar = str[r];
        if (rightChar in map)
        {
            map[rightChar] -= 1;

            if (map[rightChar] == 0)
            {
                matched += 1;
            }
        }

        while (matched == pattern.length)
        {
            let substr = str.substr(l, r - l + 1);
            if (result == "" || result.length > substr.length)
            {
                result = substr;
            }

            let leftChar = str[l];
            if (leftChar in map)
            {
                if (map[leftChar] == 0)
                {
                    matched -= 1;
                }
                map[leftChar] += 1;
            }

            l += 1;
        }

        r += 1;
    }

    return result;
}

