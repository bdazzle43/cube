/*
错误
====

错误是可以用字符串描述自己的任何东西。主要思路是由预定义的内建接口类型 error，和其返回字符串的方法 Error 构成。

type error interface {
    Error() string
}

当用 fmt 包的多种不同的打印函数输出一个 error 时，会自动的调用该方法。
*/

package main

import (
    "fmt"
    "time"
)
type MyError struct {
    When time.Time
    What string
}

func (e *MyError) Error() string {
    return fmt.Sprintf("at %v, %s", e.When, e.What)
}

func run() error {
    return &MyError {
        time.Now(),
        "it didn't work",
    }
}

func main() {
    if err := run(); err != nil {
        fmt.Println(err)
    }
}

