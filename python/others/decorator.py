#!/usr/bin/env python
# -*- coding: utf-8 -*-

from time import ctime, sleep

def tcfunc(func):
    def wrappedFunc():
        print '[%s] %s() called' % (
            ctime(), func)
        return func()
    
    print "in tcfunc called"
    print "wrapped func %s" % wrappedFunc
    return wrappedFunc

@tcfunc
def foo():
    print "in foo called"
    pass

print "-"*20

print "foo func : %s" % foo

foo()
print "-"*50
sleep(4)

for i in range(2):
    sleep(i)
    foo()
    print "-"*100
