#include<stdio.h>
int main()
{
    int First = 0 , Second = 1, Sum = 0 , Number;
    printf("Enter the number");
    scanf("Fibonacci Series is : %d %d ", First, Second);
    Sum = First + Second;
    while(Sum <= Number)
    {
        printf("%d", Sum);
        First = Second;
        Second = Sum;
        Sum = First + Second;
    }
    return 0;
}