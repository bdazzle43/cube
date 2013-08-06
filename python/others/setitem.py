#!/usr/bin/env python
#-*- coding: utf--8 -*-

class A(dict):
    def __init__(self, name=None):
        dict.__init__(self)
        self['name'] = name 

    def __setitem__(self, key, item):
        if key == 'name' and item:
            self['age'] = 0
            self['sex'] = 'male'
        dict.__setitem__(self, key, item)


if __name__ == '__main__':
    a = A()
    print a
    a['name'] = 'Tom'
    print a
