/*
 For
 ===
 
 Go 只有一种循环结构， for 循环。
 基本的 for 循环看起来跟 C 或者 Java 中做的一样，除了没有了()之外（甚至强制不能使用它们），而{}是必须的。
*/

package main

import "fmt"

func main() {
    sum := 0
    for i := 0; i < 10; i++ {
        sum += i
    }
    fmt.Println(sum)

}
