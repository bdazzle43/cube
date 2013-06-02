/*
 结构体文法
 ==========

 结构体文法表示通过结构体字段的值作为列表来新分配一个结构体。
 使用 Name: 语法可以仅列出部分字段。（字段名的顺序无关。）
 特殊的前缀 & 构造了指向结构体文法的指针。
*/

package main

import "fmt"

type Vertex struct {
    X, Y int
}

var (
    p = Vertex{1, 2}    // has type Vertex
    q = &Vertex{1, 2}   // has type *Vertex
    r = Vertex{X: 1}    // Y:0 is implicit
    s = Vertex{}        // X:0 and Y:0
)

func main() {
    fmt.Println(p, q, r, s)
}
