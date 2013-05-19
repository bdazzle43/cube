/*
 包
 ==
 每个 Go 程序都是由包组成。
 程序运行的入口是包 main。
 这个车给你需使用并导入了包"fmt"和"math"。
 按照惯例，包名与导入路径的最后一个目录一致。
*/

package main

import (
    "fmt"
    "math"
)

func main() {
    fmt.Println("Happy", math.Pi, "Day")
}
