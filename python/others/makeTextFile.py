#!/usr/bin/env python3
# -*- coding:utf-8 -*-

'''
建立文本文件
'''

import os
ls = os.linesep

while True:
	fname = input('Input a name:')
	if os.path.exists(fname):
		print( "ERROR: '%s' already exists" % fname)
	else:
		break

all = []
print("\nEnter lines('.' by itself to quit).\n")

while True:
	entry = input('>')
	if entry == '.':
		break
	else:
		all.append(entry)

fobj = open(fname, 'w')
fobj.writelines(['%s%s' % (x, ls) for x in all])
fobj.close()
print("DONE!")


