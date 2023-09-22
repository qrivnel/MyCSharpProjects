// c++ToSortArray.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

int findSmallest(int array[8]) {
    int min = array[0];
    for (int i = 1; i < 8; i++) {
        if (min > array[i]) {
            min = array[i];
        }
    }
    return min;
}

void SortArray(int array[8]) {
    int sortArray[8];
    int min = array[0];
    int k = 0;
    cout << findSmallest(array);
}
int main()
{
    int array[8] = { 7, 1, 3, 8, 0, 9, 6, 4 };
    SortArray(array);
    /*/for (int i = 0; i < 8; i++) {
        cout << array[i] << endl;
    }
    SortArray(array);
    for (int i = 0; i < 8; i++) {
        cout << array[i] << endl;
    }*/
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
