/*
 导入
 ====
 这个代码用元口号组合了导入，这是"factored"导入语句。同样可以编写多个导入语句，例如：
  import "fmt"
  import "math"
 不过通常都胡i用 factored 格式来使代码工整。
*/

package main

import (
    "fmt"
    "math"
)

func main() {
    fmt.Printf("Now you have %g problems.",
               math.Nextafter(2, 3))
}
