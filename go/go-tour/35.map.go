/*
 Maps
 ====

 map 映射键到值。
 map 在使用之前必须用 make 来创建（不是 new）；一个值为 nil 的 map 是空的，并且不能赋值。
*/

package main

import "fmt"

type Vertex struct {
    Lat, Long float64
}

var m map[string]Vertex

func main() {
    m = make(map[string]Vertex)
    m["Bell Labs"] = Vertex{
        40.68433, -70.39967,
    }
    fmt.Println(m["Bell Labs"])
}
