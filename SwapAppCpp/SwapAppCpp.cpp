// SwapAppCpp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include"swap.h"
// using namespace std;



int main()
{
    std::cout << "Hello World!" << std::endl;

    int* i = (int*) malloc(sizeof(int));
    int j = 20;
    int* k = &j;

    int* arr = (int*)malloc(2 * sizeof(int));
    if (i != NULL) *i = 10;
    
    if (arr != NULL) {
        *arr = 1;
        std::cout << *arr + "\n";
    }

    arr++;
    if (arr != NULL) {
        *arr = 2;
        std::cout << *arr << std::endl;
    }

    swap(i, &j);
    if (i != NULL) std::cout << "i: " << *i << ", j: " << j;
    return(0);
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
