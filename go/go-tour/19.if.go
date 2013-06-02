/*
 If
 ==
 
 if 语句开来跟 C 或者 Java 中的一样，除了没有()之外（甚至强制不能使用它们），而{}是必须的。
*/

package main

import (
    "fmt"
    "math"
)

func sqrt(x float64) string {
    if x < 0 {
        return sqrt(-x) + "i"
    }
    return fmt.Sprint(math.Sqrt(x))
}

func main() {
    fmt.Println(sqrt(2), sqrt(-4))
}
