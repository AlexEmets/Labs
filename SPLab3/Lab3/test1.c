#include <stdio.h>

int a = 32;

char b;
//a
static short c = 'a';

/* a
*/
void func(int* x) { ++(*x); }

int main(int argc, char** argv) {
    short _sh = 666;
    if(1) {
        func(&_sh);
    }
    return 0;
}