package main

/*
#include <stdio.h>
void hello() {
	printf("Hello, Cgo! -- From C.\n");
}
*/
import "C"

func main() {
	C.hello()
}
