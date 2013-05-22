/*
 For （续）
 =========
 
 跟 C 或者 Java 中一样，可以让前置，后置语句为空。
*/

package main

import "fmt"

func main() {
    sum := 1
    for ; sum < 1000; {
        sum += sum
    }
    fmt.Println(sum)
}
