/*
接口
====

接口类型是由一组方法定义的集合。
接口类型的值可以春房实现这些方法的任何值。
*/

package main

import (
    "fmt"
    "math"
)

type Abser interface {
    Abs() float64
}

type MyFloat float64

func (f MyFloat) Abs() float64 {
    if f < 0 {
        return float64(-f)
    }
    return float64(f)
}

type Vertex struct {
    X, Y float64
}

func (v *Vertex) Abs() float64 {
    return math.Sqrt(v.X*v.X + v.Y*v.Y)
}

func main() {
    var a Abser
    f := MyFloat(-math.Sqrt2)
    v := Vertex{3, 4}

    a = f   // Abser 的 MyFloat 实现
    a = &v  // Abser 的 *Vertex 实现
    //a = v   // Vertex，没有实现 Abser

    fmt.Println(a.Abs())
}
