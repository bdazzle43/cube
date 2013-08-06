#!/usr/bin/env python3
# -*- coding:utf -*-

'''
读取文本文件
'''

fname = input('Enter filename:')
print()

try:
	fobj = open(fname, 'r')
except IOError:
	print("*** file open error:", e)
else:
	for line in fobj:
		print(line,)
	fobj.close()

