/*
 练习：slice
 ===========

 实现 Pic。它应当接受一个 slice 的长度 dy，和 slice 中的每个元素的长度的8位无符号整数 dx。当执行这个程序，它会将整数转换为灰度图片进行展示。
 图片的实现已经完成。可能用到的函数包括 x^y，(x+y)/2 和 x*y。
 （需要使用循环来分配 [][]unit8 中的每个 []uint8。）
 （使用 uint8(intValue) 在类型之间转换。）
*/

package main

import (
        "bytes"
        "encoding/base64"
        "fmt"
        "image"
        "image/png"
)

func Show(f func(int, int) [][]uint8) {
        const (
                dx = 256
                dy = 256
        )
        data := f(dx, dy)
        m := image.NewNRGBA(image.Rect(0, 0, dx, dy))
        for y := 0; y < dy; y++ {
                for x := 0; x < dx; x++ {
                        v := data[y][x]
                        i := y*m.Stride + x*4
                        m.Pix[i] = v
                        m.Pix[i+1] = v
                        m.Pix[i+2] = 255
                        m.Pix[i+3] = 255
                }
        }
        ShowImage(m)
}

func ShowImage(m image.Image) {
        var buf bytes.Buffer
        png.Encode(&buf, m)
        enc := base64.StdEncoding.EncodeToString(buf.Bytes())
        fmt.Println("IMAGE:" + enc)
}

//import "code.google.com/p/go-tour/pic"

func Pic(dx, dy int) [][]uint8 {
    pic := make([][]uint8, dy)          // 建立长度为 dy 的 slice，每个元素都是一个 slice
    for i, _ := range pic{
        pic[i] = make([]uint8, dx)      // 每个元素有 dx 个长度为8位的无符号整数
    }

    for i := range pic{
        for j := range pic[i]{
            pic[i][j] = uint8(i + j)
        }
    }

    return pic
}

func main() {
    Show(Pic)
}
