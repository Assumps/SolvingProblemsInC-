// See https://aka.ms/new-console-template for more information
/* Common Items problem
 * You have 2 arrays with letters per example
 * arrayA = [ 'a', 'z', 's']
 * arrayB = [ 'c', 'y', 't']
 * Between the arrays we dont have a pairs, in this case the result is false, if we have pairs the result is true
 * 
 * ContaimCommomItemNestedSolution has in bigO notation time complexity O(a*b) because we have a nested loop but the array size differents
 * 
 * This solution is bad in cases like a array has increase the letters quantiy
 * 
 * ContaimCommomItemHashMapSolution has a bigO notation time complexity equals to O(a+b) is equivalent O(n)
 * 
 * if the array increase your size we dont have so many problems because the performance is so better
*/

static bool ContaimCommomItemNestedSolution(char[] arrayA, char[] ArrayB)
{
    for (int i = 0; i < arrayA.Length; i++)
    {
        for (int j = 0;j < ArrayB.Length; j++)
        {
            if (arrayA[i] == ArrayB[j])
                return true;
        }
    }
    return false;
}

static bool ContaimCommomItemHashMapSolution(char[] arrayA, char[] arrayB)
{
    Dictionary<char, bool> map = new Dictionary<char, bool>();

    for (int i = 0; i < arrayA.Length; i++)
    {
        if (!map.ContainsKey(arrayA[i]))
            map.Add(arrayA[i], true);
    }

    for (int j = 0; j < arrayB.Length; j++)
    {
        if (map.ContainsKey(arrayB[j]))
        {
            return true;
        }
    }
    return false;
}

char[] arrayA = ['a','b','c','x'];
char[] arrayB = ['z', 'y', 'i'];

var response = ContaimCommomItemHashMapSolution(arrayA,arrayB);
// var response = ContaimCommomItemNestedSolution(arrayA, arrayB);
Console.WriteLine(response);
