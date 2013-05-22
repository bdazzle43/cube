/*
 构造 slice
 ==========

 slice 由函数 make 创建。这会分配一个零长度的数组并且返回一个 slice 指向这个数组：
 a := make([]int, 5)    // len(a)=5
 slice 有长度和容量。slice 的容量是底层数组可以增长的最大长度。
 为了指定容量，可传递第三个参数到 make：
 b := make([]int, 0, 5) // len(b)=0, cap(b)=5
 slice 可以通过“重新切片”来扩容（增长到容量的上限）：
 b = b[:cap(b)] // len(b)=5, cap(b)=5
 b = b[1:]      // len(b)=4, cap(b)=4
*/

package main

import "fmt"

func main() {
    a := make([]int, 5)
    printSlice("a", a)
    b := make([]int, 0, 5)
    printSlice("b", b)
    c := b[:2]
    printSlice("c", c)
    d := c[2:5]
    printSlice("d", d)
}

func printSlice(s string, x []int) {
    fmt.Printf("%s len=%d cap=%d %v\n", s, len(x), cap(x), x)
}

