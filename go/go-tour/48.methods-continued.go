/*
方法（续）
=========

事实上，可以对包中的任意类型定义任意方法，而不仅仅是结构体。
不能对来自其他包的类型或基础类型定义方法。
*/

package main

import (
    "fmt"
    "math"
)

type MyFloat float64

func (f MyFloat) Abs() float64 {
    if f < 0 {
        return float64(-f)
    }
    return float64(f)
}

func main() {
    f := MyFloat(-math.Sqrt2)
    fmt.Println(f.Abs())
}
