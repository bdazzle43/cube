/*
 初始化变量
 ==========
 变量定义可以包含初始值，每个变量对应一个。
 如果初始化是使用表达式，则可以省略类型；变量出是指中获得类型。
*/

package main

import "fmt"

var x, y, z int = 1, 2, 3
var c, python, java = true, false, "no!"

func main() {
    fmt.Println(x, y, z, c, python, java)
}
