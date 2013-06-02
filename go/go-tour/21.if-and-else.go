/*
 if 和 else
 ==========
 
 在 if 的简单语句处定义的变量同样可以在任何对应的 else 块中使用。
*/

package main

import (
    "fmt"
    "math"
)

func pow(x, n, lim float64) float64 {
    if v := math.Pow(x, n); v < lim {
        return v
    } else {
        fmt.Printf("%g >= %g\n", v, lim)
    }
    // 不能在这里使用 v，因此
    return lim
}

func main() {
    fmt.Println(
        pow(3, 2, 10),
        pow(3, 3, 20),
    )
}
