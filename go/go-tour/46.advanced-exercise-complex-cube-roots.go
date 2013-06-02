/*
 进阶练习：复数立方根
 ====================

 让我们通过 complex64 和 complex128 来探索一下 Go 内建的复数。对于立方根，牛顿法需要大量的循环：
    z = z - (z^3 - x)/(3z^2)
 找到 2 的立方根，确保算法能够工作。在 math/cmplx 包含中有 Pow 函数。
*/

package main

import (
    "fmt"
)

func Cbrt(x complex128) complex128 {

}

func main() {
    fmt.Println(Cbrt(2))
}
