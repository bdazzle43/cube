/*
 For 是 Go 的“while”
 ===================
 
 基于此可以省略分号：C 的 while 在 Go 中也是用 for 实现。
*/

package main

import "fmt"

func main() {
    sum := 1
    for sum < 1000 {
        sum += sum
    }
    fmt.Println(sum)
}
