/*
 练习：错误
 ==========
 从之前的练习中复制 Sqrt 函数，并修改使其返回 error 值。
 Sqrt 接受到一个负数时，应当返回一个非 nil 的错误值。复数同样也不被支持。
 创造一个新类型
 type ErrNegetiveSqrt float64
 使其成为一个 error,通过
 func (e ErrNegativeSqrt) Error() string
 方法就可以让 ErrNegativeSqrt(-2).Error() 返回“cannot Sqrt negative nunber: -2”
 注意
*/
