/*
 函数的闭包
 ==========

 并且函数是完全闭包的。
 函数 adder 返回一个闭包。每个闭包被绑定到了一个特定的 sum 变量上。
*/

package main

import "fmt"

func adder() func(int) int {
    sum := 0
    return func(x int) int {
        sum += x
        return sum
    }
}

func main() {
    pos, neg := adder(), adder()
    for i := 0; i < 10; i++ {
        fmt.Println(
            pos(i),
            neg(-2*i),
        )
    }
}
