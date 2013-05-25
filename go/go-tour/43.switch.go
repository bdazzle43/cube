/*
 Switch
 ======

 你可能已经猜到了 switch 可能的形式了。
 case 体会自动终止，除非用 fallthrough 语句作为结尾。
*/

package main

import (
    "fmt"
    "runtime"
)

func main() {
    fmt.Println("Go runs on")
    switch os := runtime.GOOS; os {
    case "darwin":
        fmt.Println("OS X.")
    case "linux":
        fmt.Println("Linux.")
    default:
        fmt.Printf("%s.", os)
    }
}
