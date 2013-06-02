/*
 练习：map
 =========

 实现 WordCount。它应当返回一个含有 s 中的每个“word”数量的 map。函数 wc.Test 针对这个函数执行一个测试用例，并打印成功或失败。

 ***未完成***
*/

package main

import (
    "code.google.com/p/go-tour/wc"
)

func WordCount(s string) map[string]int {
    return map[string]int{"x": 1}
}

func main() {
    wc.Test(WordCount)
}
