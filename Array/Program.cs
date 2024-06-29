/** single-dimentional Array **/

int[] arrInit1 = new int[2] { 10, 20 };

int[] arr1 = new int[3]; // set an array with size 3
arr1[0] = 1;
arr1[1] = 2;
arr1[2] = 3;
foreach (int item in arr1)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine("Its {0} dimentional array", arr1.Rank); // define the dimention: 1



/** multi-dimentional array **/
// [row, column]
// should be same numbers of column of every rows
int[,] arrInit2 = new int[2, 2]
{
                {10, 20 },
                {30, 40 }
};

int[,] arr2 = new int[2, 3];    // set an array with size 2 x 3
arr2[0, 0] = 1; arr2[0, 1] = 2; arr2[0, 2] = 3; // [[1, 2, 3],
arr2[1, 0] = 4; arr2[1, 1] = 5; arr2[1, 2] = 6; //  [4, 5, 6]]

// travarse the array
for (int i = 0; i < 2; i++) // row
{
    for (int j = 0; j < 3; j++) // column
    {
        Console.Write(arr2[i, j] + " ");
    }
    Console.WriteLine();
}

// set array with 2 x 2 x 3                                 // [
int[,,] arr3 = new int[2, 2, 3];                            //     [[1, 2, 3],        
arr3[0, 0, 0] = 1; arr3[0, 0, 1] = 2; arr3[0, 0, 2] = 3;    //      [4, 5, 6]],
arr3[0, 1, 0] = 4; arr3[0, 1, 1] = 5; arr3[0, 1, 2] = 6;    //     [[40, 50, 60]
arr3[1, 0, 0] = 10; arr3[1, 0, 1] = 20; arr3[1, 0, 2] = 30; //      [10, 20, 30]],
arr3[1, 1, 0] = 40; arr3[1, 1, 1] = 50; arr3[1, 1, 2] = 60; // ]




/** Jacked Array **/
// can be different numbers of column
int[][] arr4 = new int[3][];
arr4[0] = new int[4] { 1, 3, 5, 7 };
arr4[1] = new int[3] { 10, 30, 50 };
arr4[2] = new int[5] { 0, 2, 4, 6, 8 };

// access an element
arr4[1][2] = 70;
Console.WriteLine($"arr4[1][2]: {arr4[1][2]}");