/*
 new 函数
 ========

 表达式 new(T) 分配了一个零初始化的 T 值，并返回指向它的指针。
 var t *T = new(T)
 t := new(T)
*/

package main

import "fmt"

type Vertex struct {
    X, Y int
}

func main() {
    v := new(Vertex)
    fmt.Println(v)
    v.X, v.Y = 11, 9
    fmt.Println(v)
}
