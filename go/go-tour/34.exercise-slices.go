/*
 练习：slice
 ===========

 实现 Pic。它应当接受一个 slice 的长度 dy，和 slice 中的每个元素的长度的8位无符号整数 dx。当执行这个程序，它会将整数转换为灰度图片进行展示。
 图片的实现已经完成。可能用到的函数包括 x^y，(x+y)/2 和 x*y。
 （需要使用循环来分配 [][]unit8 中的每个 []uint8。）
 （使用 uint8(intValue) 在类型之间转换。）
*/

package main

import "code.google.com/p/go-tour/pic"

func Pic(dx, dy int) [][]uint8 {
}

func main() {
    pic.Show(Pic)
}
